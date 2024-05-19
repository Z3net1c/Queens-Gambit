using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsaproject
{
    public partial class easylevelform : Form
    {
        string s;
        int[] userinputarray = new int[4];
        public bool startbutton; //to check if user have clicked start button or not
        public bool checkbuttonpress;

        int noofattempt;
        int nooffailedattempt;
        int noofpassattempt;

        int hardlevelattempt;
        int hardpassattempt;
        int hardfailattempt;

        private nqueen_solver solver;
        List<int[]>  allsolution= new List<int[]>();
        Label lastclickedrow0;
        Label lastclickedrow1;
        Label lastclickedrow2;
        Label lastclickedrow3;


        public easylevelform(string name,int n1,int n2,int n3,int m1,int m2,int m3)
        {
            InitializeComponent();
            
            solver = new nqueen_solver();
            startbutton = false;
            checkbuttonpress = false;

            noofpassattempt = n2;
            nooffailedattempt = n3;
            noofattempt = n1;

            hardlevelattempt = m1;
            hardpassattempt = m2;
            hardfailattempt = m3;
            s = name;
           
            
            //this.WindowState = FormWindowState.Maximized; // Maximize the form on load
            //this.AutoSize = true; // Optional: Automatically adjust the form size based on its content
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink; // 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[0] = 0;
                    if (lastclickedrow0 != null)
                    {
                        lastclickedrow0.Text = "";
                        if (lastclickedrow0 == row0col1 || lastclickedrow0 == row0col3)
                        {
                            lastclickedrow0.BackColor = Color.Black;

                        }
                        else
                        {
                            lastclickedrow0.BackColor = Color.White;
                        }
                    }
                    row0col0.BackColor = Color.Teal;
                    row0col0.Text = "♛";
                    row0col0.TextAlign = ContentAlignment.MiddleCenter;
                    row0col0.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row0col0.ForeColor = Color.White;
                    lastclickedrow0 = row0col0;
                }
                else
                {
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void row0col1_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[0] = 1;
                    if (lastclickedrow0 != null)
                    {
                        lastclickedrow0.Text = "";
                        if (lastclickedrow0 == row0col1 || lastclickedrow0 == row0col3)
                        {
                            lastclickedrow0.BackColor = Color.Black;

                        }
                        else
                        {
                            lastclickedrow0.BackColor = Color.White;
                        }
                    }
                    row0col1.BackColor = Color.Teal;
                    row0col1.Text = "♛";
                    row0col1.TextAlign = ContentAlignment.MiddleCenter;
                    row0col1.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row0col1.ForeColor = Color.White;
                    lastclickedrow0 = row0col1;

                }
                else
                {
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void row0col2_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[0] = 2;
                    if (lastclickedrow0 != null)
                    {
                        lastclickedrow0.Text = "";
                        if (lastclickedrow0 == row0col1 || lastclickedrow0 == row0col3)
                        {
                            lastclickedrow0.BackColor = Color.Black;

                        }
                        else
                        {
                            lastclickedrow0.BackColor = Color.White;
                        }
                    }
                    row0col2.BackColor = Color.Teal;
                    row0col2.Text = "♛";
                    row0col2.TextAlign = ContentAlignment.MiddleCenter;
                    row0col2.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row0col2.ForeColor = Color.White;
                    lastclickedrow0 = row0col2;
                }
                else
                {
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row0col3_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[0] = 3;
                    if (lastclickedrow0 != null)
                    {
                        lastclickedrow0.Text = "";
                        if (lastclickedrow0 == row0col1 || lastclickedrow0 == row0col3)
                        {
                            lastclickedrow0.BackColor = Color.Black;

                        }
                        else
                        {
                            lastclickedrow0.BackColor = Color.White;
                        }
                    }
                    row0col3.BackColor = Color.Teal;
                    row0col3.Text = "♛";
                    row0col3.TextAlign = ContentAlignment.MiddleCenter;
                    row0col3.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row0col3.ForeColor = Color.White;
                    lastclickedrow0 = row0col3;
                }
                else
                {
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void row1col0_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[1] = 0;
                    if (lastclickedrow1 != null)
                    {
                        lastclickedrow1.Text = "";
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2)
                        {
                            lastclickedrow1.BackColor = Color.Black;

                        }
                        else
                        {
                            lastclickedrow1.BackColor = Color.White;
                        }
                    }
                    row1col0.BackColor = Color.Teal;
                    row1col0.Text = "♛";
                    row1col0.TextAlign = ContentAlignment.MiddleCenter;
                    row1col0.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row1col0.ForeColor = Color.White;
                    lastclickedrow1 = row1col0;
                }
                else
                {
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row1col1_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[1] = 1;
                    if (lastclickedrow1 != null)
                    {
                        lastclickedrow1.Text = "";
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2)
                        {
                            lastclickedrow1.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow1.BackColor = Color.White;
                        }
                    }
                    row1col1.BackColor = Color.Teal;
                    row1col1.Text = "♛";
                    row1col1.TextAlign = ContentAlignment.MiddleCenter;
                    row1col1.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row1col1.ForeColor = Color.White;
                    lastclickedrow1 = row1col1;
                }
                else
                {
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void row1col2_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[1] = 2;
                    if (lastclickedrow1 != null)
                    {
                        lastclickedrow1.Text = "";
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2)
                        {
                            lastclickedrow1.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow1.BackColor = Color.White;
                        }
                    }
                    row1col2.BackColor = Color.Teal;
                    row1col2.Text = "♛";
                    row1col2.TextAlign = ContentAlignment.MiddleCenter;
                    row1col2.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row1col2.ForeColor = Color.White;
                    lastclickedrow1 = row1col2;
                }
                else
                {
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void row1col3_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[1] = 3;
                    if (lastclickedrow1 != null)
                    {
                        lastclickedrow1.Text = "";
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2)
                        {
                            lastclickedrow1.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow1.BackColor = Color.White;
                        }
                    }
                    row1col3.BackColor = Color.Teal;
                    row1col3.Text = "♛";
                    row1col3.TextAlign = ContentAlignment.MiddleCenter;
                    row1col3.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row1col3.ForeColor = Color.White;
                    lastclickedrow1 = row1col3;
                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row2col0_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[2] = 0;
                    if (lastclickedrow2 != null)
                    {
                        lastclickedrow2.Text = "";
                        if (lastclickedrow2 == row2col1 || lastclickedrow2 == row2col3)
                        {
                            lastclickedrow2.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow2.BackColor = Color.White;
                        }
                    }
                    row2col0.BackColor = Color.Teal;
                    row2col0.Text = "♛";
                    row2col0.TextAlign = ContentAlignment.MiddleCenter;
                    row2col0.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row2col0.ForeColor = Color.White;

                    lastclickedrow2 = row2col0;
                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row2col1_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[2] = 1;
                    if (lastclickedrow2 != null)
                    {
                        lastclickedrow2.Text = "";
                        if (lastclickedrow2 == row2col1 || lastclickedrow2 == row2col3)
                        {
                            lastclickedrow2.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow2.BackColor = Color.White;
                        }
                    }
                    row2col1.BackColor = Color.Teal;
                    row2col1.Text = "♛";
                    row2col1.TextAlign = ContentAlignment.MiddleCenter;
                    row2col1.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row2col1.ForeColor = Color.White;
                    lastclickedrow2 = row2col1;
                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row2col2_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[2] = 2;
                    if (lastclickedrow2 != null)
                    {
                        lastclickedrow2.Text = "";
                        if (lastclickedrow2 == row2col1 || lastclickedrow2 == row2col3)
                        {
                            lastclickedrow2.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow2.BackColor = Color.White;
                        }
                    }
                    row2col2.BackColor = Color.Teal;
                    row2col2.Text = "♛";
                    row2col2.TextAlign = ContentAlignment.MiddleCenter;
                    row2col2.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row2col2.ForeColor = Color.White;
                    lastclickedrow2 = row2col2;
                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void row2col3_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[2] = 3;
                    if (lastclickedrow2 != null)
                    {
                        lastclickedrow2.Text = "";
                        if (lastclickedrow2 == row2col1 || lastclickedrow2 == row2col3)
                        {
                            lastclickedrow2.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow2.BackColor = Color.White;
                        }
                    }
                    row2col3.BackColor = Color.Teal;
                    row2col3.Text = "♛";
                    row2col3.TextAlign = ContentAlignment.MiddleCenter;
                    row2col3.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row2col3.ForeColor = Color.White;
                    lastclickedrow2 = row2col3;
                }
                else
                {
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row3col0_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[3] = 0;
                    if (lastclickedrow3 != null)
                    {
                        lastclickedrow3.Text = "";
                        if (lastclickedrow3 == row3col0 || lastclickedrow3 == row3col2)
                        {
                            lastclickedrow3.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow3.BackColor = Color.White;
                        }
                    }
                    row3col0.BackColor = Color.Teal;
                    row3col0.Text = "♛";
                    row3col0.TextAlign = ContentAlignment.MiddleCenter;
                    row3col0.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row3col0.ForeColor = Color.White;
                    lastclickedrow3 = row3col0;
                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row3col1_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[3] = 1;
                    if (lastclickedrow3 != null)
                    {
                        lastclickedrow3.Text = "";
                        if (lastclickedrow3 == row3col0 || lastclickedrow3 == row3col2)
                        {
                            lastclickedrow3.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow3.BackColor = Color.White;
                        }
                    }
                    row3col1.BackColor = Color.Teal;
                    row3col1.Text = "♛";
                    row3col1.TextAlign = ContentAlignment.MiddleCenter;
                    row3col1.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row3col1.ForeColor = Color.White;
                    lastclickedrow3 = row3col1;
                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row3col2_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[3] = 2;
                    if (lastclickedrow3 != null)
                    {
                        lastclickedrow3.Text = "";
                        if (lastclickedrow3 == row3col0 || lastclickedrow3 == row3col2)
                        {
                            lastclickedrow3.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow3.BackColor = Color.White;
                        }
                    }
                    row3col2.BackColor = Color.Teal;
                    row3col2.Text = "♛";
                    row3col2.TextAlign = ContentAlignment.MiddleCenter;
                    row3col2.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row3col2.ForeColor = Color.White;
                    lastclickedrow3 = row3col2;
                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        private void row3col3_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[3] = 3;
                    if (lastclickedrow3 != null)
                    {
                        lastclickedrow3.Text = "";
                        if (lastclickedrow3 == row3col0 || lastclickedrow3 == row3col2)
                        {
                            lastclickedrow3.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow3.BackColor = Color.White;
                        }
                    }
                    row3col3.BackColor = Color.Teal;
                    row3col3.Text = "♛";
                    row3col3.TextAlign = ContentAlignment.MiddleCenter;
                    row3col3.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row3col3.ForeColor = Color.White;
                    lastclickedrow3 = row3col3;
                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //checkbuttonevent
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    noofattempt++;
                    if (lastclickedrow0 != null && lastclickedrow1 != null && lastclickedrow2 != null && lastclickedrow3 != null)
                    {
                        int n = 4;
                        allsolution = solver.SolveNQueens(n);
                        if (allsolution.Count > 0)
                        {
                            for (int i = 0; i < allsolution.Count; i++)
                            {
                                if ((userinputarray[0] == allsolution[i][0]) && (userinputarray[1] == allsolution[i][1]) && (userinputarray[2] == allsolution[i][2]) && (userinputarray[3] == allsolution[i][3]))
                                {
                                    lastclickedrow0.BackColor = Color.Pink;
                                    lastclickedrow1.BackColor = Color.Pink;
                                    lastclickedrow2.BackColor = Color.Pink;
                                    lastclickedrow3.BackColor = Color.Pink;
                                    noofpassattempt++;
                                }
                            }

                            if ((lastclickedrow0.BackColor != Color.Pink) && (lastclickedrow1.BackColor != Color.Pink) && (lastclickedrow2.BackColor != Color.Pink) && (lastclickedrow3.BackColor != Color.Pink))
                            {
                                lastclickedrow0.BackColor = Color.Red;
                                lastclickedrow1.BackColor = Color.Red;
                                lastclickedrow2.BackColor = Color.Red;
                                lastclickedrow3.BackColor = Color.Red;
                                nooffailedattempt++;

                            }
                           
                        }
                        
                        checkbuttonpress = true;
                        startbutton = false;
                    }
                    else
                    {
                        MessageBox.Show("First you have to place queens in each row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (startbutton == true||checkbuttonpress==true)
            {
                try
                {
                    lastclickedrow0 = null;
                    lastclickedrow1 = null;
                    lastclickedrow2 = null;
                    lastclickedrow3 = null;

                    row0col0.BackColor = Color.White;
                    row0col1.BackColor = Color.Black;
                    row0col2.BackColor = Color.White;
                    row0col3.BackColor = Color.Black;

                    row1col0.BackColor = Color.Black;
                    row1col1.BackColor = Color.White;
                    row1col2.BackColor = Color.Black;
                    row1col3.BackColor = Color.White;

                    row2col0.BackColor = Color.White;
                    row2col1.BackColor = Color.Black;
                    row2col2.BackColor = Color.White;
                    row2col3.BackColor = Color.Black;

                    row3col0.BackColor = Color.Black;
                    row3col1.BackColor = Color.White;
                    row3col2.BackColor = Color.Black;
                    row3col3.BackColor = Color.White;
                    row0col3.Text = "";
                    row0col2.Text = "";
                    row0col1.Text = "";
                    row0col0.Text = "";
                    row1col3.Text = "";
                    row1col2.Text = "";
                    row1col1.Text = "";
                    row1col0.Text = "";
                    row2col3.Text = "";
                    row2col2.Text = "";
                    row2col1.Text = "";
                    row2col0.Text = "";
                    row3col3.Text = "";
                    row3col2.Text = "";
                    row3col1.Text = "";
                    row3col0.Text = "";







                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form3_levels_ form3 = new Form3_levels_(s,noofattempt,noofpassattempt, nooffailedattempt,hardlevelattempt,hardpassattempt,hardfailattempt);
            form3.Show();
            this.Close();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            easylevelhelp help = new easylevelhelp();
            help.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            startbutton = true;
            checkbuttonpress = false;
            lastclickedrow0 = null;
            lastclickedrow1 = null;
            lastclickedrow2 = null;
            lastclickedrow3 = null;

            row0col0.BackColor = Color.White;
            row0col1.BackColor = Color.Black;
            row0col2.BackColor = Color.White;
            row0col3.BackColor = Color.Black;

            row1col0.BackColor = Color.Black;
            row1col1.BackColor = Color.White;
            row1col2.BackColor = Color.Black;
            row1col3.BackColor = Color.White;

            row2col0.BackColor = Color.White;
            row2col1.BackColor = Color.Black;
            row2col2.BackColor = Color.White;
            row2col3.BackColor = Color.Black;

            row3col0.BackColor = Color.Black;
            row3col1.BackColor = Color.White;
            row3col2.BackColor = Color.Black;
            row3col3.BackColor = Color.White;
            row0col3.Text = "";
            row0col2.Text = "";
            row0col1.Text = "";
            row0col0.Text = "";
            row1col3.Text = "";
            row1col2.Text = "";
            row1col1.Text = "";
            row1col0.Text = "";
            row2col3.Text = "";
            row2col2.Text = "";
            row2col1.Text = "";
            row2col0.Text = "";
            row3col3.Text = "";
            row3col2.Text = "";
            row3col1.Text = "";
            row3col0.Text = "";
            


        }

        private void easylevelform_Load(object sender, EventArgs e)
        {

        }
    }
}