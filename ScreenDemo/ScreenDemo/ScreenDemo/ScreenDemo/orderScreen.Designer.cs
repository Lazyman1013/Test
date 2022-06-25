namespace ScreenDemo
{
    partial class orderScreen
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coffee_QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.coffee_HotRadButton = new System.Windows.Forms.RadioButton();
            this.coffee_ColdRadButton = new System.Windows.Forms.RadioButton();
            this.coffee_QuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_QuantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ScreenDemo.Properties.Resources.boba;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(35, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ScreenDemo.Properties.Resources.coffee;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(35, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ScreenDemo.Properties.Resources.Illustration;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(232, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 455);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // coffee_QuantityUpDown
            // 
            this.coffee_QuantityUpDown.Location = new System.Drawing.Point(243, 128);
            this.coffee_QuantityUpDown.Name = "coffee_QuantityUpDown";
            this.coffee_QuantityUpDown.Size = new System.Drawing.Size(43, 20);
            this.coffee_QuantityUpDown.TabIndex = 3;
            this.coffee_QuantityUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coffee_QuantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // coffee_HotRadButton
            // 
            this.coffee_HotRadButton.AutoSize = true;
            this.coffee_HotRadButton.Location = new System.Drawing.Point(191, 105);
            this.coffee_HotRadButton.Name = "coffee_HotRadButton";
            this.coffee_HotRadButton.Size = new System.Drawing.Size(42, 17);
            this.coffee_HotRadButton.TabIndex = 4;
            this.coffee_HotRadButton.TabStop = true;
            this.coffee_HotRadButton.Text = "Hot";
            this.coffee_HotRadButton.UseVisualStyleBackColor = true;
            // 
            // coffee_ColdRadButton
            // 
            this.coffee_ColdRadButton.AutoSize = true;
            this.coffee_ColdRadButton.Location = new System.Drawing.Point(239, 105);
            this.coffee_ColdRadButton.Name = "coffee_ColdRadButton";
            this.coffee_ColdRadButton.Size = new System.Drawing.Size(46, 17);
            this.coffee_ColdRadButton.TabIndex = 5;
            this.coffee_ColdRadButton.TabStop = true;
            this.coffee_ColdRadButton.Text = "Cold";
            this.coffee_ColdRadButton.UseVisualStyleBackColor = true;
            // 
            // coffee_QuantityLabel
            // 
            this.coffee_QuantityLabel.AutoSize = true;
            this.coffee_QuantityLabel.Location = new System.Drawing.Point(188, 130);
            this.coffee_QuantityLabel.Name = "coffee_QuantityLabel";
            this.coffee_QuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.coffee_QuantityLabel.TabIndex = 6;
            this.coffee_QuantityLabel.Text = "Quantity:";
            // 
            // orderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(571, 431);
            this.Controls.Add(this.coffee_QuantityLabel);
            this.Controls.Add(this.coffee_ColdRadButton);
            this.Controls.Add(this.coffee_HotRadButton);
            this.Controls.Add(this.coffee_QuantityUpDown);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "orderScreen";
            this.Text = "orderScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_QuantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown coffee_QuantityUpDown;
        private System.Windows.Forms.RadioButton coffee_HotRadButton;
        private System.Windows.Forms.RadioButton coffee_ColdRadButton;
        private System.Windows.Forms.Label coffee_QuantityLabel;
    }
}