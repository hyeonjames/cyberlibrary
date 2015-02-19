namespace CyberLibrary2
{
    partial class Page_Read
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
            this.hScroll = new System.Windows.Forms.VScrollBar();
            this.vScroll = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // hScroll
            // 
            this.hScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hScroll.LargeChange = 1;
            this.hScroll.Location = new System.Drawing.Point(281, -1);
            this.hScroll.Maximum = 0;
            this.hScroll.Name = "hScroll";
            this.hScroll.Size = new System.Drawing.Size(17, 270);
            this.hScroll.TabIndex = 3;
            this.hScroll.ValueChanged += new System.EventHandler(this.hScroll_ValueChanged);
            // 
            // vScroll
            // 
            this.vScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vScroll.LargeChange = 1;
            this.vScroll.Location = new System.Drawing.Point(-1, 269);
            this.vScroll.Maximum = 0;
            this.vScroll.Name = "vScroll";
            this.vScroll.Size = new System.Drawing.Size(299, 17);
            this.vScroll.TabIndex = 2;
            this.vScroll.ValueChanged += new System.EventHandler(this.vScroll_ValueChanged);
            // 
            // Page_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.hScroll);
            this.Controls.Add(this.vScroll);
            this.Name = "Page_Read";
            this.Size = new System.Drawing.Size(298, 286);
            this.Load += new System.EventHandler(this.Page_Read_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Page_Read_Paint);
            this.Click += new System.EventHandler(this.Page_Read_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Page_Read_MouseMove);
            this.SizeChanged += new System.EventHandler(this.Page_Read_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar hScroll;
        private System.Windows.Forms.HScrollBar vScroll;
    }
}
