using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class AddBooking
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
            this.bookingForm = new System.Windows.Forms.GroupBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.bookingBackButton = new System.Windows.Forms.Button();
            this.addBookingButton = new System.Windows.Forms.Button();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingForm
            // 
            this.bookingForm.Controls.Add(this.addUserButton);
            this.bookingForm.Controls.Add(this.bookingBackButton);
            this.bookingForm.Controls.Add(this.addBookingButton);
            this.bookingForm.Controls.Add(this.endTimePicker);
            this.bookingForm.Controls.Add(this.label3);
            this.bookingForm.Controls.Add(this.startTimePicker);
            this.bookingForm.Controls.Add(this.label2);
            this.bookingForm.Controls.Add(this.bookingName);
            this.bookingForm.Controls.Add(this.label1);
            this.bookingForm.Location = new System.Drawing.Point(28, 27);
            this.bookingForm.Name = "bookingForm";
            this.bookingForm.Size = new System.Drawing.Size(727, 361);
            this.bookingForm.TabIndex = 0;
            this.bookingForm.TabStop = false;
            this.bookingForm.Text = "addBooking";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(400, 271);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(128, 42);
            this.addUserButton.TabIndex = 8;
            this.addUserButton.Text = "add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // bookingBackButton
            // 
            this.bookingBackButton.Location = new System.Drawing.Point(210, 267);
            this.bookingBackButton.Name = "bookingBackButton";
            this.bookingBackButton.Size = new System.Drawing.Size(127, 46);
            this.bookingBackButton.TabIndex = 7;
            this.bookingBackButton.Text = "back";
            this.bookingBackButton.UseVisualStyleBackColor = true;
            this.bookingBackButton.Click += new System.EventHandler(this.bookingBackButton_Click);
            // 
            // addBookingButton
            // 
            this.addBookingButton.Location = new System.Drawing.Point(6, 267);
            this.addBookingButton.Name = "addBookingButton";
            this.addBookingButton.Size = new System.Drawing.Size(140, 47);
            this.addBookingButton.TabIndex = 6;
            this.addBookingButton.Text = "add booking";
            this.addBookingButton.UseVisualStyleBackColor = true;
            this.addBookingButton.Click += new System.EventHandler(this.addBookingButton_Click);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(6, 181);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(139, 22);
            this.endTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "endTime";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(6, 119);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(139, 22);
            this.startTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "startTime";
            // 
            // bookingName
            // 
            this.bookingName.Location = new System.Drawing.Point(6, 55);
            this.bookingName.Name = "bookingName";
            this.bookingName.Size = new System.Drawing.Size(127, 22);
            this.bookingName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookingForm);
            this.Name = "AddBooking";
            this.Text = "AddBooking";
            this.bookingForm.ResumeLayout(false);
            this.bookingForm.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addUserButton;

        private System.Windows.Forms.Button bookingBackButton;

        private System.Windows.Forms.TextBox bookingName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Button addBookingButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox bookingForm;

        #endregion
    }
}