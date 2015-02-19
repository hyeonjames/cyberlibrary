using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using CyberLibrary2.Classes;
namespace CyberLibrary2.Controls
{
    public partial class Book_Read : UserControl
    {
        public Book myBook;
        MemoView mview;
        public int PageIndex;
        public Book_Read()
        {
            InitializeComponent();
            myBook = new Book();
            DMemo dmemo = new DMemo();
            dmemo.Font = labelDescription.Font;
            dmemo.FColor = labelDescription.ForeColor;
            dmemo.BColor = Color.Orange;
            dmemo.Name = "페이지 설명";
            dmemo.Context = labelDescription.Text;
            mview = new MemoView(dmemo);
            mview.Hide();
            this.Controls.Add(mview);
            
            this.Controls.SetChildIndex(mview, 0);
        }
        
        public Book_Read(Book bok)
        {
            InitializeComponent();
            myBook = bok;
            PageSet(1);
        }
        public void PageSet(int index)
        {
            Page p = myBook.TreeToPage(myBook.MainGroup, index);
            if (p != null)
            {
                PageRead.PageLoad(p);
                PageIndex = index;
                label1.Text = "Page " + PageIndex.ToString() + "/" + myBook.PageCount.ToString() + " " + p.Name;
                mview.mymemo.Context = p.Explain;
                labelDescription.Text = p.Explain;
            }
        }
        public void LoadFile(string FileName)
        {
            System.IO.FileStream fstream = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            myBook = (Book)Component.LoadClass(fstream);
            fstream.Close();
            PageSet(1);
        }
        public void SetBook(Book b)
        {
            myBook = b;
            myBook.MainGroup.RefreshAllPage();
            PageSet(1);
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {
            Point mPoint = this.PointToClient(Cursor.Position);
            DMemo dmemo = new DMemo();
            dmemo.Font = labelDescription.Font;
            dmemo.FColor = labelDescription.ForeColor;
            dmemo.BColor = Color.Orange;
            dmemo.Name = "페이지 설명";
            dmemo.Context = labelDescription.Text;
            mview = new MemoView(dmemo);
            mview.SetBounds(mPoint.X, mPoint.Y, 100, 100);
            mview.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            PageSet(PageIndex - 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Forms.AboutBook about = new CyberLibrary2.Forms.AboutBook(myBook);
            about.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            PageSet(PageIndex + 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Forms.HasteForm hform = new CyberLibrary2.Forms.HasteForm(myBook, PageRead.myPage.Name);
            if (hform.ShowDialog() == DialogResult.OK)
            {
                Page p = myBook.FindPage(hform.name);
                PageSet(p.PageIndex);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Forms.ScreenForm shForm = new CyberLibrary2.Forms.ScreenForm(myBook);
            shForm.ShowDialog();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            
                Forms.PrintForm printForm = new CyberLibrary2.Forms.PrintForm(PageRead.myPage);
                printForm.ShowDialog();
            
        }
        private void HotKeyDown(object sender, KeyEventArgs e)
        {
            if (!this.Visible) return;
            if (ProgramSettings.GetSKey("PrevPage").CheckKeyEvent(e))
            {
                PageSet(PageIndex-1);
            }
            if (ProgramSettings.GetSKey("NextPage").CheckKeyEvent(e))
            {
                PageSet(PageIndex+1);
            }
            if (ProgramSettings.GetSKey("FullMode").CheckKeyEvent(e))
            {
                pictureBox5_Click(sender, null);
            }
            if (ProgramSettings.GetSKey("Haste").CheckKeyEvent(e))
            {
                pictureBox3_Click(sender, null);
            }
        }
        private void Book_Read_Load(object sender, EventArgs e)
        {
            this.FindForm().KeyDown += HotKeyDown;
        }
    }
}
