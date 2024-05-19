
namespace dsaproject
{
    partial class Form2_name_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nobutton = new System.Windows.Forms.Button();
            this.yesbutton = new System.Windows.Forms.Button();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Nobutton);
            this.panel1.Controls.Add(this.yesbutton);
            this.panel1.Controls.Add(this.nametextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 249);
            this.panel1.TabIndex = 0;
            // 
            // Nobutton
            // 
            this.Nobutton.BackColor = System.Drawing.Color.White;
            this.Nobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nobutton.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nobutton.ForeColor = System.Drawing.Color.Red;
            this.Nobutton.Location = new System.Drawing.Point(461, 148);
            this.Nobutton.Name = "Nobutton";
            this.Nobutton.Size = new System.Drawing.Size(110, 44);
            this.Nobutton.TabIndex = 6;
            this.Nobutton.Text = "NO";
            this.Nobutton.UseVisualStyleBackColor = false;
            this.Nobutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // yesbutton
            // 
            this.yesbutton.BackColor = System.Drawing.Color.White;
            this.yesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yesbutton.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.yesbutton.Location = new System.Drawing.Point(323, 148);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(116, 44);
            this.yesbutton.TabIndex = 5;
            this.yesbutton.Text = "YES";
            this.yesbutton.UseVisualStyleBackColor = false;
            this.yesbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(282, 99);
            this.nametextbox.Margin = new System.Windows.Forms.Padding(0);
            this.nametextbox.MaximumSize = new System.Drawing.Size(500, 500);
            this.nametextbox.MaxLength = 40000;
            this.nametextbox.MinimumSize = new System.Drawing.Size(100, 100);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(308, 20);
            this.nametextbox.TabIndex = 4;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do you want to continue?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Your Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(106, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Queens\'s Gambit";
            // 
            // Form2_name_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 245);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2_name_";
            this.Text = "Queen\'s Gambit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Nobutton;
        private System.Windows.Forms.Button yesbutton;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}