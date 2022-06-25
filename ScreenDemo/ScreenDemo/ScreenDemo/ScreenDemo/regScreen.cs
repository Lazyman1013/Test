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
    public partial class regScreen : Form
    {
        public regScreen()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            new logInScreen().Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
