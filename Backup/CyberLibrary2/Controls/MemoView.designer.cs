namespace CyberLibrary2
{
    partial class MemoView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoView));
            this.PanelRightPlus = new System.Windows.Forms.Panel();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelRightBottom = new System.Windows.Forms.Panel();
            this.MemoBar = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MemoText = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MemoBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelRightPlus
            // 
            this.PanelRightPlus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRightPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelRightPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRightPlus.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.PanelRightPlus.Location = new System.Drawing.Point(213, 17);
            this.PanelRightPlus.Name = "PanelRightPlus";
            this.PanelRightPlus.Size = new System.Drawing.Size(8, 136);
            this.PanelRightPlus.TabIndex = 0;
            this.PanelRightPlus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelRightPlus_MouseMove);
            this.PanelRightPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelRightPlus_MouseDown);
            this.PanelRightPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelRightPlus_MouseUp);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PanelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.PanelBottom.Location = new System.Drawing.Point(0, 152);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(213, 8);
            this.PanelBottom.TabIndex = 1;
            this.PanelBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBottom_MouseMove);
            this.PanelBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBottom_MouseDown);
            this.PanelBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelBottom_MouseUp);
            // 
            // PanelRightBottom
            // 
            this.PanelRightBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRightBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRightBottom.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.PanelRightBottom.Location = new System.Drawing.Point(213, 152);
            this.PanelRightBottom.Name = "PanelRightBottom";
            this.PanelRightBottom.Size = new System.Drawing.Size(8, 8);
            this.PanelRightBottom.TabIndex = 2;
            this.PanelRightBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelRightBottom_MouseMove);
            this.PanelRightBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelRightBottom_MouseDown);
            this.PanelRightBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelRightBottom_MouseUp);
            // 
            // MemoBar
            // 
            this.MemoBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemoBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoBar.Controls.Add(this.pictureBox1);
            this.MemoBar.Controls.Add(this.TitleLabel);
            this.MemoBar.Location = new System.Drawing.Point(0, 0);
            this.MemoBar.Name = "MemoBar";
            this.MemoBar.Size = new System.Drawing.Size(222, 20);
            this.MemoBar.TabIndex = 3;
            this.MemoBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MemoBar_MouseMove);
            this.MemoBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MemoBar_MouseDown);
            this.MemoBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MemoBar_MouseUp);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(18, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(69, 12);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "메모 타이틀";
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MemoBar_MouseMove);
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MemoBar_MouseDown);
            this.TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MemoBar_MouseUp);
            // 
            // MemoText
            // 
            this.MemoText.AutoSize = true;
            this.MemoText.Location = new System.Drawing.Point(3, 23);
            this.MemoText.Name = "MemoText";
            this.MemoText.Size = new System.Drawing.Size(29, 12);
            this.MemoText.TabIndex = 4;
            this.MemoText.Text = "메모";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Location = new System.Drawing.Point(195, 19);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(19, 23);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MemoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.MemoText);
            this.Controls.Add(this.MemoBar);
            this.Controls.Add(this.PanelRightBottom);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelRightPlus);
            this.Name = "MemoView";
            this.Size = new System.Drawing.Size(221, 160);
            this.MemoBar.ResumeLayout(false);
            this.MemoBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelRightPlus;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelRightBottom;
        private System.Windows.Forms.Panel MemoBar;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MemoText;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
