using System.Security.Cryptography.X509Certificates;

namespace BankAccount.cs
{
    public partial class Form1 : Form
    {



        public double num2;
        public double amount;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;

            if (radioButton1.Checked)
            {

                amount = Double.Parse(textBox1.Text);
                textBox2.Text = Convert.ToString(amount);

                sum = amount + amount;
             
               

                textBox2.Text = sum.ToString();








            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Enabled)
            {
                textBox2.Clear();
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Enabled)
            {

                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
           this.Hide();
        }
    }
}
