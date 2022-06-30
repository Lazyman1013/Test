using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenDemo
{
    public partial class orderScreen : Form
    {
        public orderScreen()
        {
            InitializeComponent();
        }
        int coffeePrice = 4;
        int teaPrice = 4;
        int noOrder = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You have selected Coffee");

           // if (coffee_HotRadButton.Checked)
           // {
           //     MessageBox.Show("Hot coffee selected");
           // }
           // else
           // {
            //    MessageBox.Show("Cold coffee selected");
            //}
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You have selected Tea");

           // if (coffee_HotRadButton.Checked)
           // {
           //     MessageBox.Show("Hot Tea selected");
          //  }
           // else
           // {
           //     MessageBox.Show("Cold Tea selected");
           // }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
            else if (result == DialogResult.No)
            {
                new orderScreen().Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (coffee_HotRadButton.Checked)
            {
                int coffee = int.Parse(textBox2.Text);
                MessageBox.Show("You ordered: " + coffee + " hot coffee ");
                
            }
            else if (coffee_ColdRadButton.Checked)
            {
                int coffee = int.Parse(textBox2.Text);
                MessageBox.Show("You ordered: " + coffee + " cold coffee ");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int tea = int.Parse(textBox4.Text);
                MessageBox.Show("You ordered: " + tea + " hot tea ");

            }
            else if (radioButton2.Checked)
            {
                int tea = int.Parse(textBox4.Text);
                MessageBox.Show("You ordered: " + tea + " cold tea ");

            }
           


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int totalPrice3;
            int totalOrder= int.Parse(textBox4.Text);
            int totalTea = int.Parse(textBox2.Text);
            totalOrder += totalTea;
            textBox1.Text = totalOrder.ToString();

            int totalPrice = int.Parse(textBox2.Text + coffeePrice);
            int totalPrice2 = int.Parse(textBox4.Text + teaPrice);


             totalPrice3 = (totalPrice + totalPrice2);
            textBox3.Text = totalPrice3.ToString();
            
           


        }
    }
}
