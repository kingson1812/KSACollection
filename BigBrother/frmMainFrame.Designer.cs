namespace BigBrother
{
    partial class frmMainFrame
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
            this.pnlLeftWindow = new System.Windows.Forms.Panel();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.picEN = new System.Windows.Forms.PictureBox();
            this.picVI = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.cboListPrograms = new System.Windows.Forms.ComboBox();
            this.pnlRightWindow = new System.Windows.Forms.Panel();
            this.pic06 = new System.Windows.Forms.PictureBox();
            this.pic04 = new System.Windows.Forms.PictureBox();
            this.pic02 = new System.Windows.Forms.PictureBox();
            this.pic05 = new System.Windows.Forms.PictureBox();
            this.pic03 = new System.Windows.Forms.PictureBox();
            this.pic01 = new System.Windows.Forms.PictureBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.pnlLeftWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVI)).BeginInit();
            this.pnlRightWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftWindow
            // 
            this.pnlLeftWindow.Controls.Add(this.lblLanguage);
            this.pnlLeftWindow.Controls.Add(this.picEN);
            this.pnlLeftWindow.Controls.Add(this.picVI);
            this.pnlLeftWindow.Controls.Add(this.btnStart);
            this.pnlLeftWindow.Controls.Add(this.lblProgramName);
            this.pnlLeftWindow.Controls.Add(this.cboListPrograms);
            this.pnlLeftWindow.Location = new System.Drawing.Point(10, 12);
            this.pnlLeftWindow.Name = "pnlLeftWindow";
            this.pnlLeftWindow.Size = new System.Drawing.Size(432, 365);
            this.pnlLeftWindow.TabIndex = 0;
            // 
            // lblLanguage
            // 
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Location = new System.Drawing.Point(13, 335);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(70, 23);
            this.lblLanguage.TabIndex = 4;
            this.lblLanguage.Text = "lblLanguage";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picEN
            // 
            this.picEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEN.ImageLocation = "";
            this.picEN.Location = new System.Drawing.Point(148, 331);
            this.picEN.Name = "picEN";
            this.picEN.Size = new System.Drawing.Size(49, 31);
            this.picEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEN.TabIndex = 3;
            this.picEN.TabStop = false;
            this.picEN.Click += new System.EventHandler(this.picEN_Click);
            // 
            // picVI
            // 
            this.picVI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVI.ImageLocation = "";
            this.picVI.Location = new System.Drawing.Point(88, 331);
            this.picVI.Name = "picVI";
            this.picVI.Size = new System.Drawing.Size(49, 31);
            this.picVI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVI.TabIndex = 3;
            this.picVI.TabStop = false;
            this.picVI.Click += new System.EventHandler(this.picVI_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(88, 73);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 25);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.BackColor = System.Drawing.Color.Transparent;
            this.lblProgramName.Location = new System.Drawing.Point(6, 21);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(94, 15);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "lblProgramName";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboListPrograms
            // 
            this.cboListPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboListPrograms.FormattingEnabled = true;
            this.cboListPrograms.Location = new System.Drawing.Point(103, 18);
            this.cboListPrograms.MaxLength = 20;
            this.cboListPrograms.Name = "cboListPrograms";
            this.cboListPrograms.Size = new System.Drawing.Size(315, 23);
            this.cboListPrograms.Sorted = true;
            this.cboListPrograms.TabIndex = 0;
            // 
            // pnlRightWindow
            // 
            this.pnlRightWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightWindow.Controls.Add(this.pic06);
            this.pnlRightWindow.Controls.Add(this.pic04);
            this.pnlRightWindow.Controls.Add(this.pic02);
            this.pnlRightWindow.Controls.Add(this.pic05);
            this.pnlRightWindow.Controls.Add(this.pic03);
            this.pnlRightWindow.Controls.Add(this.pic01);
            this.pnlRightWindow.Location = new System.Drawing.Point(448, 12);
            this.pnlRightWindow.Name = "pnlRightWindow";
            this.pnlRightWindow.Size = new System.Drawing.Size(326, 417);
            this.pnlRightWindow.TabIndex = 0;
            // 
            // pic06
            // 
            this.pic06.Location = new System.Drawing.Point(165, 280);
            this.pic06.Name = "pic06";
            this.pic06.Size = new System.Drawing.Size(157, 134);
            this.pic06.TabIndex = 0;
            this.pic06.TabStop = false;
            // 
            // pic04
            // 
            this.pic04.Location = new System.Drawing.Point(165, 142);
            this.pic04.Name = "pic04";
            this.pic04.Size = new System.Drawing.Size(157, 134);
            this.pic04.TabIndex = 0;
            this.pic04.TabStop = false;
            // 
            // pic02
            // 
            this.pic02.Location = new System.Drawing.Point(165, 3);
            this.pic02.Name = "pic02";
            this.pic02.Size = new System.Drawing.Size(157, 134);
            this.pic02.TabIndex = 0;
            this.pic02.TabStop = false;
            // 
            // pic05
            // 
            this.pic05.Location = new System.Drawing.Point(4, 280);
            this.pic05.Name = "pic05";
            this.pic05.Size = new System.Drawing.Size(157, 134);
            this.pic05.TabIndex = 0;
            this.pic05.TabStop = false;
            // 
            // pic03
            // 
            this.pic03.Location = new System.Drawing.Point(4, 142);
            this.pic03.Name = "pic03";
            this.pic03.Size = new System.Drawing.Size(157, 134);
            this.pic03.TabIndex = 0;
            this.pic03.TabStop = false;
            // 
            // pic01
            // 
            this.pic01.Location = new System.Drawing.Point(4, 3);
            this.pic01.Name = "pic01";
            this.pic01.Size = new System.Drawing.Size(157, 134);
            this.pic01.TabIndex = 0;
            this.pic01.TabStop = false;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtError.Location = new System.Drawing.Point(12, 383);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(430, 43);
            this.txtError.TabIndex = 1;
            // 
            // frmMainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.pnlRightWindow);
            this.Controls.Add(this.pnlLeftWindow);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KingSon \'s App Collection";
            this.Load += new System.EventHandler(this.frmMainFrame_Load);
            this.pnlLeftWindow.ResumeLayout(false);
            this.pnlLeftWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVI)).EndInit();
            this.pnlRightWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftWindow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.ComboBox cboListPrograms;
        private System.Windows.Forms.Panel pnlRightWindow;
        private System.Windows.Forms.PictureBox pic06;
        private System.Windows.Forms.PictureBox pic04;
        private System.Windows.Forms.PictureBox pic02;
        private System.Windows.Forms.PictureBox pic05;
        private System.Windows.Forms.PictureBox pic03;
        private System.Windows.Forms.PictureBox pic01;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.PictureBox picEN;
        private System.Windows.Forms.PictureBox picVI;
    }
}

