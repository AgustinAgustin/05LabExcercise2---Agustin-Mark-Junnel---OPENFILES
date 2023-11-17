namespace _05LabExcercise2
{
    partial class FrmStudentRecords
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
            this.ListViewShowText = new System.Windows.Forms.ListView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnFindFiles = new System.Windows.Forms.Button();
            this.btnUploadFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListViewShowText
            // 
            this.ListViewShowText.BackColor = System.Drawing.Color.PeachPuff;
            this.ListViewShowText.HideSelection = false;
            this.ListViewShowText.Location = new System.Drawing.Point(12, 80);
            this.ListViewShowText.Name = "ListViewShowText";
            this.ListViewShowText.Size = new System.Drawing.Size(488, 306);
            this.ListViewShowText.TabIndex = 0;
            this.ListViewShowText.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRegister.Location = new System.Drawing.Point(518, 118);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 46);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnFindFiles
            // 
            this.btnFindFiles.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFindFiles.Location = new System.Drawing.Point(518, 197);
            this.btnFindFiles.Name = "btnFindFiles";
            this.btnFindFiles.Size = new System.Drawing.Size(170, 46);
            this.btnFindFiles.TabIndex = 2;
            this.btnFindFiles.Text = "FIND";
            this.btnFindFiles.UseVisualStyleBackColor = false;
            this.btnFindFiles.Click += new System.EventHandler(this.btnFindFiles_Click);
            // 
            // btnUploadFiles
            // 
            this.btnUploadFiles.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnUploadFiles.Location = new System.Drawing.Point(518, 268);
            this.btnUploadFiles.Name = "btnUploadFiles";
            this.btnUploadFiles.Size = new System.Drawing.Size(170, 46);
            this.btnUploadFiles.TabIndex = 3;
            this.btnUploadFiles.Text = "UPLOAD";
            this.btnUploadFiles.UseVisualStyleBackColor = false;
            this.btnUploadFiles.Click += new System.EventHandler(this.btnUploadFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIEW RECORDS";
            // 
            // FrmStudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(724, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUploadFiles);
            this.Controls.Add(this.btnFindFiles);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ListViewShowText);
            this.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmStudentRecords";
            this.Text = "FrmStudentRecords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewShowText;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFindFiles;
        private System.Windows.Forms.Button btnUploadFiles;
        private System.Windows.Forms.Label label1;
    }
}