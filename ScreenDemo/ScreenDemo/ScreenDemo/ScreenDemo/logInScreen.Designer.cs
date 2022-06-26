namespace ScreenDemo
{
    partial class logInScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInScreen));
            this.loginButton = new System.Windows.Forms.Button();
            this.keepLoginChkBox = new System.Windows.Forms.CheckBox();
            this.signinLabel = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.loginButton.Location = new System.Drawing.Point(176, 162);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // keepLoginChkBox
            // 
            this.keepLoginChkBox.AutoSize = true;
            this.keepLoginChkBox.BackColor = System.Drawing.Color.Transparent;
            this.keepLoginChkBox.ForeColor = System.Drawing.Color.White;
            this.keepLoginChkBox.Location = new System.Drawing.Point(162, 98);
            this.keepLoginChkBox.Name = "keepLoginChkBox";
            this.keepLoginChkBox.Size = new System.Drawing.Size(94, 17);
            this.keepLoginChkBox.TabIndex = 1;
            this.keepLoginChkBox.Text = "Remember me";
            this.keepLoginChkBox.UseVisualStyleBackColor = false;
            this.keepLoginChkBox.CheckedChanged += new System.EventHandler(this.keepLoginChkBox_CheckedChanged);
            // 
            // signinLabel
            // 
            this.signinLabel.AutoSize = true;
            this.signinLabel.BackColor = System.Drawing.Color.Transparent;
            this.signinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.signinLabel.Location = new System.Drawing.Point(192, 19);
            this.signinLabel.Name = "signinLabel";
            this.signinLabel.Size = new System.Drawing.Size(46, 13);
            this.signinLabel.TabIndex = 2;
            this.signinLabel.Text = "Sign in";
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(162, 46);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(100, 20);
            this.userTxtBox.TabIndex = 3;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.userLabel.Location = new System.Drawing.Point(89, 49);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(67, 13);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Username:";
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(162, 72);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passTxtBox.TabIndex = 5;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.passLabel.Location = new System.Drawing.Point(91, 75);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(65, 13);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Password:";
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.exitButton.Location = new System.Drawing.Point(257, 162);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // regButton
            // 
            this.regButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.regButton.Location = new System.Drawing.Point(95, 162);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 8;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // logInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ScreenDemo.Properties.Resources.Illustration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(416, 197);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.signinLabel);
            this.Controls.Add(this.keepLoginChkBox);
            this.Controls.Add(this.loginButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logInScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox keepLoginChkBox;
        private System.Windows.Forms.Label signinLabel;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button regButton;
    }
}

