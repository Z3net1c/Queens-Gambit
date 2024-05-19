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
    public partial class resultform : Form
    {
        string n;
        int easyattempts;
        int easypass;
        int easyfail;

        int hardattempts;
        int hardpass;
        int hardfail;

        int progresseasy;
        int progresshard;
        public resultform(string name, int easy_no_of_attempt, int easy_pass_no_of_attempt,int easy_failed_no_of_attempt, int hard_no_of_attempt, int hard_pass_no_of_attempt, int hard_failed_no_of_attempt)
        {
            InitializeComponent();
            n = name;
            easyattempts = easy_no_of_attempt;
            easypass = easy_pass_no_of_attempt;
            easyfail = easy_failed_no_of_attempt;

            hardattempts = hard_no_of_attempt;
            hardpass = hard_pass_no_of_attempt;
            hardfail = hard_failed_no_of_attempt;

            easyleveltotalnoofttempt.Text=easyattempts.ToString();
            easypassnoofattempt.Text = easypass.ToString();
            easypfailednoofattempt.Text = easyfail.ToString();

            Hardleveltotalnoofttempt.Text = hardattempts.ToString();
            hardpassnoofattempt.Text = hardpass.ToString();
            hardpfailednoofattempt.Text = hardfail.ToString();
            namelabel.Text = n;

            if (easyattempts != 0)
            {
                progresseasy = easypass;
                if (progresseasy < (easyattempts / 2))
                {
                    progresslabeleasy.Text = "Low";
                }
                if (progresseasy == (easyattempts / 2))
                {
                    progresslabeleasy.Text = "Moderate";
                }
                if (progresseasy > (easyattempts / 2))
                {
                    progresslabeleasy.Text = "High";
                }
            }
            if (easyattempts == 0)
            {
                progresslabeleasy.Text = "-------";
            }

            //hard
            if (hardattempts != 0)
            {
                progresshard = hardpass;
                if (progresshard < (hardattempts / 2))
                {
                    progresslabelhard.Text = "Low";
                }
                if (progresshard == (hardattempts / 2))
                {
                    progresslabelhard.Text = "Moderate";
                }
                if (progresshard > (hardattempts / 2))
                {
                    progresslabelhard.Text = "High";
                }
            }
            if (hardattempts == 0)
            {
                progresslabelhard.Text = "-------";
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form3_levels_ fff = new Form3_levels_(n,easyattempts,easypass,easyfail,hardattempts,hardpass,hardfail);
            fff.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void progresslabeleasy_Click(object sender, EventArgs e)
        {

        }

        private void resultform_Load(object sender, EventArgs e)
        {
   
        }

       
    }
}
