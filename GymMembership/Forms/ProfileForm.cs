using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymMembership.Forms
{
    public partial class ProfileForm : Form
    {
        // Saved state for administrator details
        private string _savedFullName = "System Administrator";
        private string _savedUsername = "admin";
        private string _savedEmail = "admin@gym.com";
        private string _savedPhone = "+251 941 111 111";

        // Simulated admin password (matching the default login password)
        private string _currentPassword = "admin123";

        // Track whether we are in View Mode or Edit Mode
        private bool _isEditingProfile = false;

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Load saved admin data into fields
            DisplayAdminData();

            // Start in View Mode (Plain text / Read-only)
            SetProfileEditMode(false);

            // Hide password change inputs initially
            pnlPasswordInputs.Visible = false;
            btnOpenPasswordChange.Visible = true;
        }

        /// <summary>
        /// Populates the text boxes with the current saved admin data.
        /// </summary>
        private void DisplayAdminData()
        {
            txtFullName.Text = _savedFullName;
            txtUsername.Text = _savedUsername;
            txtEmail.Text = _savedEmail;
            txtPhone.Text = _savedPhone;
        }

        /// <summary>
        /// Toggles between View Mode (plain text appearance) and Edit Mode (active inputs).
        /// </summary>
        private void SetProfileEditMode(bool isEditing)
        {
            _isEditingProfile = isEditing;

            // In Edit Mode, allow editing editable fields; otherwise keep read-only
            txtFullName.ReadOnly = !isEditing;
            txtEmail.ReadOnly = !isEditing;
            txtPhone.ReadOnly = !isEditing;

            // Username is always read-only
            txtUsername.ReadOnly = true;

            // Visual feedback: White background when editing, system control light when viewing
            Color editableBg = isEditing ? Color.White : SystemColors.ControlLight;
            txtFullName.BackColor = editableBg;
            txtEmail.BackColor = editableBg;
            txtPhone.BackColor = editableBg;

            // Update action buttons matching the login button style
            if (isEditing)
            {
                btnEditProfile.Text = "Save Changes";
                btnEditProfile.BackColor = SystemColors.MenuHighlight;
                btnCancelEdit.Visible = true;
                txtFullName.Focus();
            }
            else
            {
                btnEditProfile.Text = "Edit Profile";
                btnEditProfile.BackColor = SystemColors.MenuHighlight;
                btnCancelEdit.Visible = false;
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            // If currently in View Mode, switch to Edit Mode
            if (!_isEditingProfile)
            {
                SetProfileEditMode(true);
                return;
            }

            // If in Edit Mode, validate and save
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter a contact phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // Save the updated values
            _savedFullName = fullName;
            _savedEmail = email;
            _savedPhone = phone;

            // Return to View Mode
            SetProfileEditMode(false);

            MessageBox.Show("Admin profile details updated successfully!", "Profile Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            // Revert changes back to saved values and return to View Mode
            DisplayAdminData();
            SetProfileEditMode(false);
        }

        private void btnOpenPasswordChange_Click(object sender, EventArgs e)
        {
            // Show password input panel and hide trigger button
            pnlPasswordInputs.Visible = true;
            btnOpenPasswordChange.Visible = false;

            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            txtCurrentPassword.Focus();
        }

        private void btnCancelPassword_Click(object sender, EventArgs e)
        {
            // Hide password input panel and show trigger button again
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            pnlPasswordInputs.Visible = false;
            btnOpenPasswordChange.Visible = true;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string currentInput = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Validate current password
            if (string.IsNullOrEmpty(currentInput))
            {
                MessageBox.Show("Please enter your current password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return;
            }

            if (currentInput != _currentPassword)
            {
                MessageBox.Show("The current password you entered is incorrect.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Clear();
                txtCurrentPassword.Focus();
                return;
            }

            // Validate new password
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword.Length < 4)
            {
                MessageBox.Show("New password must be at least 4 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            // Update stored password
            _currentPassword = newPassword;

            // Clear inputs and close the password section
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            pnlPasswordInputs.Visible = false;
            btnOpenPasswordChange.Visible = true;

            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool hide = !chkShowPassword.Checked;
            txtCurrentPassword.UseSystemPasswordChar = hide;
            txtNewPassword.UseSystemPasswordChar = hide;
            txtConfirmPassword.UseSystemPasswordChar = hide;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
