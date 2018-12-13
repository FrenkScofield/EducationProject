namespace _12._12._18
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ImageTexbox = new System.Windows.Forms.PictureBox();
            this.AddTexbtn = new System.Windows.Forms.Button();
            this.SurnameTexbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTexbox = new System.Windows.Forms.TextBox();
            this.EmailTexbox = new System.Windows.Forms.TextBox();
            this.Addmorephotosbtn = new System.Windows.Forms.Button();
            this.Selectbtn = new System.Windows.Forms.Button();
            this.SellectGrup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTexbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // ImageTexbox
            // 
            this.ImageTexbox.Location = new System.Drawing.Point(28, 129);
            this.ImageTexbox.Name = "ImageTexbox";
            this.ImageTexbox.Size = new System.Drawing.Size(170, 213);
            this.ImageTexbox.TabIndex = 1;
            this.ImageTexbox.TabStop = false;
            // 
            // AddTexbtn
            // 
            this.AddTexbtn.Location = new System.Drawing.Point(113, 358);
            this.AddTexbtn.Name = "AddTexbtn";
            this.AddTexbtn.Size = new System.Drawing.Size(85, 25);
            this.AddTexbtn.TabIndex = 2;
            this.AddTexbtn.Text = "Add Student";
            this.AddTexbtn.UseVisualStyleBackColor = true;
            // 
            // SurnameTexbox
            // 
            this.SurnameTexbox.Location = new System.Drawing.Point(78, 64);
            this.SurnameTexbox.Name = "SurnameTexbox";
            this.SurnameTexbox.Size = new System.Drawing.Size(120, 20);
            this.SurnameTexbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // NameTexbox
            // 
            this.NameTexbox.Location = new System.Drawing.Point(78, 33);
            this.NameTexbox.Name = "NameTexbox";
            this.NameTexbox.Size = new System.Drawing.Size(120, 20);
            this.NameTexbox.TabIndex = 3;
            // 
            // EmailTexbox
            // 
            this.EmailTexbox.Location = new System.Drawing.Point(78, 92);
            this.EmailTexbox.Name = "EmailTexbox";
            this.EmailTexbox.Size = new System.Drawing.Size(120, 20);
            this.EmailTexbox.TabIndex = 3;
            // 
            // Addmorephotosbtn
            // 
            this.Addmorephotosbtn.Location = new System.Drawing.Point(28, 400);
            this.Addmorephotosbtn.Name = "Addmorephotosbtn";
            this.Addmorephotosbtn.Size = new System.Drawing.Size(170, 33);
            this.Addmorephotosbtn.TabIndex = 2;
            this.Addmorephotosbtn.Text = "Add More Photos";
            this.Addmorephotosbtn.UseVisualStyleBackColor = true;
            this.Addmorephotosbtn.Click += new System.EventHandler(this.Addmorephotosbtn_Click);
            // 
            // Selectbtn
            // 
            this.Selectbtn.Location = new System.Drawing.Point(229, 33);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(95, 25);
            this.Selectbtn.TabIndex = 2;
            this.Selectbtn.Text = "Select Photo";
            this.Selectbtn.UseVisualStyleBackColor = true;
            // 
            // SellectGrup
            // 
            this.SellectGrup.Location = new System.Drawing.Point(229, 64);
            this.SellectGrup.Name = "SellectGrup";
            this.SellectGrup.Size = new System.Drawing.Size(322, 369);
            this.SellectGrup.TabIndex = 4;
            this.SellectGrup.TabStop = false;
            this.SellectGrup.Text = "Sellect Photo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.SellectGrup);
            this.Controls.Add(this.NameTexbox);
            this.Controls.Add(this.EmailTexbox);
            this.Controls.Add(this.SurnameTexbox);
            this.Controls.Add(this.Addmorephotosbtn);
            this.Controls.Add(this.Selectbtn);
            this.Controls.Add(this.AddTexbtn);
            this.Controls.Add(this.ImageTexbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImageTexbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImageTexbox;
        private System.Windows.Forms.Button AddTexbtn;
        private System.Windows.Forms.TextBox SurnameTexbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTexbox;
        private System.Windows.Forms.TextBox EmailTexbox;
        private System.Windows.Forms.Button Addmorephotosbtn;
        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.GroupBox SellectGrup;
    }
}

