using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginButton2 = new System.Windows.Forms.Button();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginBackButton);
            this.groupBox1.Controls.Add(this.loginButton2);
            this.groupBox1.Controls.Add(this.txtLoginEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "log in";
            // 
            // loginButton2
            // 
            this.loginButton2.Location = new System.Drawing.Point(14, 108);
            this.loginButton2.Name = "loginButton2";
            this.loginButton2.Size = new System.Drawing.Size(127, 47);
            this.loginButton2.TabIndex = 2;
            this.loginButton2.Text = "login";
            this.loginButton2.UseVisualStyleBackColor = true;
            this.loginButton2.Click += new System.EventHandler(this.loginButton2_Click);
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Location = new System.Drawing.Point(6, 53);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(136, 22);
            this.txtLoginEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "email";
            // 
            // loginBackButton
            // 
            this.loginBackButton.Location = new System.Drawing.Point(165, 108);
            this.loginBackButton.Name = "loginBackButton";
            this.loginBackButton.Size = new System.Drawing.Size(123, 47);
            this.loginBackButton.TabIndex = 3;
            this.loginBackButton.Text = "back";
            this.loginBackButton.UseVisualStyleBackColor = true;
            this.loginBackButton.Click += new System.EventHandler(this.loginBackButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button loginBackButton;

        private System.Windows.Forms.Button loginButton2;

        private System.Windows.Forms.TextBox txtLoginEmail;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}