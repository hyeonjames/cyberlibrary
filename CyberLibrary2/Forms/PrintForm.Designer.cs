namespace CyberLibrary2.Forms
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.chkMemoTop = new System.Windows.Forms.CheckBox();
            this.chkMemoBottom = new System.Windows.Forms.CheckBox();
            this.chkMemoMiddle = new System.Windows.Forms.CheckBox();
            this.btPrint = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.NumbericMemoFontSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumbericMemoFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMemoTop
            // 
            this.chkMemoTop.AutoSize = true;
            this.chkMemoTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMemoTop.Location = new System.Drawing.Point(22, 12);
            this.chkMemoTop.Name = "chkMemoTop";
            this.chkMemoTop.Size = new System.Drawing.Size(113, 16);
            this.chkMemoTop.TabIndex = 0;
            this.chkMemoTop.Text = "메모 상단에 표시";
            this.chkMemoTop.UseVisualStyleBackColor = true;
            // 
            // chkMemoBottom
            // 
            this.chkMemoBottom.AutoSize = true;
            this.chkMemoBottom.Checked = true;
            this.chkMemoBottom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMemoBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMemoBottom.Location = new System.Drawing.Point(22, 34);
            this.chkMemoBottom.Name = "chkMemoBottom";
            this.chkMemoBottom.Size = new System.Drawing.Size(113, 16);
            this.chkMemoBottom.TabIndex = 1;
            this.chkMemoBottom.Text = "메모 하단에 표시";
            this.chkMemoBottom.UseVisualStyleBackColor = true;
            // 
            // chkMemoMiddle
            // 
            this.chkMemoMiddle.AutoSize = true;
            this.chkMemoMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMemoMiddle.Location = new System.Drawing.Point(22, 56);
            this.chkMemoMiddle.Name = "chkMemoMiddle";
            this.chkMemoMiddle.Size = new System.Drawing.Size(113, 16);
            this.chkMemoMiddle.TabIndex = 2;
            this.chkMemoMiddle.Text = "메모 중단에 표시";
            this.chkMemoMiddle.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPrint.Location = new System.Drawing.Point(107, 103);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 23);
            this.btPrint.TabIndex = 3;
            this.btPrint.Text = "인쇄";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(188, 103);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "취소";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btView
            // 
            this.btView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btView.Location = new System.Drawing.Point(23, 103);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 5;
            this.btView.Text = "미리 보기";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click_1);
            // 
            // NumbericMemoFontSize
            // 
            this.NumbericMemoFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NumbericMemoFontSize.Location = new System.Drawing.Point(112, 76);
            this.NumbericMemoFontSize.Name = "NumbericMemoFontSize";
            this.NumbericMemoFontSize.Size = new System.Drawing.Size(151, 21);
            this.NumbericMemoFontSize.TabIndex = 6;
            this.NumbericMemoFontSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "메모 글씨 크기";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 138);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumbericMemoFontSize);
            this.Controls.Add(this.chkMemoTop);
            this.Controls.Add(this.chkMemoBottom);
            this.Controls.Add(this.chkMemoMiddle);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "프린트 하기 - CyberLibrary";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumbericMemoFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMemoTop;
        private System.Windows.Forms.CheckBox chkMemoBottom;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.CheckBox chkMemoMiddle;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.NumericUpDown NumbericMemoFontSize;
        private System.Windows.Forms.Label label1;

    }
}