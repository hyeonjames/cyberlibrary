using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;
using CyberLibrary2.Classes;
namespace CyberLibrary2
{
    public partial class PageControl : UserControl
    {
        Point Square_Point,ShiftPoint;
        public Page myPage;
        DataType ctype;
        public DMemo sMemo;
        Point MaxExcess;
        public Color dColor;
        Point BeforePoint;
        public bool CreateMode=false;
        bool ShiftMemo = false;
        public bool EraseMode = false;
        public bool MakeSquare=false;
        public float LineWidth = 1;
        public PageControl()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            myPage = new Page();
            MaxExcess = new Point(0,0);
            BeforePoint = new Point(0, 0);
            SetMaxHVScroll();
        }
        public void RefreshScroll()
        {
            vScroll.Value = hScroll.Value = 0;
            SetHVScroll();
            MaxExcess.X = MaxExcess.Y = 0;
            foreach (DMemo d in myPage.Memos)
            {
                MaxExcess.X = (int)Math.Max((double)(d.Location.X + d.Size.Width), MaxExcess.X);
                MaxExcess.Y = (int)Math.Max((double)(d.Location.Y + d.Size.Height), MaxExcess.Y);

            }
            foreach (Control d in Controls)
            {
                if (d is BoardControl)
                {
                    if (d.Visible)
                    {
                        MaxExcess.X = (int)Math.Max((double)(d.Location.X + d.Size.Width), MaxExcess.X);
                        MaxExcess.Y = (int)Math.Max((double)(d.Location.Y + d.Size.Height), MaxExcess.Y);

                    }
                    else
                    {
                        MaxExcess.X = (int)Math.Max((double)(d.Location.X + d.Size.Width), MaxExcess.X);
                        MaxExcess.Y = (int)Math.Max((double)(d.Location.Y + d.Size.Height), MaxExcess.Y);
            
                    }
                }
            }
            foreach (DDraw d in myPage.Draws)
            {
                MaxExcess.X = (int)Math.Max((double)(d.Location.X + d.Size.Width), MaxExcess.X);
                MaxExcess.Y = (int)Math.Max((double)(d.Location.Y + d.Size.Height), MaxExcess.Y);
            }
            SetMaxHVScroll();
        }
        public void SetCreateMode(DataType dtype)
        {
            
            EraseMode = false;
            ctype = dtype;
            CreateMode = true;
            MakeSquare = false;
            this.Cursor = Cursors.Arrow;
        }
        public void CreateData(DataType dType, Rectangle point)
        {
            switch(dType)
            {
                case DataType.Memo:
                    DMemo dMemo = new DMemo();
                    MemoDialog mDialog = new MemoDialog();
                    mDialog.ShowDialog();
                    if (mDialog.ok)
                    {
                        
                        dMemo = mDialog.memo;
                        dMemo.Size = point.Size;
                        dMemo.Location.X = point.Location.X;
                        dMemo.Location.Y = point.Location.Y;
                        dMemo.myPage = myPage;
                        myPage.Memos.Add(dMemo);
                        
                    }
                    else
                        return;
                    break;
                case DataType.Image:
                    Forms.ImageDialog imgDialog = new CyberLibrary2.Forms.ImageDialog(null);
                    imgDialog.ShowDialog();
                    if (imgDialog.ok)
                    {

                        DImage dimg = new DImage();
                        dimg.Location = point.Location;
                        dimg.Size = point.Size;
                        dimg.img = imgDialog.img;
                        dimg.LoadW(this);
                        dimg.myPage = myPage;
                        dimg.ControlIndex = myPage.LastControlIndex++;
                        myPage.Controls.Add(dimg);
                        myPage.Controls.Sort(new Comparison<BookData>(SortCompare));
                    
                    }
                    else
                        return;
                    break;
                case DataType.Text:
                    DText dText = new DText();
                    dText.Location = point.Location;
                    dText.Size = point.Size;
                    dText.myPage = myPage;
                    dText.LoadW(this);
                    dText.ControlIndex = myPage.LastControlIndex++;
                    myPage.Controls.Add(dText);
                    ((bLabel)dText.bControl).Mode_Write();
                    myPage.Controls.Sort(new Comparison<BookData>(SortCompare));
                    break;
                default:
                        DDraw DDraw = new DDraw();
                        DDraw.myType = dType;
                        DDraw.Size = point.Size;
                        DDraw.Location.X = point.Location.X;
                        DDraw.Location.Y = point.Location.Y;
                        DDraw.BColor = dColor;
                        DDraw.lwidth = LineWidth;
                        DDraw.ControlIndex = myPage.LastControlIndex++;
                        DDraw.myPage = myPage;
                        //DDraw.Load(this);
                    
                        Invalidate();
                        myPage.Draws.Add(DDraw);
                        myPage.Draws.Sort(new Comparison<DDraw>(SortCompare));
                    
                    break;
            }
            CreateMode = false;
            MaxExcess.X = (int)Math.Max(point.X+point.Width, MaxExcess.X);

            MaxExcess.Y = (int)Math.Max(point.Y+point.Height, MaxExcess.Y);
            
            SetMaxHVScroll();
            Invalidate();
        }
        private int SortCompare(DDraw a, DDraw b)
        {
            return a.ControlIndex - b.ControlIndex;
        }
        private int SortCompare(BookData a, BookData b)
        {
            return a.ControlIndex - b.ControlIndex;
        }
        private void PageControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (!EraseMode)
            {
                if (CreateMode && !MakeSquare)
                {
                    Square_Point = e.Location;
                    MakeSquare = true;
                    return;
                }
                foreach (DMemo dMemo in myPage.Memos)
                {
                    if (new Rectangle(dMemo.Location, dMemo.Size).IntersectsWith(new Rectangle(e.Location,new Size(0,0))))
                    {
                        ShiftMemo = true;
                        ShiftPoint = new Point();
                        ShiftPoint.X = e.X - dMemo.Location.X;
                        MaxExcess.X = (int)Math.Max(ShiftPoint.X + dMemo.Size.Width, MaxExcess.X);

                        ShiftPoint.Y = e.Y - dMemo.Location.Y;
                        MaxExcess.Y = (int)Math.Max(ShiftPoint.Y + dMemo.Size.Height, MaxExcess.Y);
                        SetMaxHVScroll();
                        sMemo = dMemo;
                    }
                }
            }
        }
        public void PageLoad(Page p)
        {
            hScroll.Value = 0;
            vScroll.Value = 0;
            SetHVScroll();

            myPage = p;
            foreach (Control bControl in Controls)
                if (bControl is BoardControl) Controls.Remove(bControl);
            foreach (BookData bData in p.Controls)
            {
                bData.LFunc(this);
            }
            RefreshScroll();
            if (ProgramSettings.BackgroundImage) this.BackgroundImage = myPage.BackgroundImage;
            this.BackColor = myPage.BackColor;
            Invalidate();

        }
        private void PageControl_Load(object sender, EventArgs e)
        {
            vScroll.Value = 0;
            hScroll.Value = 0;
        }

        private void PageControl_Paint(object sender, PaintEventArgs e)
        {
            
            int i = 0,j=0,z=0;
            for (i = 0; i < myPage.LastControlIndex; i++)
            {
                if (myPage.Draws.Count > j && myPage.Draws[j].ControlIndex == i)
                {
                    if (!e.ClipRectangle.IntersectsWith(new Rectangle(myPage.Draws[j].Location, myPage.Draws[j].Size))) continue;
                    myPage.Draws[j].Draw(e.Graphics);
                    j++;
                }
                else if(myPage.Controls.Count > z && myPage.Controls[z].ControlIndex == i)
                {
                    if (myPage.Controls[z].bControl != null && !myPage.Controls[z].bControl.Visible)
                    {
                        if (!e.ClipRectangle.IntersectsWith(new Rectangle(myPage.Controls[z].Location, myPage.Controls[z].Size))) continue;
                        myPage.Controls[z].DrawL(e.Graphics);
                    }
                    z++;
                }
            }
            for (i = 0; i < myPage.Memos.Count; i++)
            {
                if (!e.ClipRectangle.IntersectsWith(new Rectangle(myPage.Memos[i].Location, myPage.Memos[i].Size))) continue;
                myPage.Memos[i].Draw2(e.Graphics);
            }
            //RefreshScroll();
            if (CreateMode && MakeSquare)
            {
                Point nowPoint = this.PointToClient(Cursor.Position);
                Rectangle rect = new Rectangle(Square_Point, new Size(nowPoint.X - Square_Point.X, nowPoint.Y - Square_Point.Y));
                Component.TypeDraw(dColor, LineWidth, e.Graphics, ctype, rect.Location, rect.Size);
            }
        }
        private void PageControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (EraseMode)
                return;
            
            if (!ShiftMemo)
            {
                if (CreateMode && MakeSquare)
                {
                    Invalidate();
                }
                foreach (DMemo dMemo in myPage.Memos)
                {
                    if (new Rectangle(dMemo.Location, dMemo.Size).IntersectsWith(new Rectangle(e.Location,new Size(0,0))))
                    {
                        Cursor = new Cursor(Resource_Files.MyResources._16_comment.GetHicon());
                        return;
                    }
                }
                Cursor = Cursors.Default;
            }
            else
            {
                sMemo.Location.X = e.X - ShiftPoint.X;
                sMemo.Location.Y = e.Y - ShiftPoint.Y;
                SetMaxExcess();

                Invalidate();
                SetMaxHVScroll();
            }

        }
        public void SetMaxExcess()
        {
            MaxExcess.X = MaxExcess.Y = 0;
            foreach (Control at in Controls)
            {
                if (at is BoardControl)
                {
                    MaxExcess.X = (int)Math.Max(at.Location.X + at.Width, MaxExcess.X);
                    MaxExcess.Y = (int)Math.Max(at.Location.Y + at.Height,MaxExcess.Y);
                }
            }
            foreach (BookData at in myPage.Controls)
            {
                MaxExcess.X = (int)Math.Max(at.Location.X + at.Size.Width, MaxExcess.X);
                MaxExcess.Y = (int)Math.Max(at.Location.Y + at.Size.Height, MaxExcess.Y);
                
            }
            foreach (DMemo at in myPage.Memos)
            {
                MaxExcess.X = (int)Math.Max(at.Location.X + at.Size.Width, MaxExcess.X);
                MaxExcess.Y = (int)Math.Max(at.Location.Y + at.Size.Height, MaxExcess.Y);
                
            }
        }
        public void SetHVScroll()
        {
            foreach (Control at in Controls)
            {
                if(at is BoardControl)
                {
                    at.SetBounds(at.Location.X - (vScroll.Value - BeforePoint.X) * 10, at.Location.Y - (hScroll.Value - BeforePoint.Y) * 10, at.Width, at.Height);
                    ((BoardControl)at).myData.Location.X -= (vScroll.Value - BeforePoint.X) * 10;
                    ((BoardControl)at).myData.Location.Y -= (hScroll.Value - BeforePoint.Y) * 10;
                }
            }
            foreach (DMemo at in myPage.Memos)
            {
                at.Location.X -= (vScroll.Value - BeforePoint.X) * 10;
                at.Location.Y -= (hScroll.Value - BeforePoint.Y) * 10;
            }
            foreach (DDraw at in myPage.Draws)
            {
                at.Location.X -= (vScroll.Value - BeforePoint.X) * 10;
                at.Location.Y -= (hScroll.Value - BeforePoint.Y) * 10;
            }
            BeforePoint = new Point(vScroll.Value, hScroll.Value);
            Invalidate();
        }
        public void SetMaxHVScroll()
        {
            hScroll.Maximum = ((int)Math.Max(MaxExcess.Y-this.Height+vScroll.Height,0))/10;
            vScroll.Maximum = ((int)Math.Max(MaxExcess.X-this.Width+hScroll.Width,0))/10;
            if (hScroll.Maximum == 0)
                hScroll.Enabled = false;
            else
            {
                hScroll.Maximum += 4;

                hScroll.Enabled = true;
            }
            if (vScroll.Maximum == 0)
                vScroll.Enabled = false;
            else
            {
                vScroll.Maximum += 4;

                vScroll.Enabled = true;
            }
        }
        public void Save()
        {
            hScroll.Value = 0;
            vScroll.Value = 0;
            SetHVScroll();
            foreach (Control at in Controls)
            {
                if (!(at is HScrollBar) && !(at is VScrollBar))
                {
                    ((BoardControl)at).mSave();
                }
            }
        }
        public void _EraseMode()
        {
            //CreateMode = EraseMode;
            //MakeSquare = EraseMode;
            //ShiftMemo = EraseMode;
            EraseMode = !EraseMode;
            if (EraseMode)
            {
                Cursor = new Cursor(Resource_Files.MyResources.mco.Handle);
            }
        }
        private void PageControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ShiftMemo)
            {
                if (CreateMode && MakeSquare)
                {
                    MakeSquare = false;
                    Point nowPoint = this.PointToClient(Cursor.Position);
                    CreateData(ctype, new Rectangle(Square_Point.X, Square_Point.Y, nowPoint.X - Square_Point.X, nowPoint.Y - Square_Point.Y));
                }
            }
            else
            {
                ShiftMemo = false;
            }
        }

        private void PageControl_Click(object sender, EventArgs e)
        {
            if (EraseMode)
            {
                PDelete(this.PointToClient(Cursor.Position));
            }
        }
        private void PDelete(Point xy)
        {
            int i = 0;
            for (i = myPage.Memos.Count - 1; i >= 0; i--)
            {
                if (new Rectangle(myPage.Memos[i].Location, myPage.Memos[i].Size).IntersectsWith(new Rectangle(xy,new Size(0,0))))
                {
                    myPage.Memos[i].Dispose();
                    myPage.Memos.RemoveAt(i);

                    Invalidate();
                    return;
                }
            }
            for (i = Controls.Count - 1; i >= 0; i--)
            {
                if (!(Controls[i] is VScrollBar) && !(Controls[i] is HScrollBar) && Math.checkin(new Rectangle(Controls[i].Location, Controls[i].Size), xy))
                {
                    
                    if (Controls[i] is bLabel)
                    {
                        
                        ((bLabel)Controls[i]).Dispose();
                    }
                    Controls.RemoveAt(i);
                    Invalidate();
                    return;
                }
            }
            for (i = myPage.Draws.Count - 1; i >= 0; i--)
            {
                if (myPage.Draws[i].myType == DataType.Line)
                {
                    if (myPage.Draws[i].GetRectangle().IntersectsWith(new Rectangle(xy, new Size(0, 0))))
                    {
                        myPage.Draws[i].Dispose();
                        myPage.Draws.RemoveAt(i);
                        Invalidate();
                        return;
                    }
                }
                else
                {
                    if (new Rectangle(myPage.Draws[i].Location,myPage.Draws[i].Size).IntersectsWith(new Rectangle(xy, new Size(0, 0))))
                    {
                        myPage.Draws[i].Dispose();
                        myPage.Draws.RemoveAt(i);

                        Invalidate();
                        return;
                    }
                }
            }
            
        }

        private void vScroll_ValueChanged(object sender, EventArgs e)
        {

            SetHVScroll();
        }

        private void PageControl_SizeChanged(object sender, EventArgs e)
        {
            RefreshScroll();
        }

        private void 배경색지정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            cDialog.Color = BackColor;
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                myPage.BackColor = cDialog.Color;
                this.BackColor = myPage.BackColor;
            }
        }

        private void PageControl_DoubleClick(object sender, EventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);
            
            foreach (BookData bData in myPage.Controls)
            {
                if (new Rectangle(bData.Location, bData.Size).IntersectsWith(new Rectangle(p, new Size(0, 0))))
                {
                    if (bData is DText && !bData.bControl.Visible)
                    {
                        ((bLabel)bData.bControl).Mode_Write();
                        break;
                    }
                    else if (bData is DImage && !bData.bControl.Visible)
                    {
                        bData.bControl.Show();
                        break;
                    }
                }
            }
        }

    }
    
}
