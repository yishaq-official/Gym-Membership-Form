using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMembership.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDemoData();
        }

        private void LoadDemoData()
        {
            dgvRecentActivity.Rows.Clear();
            dgvRecentActivity.Rows.Add("MEM-001", "Marcus Sterling", "Aerobics (500 ETB)", "08:30 AM", "Active");
            dgvRecentActivity.Rows.Add("MEM-002", "Elena Rostova", "Machine (500 ETB)", "09:15 AM", "Active");
            dgvRecentActivity.Rows.Add("MEM-003", "David Kim", "Dumbbell (400 ETB)", "10:05 AM", "Active");
            dgvRecentActivity.Rows.Add("MEM-004", "Sophia Ramirez", "Aerobics (500 ETB)", "11:20 AM", "Active");
            dgvRecentActivity.Rows.Add("MEM-005", "Alexander Wright", "Machine (500 ETB)", "01:45 PM", "Active");
            dgvRecentActivity.Rows.Add("MEM-006", "Chloe Anderson", "Dumbbell (400 ETB)", "02:10 PM", "Expiring Soon");
        }

        private void btnQuickRegister_Click(object sender, EventArgs e)
        {
            // Redirects to RegisterForm inside MainForm
            MainForm? mainForm = this.FindForm() as MainForm ?? this.ParentForm as MainForm;
            mainForm?.LoadForm(new RegisterForm());
        }

        private void btnQuickRenew_Click(object sender, EventArgs e)
        {
            // Redirects to MembershipForm inside MainForm
            MainForm? mainForm = this.FindForm() as MainForm ?? this.ParentForm as MainForm;
            mainForm?.LoadForm(new MembershipForm());
        }

        private void btnQuickMembers_Click(object sender, EventArgs e)
        {
            // Redirects to MembershipForm inside MainForm
            MainForm? mainForm = this.FindForm() as MainForm ?? this.ParentForm as MainForm;
            mainForm?.LoadForm(new MembershipForm());
        }
    }
}
