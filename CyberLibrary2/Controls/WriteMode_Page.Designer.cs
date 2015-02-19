namespace CyberLibrary2
{
    partial class PageControl
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
            this.components = new System.ComponentModel.Container();
            this.vScroll = new System.Windows.Forms.HScrollBar();
            this.hScroll = new System.Windows.Forms.VScrollBar();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.배경색지정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScroll
            // 
            this.vScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.vScroll.LargeChange = 1;
            this.vScroll.Location = new System.Drawing.Point(0, 347);
            this.vScroll.Maximum = 0;
            this.vScroll.Name = "vScroll";
            this.vScroll.Size = new System.Drawing.Size(383, 17);
            this.vScroll.TabIndex = 0;
            this.vScroll.ValueChanged += new System.EventHandler(this.vScroll_ValueChanged);
            // 
            // hScroll
            // 
            this.hScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hScroll.LargeChange = 1;
            this.hScroll.Location = new System.Drawing.Point(366, 0);
            this.hScroll.Maximum = 0;
            this.hScroll.Name = "hScroll";
            this.hScroll.Size = new System.Drawing.Size(17, 347);
            this.hScroll.TabIndex = 1;
            this.hScroll.ValueChanged += new System.EventHandler(this.vScroll_ValueChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배경색지정ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(138, 26);
            // 
            // 배경색지정ToolStripMenuItem
            // 
            this.배경색지정ToolStripMenuItem.Name = "배경색지정ToolStripMenuItem";
            this.배경색지정ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.배경색지정ToolStripMenuItem.Text = "배경색 지정";
            this.배경색지정ToolStripMenuItem.Click += new System.EventHandler(this.배경색지정ToolStripMenuItem_Click);
            // 
            // PageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.hScroll);
            this.Controls.Add(this.vScroll);
            this.Name = "PageControl";
            this.Size = new System.Drawing.Size(383, 364);
            this.Load += new System.EventHandler(this.PageControl_Load);
            this.DoubleClick += new System.EventHandler(this.PageControl_DoubleClick);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PageControl_Paint);
            this.Click += new System.EventHandler(this.PageControl_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PageControl_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PageControl_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PageControl_MouseUp);
            this.SizeChanged += new System.EventHandler(this.PageControl_SizeChanged);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar vScroll;
        private System.Windows.Forms.VScrollBar hScroll;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem 배경색지정ToolStripMenuItem;
    }
}
