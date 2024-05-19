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
    public partial class Form2_name_ : Form
    {
        public string participentname;
        public Form2_name_()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nametextbox.Text))
            {
                MessageBox.Show("Please enter your name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                participentname = nametextbox.Text;
                Form3_levels_ form3 = new Form3_levels_(participentname);
                form3.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r= MessageBox.Show("Are u sure you don't want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
            
        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
