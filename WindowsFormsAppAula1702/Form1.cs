using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAula1702
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int val1 = Int32.Parse(txtval1.Text);
            int val2 = Int32.Parse(txtval2.Text);
            int total = val1 + val2;

            lbltotal.Text = Convert.ToString(total);

        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int val1 = Int32.Parse(txtval1.Text);
            int val2 = Int32.Parse(txtval2.Text);

            int total = val1 - val2;

            lbltotal.Text = Convert.ToString(total);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            

            int val1 = int.Parse(txtval1.Text);
            int val2 = int.Parse(txtval2.Text);
            if (val2 == 0 || val1 == 0)
            {
                MessageBox.Show("divide por 0 não faz favor");
            }
            else
            {
                int total = val1 / val2;
                lbltotal.Text = Convert.ToString(total);
            }

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            
            int val1 = Int32.Parse(txtval1.Text);
            int val2 = Int32.Parse(txtval2.Text);

            int total = val1 * val2;

            lbltotal.Text = Convert.ToString(total);
        }
    }
}
