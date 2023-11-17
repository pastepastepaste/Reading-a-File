namespace Reading_a_File
{
    partial class FrmStudentRecord
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
            this.lvView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvView
            // 
            this.lvView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvView.HideSelection = false;
            this.lvView.Location = new System.Drawing.Point(46, 81);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(355, 204);
            this.lvView.TabIndex = 0;
            this.lvView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Record";
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(225)))), ((int)(((byte)(185)))));
            this.Register.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(446, 91);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(93, 32);
            this.Register.TabIndex = 2;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(225)))), ((int)(((byte)(185)))));
            this.Find.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(446, 156);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(93, 32);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(225)))), ((int)(((byte)(185)))));
            this.Upload.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(446, 222);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(93, 32);
            this.Upload.TabIndex = 4;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(201)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(566, 312);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvView);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Upload;
    }
}