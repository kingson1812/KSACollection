namespace MassRename
{
    partial class frmRename
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
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.pnlLower = new System.Windows.Forms.Panel();
            this.txtError = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblReplaceString = new System.Windows.Forms.Label();
            this.txtReplaceString = new System.Windows.Forms.TextBox();
            this.lblFindString = new System.Windows.Forms.Label();
            this.txtFindString = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlUpper.SuspendLayout();
            this.pnlLower.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpper
            // 
            this.pnlUpper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpper.Controls.Add(this.lblFolderPath);
            this.pnlUpper.Controls.Add(this.txtFolderPath);
            this.pnlUpper.Controls.Add(this.btnLoadFolder);
            this.pnlUpper.Location = new System.Drawing.Point(12, 12);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(372, 69);
            this.pnlUpper.TabIndex = 0;
            this.pnlUpper.TabStop = true;
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.Location = new System.Drawing.Point(5, 6);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(70, 23);
            this.lblFolderPath.TabIndex = 8;
            this.lblFolderPath.Text = "lblFolderPath";
            this.lblFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.BackColor = System.Drawing.Color.White;
            this.txtFolderPath.Location = new System.Drawing.Point(81, 6);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(287, 22);
            this.txtFolderPath.TabIndex = 0;
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btnLoadFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFolder.Location = new System.Drawing.Point(284, 34);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(84, 25);
            this.btnLoadFolder.TabIndex = 1;
            this.btnLoadFolder.Text = "btnLoadFolder";
            this.btnLoadFolder.UseVisualStyleBackColor = false;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
            // 
            // pnlLower
            // 
            this.pnlLower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLower.Controls.Add(this.txtError);
            this.pnlLower.Controls.Add(this.lblLog);
            this.pnlLower.Controls.Add(this.txtLog);
            this.pnlLower.Controls.Add(this.lblReplaceString);
            this.pnlLower.Controls.Add(this.txtReplaceString);
            this.pnlLower.Controls.Add(this.lblFindString);
            this.pnlLower.Controls.Add(this.txtFindString);
            this.pnlLower.Controls.Add(this.btnStart);
            this.pnlLower.Location = new System.Drawing.Point(12, 87);
            this.pnlLower.Name = "pnlLower";
            this.pnlLower.Size = new System.Drawing.Size(372, 362);
            this.pnlLower.TabIndex = 1;
            this.pnlLower.TabStop = true;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.White;
            this.txtError.ForeColor = System.Drawing.Color.Black;
            this.txtError.Location = new System.Drawing.Point(81, 75);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(175, 22);
            this.txtError.TabIndex = 2;
            // 
            // lblLog
            // 
            this.lblLog.Location = new System.Drawing.Point(8, 99);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(67, 23);
            this.lblLog.TabIndex = 13;
            this.lblLog.Text = "lblLog";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(8, 125);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(360, 234);
            this.txtLog.TabIndex = 4;
            // 
            // lblReplaceString
            // 
            this.lblReplaceString.Location = new System.Drawing.Point(5, 44);
            this.lblReplaceString.Name = "lblReplaceString";
            this.lblReplaceString.Size = new System.Drawing.Size(70, 23);
            this.lblReplaceString.TabIndex = 11;
            this.lblReplaceString.Text = "lblReplaceString";
            this.lblReplaceString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReplaceString
            // 
            this.txtReplaceString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplaceString.BackColor = System.Drawing.Color.White;
            this.txtReplaceString.Location = new System.Drawing.Point(81, 44);
            this.txtReplaceString.Name = "txtReplaceString";
            this.txtReplaceString.Size = new System.Drawing.Size(287, 22);
            this.txtReplaceString.TabIndex = 1;
            // 
            // lblFindString
            // 
            this.lblFindString.Location = new System.Drawing.Point(5, 9);
            this.lblFindString.Name = "lblFindString";
            this.lblFindString.Size = new System.Drawing.Size(70, 23);
            this.lblFindString.TabIndex = 9;
            this.lblFindString.Text = "lblFindString";
            this.lblFindString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFindString
            // 
            this.txtFindString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFindString.BackColor = System.Drawing.Color.White;
            this.txtFindString.Location = new System.Drawing.Point(81, 9);
            this.txtFindString.Name = "txtFindString";
            this.txtFindString.Size = new System.Drawing.Size(287, 22);
            this.txtFindString.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(284, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 25);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(396, 461);
            this.Controls.Add(this.pnlLower);
            this.Controls.Add(this.pnlUpper);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRename";
            this.Text = "Mass Rename";
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.pnlLower.ResumeLayout(false);
            this.pnlLower.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Panel pnlLower;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblReplaceString;
        private System.Windows.Forms.TextBox txtReplaceString;
        private System.Windows.Forms.Label lblFindString;
        private System.Windows.Forms.TextBox txtFindString;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtError;

    }
}

