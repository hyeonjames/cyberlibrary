using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using CyberLibrary2.Classes;
namespace CyberLibrary2.Forms
{
    public partial class NetworkUserAddForm : Form
    {
        public User User;
        public NetworkUserAddForm(User us,bool Password)
        {
            InitializeComponent();
            txtUserName.Text = us.ID;
            txtUserPW.Enabled = Password;
            NumbericPoint.Value = us.Point;
            User = us;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            User.ID = txtUserName.Text;
            if(txtUserPW.Enabled) User.PW = Component.MD5Encrypt(txtUserPW.Text);
            User.Point = (uint)NumbericPoint.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NetworkUserAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
