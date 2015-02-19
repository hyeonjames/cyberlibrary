using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
namespace CyberLibrary2.Forms
{
    partial class CyberLibraryInformation : Form
    {
        public CyberLibraryInformation()
        {
            InitializeComponent();
        }
        private void CyberLibraryInformation_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.01;
            if (this.Opacity == 1)
            {
                Timer.Enabled = false;
                Thread.Sleep(2500);
                Close();
            }
        }

       
    }
}
