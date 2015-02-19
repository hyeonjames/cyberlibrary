using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class FindBookForm : Form
    {
        BookLibrary bLib;
        public string sPath;
        public FindBookForm(BookLibrary bLibrary)
        {
            InitializeComponent();
            bLib = bLibrary;
            Column_BookPath.Width = FindListView.Width - 187;
        }

        private void FindListView_SizeChanged(object sender, EventArgs e)
        {
            Column_BookPath.Width = FindListView.Width - 187;
        }
        public void FindBookName(string bText,string Path)
        {
            BookGroup bGroup = bLib.FindGroup(Path);
            foreach (Book bok in bGroup.books)
            {
                if (bok.BookName.IndexOf(bText) >= 0)
                {
                    AddBook(bok, "책이름", Path);
                }
            }
            foreach (BookGroup gop in bGroup.groups)
            {
                FindBookName(bText, Path + "\\" + gop.Name);
            }
        }
        public void FindWriterName(string bText, string Path)
        {
            BookGroup bGroup = bLib.FindGroup(Path);
            foreach (Book bok in bGroup.books)
            {
                if (bok.WriterName.IndexOf(bText) >= 0)
                {
                    AddBook(bok, "작가이름", Path);
                }
            }
            foreach (BookGroup gop in bGroup.groups)
            {
                FindWriterName(bText, Path + "\\" + gop.Name);
            }
        }
        public void FindTransferName(string bText, string Path)
        {
            BookGroup bGroup = bLib.FindGroup(Path);
            foreach (Book bok in bGroup.books)
            {
                if (bok.TransferName.IndexOf(bText) >= 0)
                {
                    AddBook(bok, "옮김이이름", Path);
                }
            }
            foreach (BookGroup gop in bGroup.groups)
            {
                FindTransferName(bText, Path + "\\" + gop.Name);
            }
        }
        public void FindGroupName(string bText, string Path)
        {
            BookGroup bGroup = bLib.FindGroup(Path);
            if (bGroup.Name.IndexOf(bText) >= 0)
            {
                foreach (Book bok in bGroup.books)
                {
                    AddBook(bok, "그룹이름", Path);
                }
            }
            foreach (BookGroup gop in bGroup.groups)
            {
                FindGroupName(bText, Path + "\\" + gop.Name);
            }
        }
        public void AddBook(Book bok,string Tail,string Path)
        {
            Book bk2;
            foreach (ListViewItem item in FindListView.Items)
            {
                bk2 = bLib.FindBook(item.SubItems[1].Text.Substring(1));
                if (bok == bk2)
                {
                    item.SubItems[2].Text += "+" + Tail;
                    return;
                }
            }
            FindListView.Items.Add(new ListViewItem(new string[]{bok.BookName,Path + "\\" +  bok.BookName,Tail}));
        }
        private void btScan_Click(object sender, EventArgs e)
        {
            if (txtScanText.Text == "") return;
            FindListView.Items.Clear();
            if (chkBookName.Checked)
                FindBookName(txtScanText.Text, "");
            if (chkWriterName.Checked)
                FindWriterName(txtScanText.Text, "");
            if (chkTransferName.Checked)
                FindTransferName(txtScanText.Text, "");
            if (chkGroupName.Checked)
                FindGroupName(txtScanText.Text, "");

        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            sPath = "";
            if (FindListView.SelectedIndices.Count > 0)
            {
                sPath = FindListView.SelectedItems[0].SubItems[1].Text; 
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtScanText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (txtScanText.Text == "") return;
                FindListView.Items.Clear();
                if (chkBookName.Checked)
                    FindBookName(txtScanText.Text, "");
                if (chkWriterName.Checked)
                    FindWriterName(txtScanText.Text, "");
                if (chkTransferName.Checked)
                    FindTransferName(txtScanText.Text, "");
                if (chkGroupName.Checked)
                    FindGroupName(txtScanText.Text, "");
            }
        }
    }
}
