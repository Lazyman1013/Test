namespace ScreenDemo
{
    partial class regScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regScreen));
            this.regButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.reg_passLabel = new System.Windows.Forms.Label();
            this.reg_passTxtBox = new System.Windows.Forms.TextBox();
            this.reg_userLabel = new System.Windows.Forms.Label();
            this.reg_userTxtBox = new System.Windows.Forms.TextBox();
            this.regLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.regButton.Location = new System.Drawing.Point(130, 162);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 17;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.exitButton.Location = new System.Drawing.Point(211, 162);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reg_passLabel
            // 
            this.reg_passLabel.AutoSize = true;
            this.reg_passLabel.BackColor = System.Drawing.Color.Transparent;
            this.reg_passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.reg_passLabel.Location = new System.Drawing.Point(92, 92);
            this.reg_passLabel.Name = "reg_passLabel";
            this.reg_passLabel.Size = new System.Drawing.Size(65, 13);
            this.reg_passLabel.TabIndex = 15;
            this.reg_passLabel.Text = "Password:";
            // 
            // reg_passTxtBox
            // 
            this.reg_passTxtBox.Location = new System.Drawing.Point(163, 89);
            this.reg_passTxtBox.Name = "reg_passTxtBox";
            this.reg_passTxtBox.Size = new System.Drawing.Size(100, 20);
            this.reg_passTxtBox.TabIndex = 14;
            // 
            // reg_userLabel
            // 
            this.reg_userLabel.AutoSize = true;
            this.reg_userLabel.BackColor = System.Drawing.Color.Transparent;
            this.reg_userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.reg_userLabel.Location = new System.Drawing.Point(90, 66);
            this.reg_userLabel.Name = "reg_userLabel";
            this.reg_userLabel.Size = new System.Drawing.Size(67, 13);
            this.reg_userLabel.TabIndex = 13;
            this.reg_userLabel.Text = "Username:";
            // 
            // reg_userTxtBox
            // 
            this.reg_userTxtBox.Location = new System.Drawing.Point(163, 63);
            this.reg_userTxtBox.Name = "reg_userTxtBox";
            this.reg_userTxtBox.Size = new System.Drawing.Size(100, 20);
            this.reg_userTxtBox.TabIndex = 12;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.BackColor = System.Drawing.Color.Transparent;
            this.regLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(67)))), ((int)(((byte)(52)))));
            this.regLabel.Location = new System.Drawing.Point(185, 36);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(54, 13);
            this.regLabel.TabIndex = 11;
            this.regLabel.Text = "Register";
            // 
            // regScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ScreenDemo.Properties.Resources.Illustration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(416, 197);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reg_passLabel);
            this.Controls.Add(this.reg_passTxtBox);
            this.Controls.Add(this.reg_userLabel);
            this.Controls.Add(this.reg_userTxtBox);
            this.Controls.Add(this.regLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "regScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label reg_passLabel;
        private System.Windows.Forms.TextBox reg_passTxtBox;
        private System.Windows.Forms.Label reg_userLabel;
        private System.Windows.Forms.TextBox reg_userTxtBox;
        private System.Windows.Forms.Label regLabel;
    }
}