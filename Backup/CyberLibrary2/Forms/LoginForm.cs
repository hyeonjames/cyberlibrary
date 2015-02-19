using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtID.TextLength < 4)
            {
                MessageBox.Show("아이디는 4글자 이상으로 해주세요", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return;
            }
            else if (txtPW.TextLength < 8)
            {
                MessageBox.Show("비밀빈호는 8글자 이상으로 해주세요", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPW.Focus();
                return;
            }
            Program.Client.Write(CyberLibrary2.Classes.ClientPacketType.Client_Login, txtID.Text, Component.MD5Encrypt(txtPW.Text));
            
        }

        private void btJoin_Click(object sender, EventArgs e)
        {
            Program.joinForm.ShowDialog();
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.libForm.Visible)
            {
                Program.Client.Logout();
            }
        }
    }
}
