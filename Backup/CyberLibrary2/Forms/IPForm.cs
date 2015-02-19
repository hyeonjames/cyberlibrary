using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class IPForm : Form
    {
        public string IP
        {
            get
            {
                return txtIP.Text;
            }
        }
        public int Port
        {
            get
            {
                return (int)NumbericPort.Value;
            }
        }
        public IPForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
