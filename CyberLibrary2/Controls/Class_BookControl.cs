using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using CyberLibrary2.Classes;
namespace CyberLibrary2
{
    public delegate void SaveFunc();
    public partial class BoardControl : UserControl
    {
        public SaveFunc mSave;
        public BookData myData;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BoardControl
            // 
            this.Name = "BoardControl";
            this.Load += new System.EventHandler(this.BoardControl_Load);
            this.ResumeLayout(false);

        }

        private void BoardControl_Load(object sender, EventArgs e)
        {

        }
    }
    public delegate void LoadFunc(Control p);
    public delegate void DisposeFunc();
    public delegate void PrintFunc(Graphics e);
    [Serializable]

    public class BookData
    {
        public DataType myType;
        public Point Location;
        public Size Size;
        public DisposeFunc DisposeL;
        public PrintFunc Printer;
        public PrintFunc DrawL;
        public LoadFunc LFunc;
        [NonSerialized]
        public BoardControl bControl;
        [NonSerialized]
        public Page myPage;
        public int ControlIndex;
        public BookData()
        {
            
        }
    }
    [Serializable]
    public class DMemo : BookData
    {
        public string Name, Context;
        public Color BColor, FColor;
        public Font Font;
        [NonSerialized]
        MemoView mview;
        public DMemo()
        {
            myType = DataType.Memo;
            DisposeL = new DisposeFunc(Dispose);
        }
        public void Show(Control p)
        {
            Point m = p.PointToClient(Cursor.Position);
            p.Controls.Remove(mview);
            mview = new MemoView(this);
            mview.SetBounds(m.X, m.Y, 100, 100);
            p.Controls.Add(mview);
        }
        public void Draw2(Graphics e)
        {
            e.DrawRectangle(new Pen(new HatchBrush(HatchStyle.Divot, BColor)), new Rectangle(Location, Size));
        
        }
        public void Draw(Graphics e)
        {

            if (ProgramSettings.MemoView)
            {
                e.DrawRectangle(new Pen(new HatchBrush(HatchStyle.Divot, BColor)), new Rectangle(Location, Size));
            }
            if (ProgramSettings.MemoTopView)
            {
                e.DrawString(Context, Font, new HatchBrush(HatchStyle.Cross,FColor), Location);
            }
            if (ProgramSettings.MemoMiddleView)
            {
                PointF StringLocation = new PointF(Location.X, Location.Y + (Size.Height / 2) - (Font.Size / 2));
                e.DrawString(Context, Font, new HatchBrush(HatchStyle.Cross,FColor), StringLocation);
            }
            if (ProgramSettings.MemoBottomView)
            {
                PointF StringLocation = new PointF(Location.X, Location.Y + Size.Height - Font.Size - 3);
                e.DrawString(Context, Font, new HatchBrush(HatchStyle.Cross,FColor), StringLocation);
            }
        }
        public Color GetFontColor()
        {
            if (ProgramSettings.MemoDefaultFontColor == Color.Empty)
                return FColor;
            else
                return ProgramSettings.MemoDefaultFontColor;
        }
        public Color GetBackColor()
        {
            if (ProgramSettings.MemoDefaultBackColor == Color.Empty)
                return BColor;
            else
                return ProgramSettings.MemoDefaultBackColor;
        }
        public Font GetFont()
        {
            if (ProgramSettings.MemoDefaultFont == null)
                return Font;
            else
                return ProgramSettings.MemoDefaultFont;
        }
        public void Dispose()
        {
            myPage.Memos.Remove(this);
        }
    }
    [Serializable]
    public class DDraw : BookData
    {
        public Color BColor;
        public float lwidth;
        public Rectangle GetRectangle()
        {
            Rectangle rct = new Rectangle();
            rct.Width = Size.Width;
            if (Size.Width <= 0)
            {
                rct.Width += Location.X;
            }
            rct.Height = Size.Height;
            if (Size.Height <= 0)
            {
                rct.Height += Location.Y;
            }
            rct.Location = Location;
            Printer = new PrintFunc(Print);
            return rct;
        }
        public void Print(Graphics e)
        {
            Draw(e);
        }
        public void Dispose()
        {
            myPage.Draws.Remove(this);
        }

        public DDraw()
        {
            DisposeL = new DisposeFunc(Dispose);
            lwidth = 1;
            Printer = new PrintFunc(Print);
        }
        public void Draw(Graphics p)
        {
            
            switch (myType)
            {
                case DataType.Ellipse:
                    p.DrawEllipse(new Pen(BColor,lwidth), new Rectangle(Location, Size));
                    break;
                case DataType.FillEllipse:
                    p.FillEllipse(new SolidBrush(BColor), new Rectangle(Location, Size));
                    break;
                case DataType.Line:
                    
                    p.DrawLine(new Pen(BColor,lwidth), Location,new Point(Size.Width + Location.X,Size.Height + Location.Y));
                    break;
                case DataType.FillRectangle:
                    p.FillRectangle(new SolidBrush(BColor), new Rectangle(Location, Size));
                    break;
                default:
                    p.DrawRectangle(new Pen(BColor,lwidth), new Rectangle(Location, Size));
                    break;
            }
        }
    }
    [Serializable]
    public class DText : BookData
    {
        public List<PointFC> Points;
        public List<float> Linecut;
        public string Context;
        public DText()
        {
            Points = new List<PointFC>();
            Linecut = new List<float>();
            myType = DataType.Text;
            LFunc = new LoadFunc(LoadW);
            DisposeL = new DisposeFunc(LDispose);
            DrawL = new PrintFunc(Draw);
            Printer = new PrintFunc(Print);
        }
        public void Print(Graphics e)
        {
            Draw(e);
        }
        public void LDispose()
        {
            myPage.Controls.Remove(this);
        }
        public void Draw(Graphics g)
        {
            try
            {
                
                string outp = "";

                int Line = 0;
                if (Context.Length == 0) return;
                foreach (PointFC pfc in Points)
                {
                    if (pfc.Length == 0) continue;
                    outp = Context.Substring(pfc.start, pfc.Length);

                    g.FillRectangle(new SolidBrush(pfc.bcolor), new Rectangle((int)(this.Location.X + pfc.StringPlace.X) + 3, (int)(this.Location.Y + pfc.StringPlace.Y), pfc.BackColorPlace, (int)pfc.font.Size + 6));

                    g.DrawString(outp, pfc.font, new SolidBrush(pfc.color), this.Location.X + pfc.StringPlace.X, this.Location.Y + pfc.StringPlace.Y);

                    Line = pfc.Line;
                }
            }
            catch (Exception)
            {

            }
        }
        public void LoadW(Control p)
        {
            bLabel b = new bLabel((PageControl)p);
            b.LoadText(this);
            b.SetBounds(Location.X, Location.Y, Size.Width, Size.Height);

            p.Controls.Add(b);
            bControl = b;
            bControl.myData = this;
            b.Mode_Read();
        }
    }
    [Serializable]
    public class DImage : BookData
    {
        public Image img;
        public DImage()
        {
            myType = DataType.Image;
            LFunc = new LoadFunc(LoadW);
            DisposeL = new DisposeFunc(Dispose);
            Printer = new PrintFunc(Print);
            DrawL = new PrintFunc(Draw);
        }
        public void Print(Graphics e)
        {
            e.DrawImage(img, Location.X,Location.Y,Size.Width,Size.Height);
        }
        public void Dispose()
        {
            myPage.Controls.Remove(this);
        }
        public void Draw(Graphics e)
        {
            e.DrawImage(img, Location.X, Location.Y, Size.Width, Size.Height);
        
        }
        public void LoadW(Control p)
        {
            BoardImage b = new BoardImage((PageControl)p);
            b.SetBounds(Location.X, Location.Y, Size.Width, Size.Height);
            b.img = img;
            p.Controls.Add(b);
            bControl = b;
            bControl.myData = this;
        }
    }
    public enum DataType
    {
        Memo,
        Image,
        Text,
        Rectangle,
        Line,
        Ellipse,
        FillEllipse,
        FillRectangle,        
    }
}