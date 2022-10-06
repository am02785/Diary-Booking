using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddUser : Form
    {
        private AddBooking addBooking;
            
        public AddUser(AddBooking addBooking)
        {
            this.addBooking = addBooking;
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string email = txtUserEmail.Text;
            this.addBooking.addUserEmail(email);
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}