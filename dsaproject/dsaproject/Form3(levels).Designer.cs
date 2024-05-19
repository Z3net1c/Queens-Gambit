
namespace dsaproject
{
    partial class Form3_levels_
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
            this.easylevelbutton = new System.Windows.Forms.Button();
            this.mediumlevelbutton = new System.Windows.Forms.Button();
            this.hardlevelbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Levels";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // easylevelbutton
            // 
            this.easylevelbutton.BackColor = System.Drawing.Color.White;
            this.easylevelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.easylevelbutton.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easylevelbutton.ForeColor = System.Drawing.Color.Blue;
            this.easylevelbutton.Location = new System.Drawing.Point(181, 43);
            this.easylevelbutton.Name = "easylevelbutton";
            this.easylevelbutton.Size = new System.Drawing.Size(158, 54);
            this.easylevelbutton.TabIndex = 1;
            this.easylevelbutton.Text = "Easy";
            this.easylevelbutton.UseVisualStyleBackColor = false;
            this.easylevelbutton.Click += new System.EventHandler(this.easylevelbutton_Click);
            // 
            // mediumlevelbutton
            // 
            this.mediumlevelbutton.BackColor = System.Drawing.Color.White;
            this.mediumlevelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mediumlevelbutton.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumlevelbutton.ForeColor = System.Drawing.Color.Red;
            this.mediumlevelbutton.Location = new System.Drawing.Point(181, 116);
            this.mediumlevelbutton.Name = "mediumlevelbutton";
            this.mediumlevelbutton.Size = new System.Drawing.Size(158, 51);
            this.mediumlevelbutton.TabIndex = 2;
            this.mediumlevelbutton.Text = "Hard";
            this.mediumlevelbutton.UseVisualStyleBackColor = false;
            this.mediumlevelbutton.Click += new System.EventHandler(this.mediumlevelbutton_Click);
            // 
            // hardlevelbutton
            // 
            this.hardlevelbutton.BackColor = System.Drawing.Color.White;
            this.hardlevelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hardlevelbutton.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardlevelbutton.Location = new System.Drawing.Point(181, 188);
            this.hardlevelbutton.Name = "hardlevelbutton";
            this.hardlevelbutton.Size = new System.Drawing.Size(158, 54);
            this.hardlevelbutton.TabIndex = 3;
            this.hardlevelbutton.Text = "Result";
            this.hardlevelbutton.UseVisualStyleBackColor = false;
            this.hardlevelbutton.Click += new System.EventHandler(this.hardlevelbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.White;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbutton.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.Color.Maroon;
            this.backbutton.Image = global::dsaproject.Properties.Resources.backk1;
            this.backbutton.Location = new System.Drawing.Point(25, 274);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(134, 56);
            this.backbutton.TabIndex = 5;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backbutton);
            this.panel1.Controls.Add(this.easylevelbutton);
            this.panel1.Controls.Add(this.helpbutton);
            this.panel1.Controls.Add(this.mediumlevelbutton);
            this.panel1.Controls.Add(this.hardlevelbutton);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 368);
            this.panel1.TabIndex = 6;
            // 
            // helpbutton
            // 
            this.helpbutton.BackColor = System.Drawing.Color.White;
            this.helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpbutton.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpbutton.ForeColor = System.Drawing.Color.Maroon;
            this.helpbutton.Image = global::dsaproject.Properties.Resources.help1;
            this.helpbutton.Location = new System.Drawing.Point(405, 274);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(65, 65);
            this.helpbutton.TabIndex = 4;
            this.helpbutton.UseVisualStyleBackColor = false;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // Form3_levels_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 363);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3_levels_";
            this.Text = "Queen\'s Gambit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button easylevelbutton;
        private System.Windows.Forms.Button mediumlevelbutton;
        private System.Windows.Forms.Button hardlevelbutton;
        private System.Windows.Forms.Button helpbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Panel panel1;
    }
}