namespace CyberLibrary2
{
    partial class CommentBoard
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
            this.CommentView = new System.Windows.Forms.ListView();
            this.ColumnContext = new System.Windows.Forms.ColumnHeader();
            this.ColumnNick = new System.Windows.Forms.ColumnHeader();
            this.ColumnWrite = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // CommentView
            // 
            this.CommentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnContext,
            this.ColumnNick,
            this.ColumnWrite});
            this.CommentView.Location = new System.Drawing.Point(0, 0);
            this.CommentView.Name = "CommentView";
            this.CommentView.Size = new System.Drawing.Size(540, 167);
            this.CommentView.TabIndex = 0;
            this.CommentView.UseCompatibleStateImageBehavior = false;
            this.CommentView.View = System.Windows.Forms.View.Details;
            this.CommentView.Resize += new System.EventHandler(this.CommentView_Resize);
            this.CommentView.SelectedIndexChanged += new System.EventHandler(this.CommentView_SelectedIndexChanged);
            // 
            // ColumnContext
            // 
            this.ColumnContext.DisplayIndex = 1;
            this.ColumnContext.Text = "내용";
            this.ColumnContext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnContext.Width = 385;
            // 
            // ColumnNick
            // 
            this.ColumnNick.DisplayIndex = 0;
            this.ColumnNick.Text = "닉네임";
            this.ColumnNick.Width = 73;
            // 
            // ColumnWrite
            // 
            this.ColumnWrite.Text = "쓴 시간";
            this.ColumnWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnWrite.Width = 76;
            // 
            // CommentBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.CommentView);
            this.Name = "CommentBoard";
            this.Size = new System.Drawing.Size(539, 166);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader ColumnNick;
        private System.Windows.Forms.ColumnHeader ColumnContext;
        private System.Windows.Forms.ColumnHeader ColumnWrite;
        public System.Windows.Forms.ListView CommentView;

    }
}
