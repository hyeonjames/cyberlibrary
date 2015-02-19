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
    public partial class Page_Read : UserControl
    {
        public Page myPage;
        Point MaxExcess;

        Point BeforePoint;
        public Page_Read()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            BeforePoint = new Point(0, 0);
            myPage = new Page();
        }
        public void SetMaxExcess()
        {
            MaxExcess.X = MaxExcess.Y = 0;
            foreach (Control at in Controls)
            {
                if (!(at is HScrollBar) && !(at is VScrollBar))
                {
                    MaxExcess.X = (int)Math.Max(at.Location.X + at.Width, MaxExcess.X);
                    MaxExcess.Y = (int)Math.Max(at.Location.Y + at.Height, MaxExcess.Y);
                }
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
                if (!(at is HScrollBar) && !(at is VScrollBar))
                {
                    at.SetBounds(at.Location.X - (vScroll.Value - BeforePoint.X) * 10, at.Location.Y - (hScroll.Value - BeforePoint.Y) * 10, at.Width, at.Height);
                }
            }
            foreach (BookData at in myPage.Controls)
            {
                if (at is DText || at is DImage)
                {
                    at.Location.X -= (vScroll.Value - BeforePoint.X) * 10;
                    at.Location.Y -= (hScroll.Value - BeforePoint.Y) * 10;    
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
            hScroll.Maximum = ((int)Math.Max(MaxExcess.Y - this.Height + vScroll.Height, 0)) / 10;
            vScroll.Maximum = ((int)Math.Max(MaxExcess.X - this.Width + hScroll.Width, 0)) / 10;
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
        public void PageLoad(Page p)
        {

            hScroll.Value = 0;
            vScroll.Value = 0;
            SetHVScroll();
            myPage = p;
            RefreshScroll();
            if (ProgramSettings.BackgroundImage) this.BackgroundImage = myPage.BackgroundImage;
            this.BackColor = myPage.BackColor;
            Invalidate();
        }

        public void RefreshScroll()
        {
            vScroll.Value = hScroll.Value = 0;
            SetHVScroll();
            foreach (DMemo d in myPage.Memos)
            {
                MaxExcess.X = (int)Math.Max((double)(d.Location.X + d.Size.Width), MaxExcess.X);
                MaxExcess.Y = (int)Math.Max((double)(d.Location.Y + d.Size.Height), MaxExcess.Y);

            }
            foreach (BookData d in myPage.Controls)
            {
                MaxExcess.X = (int)Math.Max((double)(d.Location.X + d.Size.Width), MaxExcess.X);
                MaxExcess.Y = (int)Math.Max((double)(d.Location.Y + d.Size.Height), MaxExcess.Y);


            }
            foreach (DDraw d in myPage.Draws)
            {
                MaxExcess.X = (int)Math.Max((double)(d.Location.X + d.Size.Width), MaxExcess.X);
                MaxExcess.Y = (int)Math.Max((double)(d.Location.Y + d.Size.Height), MaxExcess.Y);
            }
            SetMaxHVScroll();
        }

        private void hScroll_ValueChanged(object sender, EventArgs e)
        {
            SetHVScroll();
        }

        private void vScroll_ValueChanged(object sender, EventArgs e)
        {
            SetHVScroll();
        }

        private void Page_Read_Click(object sender, EventArgs e)
        {
            Point m = this.PointToClient(Cursor.Position);
            foreach (DMemo dmemo in myPage.Memos)
            {
                if(Math.checkin(new Rectangle(dmemo.Location,dmemo.Size),m))
                {
                    dmemo.Show(this);
                    return ;
                }
            }
        }

        private void Page_Read_SizeChanged(object sender, EventArgs e)
        {
            RefreshScroll();
        }

        private void Page_Read_MouseMove(object sender, MouseEventArgs e)
        {
            Point m = this.PointToClient(Cursor.Position);
            foreach (DMemo dmemo in myPage.Memos)
            {
                if (new Rectangle(dmemo.Location, dmemo.Size).IntersectsWith(new Rectangle(m,new Size(0,0))))
                {
                    this.Cursor = new Cursor(Resource_Files.MyResources._16_comment.GetHicon());
                    return;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void Page_Read_Load(object sender, EventArgs e)
        {

        }

        private void Page_Read_Paint(object sender, PaintEventArgs e)
        {
            int i = 0, j = 0, z = 0;
            for (i = 0; i < myPage.LastControlIndex; i++)
            {
                if (myPage.Draws.Count > j && myPage.Draws[j].ControlIndex == i)
                {
                    if (!e.ClipRectangle.IntersectsWith(new Rectangle(myPage.Draws[j].Location, myPage.Draws[j].Size))) continue;
                    myPage.Draws[j].Draw(e.Graphics);
                    j++;
                }
                else if (myPage.Controls.Count > z && myPage.Controls[z].ControlIndex == i)
                {
                    if (!e.ClipRectangle.IntersectsWith(new Rectangle(myPage.Controls[z].Location, myPage.Controls[z].Size))) continue;
                    myPage.Controls[z].DrawL(e.Graphics);
                    z++;
                }
            }
            for (i = 0; i < myPage.Memos.Count; i++)
            {
                if (!e.ClipRectangle.IntersectsWith(new Rectangle(myPage.Memos[i].Location, myPage.Memos[i].Size))) continue;
                myPage.Memos[i].Draw(e.Graphics);
            }
            
        }
    }
}
