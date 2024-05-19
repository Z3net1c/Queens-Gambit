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
    public partial class Form3_levels_ : Form
    {
        public string name;

        int easy_no_of_attempt;
        int easy_pass_no_of_attempt;
        int easy_failed_no_of_attempt;

        int hard_no_of_attempt;
        int hard_pass_no_of_attempt;
        int hard_failed_no_of_attempt;
        
        public Form3_levels_()
        {
            InitializeComponent();
        }
        
        public Form3_levels_(string n)
        {
            InitializeComponent();
            name = n;
            hard_no_of_attempt = 0;
            hard_pass_no_of_attempt = 0;
            hard_failed_no_of_attempt = 0;

            easy_no_of_attempt = 0;
            easy_pass_no_of_attempt = 0;
            easy_failed_no_of_attempt = 0;
        }
        public Form3_levels_(string n, int n1,int n2,int n3,int m1,int m2,int m3)
        {
            InitializeComponent();

            hard_no_of_attempt = m1;
            hard_pass_no_of_attempt = m2;
            hard_failed_no_of_attempt = m3;

            easy_no_of_attempt = n1;
            easy_pass_no_of_attempt = n2;
            easy_failed_no_of_attempt = n3;
            name = n;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            helpform helpform = new helpform();
            helpform.Show();
            this.Close();
        }

        private void easylevelbutton_Click(object sender, EventArgs e)
        {
            easylevelform easyform = new easylevelform(name,easy_no_of_attempt,easy_pass_no_of_attempt,easy_failed_no_of_attempt,hard_no_of_attempt,hard_pass_no_of_attempt,hard_failed_no_of_attempt);
            easyform.Show();
            this.Close();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form2_name_ form2Instance = new Form2_name_();
            form2Instance.Show();
            this.Close();
        }

        private void mediumlevelbutton_Click(object sender, EventArgs e)
        {
            mediumlevelform mediumform = new mediumlevelform(name,easy_no_of_attempt,easy_pass_no_of_attempt,easy_failed_no_of_attempt,hard_no_of_attempt,hard_pass_no_of_attempt,hard_failed_no_of_attempt);
            mediumform.Show();
            this.Close();
        }

        private void hardlevelbutton_Click(object sender, EventArgs e)
        {
           
            
            resultform resform = new resultform(name,easy_no_of_attempt,easy_pass_no_of_attempt,easy_failed_no_of_attempt,hard_no_of_attempt,hard_pass_no_of_attempt,hard_failed_no_of_attempt);
            resform.Show();
            this.Close();
        }
    }
}
