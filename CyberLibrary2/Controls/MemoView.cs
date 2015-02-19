using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2
{
    public partial class MemoView : UserControl
    {
        bool Drop=false,PlusWd,PlusNS,PlusHG;
        public DMemo mymemo;
        Point DropPoint;
        public MemoView()
        {
            InitializeComponent();
        }
        public MemoView(DMemo m)
        {
            Color c;
            mymemo = m;
            InitializeComponent();
            
            this.BackColor = m.GetBackColor();
            MemoText.ForeColor = m.GetFontColor();
            TitleLabel.Text = m.Name;
            MemoText.Text = m.Context;
            MemoText.Font = m.GetFont();
            c = Color.FromArgb(this.BackColor.R + 5 & 0xFF, this.BackColor.G + 3 & 0xFF, this.BackColor.B + 1 & 0xFF);
            SetOutSide(c);
        }
        public void SetOutSide(Color c)
        {
            btExit.BackColor = PanelBottom.BackColor = MemoBar.BackColor = PanelRightPlus.BackColor = c;
        }
        private void MemoBar_MouseDown(object sender, MouseEventArgs e)
        {
            DropPoint = e.Location;
            Drop = true;
        }

        private void MemoBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drop)
            {
                this.SetBounds(this.Location.X + (e.Location.X - DropPoint.X), this.Location.Y + (e.Location.Y - DropPoint.Y), this.Width, this.Height);
            }
        }

        private void MemoBar_MouseUp(object sender, MouseEventArgs e)
        {
            Drop = false;
        }

        private void PanelRightPlus_MouseMove(object sender, MouseEventArgs e)
        {
            if (PlusWd)
            {
                this.SetBounds(this.Location.X, this.Location.Y, (e.Location.X - DropPoint.X) + this.Width,this.Height);
            }
        }

        private void PanelRightPlus_MouseUp(object sender, MouseEventArgs e)
        {
            PlusWd = false;
        }

        
        private void PanelRightPlus_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Drop && !PlusHG && !PlusNS)
            {
                DropPoint = e.Location;
                PlusWd = true;

            }
        }


        private void PanelBottom_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Drop && !PlusWd && !PlusNS)
            {
                DropPoint = e.Location;
                PlusHG = true;

            }
        }

        private void PanelBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (PlusHG)
            {
                this.SetBounds(this.Location.X, this.Location.Y, this.Width, (e.Location.Y - DropPoint.Y) + this.Height);
            }
        }

        private void PanelBottom_MouseUp(object sender, MouseEventArgs e)
        {
            PlusHG = false;
        }

        private void PanelRightBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (PlusNS)
            {
                this.SetBounds(this.Location.X, this.Location.Y, (e.Location.X - DropPoint.X) + this.Width, (e.Location.Y - DropPoint.Y) + this.Height);
            }
        }

        private void PanelRightBottom_MouseUp(object sender, MouseEventArgs e)
        {
            PlusNS = false;
        }

        private void PanelRightBottom_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Drop && !PlusWd && !PlusHG)
            {
                DropPoint = e.Location;
                PlusNS = true;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
