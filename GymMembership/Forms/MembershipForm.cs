using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GymMembership.Data;

namespace GymMembership.Forms
{
    public partial class MembershipForm : Form
    {
        public MembershipForm()
        {
            InitializeComponent();
        }

        private void MembershipForm_Load(object? sender, EventArgs e)
        {
            if (cmbStatusFilter.Items.Count > 0)
                cmbStatusFilter.SelectedIndex = 0;

            if (cmbPlanFilter.Items.Count > 0)
                cmbPlanFilter.SelectedIndex = 0;

            LoadMembersData();
        }

        /// <summary>
        /// Reads members from central DataStore, applies active search/filters, and binds to dgvMembers.
        /// </summary>
        public void LoadMembersData()
        {
            // Update top KPI cards directly from central store
            lblTotalCount.Text = DataStore.TotalMembersCount.ToString();
            lblActiveCount.Text = DataStore.ActiveMembersCount.ToString();
            lblExpiredCount.Text = DataStore.ExpiredMembersCount.ToString();

            // Retrieve all members
            IEnumerable<Member> members = DataStore.GetAll();

            // 1. Text Search Filter (Full Name, Phone, ID)
            string search = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                members = members.Where(m =>
                    m.FullName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    m.Phone.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    m.Id.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            // 2. Status Filter
            string status = cmbStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            if (status.Contains("Active", StringComparison.OrdinalIgnoreCase))
            {
                members = members.Where(m => m.IsActive);
            }
            else if (status.Contains("Expired", StringComparison.OrdinalIgnoreCase))
            {
                members = members.Where(m => !m.IsActive);
            }

            // 3. Category Filter
            string category = cmbPlanFilter.SelectedItem?.ToString() ?? "All Categories";
            if (!category.StartsWith("All", StringComparison.OrdinalIgnoreCase))
            {
                members = members.Where(m => m.Category.Contains(category, StringComparison.OrdinalIgnoreCase));
            }

            // Populate DataGridView
            dgvMembers.Rows.Clear();
            foreach (var m in members)
            {
                string statusDisplay = m.IsActive ? "🟢 Active" : "🔴 Expired";
                string planDisplay = $"{m.Category} ({m.MonthlyFee:0} ETB)";

                dgvMembers.Rows.Add(
                    m.Id,
                    m.FullName,
                    m.Phone,
                    planDisplay,
                    m.RegistrationDate.ToString("dd MMM yyyy"),
                    m.ExpirationDate.ToString("dd MMM yyyy"),
                    statusDisplay
                );
            }

            lblSummary.Text = $"Displaying {dgvMembers.Rows.Count} of {DataStore.TotalMembersCount} member(s)";
        }

        private void FilterChanged(object? sender, EventArgs e)
        {
            LoadMembersData();
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            LoadMembersData();
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            LoadMembersData();
        }

        private void btnNewMember_Click(object? sender, EventArgs e)
        {
            // Redirect to RegisterForm
            MainForm? main = this.FindForm() as MainForm ?? this.ParentForm as MainForm;
            main?.LoadForm(new RegisterForm());
        }

        private void btnRenew_Click(object? sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member row from the table first.", "Renew Membership", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string memberId = dgvMembers.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            string memberName = dgvMembers.SelectedRows[0].Cells[1].Value?.ToString() ?? "Member";

            if (DataStore.RenewMember(memberId, 1))
            {
                var member = DataStore.FindById(memberId);
                MessageBox.Show(
                    $"Membership for {memberName} ({memberId}) renewed successfully for 1 month!\n\n" +
                    $"• Registration/Renewal: {member?.RegistrationDate:dd MMM yyyy}\n" +
                    $"• New Expiration Date: {member?.ExpirationDate:dd MMM yyyy}\n" +
                    $"• Status: Active",
                    "Renewal Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadMembersData();
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member row to delete.", "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string memberId = dgvMembers.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            string memberName = dgvMembers.SelectedRows[0].Cells[1].Value?.ToString() ?? "Member";

            var confirm = MessageBox.Show(
                $"Are you sure you want to remove member '{memberName}' ({memberId}) from the system?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                DataStore.DeleteMember(memberId);
                LoadMembersData();
            }
        }
    }
}
