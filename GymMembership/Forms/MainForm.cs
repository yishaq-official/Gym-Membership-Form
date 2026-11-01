using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMembership.Forms
{
    public partial class MainForm : Form
    {
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
    }
}
