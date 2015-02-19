using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace CyberLibrary2
{
    public partial class MemoDialog : Form
    {
        public bool ok;
        MemoView mview;
        public DMemo memo;
        public MemoDialog()
        {
            InitializeComponent();
            ok = false;
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            FDialog.Font = txtContext.Font;
            FDialog.Color = txtContext.ForeColor;
            if (FDialog.ShowDialog() == DialogResult.OK)
            {
                txtContext.Font = FDialog.Font;
                txtContext.ForeColor = FDialog.Color;
            }
        }

        private void FDialog_Apply(object sender, EventArgs e)
        {

        }

        private void btTest_Click(object sender, EventArgs e)
        {
            DMemo m;
            m = new DMemo();
            m.FColor = txtContext.ForeColor;
            m.Font = txtContext.Font;
            m.Context = txtContext.Text;
            m.Name = txtTitle.Text;
            m.BColor = txtContext.BackColor;
            if (mview != null)
                this.Controls.Remove(mview);
            mview = new MemoView(m);
            Point nPoint = this.PointToClient(Cursor.Position);
            mview.SetBounds(nPoint.X, nPoint.Y, 100, 100);
            
            this.Controls.Add(mview);
            this.Controls.SetChildIndex(mview, 0);
        }

        private void btOK_Click(object sender, EventArgs e)
        {

            ok = true;
            memo = new DMemo();
            memo.FColor = txtContext.ForeColor;
            memo.Font = txtContext.Font;
            memo.Context = txtContext.Text;
            memo.Name = txtTitle.Text;
            memo.BColor = txtContext.BackColor;
            
            Close();
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            CDialog.Color = txtContext.BackColor;
            if (CDialog.ShowDialog() == DialogResult.OK)
            {
                txtContext.BackColor = CDialog.Color;
            }
        }

        private void txtContext_TextChanged(object sender, EventArgs e)
        {

        }

        private void MemoDialog_Load(object sender, EventArgs e)
        {

        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
