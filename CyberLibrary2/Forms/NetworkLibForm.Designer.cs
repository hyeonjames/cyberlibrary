namespace CyberLibrary2.Forms
{
    partial class NetworkLibForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkLibForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("채팅방", 2, 2);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btSendToServer = new System.Windows.Forms.PictureBox();
            this.labelServerNotice = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.GradeIcon = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.MenuBoard = new System.Windows.Forms.TreeView();
            this.TreeImage = new System.Windows.Forms.ImageList(this.components);
            this.PanelNotice = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelNotice = new System.Windows.Forms.Label();
            this.PanelShowBook = new System.Windows.Forms.Panel();
            this.btModify = new System.Windows.Forms.PictureBox();
            this.btDel = new System.Windows.Forms.PictureBox();
            this.btCommentAdd = new System.Windows.Forms.PictureBox();
            this.btDelBook = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.PictureBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.PanelGroup = new System.Windows.Forms.Panel();
            this.btWrite = new System.Windows.Forms.PictureBox();
            this.btFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.chkTransfer = new System.Windows.Forms.CheckBox();
            this.chkWriter = new System.Windows.Forms.CheckBox();
            this.chkFindName = new System.Windows.Forms.CheckBox();
            this.btPrevPage = new System.Windows.Forms.Button();
            this.btNextPage = new System.Windows.Forms.Button();
            this.labelViewPage = new System.Windows.Forms.Label();
            this.PanelWrite = new System.Windows.Forms.Panel();
            this.btRemove = new System.Windows.Forms.PictureBox();
            this.btCheck = new System.Windows.Forms.PictureBox();
            this.PanelChatting = new System.Windows.Forms.Panel();
            this.btFontColor = new System.Windows.Forms.Button();
            this.btBackColor = new System.Windows.Forms.Button();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderLine = new System.Windows.Forms.CheckBox();
            this.chkStrikeout = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.numericFontSize = new System.Windows.Forms.NumericUpDown();
            this.comboFontNames = new System.Windows.Forms.ComboBox();
            this.btSend = new System.Windows.Forms.PictureBox();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.UserList = new System.Windows.Forms.ListView();
            this.GradeImageList = new System.Windows.Forms.ImageList(this.components);
            this.richChatContext = new System.Windows.Forms.RichTextBox();
            this.CommentBoard = new CyberLibrary2.CommentBoard();
            this.BookBoard = new CyberLibrary2.Controls.NetworkBoard();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSendToServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeIcon)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.PanelNotice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelShowBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCommentAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBack)).BeginInit();
            this.PanelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btWrite)).BeginInit();
            this.PanelWrite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCheck)).BeginInit();
            this.PanelChatting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSend)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.btSendToServer);
            this.splitContainer1.Panel1.Controls.Add(this.labelServerNotice);
            this.splitContainer1.Panel1.Controls.Add(this.labelGrade);
            this.splitContainer1.Panel1.Controls.Add(this.GradeIcon);
            this.splitContainer1.Panel1.Controls.Add(this.labelName);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(676, 514);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 0;
            // 
            // btSendToServer
            // 
            this.btSendToServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendToServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSendToServer.Image = ((System.Drawing.Image)(resources.GetObject("btSendToServer.Image")));
            this.btSendToServer.Location = new System.Drawing.Point(647, 61);
            this.btSendToServer.Name = "btSendToServer";
            this.btSendToServer.Size = new System.Drawing.Size(24, 24);
            this.btSendToServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btSendToServer.TabIndex = 4;
            this.btSendToServer.TabStop = false;
            this.btSendToServer.Click += new System.EventHandler(this.btSendToServer_Click);
            // 
            // labelServerNotice
            // 
            this.labelServerNotice.AutoSize = true;
            this.labelServerNotice.Font = new System.Drawing.Font("휴먼매직체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelServerNotice.Location = new System.Drawing.Point(60, 60);
            this.labelServerNotice.Name = "labelServerNotice";
            this.labelServerNotice.Size = new System.Drawing.Size(101, 16);
            this.labelServerNotice.TabIndex = 3;
            this.labelServerNotice.Text = "** 공지 사항 : ";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(49, 35);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(276, 12);
            this.labelGrade.TabIndex = 2;
            this.labelGrade.Text = "회원님의 현재 등급은 x 입니다 ( 보유 포인트 : 0 )";
            // 
            // GradeIcon
            // 
            this.GradeIcon.Location = new System.Drawing.Point(11, 26);
            this.GradeIcon.Name = "GradeIcon";
            this.GradeIcon.Size = new System.Drawing.Size(32, 32);
            this.GradeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GradeIcon.TabIndex = 1;
            this.GradeIcon.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(49, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(153, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "UserName 님 안녕하세요 !";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.MenuBoard);
            this.splitContainer2.Panel1.Controls.Add(this.PanelNotice);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PanelChatting);
            this.splitContainer2.Panel2.Controls.Add(this.PanelGroup);
            this.splitContainer2.Panel2.Controls.Add(this.PanelShowBook);
            this.splitContainer2.Panel2.Controls.Add(this.PanelWrite);
            this.splitContainer2.Size = new System.Drawing.Size(676, 420);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 0;
            // 
            // MenuBoard
            // 
            this.MenuBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MenuBoard.ImageIndex = 2;
            this.MenuBoard.ImageList = this.TreeImage;
            this.MenuBoard.Location = new System.Drawing.Point(2, 0);
            this.MenuBoard.Name = "MenuBoard";
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "노드0";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "채팅방";
            this.MenuBoard.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.MenuBoard.SelectedImageIndex = 0;
            this.MenuBoard.Size = new System.Drawing.Size(159, 417);
            this.MenuBoard.TabIndex = 0;
            this.MenuBoard.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MenuBoard_AfterSelect);
            // 
            // TreeImage
            // 
            this.TreeImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImage.ImageStream")));
            this.TreeImage.TransparentColor = System.Drawing.Color.Magenta;
            this.TreeImage.Images.SetKeyName(0, "Board.bmp");
            this.TreeImage.Images.SetKeyName(1, "Tool Folder.bmp");
            this.TreeImage.Images.SetKeyName(2, "16-comment.png");
            // 
            // PanelNotice
            // 
            this.PanelNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PanelNotice.Controls.Add(this.pictureBox2);
            this.PanelNotice.Controls.Add(this.labelNotice);
            this.PanelNotice.Location = new System.Drawing.Point(98, 9);
            this.PanelNotice.Name = "PanelNotice";
            this.PanelNotice.Size = new System.Drawing.Size(237, 192);
            this.PanelNotice.TabIndex = 1;
            this.PanelNotice.Visible = false;
            this.PanelNotice.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNotice_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("휴먼매직체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelNotice.Location = new System.Drawing.Point(31, 14);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(45, 21);
            this.labelNotice.TabIndex = 0;
            this.labelNotice.Text = "알림";
            // 
            // PanelShowBook
            // 
            this.PanelShowBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelShowBook.Controls.Add(this.CommentBoard);
            this.PanelShowBook.Controls.Add(this.btModify);
            this.PanelShowBook.Controls.Add(this.btDel);
            this.PanelShowBook.Controls.Add(this.btCommentAdd);
            this.PanelShowBook.Controls.Add(this.btDelBook);
            this.PanelShowBook.Controls.Add(this.btBack);
            this.PanelShowBook.Controls.Add(this.txtComment);
            this.PanelShowBook.Location = new System.Drawing.Point(1, 75);
            this.PanelShowBook.Name = "PanelShowBook";
            this.PanelShowBook.Size = new System.Drawing.Size(599, 416);
            this.PanelShowBook.TabIndex = 2;
            this.PanelShowBook.Visible = false;
            this.PanelShowBook.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelShowBook_Paint_1);
            // 
            // btModify
            // 
            this.btModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModify.Image = ((System.Drawing.Image)(resources.GetObject("btModify.Image")));
            this.btModify.Location = new System.Drawing.Point(63, 3);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(24, 24);
            this.btModify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btModify.TabIndex = 9;
            this.btModify.TabStop = false;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btDel
            // 
            this.btDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.Location = new System.Drawing.Point(568, 388);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(24, 24);
            this.btDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btDel.TabIndex = 8;
            this.btDel.TabStop = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btCommentAdd
            // 
            this.btCommentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCommentAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCommentAdd.Image = ((System.Drawing.Image)(resources.GetObject("btCommentAdd.Image")));
            this.btCommentAdd.Location = new System.Drawing.Point(538, 388);
            this.btCommentAdd.Name = "btCommentAdd";
            this.btCommentAdd.Size = new System.Drawing.Size(24, 24);
            this.btCommentAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCommentAdd.TabIndex = 7;
            this.btCommentAdd.TabStop = false;
            this.btCommentAdd.Click += new System.EventHandler(this.btCommentAdd_Click);
            // 
            // btDelBook
            // 
            this.btDelBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelBook.Image = ((System.Drawing.Image)(resources.GetObject("btDelBook.Image")));
            this.btDelBook.Location = new System.Drawing.Point(33, 3);
            this.btDelBook.Name = "btDelBook";
            this.btDelBook.Size = new System.Drawing.Size(24, 24);
            this.btDelBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btDelBook.TabIndex = 6;
            this.btDelBook.TabStop = false;
            this.btDelBook.Click += new System.EventHandler(this.btDelBook_Click);
            // 
            // btBack
            // 
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.Location = new System.Drawing.Point(3, 3);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(24, 24);
            this.btBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btBack.TabIndex = 5;
            this.btBack.TabStop = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(3, 388);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(529, 21);
            this.txtComment.TabIndex = 2;
            // 
            // PanelGroup
            // 
            this.PanelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGroup.Controls.Add(this.btWrite);
            this.PanelGroup.Controls.Add(this.btFind);
            this.PanelGroup.Controls.Add(this.txtFind);
            this.PanelGroup.Controls.Add(this.chkTransfer);
            this.PanelGroup.Controls.Add(this.chkWriter);
            this.PanelGroup.Controls.Add(this.chkFindName);
            this.PanelGroup.Controls.Add(this.BookBoard);
            this.PanelGroup.Controls.Add(this.btPrevPage);
            this.PanelGroup.Controls.Add(this.btNextPage);
            this.PanelGroup.Controls.Add(this.labelViewPage);
            this.PanelGroup.Location = new System.Drawing.Point(34, 29);
            this.PanelGroup.Name = "PanelGroup";
            this.PanelGroup.Size = new System.Drawing.Size(504, 413);
            this.PanelGroup.TabIndex = 0;
            this.PanelGroup.Visible = false;
            // 
            // btWrite
            // 
            this.btWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btWrite.Image = ((System.Drawing.Image)(resources.GetObject("btWrite.Image")));
            this.btWrite.Location = new System.Drawing.Point(461, 323);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(24, 24);
            this.btWrite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btWrite.TabIndex = 1;
            this.btWrite.TabStop = false;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btFind
            // 
            this.btFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btFind.Location = new System.Drawing.Point(395, 352);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(46, 23);
            this.btFind.TabIndex = 8;
            this.btFind.Text = "찾기";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFind.Location = new System.Drawing.Point(46, 353);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(343, 21);
            this.txtFind.TabIndex = 7;
            // 
            // chkTransfer
            // 
            this.chkTransfer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkTransfer.AutoSize = true;
            this.chkTransfer.Location = new System.Drawing.Point(186, 338);
            this.chkTransfer.Name = "chkTransfer";
            this.chkTransfer.Size = new System.Drawing.Size(76, 16);
            this.chkTransfer.TabIndex = 6;
            this.chkTransfer.Text = "책 옮김이";
            this.chkTransfer.UseVisualStyleBackColor = true;
            // 
            // chkWriter
            // 
            this.chkWriter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkWriter.AutoSize = true;
            this.chkWriter.Location = new System.Drawing.Point(116, 338);
            this.chkWriter.Name = "chkWriter";
            this.chkWriter.Size = new System.Drawing.Size(64, 16);
            this.chkWriter.TabIndex = 5;
            this.chkWriter.Text = "책 작가";
            this.chkWriter.UseVisualStyleBackColor = true;
            // 
            // chkFindName
            // 
            this.chkFindName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkFindName.AutoSize = true;
            this.chkFindName.Checked = true;
            this.chkFindName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFindName.Location = new System.Drawing.Point(46, 338);
            this.chkFindName.Name = "chkFindName";
            this.chkFindName.Size = new System.Drawing.Size(64, 16);
            this.chkFindName.TabIndex = 4;
            this.chkFindName.Text = "책 이름";
            this.chkFindName.UseVisualStyleBackColor = true;
            // 
            // btPrevPage
            // 
            this.btPrevPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btPrevPage.Location = new System.Drawing.Point(144, 382);
            this.btPrevPage.Name = "btPrevPage";
            this.btPrevPage.Size = new System.Drawing.Size(32, 23);
            this.btPrevPage.TabIndex = 3;
            this.btPrevPage.Text = "◁";
            this.btPrevPage.UseVisualStyleBackColor = true;
            this.btPrevPage.Click += new System.EventHandler(this.btPrevPage_Click);
            // 
            // btNextPage
            // 
            this.btNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btNextPage.Location = new System.Drawing.Point(314, 382);
            this.btNextPage.Name = "btNextPage";
            this.btNextPage.Size = new System.Drawing.Size(32, 23);
            this.btNextPage.TabIndex = 2;
            this.btNextPage.Text = "▷";
            this.btNextPage.UseVisualStyleBackColor = true;
            this.btNextPage.Click += new System.EventHandler(this.btNextPage_Click);
            // 
            // labelViewPage
            // 
            this.labelViewPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelViewPage.AutoSize = true;
            this.labelViewPage.Location = new System.Drawing.Point(236, 387);
            this.labelViewPage.Name = "labelViewPage";
            this.labelViewPage.Size = new System.Drawing.Size(11, 12);
            this.labelViewPage.TabIndex = 1;
            this.labelViewPage.Text = "1";
            // 
            // PanelWrite
            // 
            this.PanelWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelWrite.Controls.Add(this.btRemove);
            this.PanelWrite.Controls.Add(this.btCheck);
            this.PanelWrite.Location = new System.Drawing.Point(83, 329);
            this.PanelWrite.Name = "PanelWrite";
            this.PanelWrite.Size = new System.Drawing.Size(494, 343);
            this.PanelWrite.TabIndex = 4;
            this.PanelWrite.Visible = false;
            // 
            // btRemove
            // 
            this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemove.Image = ((System.Drawing.Image)(resources.GetObject("btRemove.Image")));
            this.btRemove.Location = new System.Drawing.Point(459, 312);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(24, 24);
            this.btRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btRemove.TabIndex = 2;
            this.btRemove.TabStop = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btCheck
            // 
            this.btCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCheck.Image = ((System.Drawing.Image)(resources.GetObject("btCheck.Image")));
            this.btCheck.Location = new System.Drawing.Point(429, 312);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(24, 24);
            this.btCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCheck.TabIndex = 1;
            this.btCheck.TabStop = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // PanelChatting
            // 
            this.PanelChatting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PanelChatting.Controls.Add(this.btFontColor);
            this.PanelChatting.Controls.Add(this.btBackColor);
            this.PanelChatting.Controls.Add(this.chkItalic);
            this.PanelChatting.Controls.Add(this.chkUnderLine);
            this.PanelChatting.Controls.Add(this.chkStrikeout);
            this.PanelChatting.Controls.Add(this.chkBold);
            this.PanelChatting.Controls.Add(this.numericFontSize);
            this.PanelChatting.Controls.Add(this.comboFontNames);
            this.PanelChatting.Controls.Add(this.btSend);
            this.PanelChatting.Controls.Add(this.txtSendMsg);
            this.PanelChatting.Controls.Add(this.UserList);
            this.PanelChatting.Controls.Add(this.richChatContext);
            this.PanelChatting.Location = new System.Drawing.Point(14, 35);
            this.PanelChatting.Name = "PanelChatting";
            this.PanelChatting.Size = new System.Drawing.Size(504, 166);
            this.PanelChatting.TabIndex = 3;
            this.PanelChatting.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChatting_Paint);
            // 
            // btFontColor
            // 
            this.btFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFontColor.Location = new System.Drawing.Point(451, 107);
            this.btFontColor.Name = "btFontColor";
            this.btFontColor.Size = new System.Drawing.Size(50, 23);
            this.btFontColor.TabIndex = 11;
            this.btFontColor.Text = "폰트색";
            this.btFontColor.UseVisualStyleBackColor = true;
            this.btFontColor.Click += new System.EventHandler(this.btFontColor_Click);
            // 
            // btBackColor
            // 
            this.btBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBackColor.Location = new System.Drawing.Point(401, 107);
            this.btBackColor.Name = "btBackColor";
            this.btBackColor.Size = new System.Drawing.Size(50, 23);
            this.btBackColor.TabIndex = 10;
            this.btBackColor.Text = "배경색";
            this.btBackColor.UseVisualStyleBackColor = true;
            this.btBackColor.Click += new System.EventHandler(this.btBackColor_Click);
            // 
            // chkItalic
            // 
            this.chkItalic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(225, 111);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(60, 16);
            this.chkItalic.TabIndex = 9;
            this.chkItalic.Text = "기울임";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkUnderLine
            // 
            this.chkUnderLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUnderLine.AutoSize = true;
            this.chkUnderLine.Location = new System.Drawing.Point(291, 111);
            this.chkUnderLine.Name = "chkUnderLine";
            this.chkUnderLine.Size = new System.Drawing.Size(48, 16);
            this.chkUnderLine.TabIndex = 8;
            this.chkUnderLine.Text = "밑줄";
            this.chkUnderLine.UseVisualStyleBackColor = true;
            // 
            // chkStrikeout
            // 
            this.chkStrikeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkStrikeout.AutoSize = true;
            this.chkStrikeout.Location = new System.Drawing.Point(345, 111);
            this.chkStrikeout.Name = "chkStrikeout";
            this.chkStrikeout.Size = new System.Drawing.Size(60, 16);
            this.chkStrikeout.TabIndex = 7;
            this.chkStrikeout.Text = "취소선";
            this.chkStrikeout.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            this.chkBold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(176, 111);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            this.chkBold.TabIndex = 6;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // numericFontSize
            // 
            this.numericFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericFontSize.Location = new System.Drawing.Point(108, 109);
            this.numericFontSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericFontSize.Name = "numericFontSize";
            this.numericFontSize.Size = new System.Drawing.Size(62, 21);
            this.numericFontSize.TabIndex = 5;
            // 
            // comboFontNames
            // 
            this.comboFontNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboFontNames.FormattingEnabled = true;
            this.comboFontNames.Location = new System.Drawing.Point(6, 109);
            this.comboFontNames.Name = "comboFontNames";
            this.comboFontNames.Size = new System.Drawing.Size(96, 20);
            this.comboFontNames.TabIndex = 4;
            // 
            // btSend
            // 
            this.btSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.Image = ((System.Drawing.Image)(resources.GetObject("btSend.Image")));
            this.btSend.Location = new System.Drawing.Point(473, 132);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(24, 24);
            this.btSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btSend.TabIndex = 3;
            this.btSend.TabStop = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendMsg.Location = new System.Drawing.Point(6, 133);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(456, 21);
            this.txtSendMsg.TabIndex = 2;
            this.txtSendMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendMsg_KeyPress);
            // 
            // UserList
            // 
            this.UserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserList.Location = new System.Drawing.Point(356, 3);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(145, 102);
            this.UserList.SmallImageList = this.GradeImageList;
            this.UserList.TabIndex = 1;
            this.UserList.UseCompatibleStateImageBehavior = false;
            this.UserList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // GradeImageList
            // 
            this.GradeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.GradeImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.GradeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // richChatContext
            // 
            this.richChatContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richChatContext.Location = new System.Drawing.Point(0, 0);
            this.richChatContext.Name = "richChatContext";
            this.richChatContext.ReadOnly = true;
            this.richChatContext.Size = new System.Drawing.Size(350, 105);
            this.richChatContext.TabIndex = 0;
            this.richChatContext.TabStop = false;
            this.richChatContext.Text = "";
            // 
            // CommentBoard
            // 
            this.CommentBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentBoard.Location = new System.Drawing.Point(1, 285);
            this.CommentBoard.Name = "CommentBoard";
            this.CommentBoard.Size = new System.Drawing.Size(591, 97);
            this.CommentBoard.TabIndex = 1;
            this.CommentBoard.Load += new System.EventHandler(this.CommentBoard_Load);
            // 
            // BookBoard
            // 
            this.BookBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BookBoard.Location = new System.Drawing.Point(3, 3);
            this.BookBoard.Name = "BookBoard";
            this.BookBoard.Size = new System.Drawing.Size(503, 314);
            this.BookBoard.TabIndex = 0;
            // 
            // NetworkLibForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 514);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "NetworkLibForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "네트워크 모드 - User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkLibForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btSendToServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeIcon)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.PanelNotice.ResumeLayout(false);
            this.PanelNotice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelShowBook.ResumeLayout(false);
            this.PanelShowBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCommentAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btBack)).EndInit();
            this.PanelGroup.ResumeLayout(false);
            this.PanelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btWrite)).EndInit();
            this.PanelWrite.ResumeLayout(false);
            this.PanelWrite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCheck)).EndInit();
            this.PanelChatting.ResumeLayout(false);
            this.PanelChatting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btPrevPage;
        private System.Windows.Forms.Button btNextPage;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.CheckBox chkTransfer;
        private System.Windows.Forms.CheckBox chkWriter;
        private System.Windows.Forms.CheckBox chkFindName;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.ImageList TreeImage;
        private System.Windows.Forms.PictureBox btSendToServer;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel PanelGroup;
        public System.Windows.Forms.Panel PanelNotice;
        public System.Windows.Forms.Panel PanelShowBook;
        private System.Windows.Forms.Panel PanelChatting;
        private System.Windows.Forms.PictureBox btSend;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.RichTextBox richChatContext;
        public System.Windows.Forms.Label labelGrade;
        public System.Windows.Forms.PictureBox GradeIcon;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelServerNotice;
        public System.Windows.Forms.ImageList GradeImageList;
        public System.Windows.Forms.TreeView MenuBoard;
        public System.Windows.Forms.ListView UserList;
        public CyberLibrary2.Controls.NetworkBoard BookBoard;
        public System.Windows.Forms.Label labelNotice;
        public System.Windows.Forms.Label labelViewPage;
        private System.Windows.Forms.PictureBox btWrite;
        public System.Windows.Forms.Panel PanelWrite;
        private System.Windows.Forms.PictureBox btRemove;
        private System.Windows.Forms.PictureBox btCheck;
        public CommentBoard CommentBoard;
        private System.Windows.Forms.PictureBox btBack;
        private System.Windows.Forms.PictureBox btCommentAdd;
        public System.Windows.Forms.PictureBox btDelBook;
        public System.Windows.Forms.PictureBox btDel;
        public System.Windows.Forms.PictureBox btModify;
        private System.Windows.Forms.NumericUpDown numericFontSize;
        private System.Windows.Forms.ComboBox comboFontNames;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnderLine;
        private System.Windows.Forms.CheckBox chkStrikeout;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Button btFontColor;
        private System.Windows.Forms.Button btBackColor;
    }
}