﻿using System;
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
            new orderScreen().Show();
            this.Hide();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            new regScreen().Show();
            this.Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keepLoginChkBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (keepLoginChkBox.Checked)
            {
                
            }
        }
    }
}
