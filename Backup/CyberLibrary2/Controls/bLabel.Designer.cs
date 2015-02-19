namespace CyberLibrary2
{
    partial class bLabel
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
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.배경색변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폰트변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고정하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배경색변경ToolStripMenuItem,
            this.폰트변경ToolStripMenuItem,
            this.고정하기ToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(138, 70);
            // 
            // 배경색변경ToolStripMenuItem
            // 
            this.배경색변경ToolStripMenuItem.Name = "배경색변경ToolStripMenuItem";
            this.배경색변경ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.배경색변경ToolStripMenuItem.Text = "배경색 변경";
            this.배경색변경ToolStripMenuItem.Click += new System.EventHandler(this.배경색변경ToolStripMenuItem_Click);
            // 
            // 폰트변경ToolStripMenuItem
            // 
            this.폰트변경ToolStripMenuItem.Name = "폰트변경ToolStripMenuItem";
            this.폰트변경ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.폰트변경ToolStripMenuItem.Text = "폰트 변경";
            this.폰트변경ToolStripMenuItem.Click += new System.EventHandler(this.폰트변경ToolStripMenuItem_Click);
            // 
            // 고정하기ToolStripMenuItem
            // 
            this.고정하기ToolStripMenuItem.CheckOnClick = true;
            this.고정하기ToolStripMenuItem.Name = "고정하기ToolStripMenuItem";
            this.고정하기ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.고정하기ToolStripMenuItem.Text = "고정";
            this.고정하기ToolStripMenuItem.Click += new System.EventHandler(this.고정하기ToolStripMenuItem_Click);
            // 
            // bLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "bLabel";
            this.Size = new System.Drawing.Size(372, 291);
            this.Load += new System.EventHandler(this.bLabel_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.bLabel_PreviewKeyDown);
            this.Click += new System.EventHandler(this.bLabel_Click);
            this.Resize += new System.EventHandler(this.bLabel_Resize);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bLabel_KeyDown);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem 배경색변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폰트변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고정하기ToolStripMenuItem;


    }
}
