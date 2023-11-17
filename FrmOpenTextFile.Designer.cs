namespace _05LabExcercise2
{
    partial class FrmOpenTextFile
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
            this.lvShowText = new System.Windows.Forms.ListView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGoStudentRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShowText
            // 
            this.lvShowText.BackColor = System.Drawing.Color.PeachPuff;
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(58, 40);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(539, 332);
            this.lvShowText.TabIndex = 0;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnOpen.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(91, 397);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(193, 39);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGoStudentRecords
            // 
            this.btnGoStudentRecords.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGoStudentRecords.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoStudentRecords.Location = new System.Drawing.Point(382, 397);
            this.btnGoStudentRecords.Name = "btnGoStudentRecords";
            this.btnGoStudentRecords.Size = new System.Drawing.Size(193, 39);
            this.btnGoStudentRecords.TabIndex = 2;
            this.btnGoStudentRecords.Text = "STUDENT RECORDS";
            this.btnGoStudentRecords.UseVisualStyleBackColor = false;
            this.btnGoStudentRecords.Click += new System.EventHandler(this.btnGoStudentRecords_Click);
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(665, 472);
            this.Controls.Add(this.btnGoStudentRecords);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lvShowText);
            this.Name = "FrmOpenTextFile";
            this.Text = "FrmOpenTextFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGoStudentRecords;
    }
}

