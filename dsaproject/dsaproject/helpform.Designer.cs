
namespace dsaproject
{
    partial class helpform
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
            this.yesbutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yesbutton);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 475);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // yesbutton
            // 
            this.yesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.yesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yesbutton.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.yesbutton.Location = new System.Drawing.Point(763, 411);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(116, 44);
            this.yesbutton.TabIndex = 12;
            this.yesbutton.Text = "OK";
            this.yesbutton.UseVisualStyleBackColor = false;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(423, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "It means  no queens can share the same row,column, or diagonal.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(336, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Queens can attack only in these direction.";
            // 
            // label9
            // 
            this.label9.Image = global::dsaproject.Properties.Resources.queenattack;
            this.label9.Location = new System.Drawing.Point(115, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 202);
            this.label9.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(472, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "=> You can also check your progress in both levels by clicking result button.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(569, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "If you press any of these level a new form will be opened and you can start the p" +
    "uzzle.";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hard: A chessboard having 5 rows and 5 coloums and you have to place 5 queens.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Easy: A chessboard having 4 rows and 4 coloums and you have to place 4 queens.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "=> It consist of 2 levels:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(878, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "=> In queen\'s gambit game, your task is to place n number of queens on N * N ches" +
    "sboard so that no queen threaten each other.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "=> You can go back to the previous form by clicking back button.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queen\'s Gambit:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 472);
            this.Controls.Add(this.panel1);
            this.Name = "helpform";
            this.Text = "Help?";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button yesbutton;
    }
}