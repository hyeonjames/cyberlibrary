
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2
{

    public partial class BoardImage : BoardControl
    {
        public bool Lock;
        public Panel focusPanels;
        public Panel MainPanel;
        public Button btDispose;
        public PageControl myPage;
        public void Save()
        {
            myData.Location = this.Location;
            ((DImage)myData).img = img;
            myData.Size = this.Size;
        }
        public BoardImage(PageControl p)
        {
            InitializeComponent();
            myPage = p;
            mSave = new SaveFunc(Save);
            //myParent = p;
            //= new Panel(); MainPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            //this.SetBounds(0, 0, this.Width, this.Height);
            this.BorderStyle = BorderStyle.FixedSingle;
            
            this.Paint += MainPanel_Paint;
            this.Resize += MainPanel_Resize;
                this.MouseMove += fMouseMove;
                this.Cursor = Cursors.Hand;
                this.MouseUp += fMouseUp;
                this.MouseDown += fMouseDown;
                focusPanels = new Panel(); focusPanels.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; focusPanels.SetBounds(this.Width - 8, this.Height - 8, 8, 8); focusPanels.Cursor = Cursors.SizeNWSE;
                this.Controls.Add(focusPanels);
                focusPanels.BorderStyle = BorderStyle.FixedSingle;
                focusPanels.MouseDown += fMouseDown;
                focusPanels.MouseUp += fMouseUp;
                focusPanels.MouseMove += mvMouseMove;
                //MainPanel = new Panel(); MainPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                //MainPanel.SetBounds(0, 0, this.Width, this.Height);
                btDispose = new Button();
                btDispose.SetBounds(this.Width - 20, 0, 20, 20);
                btDispose.Text = "x";
                btDispose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btDispose.FlatStyle = FlatStyle.Flat;
                btDispose.BackColor = Color.Magenta;
                btDispose.Click += btDispose_Dispose;
                this.Controls.Add(btDispose);
            
        }
        public Image img;
        private void MainPanel_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (img != null) e.Graphics.DrawImage(img, 0, 0, this.Width, this.Height);
        }
        public void SetImage(Image simg)
        {
            img = simg;
        }
        

        private void btDispose_Dispose(object sender, EventArgs e)
        {
            myData.DisposeL();
            myPage.Controls.Remove(this);
            myPage.RefreshScroll();
            this.Dispose();

        }

        // 컨트롤 이동
        public Point BeforePoint;
        public bool fMove=false;
        public Timer tm;
        private void fMouseDown(object sender, MouseEventArgs e)
        {
            if (!fMove && !Lock)
            {
                fMove = true;
                BeforePoint = e.Location;
            }
        }

        private void fMouseMove(object sender, MouseEventArgs e)
        {
            if (fMove && !Lock)
            {
                this.SetBounds(this.Location.X + (e.X - BeforePoint.X),this.Location.Y +(e.Y-BeforePoint.Y),this.Width,this.Height);
                myPage.RefreshScroll();
            }
        }

        private void fMouseUp(object sender, MouseEventArgs e)
        {
            if (fMove)
            {
                fMove = false;
            }
        }
        
        private void mvMouseMove(object sender,MouseEventArgs e)
        {
            Point ef = this.PointToClient(Cursor.Position);
            if (fMove && !Lock)
            {
                this.SetBounds(this.Location.X, this.Location.Y, this.Width + (e.X - BeforePoint.X), this.Height + (e.Y - BeforePoint.Y));
                myPage.RefreshScroll();
            }
        }

        private void 고정하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lock = 고정하기ToolStripMenuItem.Checked;
            btDispose.Visible = focusPanels.Visible = !Lock;
        }

        private void 이미지변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();
            opDialog.Filter = "그림파일|*.bmp;*.png;*.jpg;*.gif";
            if (opDialog.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(opDialog.FileName);
            }
        }

        private void 자동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                this.SetBounds(this.Location.X, this.Location.Y, img.Width, img.Height);
                Lock = true;
                고정하기ToolStripMenuItem.Checked = Lock;

                btDispose.Visible = focusPanels.Visible = !Lock;
            }
        }

        private void 비율ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lock = false;
            고정하기ToolStripMenuItem.Checked = Lock;

            btDispose.Visible = focusPanels.Visible = !Lock;
        }
        public void Form_DClick(object sender, EventArgs e)
        {
            
        }
        
        private void 개체보호ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Save();
            myPage.Invalidate();
        }

        private void BoardImage_Load(object sender, EventArgs e)
        {

        }

        private void BoardImage_Resize(object sender, EventArgs e)
        {

        }
    }
}
