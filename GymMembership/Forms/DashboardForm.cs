using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GymMembership.Data;

namespace GymMembership.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        /// <summary>
        /// Reads live counts, revenue in ETB, and recent members from central DataStore.
        /// </summary>
        public void LoadDashboardData()
        {
            // 1. KPI Cards (Live from DataStore)
            lblTotalValue.Text = DataStore.TotalMembersCount.ToString();
            lblTotalSub.Text = $"{DataStore.ActiveMembersCount} Active / {DataStore.ExpiredMembersCount} Expired";

            lblActiveValue.Text = DataStore.ActiveMembersCount.ToString();
            int activePct = DataStore.TotalMembersCount > 0
                ? (DataStore.ActiveMembersCount * 100 / DataStore.TotalMembersCount)
                : 0;
            lblActiveSub.Text = $"{activePct}% active subscriber rate";

            lblRevenueValue.Text = $"{DataStore.TotalMonthlyRevenue:N0} ETB";
            lblRevenueSub.Text = "▲ Total active monthly revenue";

            // 2. Recent Member Activity Table (Live from DataStore)
            dgvRecentActivity.Rows.Clear();
            var members = DataStore.GetAll();

            foreach (var m in members)
            {
                string statusDisplay = m.IsActive ? "🟢 Active" : "🔴 Expired";
                string dateDisplay = m.RegistrationDate.ToString("dd MMM yyyy");
                string planDisplay = $"{m.Category} ({m.MonthlyFee:0} ETB)";

                dgvRecentActivity.Rows.Add(
                    m.Id,
                    m.FullName,
                    planDisplay,
                    dateDisplay,
                    statusDisplay
                );
            }
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
