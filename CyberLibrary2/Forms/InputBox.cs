using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class InputBox : Form
    {
        public string Input;
        public InputBox(string Caption,string Message)
        {
            InitializeComponent();
            label1.Text = Message;
            this.Text = Caption;
            Input = "";
        }
        public static string InputString(string Caption, string Message,bool Password)
        {
            InputBox input = new InputBox(Caption, Message);
            if (Password)
                input.txtInput.PasswordChar = '●';
            if (input.ShowDialog() == DialogResult.OK)
                return input.Input;
            else
                return null;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            Input = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            Close();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();

        }

        private void InputBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
                DialogResult = DialogResult.Cancel;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }


        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                btOK.Enabled = false;
            }
            else
            {
                btOK.Enabled = true;
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Input = txtInput.Text;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }


    }
}
