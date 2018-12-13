namespace _12._12._18
{
    partial class Form2
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
            this.Choosebtn = new System.Windows.Forms.Button();
            this.Photobox = new System.Windows.Forms.PictureBox();
            this.Savedbbtn = new System.Windows.Forms.Button();
            this.ASFbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photobox)).BeginInit();
            this.SuspendLayout();
            // 
            // Choosebtn
            // 
            this.Choosebtn.Location = new System.Drawing.Point(34, 39);
            this.Choosebtn.Name = "Choosebtn";
            this.Choosebtn.Size = new System.Drawing.Size(106, 34);
            this.Choosebtn.TabIndex = 0;
            this.Choosebtn.Text = "    Choose Add";
            this.Choosebtn.UseVisualStyleBackColor = true;
            this.Choosebtn.Click += new System.EventHandler(this.Choosebtn_Click);
            // 
            // Photobox
            // 
            this.Photobox.Location = new System.Drawing.Point(187, 39);
            this.Photobox.Name = "Photobox";
            this.Photobox.Size = new System.Drawing.Size(196, 239);
            this.Photobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photobox.TabIndex = 1;
            this.Photobox.TabStop = false;
            // 
            // Savedbbtn
            // 
            this.Savedbbtn.Location = new System.Drawing.Point(34, 93);
            this.Savedbbtn.Name = "Savedbbtn";
            this.Savedbbtn.Size = new System.Drawing.Size(106, 34);
            this.Savedbbtn.TabIndex = 0;
            this.Savedbbtn.Text = "Save To Databaza";
            this.Savedbbtn.UseVisualStyleBackColor = true;
            this.Savedbbtn.Click += new System.EventHandler(this.Savedbbtn_Click);
            // 
            // ASFbtn
            // 
            this.ASFbtn.Location = new System.Drawing.Point(34, 237);
            this.ASFbtn.Name = "ASFbtn";
            this.ASFbtn.Size = new System.Drawing.Size(124, 41);
            this.ASFbtn.TabIndex = 0;
            this.ASFbtn.Text = "Add Student Form";
            this.ASFbtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 312);
            this.Controls.Add(this.Photobox);
            this.Controls.Add(this.ASFbtn);
            this.Controls.Add(this.Savedbbtn);
            this.Controls.Add(this.Choosebtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Choosebtn;
        private System.Windows.Forms.PictureBox Photobox;
        private System.Windows.Forms.Button Savedbbtn;
        private System.Windows.Forms.Button ASFbtn;
    }
}