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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected Tea");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
