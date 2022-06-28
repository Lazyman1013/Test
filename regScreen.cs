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
            if (reg_userTxtBox.Text == "" | reg_passTxtBox.Text == "")
            {
                if (reg_userTxtBox.Text == "")
                {
                    MessageBox.Show("Fill the Username");
                }
                if (reg_passTxtBox.Text == "")
                {
                    MessageBox.Show("Fill the Password");
                }
                
            }
            else 
                {
                MessageBox.Show("You are now Registered");
                new logInScreen().Show();
                    this.Hide();
                }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                  "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                new regScreen().Show();
                this.Hide();
            }
        }
    }
    
}
