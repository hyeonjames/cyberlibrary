using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;
using CyberLibrary2.Classes;
namespace CyberLibrary2
{
    public partial class BookEditor : UserControl
    {
        public Book mybook;
        public List<Group> HyperGroups;
        public Book myBook
        {
            get
            {
                PageSet(1);
                return mybook;
            }
        }
        public int PageIndex;
        public BookEditor()
        {
            InitializeComponent();
            OEDialog.Filter = SVDialog.Filter = "책 파일(*.bok)|*.bok";
            ResetBook();
            HyperGroups = new List<Group>();
            LoadHyperStructure();
        }
        // XML
        /*
         * 
         * DataTable Group
         * DataRow T/F,Name,PageIndex,Description
         * DataTable Group\GroupName
         * DataRow T/F Name,PageIndex,Description
         */
        public Group TableToGroup(DataTable t)
        {
            bool GroupCheck;
            Page p;
            Group g2;
            
            Group g = new Group();
            if (t == null) return null;
            string[] Split = t.TableName.Split(@"\".ToCharArray());
            if (t.TableName == "\\" + t.DataSet.DataSetName)
            {
                g.Name = t.DataSet.DataSetName;
            }
            else g.Name = Split[Split.Length - 1];
            foreach(DataRow row in t.Rows)
            {
                GroupCheck = Convert.ToBoolean(row.ItemArray[0]);
                if(GroupCheck)
                {
                    g2 = TableToGroup(t.DataSet.Tables[t.TableName + @"\" + row.ItemArray[1].ToString()]);
                    if (g2 == null)
                    {
                        g2 = new Group();
                        g2.Name =row.ItemArray[1].ToString();
                    }
                    g.Groups.Add(g2);
                }
                else
                {
                    p = new Page();
                    p.Name = row.ItemArray[1].ToString();
                    p.PageIndex =Convert.ToInt32(row.ItemArray[2]);
                    p.Explain = row.ItemArray[3].ToString();
                    g.Pages.Add(p);
                }
            }
            return g;
        }
        private string FindName;
        public void HyperStructure_MenuAdd(string GName)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = GName;
            새북OToolStripMenuItem.DropDownItems.Add(item);
            item.Click += HyperStructure_MenuClick;
        }
        public void HyperStructure_MenuClick(object sender, EventArgs e)
        {
            FindName = ((ToolStripMenuItem)sender).Text;
            Group g = new Group(HyperGroups.Find(new Predicate<Group>(FindStructureCompare)));
            if (g == null)
            {
                MessageBox.Show("이 즐겨찾기 그룹을 찾을수 없습니다.");
            }
            DialogResult question = MessageBox.Show("작업중이던 파일을 저장하시겠습니까?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                SVDialog.FileName = "";
                if (SVDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(SVDialog.FileName);
                }
            }
            g.Name = "";
            mybook.MainGroup = g;
            PageSet(1);
        }
        public bool FindStructureCompare(Group G)
        {
            if (G.Name == FindName)
                return true;
            else
                return false;
        }
        public void LoadHyperStructure()
        {
            DataSet dSet = new DataSet();
            DirectoryInfo DirectoryInfo= new DirectoryInfo(Application.StartupPath + @"\HyperStructures");
            if(DirectoryInfo.Exists)
            {
                string[] Files = Directory.GetFiles(DirectoryInfo.FullName,"*.xml");
                HyperGroups = new List<Group>();
                foreach(string at in Files)
                {
                    try
                    {
                        dSet.ReadXml(at);
                        HyperGroups.Add(TableToGroup(dSet.Tables["\\" + dSet.DataSetName]));
                        HyperStructure_MenuAdd(dSet.DataSetName);
                    }
                    catch(Exception)
                    {
                        
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(DirectoryInfo.FullName);
            }
        }
        
        public void ResetBook()
        {
            mybook = new Book();
            mybook.BookName = "책 이름입니다.";
            mybook.BookExplain = "책 설명입니다.";
            mybook.PageCount = 1;
            
            PageIndex = 0;
            Page.myPage = new Page();
            Page.myPage.myBook = mybook;
            Page.dColor = Color.Black;
            Page.myPage.PageIndex = 1;
            Page.myPage.Name = "페이지1";
            Page.myPage.Parent = mybook.MainGroup;
            mybook.MainGroup.Pages.Add(Page.myPage);
            PageSet(1);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = false;
            Page._EraseMode();
        }

        private void toolMemo_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = false;
            Page.SetCreateMode(DataType.Memo);
        }

        public void SaveFile(string FileName)
        {
            System.IO.FileStream fstream = new System.IO.FileStream(FileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            Page.Save();
            Component.SaveClass(mybook, fstream);
            fstream.Close();
        }
        public void LoadFile(string FileName)
        {
            System.IO.FileStream fstream = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            LoadBook((Book)Component.LoadClass(fstream));
            fstream.Close();
            PageSet(1);
        }
        public void LoadBook(Book b)
        {
            if (b.SecretKey != null)
            {
            replay:
                string input = Forms.InputBox.InputString("패스워드 입력", "이 책은 패스워드가 있습니다. 패스워드를 입력해주십시오.", true);
                
                if (input != null)
                {
                    if (input.Length < 8)
                    {
                        MessageBox.Show("패스워드는 8자리 이상 입력해주십시오.");
                        goto replay;
                    }
                    string Encpt = Component.MD5Encrypt(input);
                    if (Encpt != b.SecretKey)
                    {
                        MessageBox.Show("비밀번호가 알맞지 않습니다. 다시 입력해주십시오,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto replay;
                    }
                }
                else
                {
                    return;
                }
            }
            mybook = b;
            mybook.MainGroup.RefreshAllPage();
            PageSet(1);
        }
        private void toolText_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = false;
            Page.SetCreateMode(DataType.Text);

        }

        private void toolImage_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = false;
            Page.SetCreateMode(DataType.Image);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = true;
            Page.SetCreateMode(DataType.Ellipse);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = false;
            Page.SetCreateMode(DataType.FillEllipse);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = true;

            Page.SetCreateMode(DataType.Rectangle);

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = false;

            Page.SetCreateMode(DataType.FillRectangle);

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = true;

            Page.SetCreateMode(DataType.Line);

        }

        public void PageSet(int index)
        {
            Page p = mybook.TreeToPage(mybook.MainGroup, index);


            Page.Save();
            if (p != null)
            {
                PageIndex = index;
                Page.PageLoad(p);
                label1.Text = p.PageIndex.ToString() + "/" + mybook.PageCount.ToString() + " " + p.Name;
                Page.Refresh();
            }
        }
        private void btBook_Click(object sender, EventArgs e)
        {
            CyberLibrary2.Forms.BookSettingForm frmbok = new CyberLibrary2.Forms.BookSettingForm(mybook,this);
            frmbok.ShowDialog();
            PageSet(PageIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageSet(PageIndex+1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageSet(PageIndex-1);
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            cDialog.Color = Page.dColor;
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                Page.dColor = cDialog.Color;
            }
        }

        private void 책설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BookSettingForm frmbok = new CyberLibrary2.Forms.BookSettingForm(mybook,this);
            frmbok.ShowDialog();
            PageSet(1);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            굵기설정ToolStripMenuItem.Enabled = false;
            Page.EraseMode = false;
            Page.CreateMode = false;
            Page.MakeSquare = false;
        }

        private void 굵기설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Forms.InputBox.InputString("굵기를 입력해주세요.", "굵기 설정",false);
            if (input != null)
            {
                try
                {
                    Page.LineWidth = (float)Convert.ToDouble(input);

                }
                catch (Exception)
                {
                    MessageBox.Show("제대로 된 값을 입력해 주십시오.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 빠르게가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.HasteForm hform = new CyberLibrary2.Forms.HasteForm(mybook, Page.myPage.Name);
            if (hform.ShowDialog() == DialogResult.OK)
            {
                Page p = mybook.TreeToPage(mybook.MainGroup, hform.name);
                PageSet(p.PageIndex);
            }
        }

        private void 색설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            cDialog.Color = Page.dColor;
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                Page.dColor = cDialog.Color;
            }
        }

        private void 새북OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 북열기SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OEDialog.FileName = "";
            if (OEDialog.ShowDialog() == DialogResult.OK)
                LoadFile(OEDialog.FileName);
        }

        private void 북저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SVDialog.FileName = "";
            if (SVDialog.ShowDialog() == DialogResult.OK)
                SaveFile(SVDialog.FileName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PageSet(PageIndex - 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PageSet(PageIndex + 1);
        }


        private void BookEditor_Load(object sender, EventArgs e)
        {
            this.FindForm().KeyDown += BookEditor_KeyDown;
            책설정ToolStripMenuItem.ShortcutKeyDisplayString = ProgramSettings.GetSKey("BookSetting").ToString();
            굵기설정ToolStripMenuItem.ShortcutKeyDisplayString = ProgramSettings.GetSKey("BoldSetting").ToString();
            색설정ToolStripMenuItem.ShortcutKeyDisplayString = ProgramSettings.GetSKey("ColorSetting").ToString();
            빠르게가기ToolStripMenuItem.ShortcutKeyDisplayString = ProgramSettings.GetSKey("Haste").ToString();
        }
        public void ResetBook(string BName,string Explain,params string[] Names)
        {
            mybook = new Book();
            mybook.BookName = BName;
            mybook.BookExplain = Explain;
            mybook.WriterName = "작가 이름입니다.";
            Group Group;
            Page Page;
            foreach (string at in Names)
            {

                Group = new Group();

                Group.Name = Group.Explain = at;
                Page = new Page();
                Page.Name = Page.Explain = at;
                Group.Pages.Add(Page);
                mybook.MainGroup.Groups.Add(Group);
            }
            PageSet(1);
        }

        private void BookEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.Visible) return;
            if (ProgramSettings.GetSKey("BookSetting").CheckKeyEvent(e))
            {
                책설정ToolStripMenuItem_Click(sender, null);
            }
            if (ProgramSettings.GetSKey("PrevPage").CheckKeyEvent(e))
            {
                PageSet(PageIndex - 1);
            }
            if (ProgramSettings.GetSKey("NextPage").CheckKeyEvent(e))
            {
                PageSet(PageIndex + 1);
            }
            if (ProgramSettings.GetSKey("TextMode").CheckKeyEvent(e))
                toolText_Click(sender, null);
            if (ProgramSettings.GetSKey("ImageMode").CheckKeyEvent(e))
                toolImage_Click(sender, null);
            if (ProgramSettings.GetSKey("EllipseMode").CheckKeyEvent(e))
                toolStripButton2_Click(sender, null);
            if (ProgramSettings.GetSKey("FillEllipseMode").CheckKeyEvent(e))
                toolStripButton3_Click(sender, null);
            if (ProgramSettings.GetSKey("RectangleMode").CheckKeyEvent(e))
                toolStripButton4_Click(sender, null);
            if (ProgramSettings.GetSKey("FillRectangleMode").CheckKeyEvent(e))
                toolStripButton5_Click(sender, null);
            if (ProgramSettings.GetSKey("LineMode").CheckKeyEvent(e))
                toolStripButton6_Click(sender, null);
            if (ProgramSettings.GetSKey("EraserMode").CheckKeyEvent(e))
                toolStripButton1_Click(sender, null);
            if (ProgramSettings.GetSKey("MemoMode").CheckKeyEvent(e))
                toolMemo_Click(sender, null);
            if (ProgramSettings.GetSKey("MouseMode").CheckKeyEvent(e))
                toolStripButton1_Click_1(sender, null);
            if (ProgramSettings.GetSKey("Haste").CheckKeyEvent(e))
                빠르게가기ToolStripMenuItem_Click(sender, null);
            if (ProgramSettings.GetSKey("ColorSetting").CheckKeyEvent(e))
                색설정ToolStripMenuItem_Click(sender, null);
            if (ProgramSettings.GetSKey("BoldSetting").CheckKeyEvent(e) && 굵기설정ToolStripMenuItem.Enabled)
                굵기설정ToolStripMenuItem_Click(sender, null);
            
        }

        private void Page_Load(object sender, EventArgs e)
        {

        }

        private void 새책NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("작업중이던 파일을 저장하시겠습니까?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                SVDialog.FileName = "";
                if (SVDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(SVDialog.FileName);
                }
            }
            mybook = new Book();
            mybook.BookName = "책 이름입니다.";
            mybook.BookExplain = "책 설명입니다.";
            mybook.PageCount = 1;

            PageIndex = 0;
            Page.dColor = Color.Black;
            Page.myPage = new Page();
            Page.myPage.PageIndex = 1;
            Page.myPage.Name = "페이지1";
            Page.myPage.Parent = mybook.MainGroup;
            mybook.MainGroup.Pages.Add(Page.myPage);
            PageSet(1);
        }

        private void 비밀번호설정PToolStripMenuItem_Click(object sender, EventArgs e)
        {
        replay:
            string input = Forms.InputBox.InputString("패스워드 설정", "설정하실 패스워드를 입력해주세요.", true);
            if (input != null)
            {
                if (input.Length < 8)
                {
                    MessageBox.Show("패스워드는 8자리 이상 입력해주십시오.");
                    goto replay;
                }
                mybook.SecretKey = input;
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

    }
}
