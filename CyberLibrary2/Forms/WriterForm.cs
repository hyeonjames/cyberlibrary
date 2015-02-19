using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class WriterForm : Form
    {
        public Book book;
        public BookEditor bookEditor1;
        public WriterForm()
        {
            InitializeComponent();
            this.bookEditor1 = new CyberLibrary2.BookEditor();
            this.bookEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bookEditor1.Location = new System.Drawing.Point(0, 0);
            this.bookEditor1.Name = "bookEditor1";
            this.bookEditor1.Size = new System.Drawing.Size(460, 314);
            this.bookEditor1.TabIndex = 3;
            this.Controls.Add(bookEditor1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "책 파일(*.bok)|*.bok";
            if (op.ShowDialog() == DialogResult.OK)
            {
                bookEditor1.LoadFile(op.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();
            op.Filter = "책 파일(*.bok)|*.bok";
            if (op.ShowDialog() == DialogResult.OK)
            {
                bookEditor1.SaveFile(op.FileName);
            }
        }

        private void WriterForm_Load(object sender, EventArgs e)
        {
            bookEditor1.Focus();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            bookEditor1.PageSet(bookEditor1.PageIndex);
            book = bookEditor1.mybook;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void WriterForm_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
