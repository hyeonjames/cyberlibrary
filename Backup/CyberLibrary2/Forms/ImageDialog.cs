using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2.Forms
{
    public partial class ImageDialog : Form
    {
        public Image img;
        public bool ok = false;
        public ImageDialog(Image _img)
        {
            InitializeComponent();
            img = _img;
            ImagePanel.BackgroundImage = img;
            RefreshSize();
        }
        private void RefreshSize()
        {
            if (img != null)
            {
                this.SetBounds(this.Location.X, this.Location.Y, (int)Math.Max(img.Width + 32, 186), (int)Math.Max(img.Height + 86, 154));
                pictureBox1.SetBounds(ImagePanel.Width / 2 - pictureBox1.Width / 2, ImagePanel.Height / 2 - pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Image img2;
            OpenFileDialog opDialog;
            opDialog = new OpenFileDialog();
            opDialog.Filter = "이미지파일|*.jpg;*.gif;*.bmp;*.png|모든파일|*.*";
            if (opDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img2 = Image.FromFile(opDialog.FileName);
                    if (img2 == null)
                    {
                        MessageBox.Show("파일 이상.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    img = img2;
                    pictureBox1.Image = img;
                    RefreshSize();
                }
                catch (Exception)
                {
                    MessageBox.Show("불러들이는중 에러가 발생했습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ok = true;
            Close();
        }
    }
}
