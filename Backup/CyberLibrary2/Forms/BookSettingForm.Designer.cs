namespace CyberLibrary2.Forms
{
    partial class BookSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSettingForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btStructureToHyperGroup = new System.Windows.Forms.Button();
            this.btBackgroundImage = new System.Windows.Forms.Button();
            this.txtExplainStructure = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPageIndex = new System.Windows.Forms.TextBox();
            this.txtStructureName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StructureTree = new System.Windows.Forms.TreeView();
            this.TreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그룹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.페이지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTransferName = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TreeMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btStructureToHyperGroup);
            this.tabPage1.Controls.Add(this.btBackgroundImage);
            this.tabPage1.Controls.Add(this.txtExplainStructure);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtPageIndex);
            this.tabPage1.Controls.Add(this.txtStructureName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.StructureTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "구조 설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btStructureToHyperGroup
            // 
            this.btStructureToHyperGroup.Location = new System.Drawing.Point(8, 301);
            this.btStructureToHyperGroup.Name = "btStructureToHyperGroup";
            this.btStructureToHyperGroup.Size = new System.Drawing.Size(204, 23);
            this.btStructureToHyperGroup.TabIndex = 1;
            this.btStructureToHyperGroup.Text = "이 구조를 즐겨찾기로 추가합니다.";
            this.btStructureToHyperGroup.UseVisualStyleBackColor = true;
            this.btStructureToHyperGroup.Click += new System.EventHandler(this.btStructureToHyperGroup_Click);
            // 
            // btBackgroundImage
            // 
            this.btBackgroundImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBackgroundImage.Enabled = false;
            this.btBackgroundImage.Location = new System.Drawing.Point(394, 301);
            this.btBackgroundImage.Name = "btBackgroundImage";
            this.btBackgroundImage.Size = new System.Drawing.Size(75, 23);
            this.btBackgroundImage.TabIndex = 16;
            this.btBackgroundImage.Text = "배경이미지";
            this.btBackgroundImage.UseVisualStyleBackColor = true;
            this.btBackgroundImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtExplainStructure
            // 
            this.txtExplainStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplainStructure.Enabled = false;
            this.txtExplainStructure.Location = new System.Drawing.Point(177, 124);
            this.txtExplainStructure.Multiline = true;
            this.txtExplainStructure.Name = "txtExplainStructure";
            this.txtExplainStructure.Size = new System.Drawing.Size(292, 174);
            this.txtExplainStructure.TabIndex = 14;
            this.txtExplainStructure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStructureName_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "페이지 / 그룹 요약 :";
            // 
            // txtPageIndex
            // 
            this.txtPageIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageIndex.Enabled = false;
            this.txtPageIndex.Location = new System.Drawing.Point(177, 80);
            this.txtPageIndex.Name = "txtPageIndex";
            this.txtPageIndex.Size = new System.Drawing.Size(292, 21);
            this.txtPageIndex.TabIndex = 8;
            this.txtPageIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStructureName_KeyPress);
            // 
            // txtStructureName
            // 
            this.txtStructureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStructureName.Enabled = false;
            this.txtStructureName.Location = new System.Drawing.Point(177, 37);
            this.txtStructureName.Name = "txtStructureName";
            this.txtStructureName.Size = new System.Drawing.Size(292, 21);
            this.txtStructureName.TabIndex = 7;
            this.txtStructureName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStructureName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "페이지 인덱스 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "페이지/그룹 이름 : ";
            // 
            // StructureTree
            // 
            this.StructureTree.AllowDrop = true;
            this.StructureTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.StructureTree.ContextMenuStrip = this.TreeMenu;
            this.StructureTree.ImageIndex = 0;
            this.StructureTree.ImageList = this.TreeImageList;
            this.StructureTree.Location = new System.Drawing.Point(6, 6);
            this.StructureTree.Name = "StructureTree";
            this.StructureTree.SelectedImageIndex = 0;
            this.StructureTree.Size = new System.Drawing.Size(163, 292);
            this.StructureTree.TabIndex = 0;
            this.StructureTree.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.StructureTree_QueryContinueDrag);
            this.StructureTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StructureTree_MouseUp);
            this.StructureTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.StructureTree_DragDrop);
            this.StructureTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.StructureTree_AfterSelect);
            this.StructureTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StructureTree_MouseDown);
            this.StructureTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.StructureTree_BeforeSelect);
            this.StructureTree.DragOver += new System.Windows.Forms.DragEventHandler(this.StructureTree_DragOver);
            // 
            // TreeMenu
            // 
            this.TreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.TreeMenu.Name = "TreeMenu";
            this.TreeMenu.Size = new System.Drawing.Size(99, 48);
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그룹ToolStripMenuItem,
            this.페이지ToolStripMenuItem});
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.추가ToolStripMenuItem.Text = "추가";
            // 
            // 그룹ToolStripMenuItem
            // 
            this.그룹ToolStripMenuItem.Name = "그룹ToolStripMenuItem";
            this.그룹ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.그룹ToolStripMenuItem.Text = "그룹";
            this.그룹ToolStripMenuItem.Click += new System.EventHandler(this.그룹ToolStripMenuItem_Click);
            // 
            // 페이지ToolStripMenuItem
            // 
            this.페이지ToolStripMenuItem.Name = "페이지ToolStripMenuItem";
            this.페이지ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.페이지ToolStripMenuItem.Text = "페이지";
            this.페이지ToolStripMenuItem.Click += new System.EventHandler(this.페이지ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // TreeImageList
            // 
            this.TreeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeImageList.ImageStream")));
            this.TreeImageList.TransparentColor = System.Drawing.Color.Magenta;
            this.TreeImageList.Images.SetKeyName(0, "Tool Folder.bmp");
            this.TreeImageList.Images.SetKeyName(1, "download1.bmp");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTransferName);
            this.tabPage2.Controls.Add(this.txtWriter);
            this.tabPage2.Controls.Add(this.txtExplain);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtBookName);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "정보 설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTransferName
            // 
            this.txtTransferName.Location = new System.Drawing.Point(79, 38);
            this.txtTransferName.Name = "txtTransferName";
            this.txtTransferName.Size = new System.Drawing.Size(172, 21);
            this.txtTransferName.TabIndex = 7;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(327, 11);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(147, 21);
            this.txtWriter.TabIndex = 6;
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExplain.Location = new System.Drawing.Point(22, 80);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(442, 213);
            this.txtExplain.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "책 설명 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "책 옮김 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "책 지은이 : ";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(79, 11);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(172, 21);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "책 이름 :";
            // 
            // BookSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(490, 352);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BookSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "책 설정";
            this.Load += new System.EventHandler(this.BookSettingForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookSettingForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TreeMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView StructureTree;
        private System.Windows.Forms.ImageList TreeImageList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip TreeMenu;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그룹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 페이지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPageIndex;
        private System.Windows.Forms.TextBox txtStructureName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTransferName;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtExplainStructure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btBackgroundImage;
        private System.Windows.Forms.Button btStructureToHyperGroup;
    }
}