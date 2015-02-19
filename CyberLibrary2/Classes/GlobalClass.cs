using System;
using System.Collections.Generic;

using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

using CyberLibrary2.Classes;
namespace CyberLibrary2
{
    
    public enum OptionType
    {
        SetText,
        PictureBox_SetImage,
        TreeView_NodeAdd,
        ResetBook,
        ShowPanel,
        ChatAdd,
        ListAdd,
        ReadBook,
        ItemImageIndexChange,
        SetBool,
        SetComment,
        PageSet,
    }
    public delegate void SetControlText(Control control,string txt);
    public delegate void SetControlOption(object sender,OptionType type,object data);
    public delegate void ShowForm(Form form,bool dialog);
    public delegate void DisposeForm(Form form,bool Close);
    public delegate void GenerateFunction(GFunc gfunc,params object[] obj);
    public delegate void GFunc(params object[] args);
    public static class Component
    {
        
        
        
        public static SetControlText SetText;
        public static SetControlOption SetOption;
        public static ShowForm shForm;
        public static GenerateFunction Generater;
        public static DisposeForm dsForm;
    
        public static void SaveClass(object obj,System.IO.Stream stream)
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream,obj);
        }
        public static object LoadClass( System.IO.Stream stream)
        {
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(stream);
        }
        public static void Generate(GFunc gfunc,object[] obj)
        {
            gfunc(obj);
        }

        public static string MD5Encrypt(string o)
        {
            byte[] data = Convert.FromBase64String(o);
            // This is one implementation of the abstract class MD5.
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(data);
            return Convert.ToBase64String(result);
        }
        public static void SetCOption(object sender, OptionType type, object data)
        {
            switch (type)
            {
                case OptionType.ResetBook:
                    ((BookEditor)sender).ResetBook();
                    break;
                case OptionType.SetComment:
                    ((CommentBoard)sender).SetComment((Comments)data);
                    break;
                case OptionType.SetBool:
                    sender = (bool)data;
                    break;
                case OptionType.SetText:
                    ((Control)sender).Text = data.ToString();
                    break;
                case OptionType.PageSet:
                    ((BookEditor)sender).PageSet((int)data);
                    break;
                case OptionType.PictureBox_SetImage:
                    ((PictureBox)sender).Image = (Image)data;
                    break;
                case OptionType.TreeView_NodeAdd:
                    ((TreeView)sender).Nodes.Add((TreeNode)data);
                    break;
                case OptionType.ShowPanel:
                    ((Forms.NetworkLibForm)sender).ShowPanel((Panel)data);
                    break;
                case OptionType.ChatAdd:
                    object[] Datas = (object[])data;
                    ((Forms.NetworkLibForm)sender).ChatAdd(Datas[0],Datas[1],Datas[2],Datas[3]);
                    break;
                case OptionType.ListAdd:
                    ((ListView)sender).Items.Add((ListViewItem)data);
                    break;
                case OptionType.ItemImageIndexChange:
                    ((ListViewItem)sender).ImageIndex = (int)data;
                    break;
                case OptionType.ReadBook:
                    if(sender is Controls.Book_Read)
                        ((Controls.Book_Read)sender).SetBook((Book)data);
                    if (sender is BookEditor)
                        ((BookEditor)sender).LoadBook((Book)data);
                    break;
            }
        }
        public static void SetTxt(Control control,string txt)
        {
            control.Text = txt;
        }
        public static void init()
        {
            Generater = new GenerateFunction(Generate);
            SetOption = new SetControlOption(SetCOption);
            SetText = new SetControlText(SetTxt);
            shForm = new ShowForm(showForm);
            dsForm = new DisposeForm(disposeForm);
        }
        public static void disposeForm(Form form, bool Close)
        {
            if (Close) form.Close();
            else form.Hide();
        }
        public static void showForm(Form form,bool dialog)
        {
            if (dialog) form.ShowDialog();
            else form.Show();
        }
        public static void TypeDraw(Color BColor,float width,Graphics p,DataType t,Point Location,Size Size)
        {
            switch (t)
            {
                case DataType.Ellipse:
                    p.DrawEllipse(new Pen(BColor,width), new Rectangle(Location, Size));
                    break;
                case DataType.FillEllipse:
                    p.FillEllipse(new SolidBrush(BColor), new Rectangle(Location, Size));
                    break;
                case DataType.Line:
                    p.DrawLine(new Pen(BColor,width), Location, new Point(Size.Width+Location.X, Size.Height + Location.Y));
                    break;
                case DataType.FillRectangle:
                    p.FillRectangle(new SolidBrush(BColor), new Rectangle(Location, Size));
                    
                    break;

                default:
                    p.DrawRectangle(new Pen(BColor,width), new Rectangle(Location, Size));
                    break;

            }
        }
    }
    [Serializable]
    public class BookLibrary
    {
        public string LibraryName;
        public BookGroup MainGroups;

        public BookLibrary()
        {
            MainGroups = new BookGroup();
        }

        public bool GroupinCheck(BookGroup p, BookGroup q)
        {
            if (p == null) return false;
            if (p == q) return true;
            else
                return GroupinCheck(p.Parent, q);
        }
        public BookGroup GoGroup(BookGroup g, string Name)
        {
            foreach (BookGroup p in g.groups)
            {
                if (p.Name == Name)
                    return p;
            }
            return null;
        }
        public Book GoBook(BookGroup g, string Name)
        {
            foreach (Book p in g.books)
            {
                if (p.BookName == Name)
                    return p;
            }
            return null;
        }
        public void DeleteGroup(string Name)
        {
            BookGroup now = MainGroups;
            int i = 0;
            string[] split = Name.Split('\\');
            for (i = 0; i < split.Length - 1; i++)
            {
                now = GoGroup(now, split[i]);
            }
            now.RemoveGroup(split[split.Length - 1]);
        }
        public BookGroup FindGroup(string Path)
        {
            string[] split = Path.Split('\\');
            BookGroup result = MainGroups;
            if (Path == "") return result;
            foreach (string at in split)
            {
                result = result.FindGroup(at);
                if (result == null)
                    return null;
            }
            return result;
        }
        public void DeleteBook(string Name)
        {
            BookGroup now = MainGroups;
            int i = 0;
            string[] split = Name.Split('\\');
            for (i = 0; i < split.Length - 1; i++)
            {
                now = GoGroup(now, split[i]);
            }
            now.RemoveBook(split[split.Length - 1]);
        }
        public Book FindBook(string Path)
        {
            string[] split = Path.Split('\\');
            BookGroup now = MainGroups;
            for (int i = 0; i < split.Length-1;i++ )
            {
                now=now.FindGroup(split[i]);
                if (now == null)
                    return null;
            }
            return now.FindBook(split[split.Length - 1]);
        }
    }
    [Serializable]
    public class BookGroup
    {
        public List<Book> books;
        public List<BookGroup> groups;
        public string Name;
        public BookGroup Parent;
        public BookGroup()
        {
            books = new List<Book>();
            groups = new List<BookGroup>();
            Name = "";
        }
        public static bool GroupinCheck(BookGroup p, BookGroup q)
        {
            if (p == null) return false;
            if (p == q) return true;
            else
                return GroupinCheck(p.Parent, q);
        }
        public void AddGroup(BookGroup b)
        {
            groups.Add(b);
            b.Parent = this;
        }
        public void AddBook(Book b)
        {
            books.Add(b);
            b.Parent = this;
        }
        public void SetBook(Book b, Book b2)
        {
            int index = books.IndexOf(b);
            if (index >= 0)
                books[index] = b2;
            
        }
        public Book FindBook(string Name)
        {
            foreach (Book b in books)
            {
                if (Name == b.BookName)
                    return b;
            }
            return null;
        }
        public BookGroup FindGroup(string Name)
        {
            
            foreach (BookGroup bg in groups)
            {
                if (Name == bg.Name)
                    return bg;
            }
            return null;
        }
        public void RemoveBook(string Name)
        {
            int i = 0;
            for (i = 0; i < books.Count; i++)
            {
                if (books[i].BookName == Name)
                {
                    books.RemoveAt(i);
                    break;
                }
            }
        }
        public void RemoveGroup(string Name)
        {
            int i = 0;
            for (i = 0; i < groups.Count; i++)
            {
                if (groups[i].Name == Name)
                {
                    groups.RemoveAt(i);
                    break;
                }
            }
        }
    }
    [Serializable]

    public class Book
    {
        public string WriterName, BookName, TransferName,BookExplain;
        public int PageCount;
        public Group MainGroup;
        public BookGroup Parent;
        public float BookLevel;
        public Comments Comments;
        public DateTime WriteTime;
        public long NetworkKey;
        private string CryptKey;
        public string SecretKey
        {
            get
            {
                return CryptKey;
            }
            set
            {
                CryptKey = Component.MD5Encrypt(value);
            }
        }
        public Classes.NetworkBookGroup NetworkParent;
        public Book()
        {
            MainGroup = new Group();
            Comments = new Comments();
            BookLevel = 0;
            WriterName = BookName = TransferName = BookExplain = "";
        }
        public static bool GroupinCheck(Group p,Group q)
        {
            if (p == null) return false;
            if (p == q) return true;
            else
                return GroupinCheck(p.Parent, q);
        }
        public Group GoGroup(Group g, string Name)
        {
            foreach (Group p in g.Groups)
            {
                if (p.Name == Name)
                    return p;
            }
            return null;
        }
        public Page GoPage(Group g, string Name)
        {
            foreach (Page p in g.Pages)
            {
                if (p.Name == Name)
                    return p;
            }
            return null;
        }
        public Group FindGroup(string Name)
        {
            Group now = MainGroup;
            string[] split = Name.Split('\\');
            foreach (string at in split)
            {
                now=GoGroup(now, at);
            }
            return now;
        }
        public Page FindPage(string Name)
        {
            Group now = MainGroup;
            int i = 0;
            string[] split = Name.Split('\\');
            for (i = 0; i < split.Length - 1; i++)
            {
                now = GoGroup(now, split[i]);
            }
            return GoPage(now, split[split.Length - 1]);
        }
        public void DeletePage(string Name)
        {
            Group now= MainGroup;
            int i=0;
            string[] split = Name.Split('\\');
            for (i = 0; i < split.Length - 1; i++)
            {
                now = GoGroup(now, split[i]);
            }
            now.RemovePage(split[split.Length - 1]);
        }
        public void DeleteGroup(string Name)
        {
            Group now = MainGroup;
            int i = 0;
            string[] split = Name.Split('\\');
            for (i = 0; i < split.Length - 1; i++)
            {
                now = GoGroup(now, split[i]);
            }
            now.RemoveGroup(split[split.Length - 1]);
        }
        /*public Page FindPage(string Name)
        {
            foreach (Page p in p.Pages)
                if (g.Name == Name)
                    return g;
            return null;
        }*/
        public Group TreeToGroup(Group p, string Name)
        {
            if (p.Name == Name)
                return p;
            foreach (Group g in p.Groups)
            {
                Group r = TreeToGroup(g, Name);
                if (r != null) return r;
            }
            return null;
        }
        public Page TreeToPage(Group p, string Name)
        {
            foreach (Page page in p.Pages)
            {
                if (page.Name == Name)
                    return page;
            }
            foreach (Group g in p.Groups)
            {
                Page r = TreeToPage(g, Name);
                if (r != null) return r;
            }
            return null;
        }
        public Page TreeToPage(Group p, int index)
        {
            foreach (Page page in p.Pages)
            {
                if (page.PageIndex == index)
                    return page;
            }
            foreach (Group g in p.Groups)
            {
                Page r = TreeToPage(g, index);
                if (r != null) return r;
            }
            return null;
        }
        
        
        public int GetVoidIndex()
        {
            int index = 1;
            for (index = 1; index <= PageCount; index++)
            {
                if (TreeToPage(MainGroup,index) == null)
                    return index;
            }
            return -1;
        }
    }
    [Serializable]
    public class Group
    {
        public string Name,Explain;
        public Group Parent;
        public List<Page> Pages;
        public List<Group> Groups;
        public Group()
        {
            Pages = new List<Page>();
            Groups = new List<Group>();
        }
        public Group(Group g)
        {
            Pages = new List<Page>(g.Pages);
            Groups = new List<Group>(g.Groups);
            Parent = g.Parent;
            Name = g.Name;
            Explain = g.Explain;

        }
        public void RefreshAllPage()
        {
            foreach (Page p in Pages)
                p.PageRefresh();
            foreach (Group g in Groups)
                g.RefreshAllPage();
        }
        public void RemovePage(string Name)
        {
            int i=0;
            for (i = 0; i < Pages.Count;i++ )
            {
                if (Pages[i].Name == Name)
                {
                    Pages.RemoveAt(i);
                    break;
                }
            }
        }
        public void RemoveGroup(string Name)
        {
            int i = 0;
            for (i = 0; i < Groups.Count;i++ )
            {
                if (Groups[i].Name == Name)
                {
                    Groups.RemoveAt(i);
                    break;
                }
            }
        }
    }
    [Serializable]
    public class Page
    {
        public int PageIndex;
        public int LastControlIndex;
        public Book myBook;
        public string Name,Explain;
        public Group Parent;
        public Color BackColor;
        public List<DMemo> Memos;
        public List<DDraw> Draws;
        public List<BookData> Controls;
        public Image BackgroundImage;
        public Page()
        {
            Memos = new List<DMemo>();
            Draws = new List<DDraw>();
            Controls = new List<BookData>();
            BackColor = Color.White;
        }
        public void PageRefresh()
        {
            foreach (DMemo Memo in Memos)
                Memo.myPage = this;
            foreach (DDraw draw in Draws)
                draw.myPage = this;
            foreach (BookData bData in Controls)
                bData.myPage = this;
        }
        public BookData GetData(int index)
        {
            foreach (DDraw d in Draws)
            {
                if (d.ControlIndex == index)
                    return d;
                else if (index < d.ControlIndex)
                    break;
            }
            foreach (BookData d in Controls)
            {
                if (d.ControlIndex == index)
                    return d;
                else if (index < d.ControlIndex)
                    break;
            }
            return null;
        }

        public Page(Page g)
        {
            Parent = g.Parent;
            PageIndex = g.PageIndex;
            Name = g.Name;
            Explain = g.Explain;
            myBook = g.myBook;
            Memos = new List<DMemo>(g.Memos);
            Draws = new List<DDraw>(g.Draws);
            Controls = new List<BookData>(g.Controls);
        }
    }

    public static class Math
    {
        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }
        public static double Min(double a, double b)
        {
            return a < b ? a : b;
        }
        public static bool checkin(System.Drawing.Rectangle rc,System.Drawing.Point p)
        {
            int p1 = (int)Max(rc.X, rc.X + rc.Width),m1=(int)Min(rc.X,rc.X+rc.Width);
            int p2 = (int)Max(rc.Y, rc.Y + rc.Height), m2 = (int)Min(rc.Y, rc.Y + rc.Height);
            if (p.X >= m1 && p1 >= p.X)
            {
                if (p.Y >= m2 && p2 >= p.Y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
