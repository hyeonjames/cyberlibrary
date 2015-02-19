using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Reflection;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    partial class AboutBook : Form
    {
        public AboutBook(Book bok)
        {
            InitializeComponent();
            labelProductName.Text += " : " + bok.BookName;
            labelWriter.Text += " : " + bok.WriterName;
            labelTransfer.Text += " : " + bok.TransferName;
            textBoxDescription.Text = bok.BookExplain;
        }


    }
}
