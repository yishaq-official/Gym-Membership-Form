using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMembership
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "admin123")
            {
                // Optional: Show a quick welcome message
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the Main form
                //Main mainWindow = new Main();
                //mainWindow.Show();

                // Hide the Login form (using Hide instead of Close keeps the application running)
                this.Hide();
            }
            else
            {
                // Show an error message if credentials don't match
                MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear the password field and focus back on username for convenience
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
