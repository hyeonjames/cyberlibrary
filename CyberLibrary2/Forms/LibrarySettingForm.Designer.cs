namespace CyberLibrary2.Forms
{
    partial class LibrarySettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarySettingForm));
            this.chkMemoTopView = new System.Windows.Forms.CheckBox();
            this.chkBackGroundImageView = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMemoView = new System.Windows.Forms.CheckBox();
            this.btFontSet = new System.Windows.Forms.Button();
            this.btFont = new System.Windows.Forms.Button();
            this.btBackColor = new System.Windows.Forms.Button();
            this.ComboMemoFont = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboMemoFontColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboMemoBackColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMemoMiddleView = new System.Windows.Forms.CheckBox();
            this.chkMemoBottomView = new System.Windows.Forms.CheckBox();
            this.chkMemo = new System.Windows.Forms.CheckBox();
            this.BackColorDialog = new System.Windows.Forms.ColorDialog();
            this.FontColorDialog = new System.Windows.Forms.ColorDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNone = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboKeys = new System.Windows.Forms.ComboBox();
            this.chkShift = new System.Windows.Forms.CheckBox();
            this.chkAlt = new System.Windows.Forms.CheckBox();
            this.chkControl = new System.Windows.Forms.CheckBox();
            this.ListMenu = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkMemoTopView
            // 
            this.chkMemoTopView.AutoSize = true;
            this.chkMemoTopView.Location = new System.Drawing.Point(158, 42);
            this.chkMemoTopView.Name = "chkMemoTopView";
            this.chkMemoTopView.Size = new System.Drawing.Size(128, 16);
            this.chkMemoTopView.TabIndex = 0;
            this.chkMemoTopView.Text = "메모 내용 상단표시";
            this.chkMemoTopView.UseVisualStyleBackColor = true;
            // 
            // chkBackGroundImageView
            // 
            this.chkBackGroundImageView.AutoSize = true;
            this.chkBackGroundImageView.Location = new System.Drawing.Point(302, 42);
            this.chkBackGroundImageView.Name = "chkBackGroundImageView";
            this.chkBackGroundImageView.Size = new System.Drawing.Size(116, 16);
            this.chkBackGroundImageView.TabIndex = 1;
            this.chkBackGroundImageView.Text = "배경 이미지 표시";
            this.chkBackGroundImageView.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkMemoView);
            this.groupBox1.Controls.Add(this.btFontSet);
            this.groupBox1.Controls.Add(this.btFont);
            this.groupBox1.Controls.Add(this.btBackColor);
            this.groupBox1.Controls.Add(this.ComboMemoFont);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboMemoFontColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboMemoBackColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkMemoMiddleView);
            this.groupBox1.Controls.Add(this.chkMemoBottomView);
            this.groupBox1.Controls.Add(this.chkMemo);
            this.groupBox1.Controls.Add(this.chkMemoTopView);
            this.groupBox1.Controls.Add(this.chkBackGroundImageView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "책 기본 설정";
            // 
            // chkMemoView
            // 
            this.chkMemoView.AutoSize = true;
            this.chkMemoView.Location = new System.Drawing.Point(105, 20);
            this.chkMemoView.Name = "chkMemoView";
            this.chkMemoView.Size = new System.Drawing.Size(100, 16);
            this.chkMemoView.TabIndex = 14;
            this.chkMemoView.Text = "메모구역 표시";
            this.chkMemoView.UseVisualStyleBackColor = true;
            // 
            // btFontSet
            // 
            this.btFontSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFontSet.Location = new System.Drawing.Point(221, 101);
            this.btFontSet.Name = "btFontSet";
            this.btFontSet.Size = new System.Drawing.Size(75, 23);
            this.btFontSet.TabIndex = 13;
            this.btFontSet.Text = "자세히..";
            this.btFontSet.UseVisualStyleBackColor = true;
            this.btFontSet.Click += new System.EventHandler(this.btFontSet_Click);
            // 
            // btFont
            // 
            this.btFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFont.Location = new System.Drawing.Point(238, 80);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(58, 20);
            this.btFont.TabIndex = 3;
            this.btFont.Text = "자세히..";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // btBackColor
            // 
            this.btBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBackColor.Location = new System.Drawing.Point(238, 58);
            this.btBackColor.Name = "btBackColor";
            this.btBackColor.Size = new System.Drawing.Size(58, 20);
            this.btBackColor.TabIndex = 3;
            this.btBackColor.Text = "자세히..";
            this.btBackColor.UseVisualStyleBackColor = true;
            this.btBackColor.Click += new System.EventHandler(this.btBackColor_Click);
            // 
            // ComboMemoFont
            // 
            this.ComboMemoFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboMemoFont.FormattingEnabled = true;
            this.ComboMemoFont.Items.AddRange(new object[] {
            "Default"});
            this.ComboMemoFont.Location = new System.Drawing.Point(105, 103);
            this.ComboMemoFont.Name = "ComboMemoFont";
            this.ComboMemoFont.Size = new System.Drawing.Size(111, 20);
            this.ComboMemoFont.TabIndex = 10;
            this.ComboMemoFont.SelectedIndexChanged += new System.EventHandler(this.ComboMemoFont_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "메모 기본 폰트 :";
            // 
            // ComboMemoFontColor
            // 
            this.ComboMemoFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboMemoFontColor.FormattingEnabled = true;
            this.ComboMemoFontColor.Items.AddRange(new object[] {
            "?????",
            "Default"});
            this.ComboMemoFontColor.Location = new System.Drawing.Point(111, 80);
            this.ComboMemoFontColor.Name = "ComboMemoFontColor";
            this.ComboMemoFontColor.Size = new System.Drawing.Size(121, 20);
            this.ComboMemoFontColor.TabIndex = 8;
            this.ComboMemoFontColor.SelectedIndexChanged += new System.EventHandler(this.ComboMemoFontColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "메모 기본 폰트색 : ";
            // 
            // ComboMemoBackColor
            // 
            this.ComboMemoBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboMemoBackColor.FormattingEnabled = true;
            this.ComboMemoBackColor.Items.AddRange(new object[] {
            "?????",
            "Default"});
            this.ComboMemoBackColor.Location = new System.Drawing.Point(111, 58);
            this.ComboMemoBackColor.Name = "ComboMemoBackColor";
            this.ComboMemoBackColor.Size = new System.Drawing.Size(121, 20);
            this.ComboMemoBackColor.TabIndex = 6;
            this.ComboMemoBackColor.SelectedIndexChanged += new System.EventHandler(this.ComboMemoBackColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "메모 기본 배경색 : ";
            // 
            // chkMemoMiddleView
            // 
            this.chkMemoMiddleView.AutoSize = true;
            this.chkMemoMiddleView.Location = new System.Drawing.Point(6, 42);
            this.chkMemoMiddleView.Name = "chkMemoMiddleView";
            this.chkMemoMiddleView.Size = new System.Drawing.Size(132, 16);
            this.chkMemoMiddleView.TabIndex = 4;
            this.chkMemoMiddleView.Text = "메모 내용 중간 표시";
            this.chkMemoMiddleView.UseVisualStyleBackColor = true;
            // 
            // chkMemoBottomView
            // 
            this.chkMemoBottomView.AutoSize = true;
            this.chkMemoBottomView.Location = new System.Drawing.Point(222, 20);
            this.chkMemoBottomView.Name = "chkMemoBottomView";
            this.chkMemoBottomView.Size = new System.Drawing.Size(128, 16);
            this.chkMemoBottomView.TabIndex = 3;
            this.chkMemoBottomView.Text = "메모 내용 하단표시";
            this.chkMemoBottomView.UseVisualStyleBackColor = true;
            // 
            // chkMemo
            // 
            this.chkMemo.AutoSize = true;
            this.chkMemo.Location = new System.Drawing.Point(6, 20);
            this.chkMemo.Name = "chkMemo";
            this.chkMemo.Size = new System.Drawing.Size(76, 16);
            this.chkMemo.TabIndex = 2;
            this.chkMemo.Text = "메모 사용";
            this.chkMemo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkNone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComboKeys);
            this.groupBox2.Controls.Add(this.chkShift);
            this.groupBox2.Controls.Add(this.chkAlt);
            this.groupBox2.Controls.Add(this.chkControl);
            this.groupBox2.Controls.Add(this.ListMenu);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 142);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "핫키 설정";
            // 
            // chkNone
            // 
            this.chkNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNone.AutoSize = true;
            this.chkNone.Location = new System.Drawing.Point(158, 55);
            this.chkNone.Name = "chkNone";
            this.chkNone.Size = new System.Drawing.Size(168, 16);
            this.chkNone.TabIndex = 7;
            this.chkNone.Text = "핫키 사용하지 않음(None)";
            this.chkNone.UseVisualStyleBackColor = true;
            this.chkNone.CheckedChanged += new System.EventHandler(this.chkNone_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "키 :";
            // 
            // ComboKeys
            // 
            this.ComboKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboKeys.FormattingEnabled = true;
            this.ComboKeys.Location = new System.Drawing.Point(189, 71);
            this.ComboKeys.Name = "ComboKeys";
            this.ComboKeys.Size = new System.Drawing.Size(212, 20);
            this.ComboKeys.TabIndex = 4;
            this.ComboKeys.SelectedIndexChanged += new System.EventHandler(this.ComboKeys_SelectedIndexChanged);
            // 
            // chkShift
            // 
            this.chkShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShift.AutoSize = true;
            this.chkShift.Location = new System.Drawing.Point(251, 33);
            this.chkShift.Name = "chkShift";
            this.chkShift.Size = new System.Drawing.Size(48, 16);
            this.chkShift.TabIndex = 3;
            this.chkShift.Text = "Shift";
            this.chkShift.UseVisualStyleBackColor = true;
            this.chkShift.CheckedChanged += new System.EventHandler(this.chkShift_CheckedChanged);
            // 
            // chkAlt
            // 
            this.chkAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAlt.AutoSize = true;
            this.chkAlt.Location = new System.Drawing.Point(207, 33);
            this.chkAlt.Name = "chkAlt";
            this.chkAlt.Size = new System.Drawing.Size(38, 16);
            this.chkAlt.TabIndex = 2;
            this.chkAlt.Text = "Alt";
            this.chkAlt.UseVisualStyleBackColor = true;
            this.chkAlt.CheckedChanged += new System.EventHandler(this.chkAlt_CheckedChanged);
            // 
            // chkControl
            // 
            this.chkControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkControl.AutoSize = true;
            this.chkControl.Location = new System.Drawing.Point(158, 33);
            this.chkControl.Name = "chkControl";
            this.chkControl.Size = new System.Drawing.Size(43, 16);
            this.chkControl.TabIndex = 1;
            this.chkControl.Text = "Ctrl";
            this.chkControl.UseVisualStyleBackColor = true;
            this.chkControl.CheckedChanged += new System.EventHandler(this.chkControl_CheckedChanged);
            // 
            // ListMenu
            // 
            this.ListMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListMenu.FormattingEnabled = true;
            this.ListMenu.ItemHeight = 12;
            this.ListMenu.Items.AddRange(new object[] {
            "다음 페이지로",
            "이전 페이지로",
            "크게 보기",
            "책 찾기(네트워크 모드 X)",
            "책 설정(에디터)",
            "텍스트 삽입(에디터)",
            "이미지 삽입(에디터)",
            "원 그리기(에디터)",
            "꽉 찬 원그리기(에디터)",
            "사각형 그리기(에디터)",
            "꽉 찬 사각형 그리기(에디터)",
            "선 그리기(에디터)",
            "메모 삽입(에디터)",
            "지우개 (에디터)",
            "마우스로 (에디터)",
            "빠르게 가기",
            "색 설정(에디터)",
            "굵기 설정(에디터)"});
            this.ListMenu.Location = new System.Drawing.Point(8, 20);
            this.ListMenu.Name = "ListMenu";
            this.ListMenu.Size = new System.Drawing.Size(144, 112);
            this.ListMenu.TabIndex = 0;
            this.ListMenu.SelectedIndexChanged += new System.EventHandler(this.ListMenu_SelectedIndexChanged);
            // 
            // LibrarySettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(448, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibrarySettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "라이브러리 설정";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFontSet;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.Button btBackColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ListMenu;
        private System.Windows.Forms.CheckBox chkShift;
        private System.Windows.Forms.CheckBox chkAlt;
        private System.Windows.Forms.CheckBox chkControl;
        private System.Windows.Forms.ComboBox ComboKeys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNone;
        public System.Windows.Forms.ColorDialog BackColorDialog;
        public System.Windows.Forms.ColorDialog FontColorDialog;
        public System.Windows.Forms.FontDialog FontDialog;
        public System.Windows.Forms.CheckBox chkMemoTopView;
        public System.Windows.Forms.CheckBox chkBackGroundImageView;
        public System.Windows.Forms.CheckBox chkMemo;
        public System.Windows.Forms.CheckBox chkMemoMiddleView;
        public System.Windows.Forms.CheckBox chkMemoBottomView;
        public System.Windows.Forms.ComboBox ComboMemoBackColor;
        public System.Windows.Forms.ComboBox ComboMemoFont;
        public System.Windows.Forms.ComboBox ComboMemoFontColor;
        public System.Windows.Forms.CheckBox chkMemoView;
    }
}