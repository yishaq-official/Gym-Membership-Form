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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object? sender, EventArgs e)
        {
            if (cmbGender.Items.Count > 0)
                cmbGender.SelectedIndex = 0;

            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            dtpStartDate.Value = DateTime.Today;
            UpdateFeeDisplay();
        }

        private void cmbCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateFeeDisplay();
        }

        /// <summary>
        /// Updates the dynamic fee display based on the selected workout category.
        /// </summary>
        private void UpdateFeeDisplay()
        {
            string category = GetSelectedCategory();
            decimal fee = DataStore.GetFeeByCategory(category);
            lblFeeValue.Text = $"{fee:0} ETB";
        }

        private string GetSelectedCategory()
        {
            string raw = cmbCategory.SelectedItem?.ToString() ?? "Aerobics";

            if (raw.Contains("Machine", StringComparison.OrdinalIgnoreCase))
                return "Machine";

            if (raw.Contains("Dumbbell", StringComparison.OrdinalIgnoreCase))
                return "Dumbbell";

            return "Aerobics";
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // 1. Validation
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please enter the member's full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter a contact phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // 2. Prepare member data
            string category = GetSelectedCategory();
            decimal fee = DataStore.GetFeeByCategory(category);
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime expireDate = startDate.AddMonths(1);

            var newMember = new Member
            {
                FullName = fullName,
                Phone = phone,
                Category = category,
                MonthlyFee = fee,
                Gender = cmbGender.SelectedItem?.ToString() ?? "Male",
                Address = txtAddress.Text.Trim(),
                RegistrationDate = startDate,
                ExpirationDate = expireDate
            };

            // 3. Save to central DataStore
            DataStore.AddMember(newMember);

            // 4. Prompt user to view in Members list or continue registering
            DialogResult choice = MessageBox.Show(
                $"Member registered and activated successfully!\n\n" +
                $"• Member ID: {newMember.Id}\n" +
                $"• Name: {newMember.FullName}\n" +
                $"• Phone: {newMember.Phone}\n" +
                $"• Category: {newMember.Category} ({newMember.MonthlyFee:0} ETB)\n" +
                $"• Start Date: {newMember.RegistrationDate:dd MMM yyyy}\n" +
                $"• Expiration Date: {newMember.ExpirationDate:dd MMM yyyy}\n" +
                $"• Status: 🟢 Active\n\n" +
                $"Would you like to open the Members list now to view the new record?",
                "Registration Successful",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (choice == DialogResult.Yes)
            {
                MainForm? main = this.FindForm() as MainForm ?? this.ParentForm as MainForm;
                main?.LoadForm(new MembershipForm());
            }
            else
            {
                ClearForm();
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            if (cmbGender.Items.Count > 0)
                cmbGender.SelectedIndex = 0;

            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            dtpStartDate.Value = DateTime.Today;
            UpdateFeeDisplay();
            txtName.Focus();
        }
    }
}
