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
    public partial class logInScreen : Form
    {
        public logInScreen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (userTxtBox.Text == "" | passTxtBox.Text == "")
            {
                if (userTxtBox.Text == "")
                {
                    MessageBox.Show("Fill the Username or Wrong Username");
                }
                if (passTxtBox.Text == "")
                {
                    MessageBox.Show("Fill the Password or Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("LogIn Succesfully");
                MessageBox.Show("Enjoy our Product!");
                new orderScreen().Show();
                this.Hide();
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            new regScreen().Show();
            this.Hide();

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
                new logInScreen().Show();
                this.Hide();
            }
        
    }

        private void keepLoginChkBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (keepLoginChkBox.Checked)
            {
                
            }
        }
    }
}
