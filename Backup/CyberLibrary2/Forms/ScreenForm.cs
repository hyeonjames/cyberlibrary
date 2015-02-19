using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class ScreenForm : Form
    {
        public ScreenForm(Book b)
        {
            InitializeComponent();
            BookReader.SetBook(b);
        }

        private void BookReader_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
