using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIncVAT_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(textBox1.Text);
            MessageBox.Show($"The price with VAT is : {a + Constants.kdv * a}");
            textBox1.Clear();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The name of the company is :{Constants.Institute}");
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(textBox2.Text);
            decimal num2 = Convert.ToDecimal(textBox3.Text);

            MessageBox.Show($"The sum of the  two numbers with static mat is : {Mathematic_Static.Addition(num1, num2)}");

            Mathematic_Normal m = new Mathematic_Normal();
            MessageBox.Show($"The sum of the two numbers with normal mat is {m.Addition(num1, num2)}");
            MessageBox.Show($"The difference of the two numbers with normal mat in static func is {Mathematic_Normal.Substraction(num1, num2)}");

            textBox2.Clear();
            textBox3.Clear();


        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            string company = textBox4.Text.ToLower();
            if (company == Constants.Institute)
            {
                MessageBox.Show("Congrats! we have executed a 30% discount from the price!");
            }
            else
            {
                MessageBox.Show("We have executed a 5% discount from the price!");
            }

            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            MessageBox.Show(ExtensionMethod.clearTurkishLetter(name));
            textBox5.Clear();
        }
    }
}
