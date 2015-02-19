namespace CyberLibrary2
{
    partial class LibraryForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.BookTree = new System.Windows.Forms.TreeView();
            this.TreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.북추가AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.북수정RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그룹추가GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeImageList = new System.Windows.Forms.ImageList(this.components);
            this.txtContext = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLibraryNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.라이브러리저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.네트워크TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.접속PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.라이브러리설정SEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SVDialog = new System.Windows.Forms.SaveFileDialog();
            this.OEDialog = new System.Windows.Forms.OpenFileDialog();
            this.Scanbt = new System.Windows.Forms.PictureBox();
            this.btCommentDel = new System.Windows.Forms.PictureBox();
            this.btCommentAdd = new System.Windows.Forms.PictureBox();
            this.CommentBoard = new CyberLibrary2.CommentBoard();
            this.TreeMenu.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scanbt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCommentDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCommentAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // BookTree
            // 
            this.BookTree.AllowDrop = true;
            this.BookTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.BookTree.ContextMenuStrip = this.TreeMenu;
            this.BookTree.ImageIndex = 0;
            this.BookTree.ImageList = this.TreeImageList;
            this.BookTree.LabelEdit = true;
            this.BookTree.LineColor = System.Drawing.Color.Maroon;
            this.BookTree.Location = new System.Drawing.Point(11, 27);
            this.BookTree.Name = "BookTree";
            this.BookTree.SelectedImageIndex = 0;
            this.BookTree.Size = new System.Drawing.Size(149, 266);
            this.BookTree.TabIndex = 0;
            this.BookTree.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.BookTree_BeforeLabelEdit);
            this.BookTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.BookTree_AfterLabelEdit);
            this.BookTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BookTree_AfterSelect);
            this.BookTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.BookTree_DragDrop);
            this.BookTree.DragOver += new System.Windows.Forms.DragEventHandler(this.BookTree_DragOver);
            this.BookTree.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.BookTree_QueryContinueDrag);
            this.BookTree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookTree_KeyPress);
            this.BookTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookTree_MouseDown);
            this.BookTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookTree_MouseUp);
            // 
            // TreeMenu
            // 
            this.TreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.북추가AToolStripMenuItem,
            this.북수정RToolStripMenuItem,
            this.그룹추가GToolStripMenuItem,
            this.삭제XToolStripMenuItem});
            this.TreeMenu.Name = "TreeMenu";
            this.TreeMenu.Size = new System.Drawing.Size(143, 92);
            // 
            // 북추가AToolStripMenuItem
            // 
            this.북추가AToolStripMenuItem.Name = "북추가AToolStripMenuItem";
            this.북추가AToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.북추가AToolStripMenuItem.Text = "북 추가(&A)";
            this.북추가AToolStripMenuItem.Click += new System.EventHandler(this.북추가AToolStripMenuItem_Click);
            // 
            // 북수정RToolStripMenuItem
            // 
            this.북수정RToolStripMenuItem.Name = "북수정RToolStripMenuItem";
            this.북수정RToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.북수정RToolStripMenuItem.Text = "북 수정(&R)";
            this.북수정RToolStripMenuItem.Click += new System.EventHandler(this.북수정RToolStripMenuItem_Click);
            // 
            // 그룹추가GToolStripMenuItem
            // 
            this.그룹추가GToolStripMenuItem.Name = "그룹추가GToolStripMenuItem";
            this.그룹추가GToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.그룹추가GToolStripMenuItem.Text = "그룹 추가(&G)";
            this.그룹추가GToolStripMenuItem.Click += new System.EventHandler(this.그룹추가GToolStripMenuItem_Click);
            // 
            // 삭제XToolStripMenuItem
            // 
            this.삭제XToolStripMenuItem.Name = "삭제XToolStripMenuItem";
            this.삭제XToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.삭제XToolStripMenuItem.Text = "삭제(&X)";
            this.삭제XToolStripMenuItem.Click += new System.EventHandler(this.삭제XToolStripMenuItem_Click);
            // 
            // TreeImageList
            // 
            this.TreeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImageList.ImageStream")));
            this.TreeImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.TreeImageList.Images.SetKeyName(0, "Tool Folder.bmp");
            this.TreeImageList.Images.SetKeyName(1, "download1.bmp");
            // 
            // txtContext
            // 
            this.txtContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContext.Location = new System.Drawing.Point(86, 445);
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(378, 21);
            this.txtContext.TabIndex = 13;
            this.txtContext.TextChanged += new System.EventHandler(this.txtContext_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.Location = new System.Drawing.Point(11, 445);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(69, 21);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.설정ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(544, 24);
            this.MainMenu.TabIndex = 17;
            this.MainMenu.Text = "menuStrip1";
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLibraryNToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.라이브러리저장SToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileFToolStripMenuItem.Text = "파일(&F)";
            this.fileFToolStripMenuItem.Click += new System.EventHandler(this.fileFToolStripMenuItem_Click);
            // 
            // newLibraryNToolStripMenuItem
            // 
            this.newLibraryNToolStripMenuItem.Name = "newLibraryNToolStripMenuItem";
            this.newLibraryNToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newLibraryNToolStripMenuItem.Text = "새 라이브러리(&N)";
            this.newLibraryNToolStripMenuItem.Click += new System.EventHandler(this.newLibraryNToolStripMenuItem_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.열기OToolStripMenuItem.Text = "라이브러리 열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 라이브러리저장SToolStripMenuItem
            // 
            this.라이브러리저장SToolStripMenuItem.Name = "라이브러리저장SToolStripMenuItem";
            this.라이브러리저장SToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.라이브러리저장SToolStripMenuItem.Text = "라이브러리 저장(&S)";
            this.라이브러리저장SToolStripMenuItem.Click += new System.EventHandler(this.라이브러리저장SToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.네트워크TToolStripMenuItem,
            this.라이브러리설정SEToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.설정ToolStripMenuItem.Text = "설정(&E)";
            // 
            // 네트워크TToolStripMenuItem
            // 
            this.네트워크TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.접속PToolStripMenuItem,
            this.열기NToolStripMenuItem});
            this.네트워크TToolStripMenuItem.Name = "네트워크TToolStripMenuItem";
            this.네트워크TToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.네트워크TToolStripMenuItem.Text = "네트워크(&T)";
            // 
            // 접속PToolStripMenuItem
            // 
            this.접속PToolStripMenuItem.Name = "접속PToolStripMenuItem";
            this.접속PToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.접속PToolStripMenuItem.Text = "접속(&P)";
            this.접속PToolStripMenuItem.Click += new System.EventHandler(this.접속PToolStripMenuItem_Click);
            // 
            // 열기NToolStripMenuItem
            // 
            this.열기NToolStripMenuItem.Name = "열기NToolStripMenuItem";
            this.열기NToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.열기NToolStripMenuItem.Text = "열기(&M)";
            this.열기NToolStripMenuItem.Click += new System.EventHandler(this.열기NToolStripMenuItem_Click);
            // 
            // 라이브러리설정SEToolStripMenuItem
            // 
            this.라이브러리설정SEToolStripMenuItem.Name = "라이브러리설정SEToolStripMenuItem";
            this.라이브러리설정SEToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.라이브러리설정SEToolStripMenuItem.Text = "프로그램 설정";
            this.라이브러리설정SEToolStripMenuItem.Click += new System.EventHandler(this.라이브러리설정SEToolStripMenuItem_Click);
            // 
            // SVDialog
            // 
            this.SVDialog.Filter = "오프라인 라이브러리 파일(*.offlib)|*.offlib";
            // 
            // OEDialog
            // 
            this.OEDialog.FileName = "openFileDialog1";
            this.OEDialog.Filter = "오프라인 라이브러리 파일(*.offlib)|*.offlib";
            // 
            // Scanbt
            // 
            this.Scanbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Scanbt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scanbt.Image = ((System.Drawing.Image)(resources.GetObject("Scanbt.Image")));
            this.Scanbt.Location = new System.Drawing.Point(137, 296);
            this.Scanbt.Name = "Scanbt";
            this.Scanbt.Size = new System.Drawing.Size(23, 24);
            this.Scanbt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Scanbt.TabIndex = 20;
            this.Scanbt.TabStop = false;
            this.Scanbt.Click += new System.EventHandler(this.Scanbt_Click);
            // 
            // btCommentDel
            // 
            this.btCommentDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCommentDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCommentDel.Image = ((System.Drawing.Image)(resources.GetObject("btCommentDel.Image")));
            this.btCommentDel.Location = new System.Drawing.Point(500, 445);
            this.btCommentDel.Name = "btCommentDel";
            this.btCommentDel.Size = new System.Drawing.Size(24, 24);
            this.btCommentDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCommentDel.TabIndex = 21;
            this.btCommentDel.TabStop = false;
            this.btCommentDel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btCommentAdd
            // 
            this.btCommentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCommentAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCommentAdd.Image = ((System.Drawing.Image)(resources.GetObject("btCommentAdd.Image")));
            this.btCommentAdd.Location = new System.Drawing.Point(470, 445);
            this.btCommentAdd.Name = "btCommentAdd";
            this.btCommentAdd.Size = new System.Drawing.Size(24, 24);
            this.btCommentAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCommentAdd.TabIndex = 22;
            this.btCommentAdd.TabStop = false;
            this.btCommentAdd.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CommentBoard
            // 
            this.CommentBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CommentBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentBoard.Location = new System.Drawing.Point(11, 326);
            this.CommentBoard.Name = "CommentBoard";
            this.CommentBoard.Size = new System.Drawing.Size(526, 106);
            this.CommentBoard.TabIndex = 12;
            this.CommentBoard.Load += new System.EventHandler(this.CommentBoard_Load);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 475);
            this.Controls.Add(this.btCommentAdd);
            this.Controls.Add(this.btCommentDel);
            this.Controls.Add(this.Scanbt);
            this.Controls.Add(this.BookTree);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtContext);
            this.Controls.Add(this.CommentBoard);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "LibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyber Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibraryForm_FormClosing);
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LibraryForm_KeyDown);
            this.TreeMenu.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scanbt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCommentDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCommentAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView BookTree;
        private CommentBoard CommentBoard;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLibraryNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 라이브러리저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 네트워크TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 라이브러리설정SEToolStripMenuItem;
        private System.Windows.Forms.ImageList TreeImageList;
        private System.Windows.Forms.ContextMenuStrip TreeMenu;
        private System.Windows.Forms.ToolStripMenuItem 북추가AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 북수정RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그룹추가GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제XToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SVDialog;
        private System.Windows.Forms.OpenFileDialog OEDialog;
        private System.Windows.Forms.ToolStripMenuItem 접속PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기NToolStripMenuItem;
        private System.Windows.Forms.PictureBox Scanbt;
        private System.Windows.Forms.PictureBox btCommentDel;
        private System.Windows.Forms.PictureBox btCommentAdd;
    }
}