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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Coffee");

            if (coffee_HotRadButton.Checked)
            {
                MessageBox.Show("Hot coffee selected");
            }
            else
            {
                MessageBox.Show("Cold coffee selected");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Tea");

            if (coffee_HotRadButton.Checked)
            {
                MessageBox.Show("Hot Tea selected");
            }
            else
            {
                MessageBox.Show("Cold Tea selected");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
