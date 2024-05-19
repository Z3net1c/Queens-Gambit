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
    public partial class mediumlevelform : Form
    {
        int[] userinputarray = new int[5];
        private nqueen_solver solver;
        List<int[]> allsolution = new List<int[]>();
        Label lastclickedrow0;
        Label lastclickedrow1;
        Label lastclickedrow2;
        Label lastclickedrow3;
        Label lastclickedrow4;
        int hardlevelattempt;
        int hardpassattempt;
        int hardfailattempt;

        int noofattempt;
        int nooffailedattempt;
        int noofpassattempt;

        string name;


        public bool startbutton; //to check if user have clicked start button or not
        public bool checkbuttonpress;

        public mediumlevelform(string s,int n1,int n2,int n3,int m1,int m2,int m3)
        {
            InitializeComponent();
            solver = new nqueen_solver();

            noofpassattempt = n2;
            nooffailedattempt = n3;
            noofattempt = n1;

            hardlevelattempt = m1;
            hardpassattempt = m2;
            hardfailattempt = m3;
            name = s;
        }

        

        private void row0col0_Click(object sender, EventArgs e)
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

        private void row0col4_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[0] = 4;
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
                    row0col4.BackColor = Color.Teal;
                    row0col4.Text = "♛";
                    row0col4.TextAlign = ContentAlignment.MiddleCenter;
                    row0col4.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row0col4.ForeColor = Color.White;
                    lastclickedrow0 = row0col4;
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
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2|| lastclickedrow1 == row1col4)
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
                    MessageBox.Show("Click start button to start this puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2|| lastclickedrow1 == row1col4)
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
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2|| lastclickedrow1 == row1col4)
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
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2|| lastclickedrow1 == row1col4)
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
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void row1col4_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[1] = 4;
                    if (lastclickedrow1 != null)
                    {
                        lastclickedrow1.Text = "";
                        if (lastclickedrow1 == row1col0 || lastclickedrow1 == row1col2|| lastclickedrow1 == row1col4)
                        {
                            lastclickedrow1.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow1.BackColor = Color.White;
                        }
                    }
                    row1col4.BackColor = Color.Teal;
                    row1col4.Text = "♛";
                    row1col4.TextAlign = ContentAlignment.MiddleCenter;
                    row1col4.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row1col4.ForeColor = Color.White;
                    lastclickedrow1 = row1col4;
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
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void row2col4_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[2] = 4;
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
                    row2col4.BackColor = Color.Teal;
                    row2col4.Text = "♛";
                    row2col4.TextAlign = ContentAlignment.MiddleCenter;
                    row2col4.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row2col4.ForeColor = Color.White;
                    lastclickedrow2 = row2col4;
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
                        if (lastclickedrow3 == row3col0 || lastclickedrow3 == row3col2 || lastclickedrow3 == row3col4)
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
                    MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                        if (lastclickedrow3 == row3col0 || lastclickedrow3 == row3col2 || lastclickedrow3 == row3col4)
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
                        if (lastclickedrow3 == row3col0 || lastclickedrow3 == row3col2 || lastclickedrow3 == row3col4)
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

        private void row3col4_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[3] = 4;
                    if (lastclickedrow3 != null)
                    {
                        lastclickedrow3.Text = "";
                        if (lastclickedrow3 == row3col0 || lastclickedrow3 == row3col2|| lastclickedrow3 == row3col4)
                        {
                            lastclickedrow3.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow3.BackColor = Color.White;
                        }
                    }
                    row3col4.BackColor = Color.Teal;
                    row3col4.Text = "♛";
                    row3col4.TextAlign = ContentAlignment.MiddleCenter;
                    row3col4.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row3col4.ForeColor = Color.White;
                    lastclickedrow3 = row3col4;
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

        private void row4col0_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[4] = 0;
                    if (lastclickedrow4 != null)
                    {
                        lastclickedrow4.Text = "";
                        if (lastclickedrow4 == row4col1 || lastclickedrow4 == row4col3)
                        {
                            lastclickedrow4.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow4.BackColor = Color.White;
                        }
                    }
                    row4col0.BackColor = Color.Teal;
                    row4col0.Text = "♛";
                    row4col0.TextAlign = ContentAlignment.MiddleCenter;
                    row4col0.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row4col0.ForeColor = Color.White;
                    lastclickedrow4 = row4col0;
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

        private void row4col1_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[4] = 1;
                    if (lastclickedrow4 != null)
                    {
                        lastclickedrow4.Text = "";
                        if (lastclickedrow4 == row4col1 || lastclickedrow4 == row4col3)
                        {
                            lastclickedrow4.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow4.BackColor = Color.White;
                        }
                    }
                    row4col1.BackColor = Color.Teal;
                    row4col1.Text = "♛";
                    row4col1.TextAlign = ContentAlignment.MiddleCenter;
                    row4col1.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row4col1.ForeColor = Color.White;
                    lastclickedrow4 = row4col1;
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

        private void row4col2_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[4] = 2;
                    if (lastclickedrow4 != null)
                    {
                        lastclickedrow4.Text = "";
                        if (lastclickedrow4 == row4col1 || lastclickedrow4 == row4col3)
                        {
                            lastclickedrow4.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow4.BackColor = Color.White;
                        }
                    }
                    row4col2.BackColor = Color.Teal;
                    row4col2.Text = "♛";
                    row4col2.TextAlign = ContentAlignment.MiddleCenter;
                    row4col2.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row4col2.ForeColor = Color.White;
                    lastclickedrow4 = row4col2;
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

        private void row4col3_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[4] = 3;
                    if (lastclickedrow4 != null)
                    {
                        lastclickedrow4.Text = "";
                        if (lastclickedrow4 == row4col1 || lastclickedrow4 == row4col3)
                        {
                            lastclickedrow4.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow4.BackColor = Color.White;
                        }
                    }
                    row4col3.BackColor = Color.Teal;
                    row4col3.Text = "♛";
                    row4col3.TextAlign = ContentAlignment.MiddleCenter;
                    row4col3.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row4col3.ForeColor = Color.White;
                    lastclickedrow4 = row4col3;
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

        private void row4col4_Click(object sender, EventArgs e)
        {
            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {
                    userinputarray[4] = 4;
                    if (lastclickedrow4 != null)
                    {
                        lastclickedrow4.Text = "";
                        if (lastclickedrow4 == row4col1 || lastclickedrow4 == row4col3)
                        {
                            lastclickedrow4.BackColor = Color.Black;
                        }
                        else
                        {
                            lastclickedrow4.BackColor = Color.White;
                        }
                    }
                    row4col4.BackColor = Color.Teal;
                    row4col4.Text = "♛";
                    row4col4.TextAlign = ContentAlignment.MiddleCenter;
                    row4col4.Font = new Font("Algerian", 60, FontStyle.Bold);
                    row4col4.ForeColor = Color.White;
                    lastclickedrow4 = row4col4;
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

        private void mediumlevelform_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//checkbutton
        {
            int n = 5;

            if (checkbuttonpress == false)
            {
                if (startbutton == true)
                {

                    if (lastclickedrow0 != null && lastclickedrow1 != null && lastclickedrow2 != null && lastclickedrow3 != null && lastclickedrow4 != null)
                    {
                        hardlevelattempt++;
                        allsolution = solver.SolveNQueens(n);
                        if (allsolution.Count > 0)
                        {
                            for (int i = 0; i < allsolution.Count; i++)
                            {
                                if ((userinputarray[0] == allsolution[i][0]) && (userinputarray[1] == allsolution[i][1]) && (userinputarray[2] == allsolution[i][2]) && (userinputarray[3] == allsolution[i][3]) && (userinputarray[4] == allsolution[i][4]))
                                {
                                    lastclickedrow0.BackColor = Color.Pink;
                                    lastclickedrow1.BackColor = Color.Pink;
                                    lastclickedrow2.BackColor = Color.Pink;
                                    lastclickedrow3.BackColor = Color.Pink;
                                    lastclickedrow4.BackColor = Color.Pink;
                                    hardpassattempt++;
                                }
                            }

                            if ((lastclickedrow0.BackColor != Color.Pink)&&(lastclickedrow1.BackColor != Color.Pink)&&(lastclickedrow2.BackColor != Color.Pink)&&(lastclickedrow3.BackColor != Color.Pink)&&(lastclickedrow4.BackColor != Color.Pink))
                            {
                                lastclickedrow0.BackColor = Color.Red;
                                lastclickedrow1.BackColor = Color.Red;
                                lastclickedrow2.BackColor = Color.Red;
                                lastclickedrow3.BackColor = Color.Red;
                                lastclickedrow4.BackColor = Color.Red;
                                hardfailattempt++;
                                
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

        private void button5_Click(object sender, EventArgs e) //startbutton
        {
            startbutton = true;
            checkbuttonpress = false;
            lastclickedrow0 = null;
            lastclickedrow1 = null;
            lastclickedrow2 = null;
            lastclickedrow3 = null;
            lastclickedrow4 = null;

            row0col0.BackColor = Color.White;
            row0col1.BackColor = Color.Black;
            row0col2.BackColor = Color.White;
            row0col3.BackColor = Color.Black;
            row0col4.BackColor = Color.White;

            row1col0.BackColor = Color.Black;
            row1col1.BackColor = Color.White;
            row1col2.BackColor = Color.Black;
            row1col3.BackColor = Color.White;
            row1col4.BackColor = Color.Black;

            row2col0.BackColor = Color.White;
            row2col1.BackColor = Color.Black;
            row2col2.BackColor = Color.White;
            row2col3.BackColor = Color.Black;
            row2col4.BackColor = Color.White;

            row3col0.BackColor = Color.Black;
            row3col1.BackColor = Color.White;
            row3col2.BackColor = Color.Black;
            row3col3.BackColor = Color.White;
            row3col4.BackColor = Color.Black;

            row4col0.BackColor = Color.White;
            row4col1.BackColor = Color.Black;
            row4col2.BackColor = Color.White;
            row4col3.BackColor = Color.Black;
            row4col4.BackColor = Color.White;


            row0col4.Text = "";
            row0col3.Text = "";
            row0col2.Text = "";
            row0col1.Text = "";
            row0col0.Text = "";

            row1col4.Text = "";
            row1col3.Text = "";
            row1col2.Text = "";
            row1col1.Text = "";
            row1col0.Text = "";

            row2col4.Text = "";
            row2col3.Text = "";
            row2col2.Text = "";
            row2col1.Text = "";
            row2col0.Text = "";

            row3col4.Text = "";
            row3col3.Text = "";
            row3col2.Text = "";
            row3col1.Text = "";
            row3col0.Text = "";
            

            row4col4.Text = "";
            row4col3.Text = "";
            row4col2.Text = "";
            row4col1.Text = "";
            row4col0.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e) //reset
        {
            if (startbutton == true || checkbuttonpress == true)
            {
                try
                {
                    lastclickedrow0 = null;
                    lastclickedrow1 = null;
                    lastclickedrow2 = null;
                    lastclickedrow3 = null;
                    lastclickedrow4 = null;

                    row0col0.BackColor = Color.White;
                    row0col1.BackColor = Color.Black;
                    row0col2.BackColor = Color.White;
                    row0col3.BackColor = Color.Black;
                    row0col4.BackColor = Color.White;

                    row1col0.BackColor = Color.Black;
                    row1col1.BackColor = Color.White;
                    row1col2.BackColor = Color.Black;
                    row1col3.BackColor = Color.White;
                    row1col4.BackColor = Color.Black;

                    row2col0.BackColor = Color.White;
                    row2col1.BackColor = Color.Black;
                    row2col2.BackColor = Color.White;
                    row2col3.BackColor = Color.Black;
                    row2col4.BackColor = Color.White;


                    row3col0.BackColor = Color.Black;
                    row3col1.BackColor = Color.White;
                    row3col2.BackColor = Color.Black;
                    row3col3.BackColor = Color.White;
                    row3col4.BackColor = Color.Black;

                    row4col0.BackColor = Color.White;
                    row4col1.BackColor = Color.Black;
                    row4col2.BackColor = Color.White;
                    row4col3.BackColor = Color.Black;
                    row4col4.BackColor = Color.White;

                    row0col4.Text = "";
                    row0col3.Text = "";
                    row0col2.Text = "";
                    row0col1.Text = "";
                    row0col0.Text = "";

                    row1col4.Text = "";
                    row1col3.Text = "";
                    row1col2.Text = "";
                    row1col1.Text = "";
                    row1col0.Text = "";

                    row2col4.Text = "";
                    row2col3.Text = "";
                    row2col2.Text = "";
                    row2col1.Text = "";
                    row2col0.Text = "";

                    row3col4.Text = "";
                    row3col3.Text = "";
                    row3col2.Text = "";
                    row3col1.Text = "";
                    row3col0.Text = "";

                    row4col4.Text = "";
                    row4col3.Text = "";
                    row4col2.Text = "";
                    row4col1.Text = "";
                    row4col0.Text = "";






                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Click start button to start the puzzle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void button3_Click(object sender, EventArgs e) //main menu
        {
            Form3_levels_ form3 = new Form3_levels_(name,noofattempt,noofpassattempt,nooffailedattempt,hardlevelattempt,hardpassattempt,hardfailattempt);
            form3.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hardlevelhelp h = new Hardlevelhelp();
            h.Show();
        }
    }
}
