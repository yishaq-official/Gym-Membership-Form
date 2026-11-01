using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymMembership;

namespace GymMembership.Forms
{
    public partial class MainForm : Form
    {
        private bool _isLoggingOut = false;

        public MainForm()
        {
            InitializeComponent();
            // Load DashboardForm as default view on startup
            LoadForm(new DashboardForm());
        }

        public void LoadForm(Form childForm)
        {
            if (this.panelContent.Controls.Count > 0)
            {
                this.panelContent.Controls[0].Dispose();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashForm = new DashboardForm();
            LoadForm(dashForm);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MembershipForm membersForm = new MembershipForm();
            LoadForm(membersForm);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // Loads ProfileForm
            ProfileForm profileForm = new ProfileForm();
            LoadForm(profileForm);
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            // Loads RegisterForm
            RegisterForm RegisterForm = new RegisterForm();
            LoadForm(RegisterForm);
        }

        private void btnMembers_Click_1(object sender, EventArgs e)
        {
            MembershipForm MemberForm = new MembershipForm();
            LoadForm(MemberForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _isLoggingOut = true;

                LoginForm? loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
                if (loginForm != null)
                {
                    loginForm.ResetForm();
                    loginForm.Show();
                }
                else
                {
                    LoginForm newLogin = new LoginForm();
                    newLogin.Show();
                }

                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLoggingOut)
            {
                Application.Exit();
            }
        }
    }
}
