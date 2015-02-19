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
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
            
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (CheckAgree.Checked)
            {
                if (txtUseID.TextLength >= 4)
                {
                    if (txtUsePW.TextLength >= 8)
                    {
                        if (txtConfPW.Text == txtUsePW.Text)
                        {
                            Program.Client.Write(ClientPacketType.Client_Join, txtUseID.Text, txtUsePW.Text);
                        }
                        else
                        {
                            MessageBox.Show("패스워드 확인란이 패스워드와 일치하지 않습니다.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("패스워드는 8자리 이상이어야 합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("아이디는 4글자 이상이어야 합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("안내문에 대해 동의가 필요합니다", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JoinForm_Load(object sender, EventArgs e)
        {
            Program.Client.Write(ClientPacketType.Client_GetGuide);
        }

    }
}
