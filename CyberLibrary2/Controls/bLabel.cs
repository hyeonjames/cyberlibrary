using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2
{
    public partial class bLabel : BoardControl
    {
        public bool Lock=false;
        public RichTextBox writeMode;
        public List<PointFC> Labels;
        public List<float> LineCut;
        PageControl Page;
        public Panel focusPanels;
        public Panel MainPanel;
        public Button btDispose;
        //public MiniFontDialog mfdialog;
        public bLabel()
        {
        }
        public void Save()
        {
            myData.Location = this.Location;
            myData.Size = this.Size;
            ((DText)myData).Points = Labels;
            ((DText)myData).Linecut = LineCut;
            ((DText)myData).Context = writeMode.Text;
        }
        public bLabel(PageControl myPage)
        {

            InitializeComponent();
            this.mSave = new SaveFunc(Save);
            Page = myPage;
            Labels = new List<PointFC>();
            LineCut = new List<float>();
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
            writeMode = new RichTextBox();
            writeMode.SetBounds(0,0, this.Width, this.Height);
            writeMode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            //writeMode.Hide();
            writeMode.WordWrap = false;
            writeMode.KeyDown += bLabel_KeyDown;
            writeMode.MouseMove += fMouseMove;
            writeMode.Cursor = Cursors.Hand;
            writeMode.MouseUp += fMouseUp;
            writeMode.MouseDown += fMouseDown;
            writeMode.ContextMenuStrip = Menu;
            this.Controls.Add(btDispose);
            
            this.Controls.Add(writeMode);
            
            //SetBounds(nPoint.X, nPoint.Y - this.Height - 3, this.Width, this.Height);

        }
        
        private void bLabel_Load(object sender, EventArgs e)
        {
            Mode_Write();

            //writeMode.Show();
        }
        public void LoadText(DText dtxt)
        {
            Labels = new List<PointFC>(dtxt.Points);
            this.SetBounds(dtxt.Location.X, dtxt.Location.Y, dtxt.Size.Width, dtxt.Size.Height);
            writeMode.Text += dtxt.Context;
            foreach (PointFC at in dtxt.Points)
            {
                if (at.Length > 0)
                {
                    writeMode.Select(at.start, at.Length);
                    writeMode.SelectionBackColor = at.bcolor;
                    writeMode.SelectionColor = at.color;
                    writeMode.SelectionFont = at.font;
                    
                }
            }
            writeMode.SelectionLength = 0;
            writeMode.SelectionStart = writeMode.TextLength;
            
        }
        
        public void Mode_Read()
        {
            PointFC pfc = new PointFC();
            int i = 0, j, k;
            float maxsize;
            LineCut.Clear();
            Labels.Clear();
            this.Hide();
            
            for (i = 0; i < writeMode.Lines.Length; i++)
            {
                k = writeMode.GetFirstCharIndexFromLine(i);
                maxsize = 0;
                //maxsize = pfc.font.Size;
                for (j = 0; j < writeMode.Lines[i].Length; j++)
                {
                    writeMode.SelectionStart = k;
                    writeMode.SelectionLength = 1;
                    if (!writeMode.SelectionBackColor.Equals(pfc.bcolor) || !writeMode.SelectionFont.Equals(pfc.font) || !writeMode.SelectionColor.Equals(pfc.color))
                    {
                        Labels.Add(pfc);
                        pfc = new PointFC();
                        pfc.start = k;
                        pfc.bcolor = writeMode.SelectionBackColor;
                        if (pfc.bcolor == writeMode.BackColor)
                            pfc.bcolor = Color.Empty;
                        pfc.color = writeMode.SelectionColor;
                        pfc.font = writeMode.SelectionFont;
                        pfc.Line = i;
                        pfc.Length = 1;
                        pfc.StringPlace = writeMode.GetPositionFromCharIndex(k);
                        
                    }
                    else
                    {
                        pfc.Length++;
                        pfc.BackColorPlace = writeMode.GetPositionFromCharIndex(k+1).X - writeMode.GetPositionFromCharIndex(k-pfc.Length+1).X;
                    }
                    k++;
                    maxsize = (float)Math.Max((double)pfc.font.Size, (double)maxsize);
                }
                if (pfc.BackColorPlace == 0)
                {
                    //pfc.Length++;
                    pfc.BackColorPlace = writeMode.GetPositionFromCharIndex(k + 1).X - writeMode.GetPositionFromCharIndex(k - pfc.Length + 1).X;
                    
                }
                if(pfc.font != null) Labels.Add(pfc);
                LineCut.Add(maxsize);
                pfc = new PointFC();
            }
            Save();
            writeMode.SelectionStart = 0;
            writeMode.SelectionLength = 0;
        }
        public void Mode_Write()
        {
            this.Show();
        }

        private void bLabel_Click(object sender, EventArgs e)
        {
            Mode_Write();
        }

        private void bLabel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Mode_Read();
        }


        private void bLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Mode_Read();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (writeMode.SelectionFont.Bold)
            {
                writeMode.SelectionFont = new Font(writeMode.SelectionFont, writeMode.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {

                writeMode.SelectionFont = new Font(writeMode.SelectionFont, writeMode.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (writeMode.SelectionFont.Italic)
            {
                writeMode.SelectionFont = new Font(writeMode.SelectionFont, writeMode.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {

                writeMode.SelectionFont = new Font(writeMode.SelectionFont, writeMode.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (writeMode.SelectionFont.Strikeout)
            {
                writeMode.SelectionFont = new Font(writeMode.SelectionFont, writeMode.SelectionFont.Style & ~FontStyle.Strikeout);
            }
            else
            {

                writeMode.SelectionFont = new Font(writeMode.SelectionFont, writeMode.SelectionFont.Style | FontStyle.Strikeout);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (writeMode.SelectionFont.Underline)
            {
                writeMode.SelectionFont = new Font(writeMode.SelectionFont, writeMode.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {

                writeMode.SelectionFont = new Font(writeMode.SelectionFont, writeMode.SelectionFont.Style | FontStyle.Underline);
            }
        }
        private void btDispose_Dispose(object sender, EventArgs e)
        {
            myData.DisposeL();
            Page.Controls.Remove(this);
            Page.RefreshScroll();
            this.Dispose();
        }
        // 컨트롤 이동
        public Point BeforePoint;
        public bool fMove = false;
        public Timer tm;
        private void fMouseDown(object sender, MouseEventArgs e)
        {
            if (Lock) return;

            if (!fMove)
            {
                fMove = true;
                BeforePoint = e.Location;
            }
        }

        private void fMouseMove(object sender, MouseEventArgs e)
        {
            if (Lock) return;
            if (fMove)
            {
                
                this.SetBounds(this.Location.X + (e.X - BeforePoint.X), this.Location.Y + (e.Y - BeforePoint.Y), this.Width, this.Height);
                //BeforePoint = e.Location;
                Page.RefreshScroll();
            }
        }

        private void fMouseUp(object sender, MouseEventArgs e)
        {
            if (fMove )
            {
                fMove = false;
            }
        }

        private void mvMouseMove(object sender, MouseEventArgs e)
        {
            Point ef = this.PointToClient(Cursor.Position);
            if (Lock) return;
            if (fMove )
            {
                this.SetBounds(this.Location.X, this.Location.Y, this.Width + (e.X - BeforePoint.X), this.Height + (e.Y - BeforePoint.Y));
                Page.RefreshScroll();
            }
        }

        private void 배경색변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (writeMode.SelectionColor != null)
            {
                cDialog.Color = writeMode.SelectionBackColor;
                if (cDialog.ShowDialog() == DialogResult.OK)
                {
                    writeMode.SelectionBackColor = cDialog.Color;
                }
            }
        }

        private void 폰트변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fDialog = new FontDialog();
            if (writeMode.SelectionColor != null)
            {
                fDialog.Font = writeMode.SelectionFont;
                fDialog.Color = writeMode.SelectionColor;
                if (fDialog.ShowDialog() == DialogResult.OK)
                {
                    writeMode.SelectionColor = fDialog.Color;
                    writeMode.SelectionFont = fDialog.Font;
                }
            }
        }

        private void 고정하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lock = 고정하기ToolStripMenuItem.Checked;
            btDispose.Visible = focusPanels.Visible = !Lock;
        }

        private void bLabel_Resize(object sender, EventArgs e)
        {

        }


    }
    [Serializable]
    public struct PointFC
    {
        public int start,Length,Line,BackColorPlace;
        public Point StringPlace;
        public Color color,bcolor;
        public Font font;
    }
}
