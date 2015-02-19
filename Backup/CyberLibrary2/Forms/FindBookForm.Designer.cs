namespace CyberLibrary2.Forms
{
    partial class FindBookForm
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
            this.chkBookName = new System.Windows.Forms.CheckBox();
            this.chkWriterName = new System.Windows.Forms.CheckBox();
            this.chkTransferName = new System.Windows.Forms.CheckBox();
            this.chkGroupName = new System.Windows.Forms.CheckBox();
            this.txtScanText = new System.Windows.Forms.TextBox();
            this.btScan = new System.Windows.Forms.Button();
            this.FindListView = new System.Windows.Forms.ListView();
            this.Column_BookName = new System.Windows.Forms.ColumnHeader();
            this.Column_BookPath = new System.Windows.Forms.ColumnHeader();
            this.Column_FoundInfo = new System.Windows.Forms.ColumnHeader();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkBookName
            // 
            this.chkBookName.AutoSize = true;
            this.chkBookName.Location = new System.Drawing.Point(12, 12);
            this.chkBookName.Name = "chkBookName";
            this.chkBookName.Size = new System.Drawing.Size(64, 16);
            this.chkBookName.TabIndex = 1;
            this.chkBookName.Text = "책 이름";
            this.chkBookName.UseVisualStyleBackColor = true;
            // 
            // chkWriterName
            // 
            this.chkWriterName.AutoSize = true;
            this.chkWriterName.Location = new System.Drawing.Point(164, 12);
            this.chkWriterName.Name = "chkWriterName";
            this.chkWriterName.Size = new System.Drawing.Size(76, 16);
            this.chkWriterName.TabIndex = 2;
            this.chkWriterName.Text = "작가 이름";
            this.chkWriterName.UseVisualStyleBackColor = true;
            // 
            // chkTransferName
            // 
            this.chkTransferName.AutoSize = true;
            this.chkTransferName.Location = new System.Drawing.Point(246, 12);
            this.chkTransferName.Name = "chkTransferName";
            this.chkTransferName.Size = new System.Drawing.Size(88, 16);
            this.chkTransferName.TabIndex = 3;
            this.chkTransferName.Text = "옮김이 이름";
            this.chkTransferName.UseVisualStyleBackColor = true;
            // 
            // chkGroupName
            // 
            this.chkGroupName.AutoSize = true;
            this.chkGroupName.Location = new System.Drawing.Point(82, 12);
            this.chkGroupName.Name = "chkGroupName";
            this.chkGroupName.Size = new System.Drawing.Size(76, 16);
            this.chkGroupName.TabIndex = 5;
            this.chkGroupName.Text = "그룹 이름";
            this.chkGroupName.UseVisualStyleBackColor = true;
            // 
            // txtScanText
            // 
            this.txtScanText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScanText.Location = new System.Drawing.Point(12, 34);
            this.txtScanText.Name = "txtScanText";
            this.txtScanText.Size = new System.Drawing.Size(335, 21);
            this.txtScanText.TabIndex = 6;
            this.txtScanText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanText_KeyPress);
            // 
            // btScan
            // 
            this.btScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btScan.Location = new System.Drawing.Point(353, 34);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(68, 21);
            this.btScan.TabIndex = 7;
            this.btScan.Text = "검색";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // FindListView
            // 
            this.FindListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FindListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column_BookName,
            this.Column_BookPath,
            this.Column_FoundInfo});
            this.FindListView.Location = new System.Drawing.Point(12, 61);
            this.FindListView.Name = "FindListView";
            this.FindListView.Size = new System.Drawing.Size(409, 153);
            this.FindListView.TabIndex = 8;
            this.FindListView.UseCompatibleStateImageBehavior = false;
            this.FindListView.View = System.Windows.Forms.View.Details;
            this.FindListView.SizeChanged += new System.EventHandler(this.FindListView_SizeChanged);
            // 
            // Column_BookName
            // 
            this.Column_BookName.Text = "책 이름";
            this.Column_BookName.Width = 75;
            // 
            // Column_BookPath
            // 
            this.Column_BookPath.Text = "책 경로";
            this.Column_BookPath.Width = 222;
            // 
            // Column_FoundInfo
            // 
            this.Column_FoundInfo.Text = "발견 정보";
            this.Column_FoundInfo.Width = 107;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(346, 220);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "취소";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.Location = new System.Drawing.Point(265, 220);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 10;
            this.btOK.Text = "확인";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 250);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.FindListView);
            this.Controls.Add(this.btScan);
            this.Controls.Add(this.txtScanText);
            this.Controls.Add(this.chkGroupName);
            this.Controls.Add(this.chkTransferName);
            this.Controls.Add(this.chkWriterName);
            this.Controls.Add(this.chkBookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "검색";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBookName;
        private System.Windows.Forms.CheckBox chkWriterName;
        private System.Windows.Forms.CheckBox chkTransferName;
        private System.Windows.Forms.CheckBox chkGroupName;
        private System.Windows.Forms.TextBox txtScanText;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.ListView FindListView;
        private System.Windows.Forms.ColumnHeader Column_BookName;
        private System.Windows.Forms.ColumnHeader Column_BookPath;
        private System.Windows.Forms.ColumnHeader Column_FoundInfo;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;

    }
}