namespace CyberLibrary2
{
    public partial class BoardImage
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
            this.ImageSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.이미지변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사이즈타입ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비율ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고정하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.개체보호ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageSetting
            // 
            this.ImageSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이미지변경ToolStripMenuItem,
            this.사이즈타입ToolStripMenuItem,
            this.고정하기ToolStripMenuItem,
            this.개체보호ToolStripMenuItem});
            this.ImageSetting.Name = "ImageSetting";
            this.ImageSetting.Size = new System.Drawing.Size(138, 92);
            // 
            // 이미지변경ToolStripMenuItem
            // 
            this.이미지변경ToolStripMenuItem.Name = "이미지변경ToolStripMenuItem";
            this.이미지변경ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.이미지변경ToolStripMenuItem.Text = "이미지 변경";
            this.이미지변경ToolStripMenuItem.Click += new System.EventHandler(this.이미지변경ToolStripMenuItem_Click);
            // 
            // 사이즈타입ToolStripMenuItem
            // 
            this.사이즈타입ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동ToolStripMenuItem,
            this.비율ToolStripMenuItem});
            this.사이즈타입ToolStripMenuItem.Name = "사이즈타입ToolStripMenuItem";
            this.사이즈타입ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.사이즈타입ToolStripMenuItem.Text = "사이즈 타입";
            // 
            // 자동ToolStripMenuItem
            // 
            this.자동ToolStripMenuItem.Name = "자동ToolStripMenuItem";
            this.자동ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.자동ToolStripMenuItem.Text = "자동";
            this.자동ToolStripMenuItem.Click += new System.EventHandler(this.자동ToolStripMenuItem_Click);
            // 
            // 비율ToolStripMenuItem
            // 
            this.비율ToolStripMenuItem.Name = "비율ToolStripMenuItem";
            this.비율ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.비율ToolStripMenuItem.Text = "비율";
            this.비율ToolStripMenuItem.Click += new System.EventHandler(this.비율ToolStripMenuItem_Click);
            // 
            // 고정하기ToolStripMenuItem
            // 
            this.고정하기ToolStripMenuItem.CheckOnClick = true;
            this.고정하기ToolStripMenuItem.Name = "고정하기ToolStripMenuItem";
            this.고정하기ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.고정하기ToolStripMenuItem.Text = "고정";
            this.고정하기ToolStripMenuItem.Click += new System.EventHandler(this.고정하기ToolStripMenuItem_Click);
            // 
            // 개체보호ToolStripMenuItem
            // 
            this.개체보호ToolStripMenuItem.Name = "개체보호ToolStripMenuItem";
            this.개체보호ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.개체보호ToolStripMenuItem.Text = "개체 보호";
            this.개체보호ToolStripMenuItem.Click += new System.EventHandler(this.개체보호ToolStripMenuItem_Click);
            // 
            // BoardImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.ImageSetting;
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "BoardImage";
            this.Size = new System.Drawing.Size(227, 245);
            this.Load += new System.EventHandler(this.BoardImage_Load);
            this.Resize += new System.EventHandler(this.BoardImage_Resize);
            this.ImageSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ImageSetting;
        private System.Windows.Forms.ToolStripMenuItem 이미지변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사이즈타입ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비율ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고정하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 개체보호ToolStripMenuItem;


    }
}
