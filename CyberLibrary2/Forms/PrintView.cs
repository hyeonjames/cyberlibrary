using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace CyberLibrary2.Forms
{
    public partial class PrintView : Form
    {
        public PrintView(PrintDocument bok)
        {
            InitializeComponent();
            Printer.Document = bok;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Printer.Zoom *= 1.5;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Printer.Zoom /= 1.5;

        }
    }
}
