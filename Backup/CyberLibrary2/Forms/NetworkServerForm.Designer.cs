namespace CyberLibrary2.Forms
{
    partial class NetworkServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkServerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EventList = new System.Windows.Forms.ListView();
            this.EventImageList = new System.Windows.Forms.ImageList(this.components);
            this.btOpen = new System.Windows.Forms.PictureBox();
            this.btSave = new System.Windows.Forms.PictureBox();
            this.PortNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPortNumber = new System.Windows.Forms.Label();
            this.btOpenServer = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.UserPanel = new System.Windows.Forms.TabPage();
            this.btXMLOpen = new System.Windows.Forms.Button();
            this.btXMLSave = new System.Windows.Forms.Button();
            this.btLock = new System.Windows.Forms.PictureBox();
            this.btModify = new System.Windows.Forms.PictureBox();
            this.btUserDel = new System.Windows.Forms.PictureBox();
            this.btUserAdd = new System.Windows.Forms.PictureBox();
            this.UserList = new System.Windows.Forms.ListView();
            this.ColumnUserID = new System.Windows.Forms.ColumnHeader();
            this.ColumnUserState = new System.Windows.Forms.ColumnHeader();
            this.ColumnUserLevel = new System.Windows.Forms.ColumnHeader();
            this.labelConnectedUserCount = new System.Windows.Forms.Label();
            this.labelAllUserCount = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btNoticeFloat = new System.Windows.Forms.Button();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btClearUserMessage = new System.Windows.Forms.Button();
            this.UserMessageList = new System.Windows.Forms.ListView();
            this.ColumnContext = new System.Windows.Forms.ColumnHeader();
            this.ColumnSendID = new System.Windows.Forms.ColumnHeader();
            this.ColumnSendTime = new System.Windows.Forms.ColumnHeader();
            this.label8 = new System.Windows.Forms.Label();
            this.BoardControl = new System.Windows.Forms.TabPage();
            this.NumbericWriteAddPoint = new System.Windows.Forms.NumericUpDown();
            this.NumbericReadSubPoint = new System.Windows.Forms.NumericUpDown();
            this.txtBoardDecription = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboWriteLimit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ComboReadLimit = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoardName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BoardTree = new System.Windows.Forms.TreeView();
            this.TreeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.게시판추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그룹추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeImages = new System.Windows.Forms.ImageList(this.components);
            this.GradeControl = new System.Windows.Forms.TabPage();
            this.NumbericLimitPoint = new System.Windows.Forms.NumericUpDown();
            this.chkOperate = new System.Windows.Forms.CheckBox();
            this.chkDelModify = new System.Windows.Forms.CheckBox();
            this.chkAbleWrite = new System.Windows.Forms.CheckBox();
            this.chkAbleRead = new System.Windows.Forms.CheckBox();
            this.btIconChange = new System.Windows.Forms.Button();
            this.txtLevelDescription = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.LevelList = new System.Windows.Forms.ListView();
            this.LevelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.등급추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.등급삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LevelIconImages = new System.Windows.Forms.ImageList(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btBanOpen = new System.Windows.Forms.PictureBox();
            this.btIPBan = new System.Windows.Forms.PictureBox();
            this.IPBanCombo = new System.Windows.Forms.ComboBox();
            this.IPBanList = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.NumericThreadSleep = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NumericCommentWriteLimitTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NumericWriteLimitTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxConnectSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJoinGuide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).BeginInit();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUserDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUserAdd)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.BoardControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericWriteAddPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericReadSubPoint)).BeginInit();
            this.TreeContextMenu.SuspendLayout();
            this.GradeControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericLimitPoint)).BeginInit();
            this.LevelContextMenu.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btBanOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btIPBan)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericThreadSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCommentWriteLimitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWriteLimitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxConnectSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.UserPanel);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.BoardControl);
            this.tabControl1.Controls.Add(this.GradeControl);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EventList);
            this.tabPage1.Controls.Add(this.btOpen);
            this.tabPage1.Controls.Add(this.btSave);
            this.tabPage1.Controls.Add(this.PortNumber);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.labelPortNumber);
            this.tabPage1.Controls.Add(this.btOpenServer);
            this.tabPage1.Controls.Add(this.txtServerName);
            this.tabPage1.Controls.Add(this.labelServerName);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "정 보 관 리";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EventList
            // 
            this.EventList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EventList.AutoArrange = false;
            this.EventList.Location = new System.Drawing.Point(14, 73);
            this.EventList.Name = "EventList";
            this.EventList.Size = new System.Drawing.Size(431, 217);
            this.EventList.SmallImageList = this.EventImageList;
            this.EventList.TabIndex = 25;
            this.EventList.UseCompatibleStateImageBehavior = false;
            this.EventList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // EventImageList
            // 
            this.EventImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("EventImageList.ImageStream")));
            this.EventImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.EventImageList.Images.SetKeyName(0, "16-email-forward.png");
            this.EventImageList.Images.SetKeyName(1, "16-email-letter.png");
            this.EventImageList.Images.SetKeyName(2, "16-message-info.png");
            this.EventImageList.Images.SetKeyName(3, "16-message-warn.png");
            // 
            // btOpen
            // 
            this.btOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOpen.Image = ((System.Drawing.Image)(resources.GetObject("btOpen.Image")));
            this.btOpen.Location = new System.Drawing.Point(40, 300);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(20, 19);
            this.btOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btOpen.TabIndex = 24;
            this.btOpen.TabStop = false;
            this.btOpen.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(14, 300);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(20, 19);
            this.btSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btSave.TabIndex = 23;
            this.btSave.TabStop = false;
            this.btSave.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PortNumber
            // 
            this.PortNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PortNumber.Location = new System.Drawing.Point(83, 46);
            this.PortNumber.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(362, 21);
            this.PortNumber.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 16;
            // 
            // labelPortNumber
            // 
            this.labelPortNumber.AutoSize = true;
            this.labelPortNumber.Location = new System.Drawing.Point(12, 48);
            this.labelPortNumber.Name = "labelPortNumber";
            this.labelPortNumber.Size = new System.Drawing.Size(65, 12);
            this.labelPortNumber.TabIndex = 14;
            this.labelPortNumber.Text = "포트 번호 :";
            // 
            // btOpenServer
            // 
            this.btOpenServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenServer.Location = new System.Drawing.Point(370, 296);
            this.btOpenServer.Name = "btOpenServer";
            this.btOpenServer.Size = new System.Drawing.Size(75, 23);
            this.btOpenServer.TabIndex = 13;
            this.btOpenServer.Text = "서버 열기";
            this.btOpenServer.UseVisualStyleBackColor = true;
            this.btOpenServer.Click += new System.EventHandler(this.btOpenServer_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerName.Location = new System.Drawing.Point(83, 20);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(362, 21);
            this.txtServerName.TabIndex = 7;
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(12, 23);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(65, 12);
            this.labelServerName.TabIndex = 6;
            this.labelServerName.Text = "서버 이름 :";
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.btXMLOpen);
            this.UserPanel.Controls.Add(this.btXMLSave);
            this.UserPanel.Controls.Add(this.btLock);
            this.UserPanel.Controls.Add(this.btModify);
            this.UserPanel.Controls.Add(this.btUserDel);
            this.UserPanel.Controls.Add(this.btUserAdd);
            this.UserPanel.Controls.Add(this.UserList);
            this.UserPanel.Controls.Add(this.labelConnectedUserCount);
            this.UserPanel.Controls.Add(this.labelAllUserCount);
            this.UserPanel.Location = new System.Drawing.Point(4, 21);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Padding = new System.Windows.Forms.Padding(3);
            this.UserPanel.Size = new System.Drawing.Size(453, 328);
            this.UserPanel.TabIndex = 1;
            this.UserPanel.Text = "유 저 관 리";
            this.UserPanel.UseVisualStyleBackColor = true;
            this.UserPanel.Click += new System.EventHandler(this.tabPage2_Click);
            this.UserPanel.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btXMLOpen
            // 
            this.btXMLOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btXMLOpen.Location = new System.Drawing.Point(105, 296);
            this.btXMLOpen.Name = "btXMLOpen";
            this.btXMLOpen.Size = new System.Drawing.Size(89, 23);
            this.btXMLOpen.TabIndex = 12;
            this.btXMLOpen.Text = "XML로 열기";
            this.btXMLOpen.UseVisualStyleBackColor = true;
            this.btXMLOpen.Click += new System.EventHandler(this.btXMLOpen_Click);
            // 
            // btXMLSave
            // 
            this.btXMLSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btXMLSave.Location = new System.Drawing.Point(10, 296);
            this.btXMLSave.Name = "btXMLSave";
            this.btXMLSave.Size = new System.Drawing.Size(89, 23);
            this.btXMLSave.TabIndex = 11;
            this.btXMLSave.Text = "XML로 저장";
            this.btXMLSave.UseVisualStyleBackColor = true;
            this.btXMLSave.Click += new System.EventHandler(this.btXMLSave_Click);
            // 
            // btLock
            // 
            this.btLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLock.Image = global::CyberLibrary2.Properties.Resources._24_security_lock;
            this.btLock.Location = new System.Drawing.Point(335, 297);
            this.btLock.Name = "btLock";
            this.btLock.Size = new System.Drawing.Size(24, 24);
            this.btLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btLock.TabIndex = 10;
            this.btLock.TabStop = false;
            this.btLock.Click += new System.EventHandler(this.btLock_Click);
            // 
            // btModify
            // 
            this.btModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModify.Image = ((System.Drawing.Image)(resources.GetObject("btModify.Image")));
            this.btModify.Location = new System.Drawing.Point(393, 297);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(24, 24);
            this.btModify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btModify.TabIndex = 9;
            this.btModify.TabStop = false;
            this.btModify.Click += new System.EventHandler(this.btModify_Click_1);
            // 
            // btUserDel
            // 
            this.btUserDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUserDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUserDel.Image = ((System.Drawing.Image)(resources.GetObject("btUserDel.Image")));
            this.btUserDel.Location = new System.Drawing.Point(421, 297);
            this.btUserDel.Name = "btUserDel";
            this.btUserDel.Size = new System.Drawing.Size(24, 24);
            this.btUserDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btUserDel.TabIndex = 8;
            this.btUserDel.TabStop = false;
            this.btUserDel.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btUserAdd
            // 
            this.btUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUserAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUserAdd.Image = ((System.Drawing.Image)(resources.GetObject("btUserAdd.Image")));
            this.btUserAdd.Location = new System.Drawing.Point(365, 297);
            this.btUserAdd.Name = "btUserAdd";
            this.btUserAdd.Size = new System.Drawing.Size(24, 24);
            this.btUserAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btUserAdd.TabIndex = 7;
            this.btUserAdd.TabStop = false;
            this.btUserAdd.Click += new System.EventHandler(this.btUserAdd_Click_1);
            // 
            // UserList
            // 
            this.UserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnUserID,
            this.ColumnUserState,
            this.ColumnUserLevel});
            this.UserList.Location = new System.Drawing.Point(10, 55);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(435, 236);
            this.UserList.TabIndex = 4;
            this.UserList.UseCompatibleStateImageBehavior = false;
            this.UserList.View = System.Windows.Forms.View.Details;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            this.UserList.SizeChanged += new System.EventHandler(this.UserList_SizeChanged);
            this.UserList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.UserList_ItemSelectionChanged);
            // 
            // ColumnUserID
            // 
            this.ColumnUserID.Text = "ID";
            this.ColumnUserID.Width = 204;
            // 
            // ColumnUserState
            // 
            this.ColumnUserState.Text = "상태";
            this.ColumnUserState.Width = 108;
            // 
            // ColumnUserLevel
            // 
            this.ColumnUserLevel.Text = "등급";
            this.ColumnUserLevel.Width = 113;
            // 
            // labelConnectedUserCount
            // 
            this.labelConnectedUserCount.AutoSize = true;
            this.labelConnectedUserCount.Location = new System.Drawing.Point(8, 40);
            this.labelConnectedUserCount.Name = "labelConnectedUserCount";
            this.labelConnectedUserCount.Size = new System.Drawing.Size(103, 12);
            this.labelConnectedUserCount.TabIndex = 1;
            this.labelConnectedUserCount.Text = "접속 쓰레드 : 0 명";
            // 
            // labelAllUserCount
            // 
            this.labelAllUserCount.AutoSize = true;
            this.labelAllUserCount.Location = new System.Drawing.Point(8, 15);
            this.labelAllUserCount.Name = "labelAllUserCount";
            this.labelAllUserCount.Size = new System.Drawing.Size(107, 12);
            this.labelAllUserCount.TabIndex = 0;
            this.labelAllUserCount.Text = "총 유저 인원 : 0 명";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btNoticeFloat);
            this.tabPage3.Controls.Add(this.txtNotice);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btClearUserMessage);
            this.tabPage3.Controls.Add(this.UserMessageList);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(453, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "환 경 관 리";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btNoticeFloat
            // 
            this.btNoticeFloat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNoticeFloat.Enabled = false;
            this.btNoticeFloat.Location = new System.Drawing.Point(370, 137);
            this.btNoticeFloat.Name = "btNoticeFloat";
            this.btNoticeFloat.Size = new System.Drawing.Size(75, 23);
            this.btNoticeFloat.TabIndex = 5;
            this.btNoticeFloat.Text = "띄우기";
            this.btNoticeFloat.UseVisualStyleBackColor = true;
            this.btNoticeFloat.Click += new System.EventHandler(this.btNoticeFloat_Click);
            // 
            // txtNotice
            // 
            this.txtNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotice.Enabled = false;
            this.txtNotice.Location = new System.Drawing.Point(8, 28);
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(437, 103);
            this.txtNotice.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "서버 공지 띄우기";
            // 
            // btClearUserMessage
            // 
            this.btClearUserMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearUserMessage.Enabled = false;
            this.btClearUserMessage.Location = new System.Drawing.Point(384, 300);
            this.btClearUserMessage.Name = "btClearUserMessage";
            this.btClearUserMessage.Size = new System.Drawing.Size(63, 23);
            this.btClearUserMessage.TabIndex = 2;
            this.btClearUserMessage.Text = "청소";
            this.btClearUserMessage.UseVisualStyleBackColor = true;
            this.btClearUserMessage.Click += new System.EventHandler(this.btClearUserMessage_Click);
            // 
            // UserMessageList
            // 
            this.UserMessageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserMessageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnContext,
            this.ColumnSendID,
            this.ColumnSendTime});
            this.UserMessageList.Enabled = false;
            this.UserMessageList.Location = new System.Drawing.Point(10, 166);
            this.UserMessageList.Name = "UserMessageList";
            this.UserMessageList.Size = new System.Drawing.Size(437, 128);
            this.UserMessageList.TabIndex = 1;
            this.UserMessageList.UseCompatibleStateImageBehavior = false;
            this.UserMessageList.View = System.Windows.Forms.View.Details;
            // 
            // ColumnContext
            // 
            this.ColumnContext.Text = "내용";
            this.ColumnContext.Width = 237;
            // 
            // ColumnSendID
            // 
            this.ColumnSendID.Text = "ID";
            this.ColumnSendID.Width = 75;
            // 
            // ColumnSendTime
            // 
            this.ColumnSendTime.Text = "보낸 시각";
            this.ColumnSendTime.Width = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "유저들이 보낸 메세지 :";
            // 
            // BoardControl
            // 
            this.BoardControl.Controls.Add(this.NumbericWriteAddPoint);
            this.BoardControl.Controls.Add(this.NumbericReadSubPoint);
            this.BoardControl.Controls.Add(this.txtBoardDecription);
            this.BoardControl.Controls.Add(this.label15);
            this.BoardControl.Controls.Add(this.label14);
            this.BoardControl.Controls.Add(this.label13);
            this.BoardControl.Controls.Add(this.ComboWriteLimit);
            this.BoardControl.Controls.Add(this.label12);
            this.BoardControl.Controls.Add(this.ComboReadLimit);
            this.BoardControl.Controls.Add(this.label11);
            this.BoardControl.Controls.Add(this.txtBoardName);
            this.BoardControl.Controls.Add(this.label10);
            this.BoardControl.Controls.Add(this.BoardTree);
            this.BoardControl.Location = new System.Drawing.Point(4, 21);
            this.BoardControl.Name = "BoardControl";
            this.BoardControl.Padding = new System.Windows.Forms.Padding(3);
            this.BoardControl.Size = new System.Drawing.Size(453, 328);
            this.BoardControl.TabIndex = 3;
            this.BoardControl.Text = "게 시 판 관 리";
            this.BoardControl.UseVisualStyleBackColor = true;
            this.BoardControl.Leave += new System.EventHandler(this.tabPage4_Leave);
            // 
            // NumbericWriteAddPoint
            // 
            this.NumbericWriteAddPoint.Location = new System.Drawing.Point(309, 115);
            this.NumbericWriteAddPoint.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumbericWriteAddPoint.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.NumbericWriteAddPoint.Name = "NumbericWriteAddPoint";
            this.NumbericWriteAddPoint.Size = new System.Drawing.Size(136, 21);
            this.NumbericWriteAddPoint.TabIndex = 18;
            // 
            // NumbericReadSubPoint
            // 
            this.NumbericReadSubPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NumbericReadSubPoint.Location = new System.Drawing.Point(309, 89);
            this.NumbericReadSubPoint.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumbericReadSubPoint.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.NumbericReadSubPoint.Name = "NumbericReadSubPoint";
            this.NumbericReadSubPoint.Size = new System.Drawing.Size(136, 21);
            this.NumbericReadSubPoint.TabIndex = 17;
            // 
            // txtBoardDecription
            // 
            this.txtBoardDecription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoardDecription.Location = new System.Drawing.Point(194, 158);
            this.txtBoardDecription.Multiline = true;
            this.txtBoardDecription.Name = "txtBoardDecription";
            this.txtBoardDecription.Size = new System.Drawing.Size(251, 161);
            this.txtBoardDecription.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(194, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 12);
            this.label15.TabIndex = 13;
            this.label15.Text = "그룹 설명 : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(194, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "쓰기 가산 포인트 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(194, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "읽기 반감 포인트 : ";
            // 
            // ComboWriteLimit
            // 
            this.ComboWriteLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboWriteLimit.FormattingEnabled = true;
            this.ComboWriteLimit.Location = new System.Drawing.Point(293, 60);
            this.ComboWriteLimit.Name = "ComboWriteLimit";
            this.ComboWriteLimit.Size = new System.Drawing.Size(152, 20);
            this.ComboWriteLimit.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "쓰기 제한 등급 :";
            // 
            // ComboReadLimit
            // 
            this.ComboReadLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboReadLimit.FormattingEnabled = true;
            this.ComboReadLimit.Location = new System.Drawing.Point(293, 35);
            this.ComboReadLimit.Name = "ComboReadLimit";
            this.ComboReadLimit.Size = new System.Drawing.Size(152, 20);
            this.ComboReadLimit.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "읽기 제한 등급 :";
            // 
            // txtBoardName
            // 
            this.txtBoardName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoardName.Location = new System.Drawing.Point(235, 11);
            this.txtBoardName.Name = "txtBoardName";
            this.txtBoardName.Size = new System.Drawing.Size(210, 21);
            this.txtBoardName.TabIndex = 4;
            this.txtBoardName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoardName_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "이름 :";
            // 
            // BoardTree
            // 
            this.BoardTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardTree.ContextMenuStrip = this.TreeContextMenu;
            this.BoardTree.ImageIndex = 0;
            this.BoardTree.ImageList = this.TreeImages;
            this.BoardTree.Location = new System.Drawing.Point(3, 6);
            this.BoardTree.Name = "BoardTree";
            this.BoardTree.SelectedImageIndex = 0;
            this.BoardTree.Size = new System.Drawing.Size(185, 313);
            this.BoardTree.TabIndex = 0;
            this.BoardTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BoardTree_AfterSelect);
            this.BoardTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.BoardTree_BeforeSelect);
            // 
            // TreeContextMenu
            // 
            this.TreeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.게시판추가ToolStripMenuItem,
            this.그룹추가ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.TreeContextMenu.Name = "TreeContextMenu";
            this.TreeContextMenu.Size = new System.Drawing.Size(165, 70);
            // 
            // 게시판추가ToolStripMenuItem
            // 
            this.게시판추가ToolStripMenuItem.Name = "게시판추가ToolStripMenuItem";
            this.게시판추가ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.게시판추가ToolStripMenuItem.Text = "게시판 추가";
            this.게시판추가ToolStripMenuItem.Click += new System.EventHandler(this.게시판추가ToolStripMenuItem_Click);
            // 
            // 그룹추가ToolStripMenuItem
            // 
            this.그룹추가ToolStripMenuItem.Name = "그룹추가ToolStripMenuItem";
            this.그룹추가ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.그룹추가ToolStripMenuItem.Text = "그룹 추가";
            this.그룹추가ToolStripMenuItem.Click += new System.EventHandler(this.그룹추가ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.삭제ToolStripMenuItem.Text = "게시판/그룹 삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // TreeImages
            // 
            this.TreeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImages.ImageStream")));
            this.TreeImages.TransparentColor = System.Drawing.Color.Magenta;
            this.TreeImages.Images.SetKeyName(0, "Board.bmp");
            this.TreeImages.Images.SetKeyName(1, "Tool Folder.bmp");
            this.TreeImages.Images.SetKeyName(2, "download1.bmp");
            // 
            // GradeControl
            // 
            this.GradeControl.Controls.Add(this.NumbericLimitPoint);
            this.GradeControl.Controls.Add(this.chkOperate);
            this.GradeControl.Controls.Add(this.chkDelModify);
            this.GradeControl.Controls.Add(this.chkAbleWrite);
            this.GradeControl.Controls.Add(this.chkAbleRead);
            this.GradeControl.Controls.Add(this.btIconChange);
            this.GradeControl.Controls.Add(this.txtLevelDescription);
            this.GradeControl.Controls.Add(this.label18);
            this.GradeControl.Controls.Add(this.label17);
            this.GradeControl.Controls.Add(this.txtLevelName);
            this.GradeControl.Controls.Add(this.label16);
            this.GradeControl.Controls.Add(this.LevelList);
            this.GradeControl.Location = new System.Drawing.Point(4, 21);
            this.GradeControl.Name = "GradeControl";
            this.GradeControl.Padding = new System.Windows.Forms.Padding(3);
            this.GradeControl.Size = new System.Drawing.Size(453, 328);
            this.GradeControl.TabIndex = 4;
            this.GradeControl.Text = "등 급 관 리";
            this.GradeControl.UseVisualStyleBackColor = true;
            this.GradeControl.Validated += new System.EventHandler(this.tabPage5_Validated);
            this.GradeControl.Leave += new System.EventHandler(this.tabPage5_Leave);
            // 
            // NumbericLimitPoint
            // 
            this.NumbericLimitPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NumbericLimitPoint.Location = new System.Drawing.Point(171, 79);
            this.NumbericLimitPoint.Maximum = new decimal(new int[] {
            2100000000,
            0,
            0,
            0});
            this.NumbericLimitPoint.Name = "NumbericLimitPoint";
            this.NumbericLimitPoint.Size = new System.Drawing.Size(274, 21);
            this.NumbericLimitPoint.TabIndex = 14;
            // 
            // chkOperate
            // 
            this.chkOperate.AutoSize = true;
            this.chkOperate.Location = new System.Drawing.Point(371, 45);
            this.chkOperate.Name = "chkOperate";
            this.chkOperate.Size = new System.Drawing.Size(48, 16);
            this.chkOperate.TabIndex = 13;
            this.chkOperate.Text = "관리";
            this.chkOperate.UseVisualStyleBackColor = true;
            this.chkOperate.CheckedChanged += new System.EventHandler(this.chkOperate_CheckedChanged);
            // 
            // chkDelModify
            // 
            this.chkDelModify.AutoSize = true;
            this.chkDelModify.Location = new System.Drawing.Point(279, 45);
            this.chkDelModify.Name = "chkDelModify";
            this.chkDelModify.Size = new System.Drawing.Size(86, 16);
            this.chkDelModify.TabIndex = 12;
            this.chkDelModify.Text = "삭제 / 수정";
            this.chkDelModify.UseVisualStyleBackColor = true;
            // 
            // chkAbleWrite
            // 
            this.chkAbleWrite.AutoSize = true;
            this.chkAbleWrite.Location = new System.Drawing.Point(225, 45);
            this.chkAbleWrite.Name = "chkAbleWrite";
            this.chkAbleWrite.Size = new System.Drawing.Size(48, 16);
            this.chkAbleWrite.TabIndex = 11;
            this.chkAbleWrite.Text = "쓰기";
            this.chkAbleWrite.UseVisualStyleBackColor = true;
            // 
            // chkAbleRead
            // 
            this.chkAbleRead.AutoSize = true;
            this.chkAbleRead.Location = new System.Drawing.Point(171, 45);
            this.chkAbleRead.Name = "chkAbleRead";
            this.chkAbleRead.Size = new System.Drawing.Size(48, 16);
            this.chkAbleRead.TabIndex = 10;
            this.chkAbleRead.Text = "읽기";
            this.chkAbleRead.UseVisualStyleBackColor = true;
            // 
            // btIconChange
            // 
            this.btIconChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btIconChange.Location = new System.Drawing.Point(6, 299);
            this.btIconChange.Name = "btIconChange";
            this.btIconChange.Size = new System.Drawing.Size(75, 23);
            this.btIconChange.TabIndex = 9;
            this.btIconChange.Text = "아이콘변경";
            this.btIconChange.UseVisualStyleBackColor = true;
            this.btIconChange.Click += new System.EventHandler(this.btIconChange_Click);
            // 
            // txtLevelDescription
            // 
            this.txtLevelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevelDescription.Location = new System.Drawing.Point(171, 118);
            this.txtLevelDescription.Multiline = true;
            this.txtLevelDescription.Name = "txtLevelDescription";
            this.txtLevelDescription.Size = new System.Drawing.Size(274, 175);
            this.txtLevelDescription.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(169, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 7;
            this.label18.Text = "등급 설명 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(243, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "등급 필요 포인트 (10억 이상은 수동입니다.)";
            // 
            // txtLevelName
            // 
            this.txtLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevelName.Location = new System.Drawing.Point(238, 18);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.Size = new System.Drawing.Size(207, 21);
            this.txtLevelName.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(169, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "등급 이름 :";
            // 
            // LevelList
            // 
            this.LevelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.LevelList.AutoArrange = false;
            this.LevelList.ContextMenuStrip = this.LevelContextMenu;
            this.LevelList.HideSelection = false;
            this.LevelList.LabelWrap = false;
            this.LevelList.Location = new System.Drawing.Point(6, 6);
            this.LevelList.MultiSelect = false;
            this.LevelList.Name = "LevelList";
            this.LevelList.Size = new System.Drawing.Size(157, 287);
            this.LevelList.SmallImageList = this.LevelIconImages;
            this.LevelList.TabIndex = 0;
            this.LevelList.UseCompatibleStateImageBehavior = false;
            this.LevelList.View = System.Windows.Forms.View.List;
            this.LevelList.SelectedIndexChanged += new System.EventHandler(this.LevelList_SelectedIndexChanged);
            this.LevelList.Click += new System.EventHandler(this.LevelList_Click);
            // 
            // LevelContextMenu
            // 
            this.LevelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.등급추가ToolStripMenuItem,
            this.등급삭제ToolStripMenuItem});
            this.LevelContextMenu.Name = "LevelContextMenu";
            this.LevelContextMenu.Size = new System.Drawing.Size(126, 48);
            // 
            // 등급추가ToolStripMenuItem
            // 
            this.등급추가ToolStripMenuItem.Name = "등급추가ToolStripMenuItem";
            this.등급추가ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.등급추가ToolStripMenuItem.Text = "등급 추가";
            this.등급추가ToolStripMenuItem.Click += new System.EventHandler(this.등급추가ToolStripMenuItem_Click);
            // 
            // 등급삭제ToolStripMenuItem
            // 
            this.등급삭제ToolStripMenuItem.Name = "등급삭제ToolStripMenuItem";
            this.등급삭제ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.등급삭제ToolStripMenuItem.Text = "등급 삭제";
            this.등급삭제ToolStripMenuItem.Click += new System.EventHandler(this.등급삭제ToolStripMenuItem_Click);
            // 
            // LevelIconImages
            // 
            this.LevelIconImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.LevelIconImages.ImageSize = new System.Drawing.Size(16, 16);
            this.LevelIconImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btBanOpen);
            this.tabPage6.Controls.Add(this.btIPBan);
            this.tabPage6.Controls.Add(this.IPBanCombo);
            this.tabPage6.Controls.Add(this.IPBanList);
            this.tabPage6.Location = new System.Drawing.Point(4, 21);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(453, 328);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "밴 설 정";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btBanOpen
            // 
            this.btBanOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBanOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBanOpen.Image = global::CyberLibrary2.Properties.Resources._24_security_lock_open;
            this.btBanOpen.Location = new System.Drawing.Point(421, 298);
            this.btBanOpen.Name = "btBanOpen";
            this.btBanOpen.Size = new System.Drawing.Size(24, 24);
            this.btBanOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btBanOpen.TabIndex = 3;
            this.btBanOpen.TabStop = false;
            this.btBanOpen.Click += new System.EventHandler(this.btBanOpen_Click);
            // 
            // btIPBan
            // 
            this.btIPBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btIPBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIPBan.Image = global::CyberLibrary2.Properties.Resources._24_security_lock;
            this.btIPBan.Location = new System.Drawing.Point(227, 298);
            this.btIPBan.Name = "btIPBan";
            this.btIPBan.Size = new System.Drawing.Size(24, 24);
            this.btIPBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btIPBan.TabIndex = 2;
            this.btIPBan.TabStop = false;
            this.btIPBan.Click += new System.EventHandler(this.btIPBan_Click);
            // 
            // IPBanCombo
            // 
            this.IPBanCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IPBanCombo.FormattingEnabled = true;
            this.IPBanCombo.Location = new System.Drawing.Point(8, 302);
            this.IPBanCombo.Name = "IPBanCombo";
            this.IPBanCombo.Size = new System.Drawing.Size(213, 20);
            this.IPBanCombo.TabIndex = 1;
            // 
            // IPBanList
            // 
            this.IPBanList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IPBanList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPBanList.FormattingEnabled = true;
            this.IPBanList.ItemHeight = 12;
            this.IPBanList.Location = new System.Drawing.Point(8, 6);
            this.IPBanList.Name = "IPBanList";
            this.IPBanList.Size = new System.Drawing.Size(437, 290);
            this.IPBanList.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.NumericThreadSleep);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Controls.Add(this.NumericCommentWriteLimitTime);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Controls.Add(this.NumericWriteLimitTime);
            this.tabPage7.Controls.Add(this.label3);
            this.tabPage7.Controls.Add(this.MaxConnectSize);
            this.tabPage7.Controls.Add(this.label2);
            this.tabPage7.Controls.Add(this.txtJoinGuide);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Location = new System.Drawing.Point(4, 21);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(453, 328);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "기 타 설 정";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // NumericThreadSleep
            // 
            this.NumericThreadSleep.Location = new System.Drawing.Point(161, 254);
            this.NumericThreadSleep.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericThreadSleep.Name = "NumericThreadSleep";
            this.NumericThreadSleep.Size = new System.Drawing.Size(284, 21);
            this.NumericThreadSleep.TabIndex = 2;
            this.NumericThreadSleep.ValueChanged += new System.EventHandler(this.NumericThreadSleep_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "쓰레드 슬립 시간 (밀리초) : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NumericCommentWriteLimitTime
            // 
            this.NumericCommentWriteLimitTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericCommentWriteLimitTime.Location = new System.Drawing.Point(161, 232);
            this.NumericCommentWriteLimitTime.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericCommentWriteLimitTime.Name = "NumericCommentWriteLimitTime";
            this.NumericCommentWriteLimitTime.Size = new System.Drawing.Size(284, 21);
            this.NumericCommentWriteLimitTime.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "덧글 쓰기 시간 제한 (초) :";
            // 
            // NumericWriteLimitTime
            // 
            this.NumericWriteLimitTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericWriteLimitTime.Location = new System.Drawing.Point(149, 210);
            this.NumericWriteLimitTime.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumericWriteLimitTime.Name = "NumericWriteLimitTime";
            this.NumericWriteLimitTime.Size = new System.Drawing.Size(296, 21);
            this.NumericWriteLimitTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "글쓰기 시간 제한 (초) : ";
            // 
            // MaxConnectSize
            // 
            this.MaxConnectSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxConnectSize.Location = new System.Drawing.Point(99, 187);
            this.MaxConnectSize.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.MaxConnectSize.Name = "MaxConnectSize";
            this.MaxConnectSize.Size = new System.Drawing.Size(346, 21);
            this.MaxConnectSize.TabIndex = 3;
            this.MaxConnectSize.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "접속 제한 인원";
            // 
            // txtJoinGuide
            // 
            this.txtJoinGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJoinGuide.Location = new System.Drawing.Point(10, 29);
            this.txtJoinGuide.Multiline = true;
            this.txtJoinGuide.Name = "txtJoinGuide";
            this.txtJoinGuide.Size = new System.Drawing.Size(435, 145);
            this.txtJoinGuide.TabIndex = 1;
            this.txtJoinGuide.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원가입 안내문";
            // 
            // NetworkServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(461, 352);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NetworkServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "네트워크 열기";
            this.Load += new System.EventHandler(this.NetworkServerForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkServerForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).EndInit();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUserDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUserAdd)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.BoardControl.ResumeLayout(false);
            this.BoardControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericWriteAddPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericReadSubPoint)).EndInit();
            this.TreeContextMenu.ResumeLayout(false);
            this.GradeControl.ResumeLayout(false);
            this.GradeControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericLimitPoint)).EndInit();
            this.LevelContextMenu.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btBanOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btIPBan)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericThreadSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCommentWriteLimitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWriteLimitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxConnectSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.TabPage UserPanel;
        private System.Windows.Forms.Label labelPortNumber;
        private System.Windows.Forms.Button btOpenServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage BoardControl;
        private System.Windows.Forms.Label labelConnectedUserCount;
        private System.Windows.Forms.Label labelAllUserCount;
        private System.Windows.Forms.ListView UserList;
        private System.Windows.Forms.ColumnHeader ColumnUserID;
        private System.Windows.Forms.ColumnHeader ColumnUserState;
        private System.Windows.Forms.ColumnHeader ColumnUserLevel;
        private System.Windows.Forms.Button btClearUserMessage;
        private System.Windows.Forms.ColumnHeader ColumnContext;
        private System.Windows.Forms.ColumnHeader ColumnSendID;
        private System.Windows.Forms.ColumnHeader ColumnSendTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btNoticeFloat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage GradeControl;
        private System.Windows.Forms.TreeView BoardTree;
        private System.Windows.Forms.ImageList TreeImages;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoardName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboWriteLimit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ComboReadLimit;
        private System.Windows.Forms.TextBox txtBoardDecription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView LevelList;
        private System.Windows.Forms.TextBox txtLevelDescription;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btIconChange;
        private System.Windows.Forms.ContextMenuStrip TreeContextMenu;
        private System.Windows.Forms.ContextMenuStrip LevelContextMenu;
        private System.Windows.Forms.CheckBox chkOperate;
        private System.Windows.Forms.CheckBox chkDelModify;
        private System.Windows.Forms.CheckBox chkAbleWrite;
        private System.Windows.Forms.CheckBox chkAbleRead;
        private System.Windows.Forms.ToolStripMenuItem 게시판추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그룹추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 등급추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 등급삭제ToolStripMenuItem;
        private System.Windows.Forms.ImageList LevelIconImages;
        private System.Windows.Forms.NumericUpDown NumbericWriteAddPoint;
        private System.Windows.Forms.NumericUpDown NumbericReadSubPoint;
        private System.Windows.Forms.NumericUpDown NumbericLimitPoint;
        private System.Windows.Forms.NumericUpDown PortNumber;
        private System.Windows.Forms.PictureBox btSave;
        private System.Windows.Forms.PictureBox btOpen;
        private System.Windows.Forms.PictureBox btUserAdd;
        private System.Windows.Forms.PictureBox btUserDel;
        private System.Windows.Forms.PictureBox btModify;
        private System.Windows.Forms.ImageList EventImageList;
        public System.Windows.Forms.ListView EventList;
        private System.Windows.Forms.PictureBox btLock;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox btBanOpen;
        private System.Windows.Forms.PictureBox btIPBan;
        private System.Windows.Forms.ComboBox IPBanCombo;
        public System.Windows.Forms.ListBox IPBanList;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtJoinGuide;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown MaxConnectSize;
        public System.Windows.Forms.ListView UserMessageList;
        public System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumericWriteLimitTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericCommentWriteLimitTime;
        private System.Windows.Forms.NumericUpDown NumericThreadSleep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btXMLOpen;
        private System.Windows.Forms.Button btXMLSave;
        public System.Windows.Forms.TextBox txtServerName;

    }
}