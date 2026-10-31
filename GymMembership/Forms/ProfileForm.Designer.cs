namespace GymMembership.Forms
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            panelHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            grpPersonalInfo = new GroupBox();
            btnCancelEdit = new Button();
            btnEditProfile = new Button();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            grpSecurity = new GroupBox();
            btnOpenPasswordChange = new Button();
            lblPasswordDisplay = new Label();
            pnlPasswordInputs = new Panel();
            btnCancelPassword = new Button();
            btnSavePassword = new Button();
            chkShowPassword = new CheckBox();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblCurrentPassword = new Label();
            btnClose = new Button();
            panelHeader.SuspendLayout();
            grpPersonalInfo.SuspendLayout();
            grpSecurity.SuspendLayout();
            pnlPasswordInputs.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveCaption;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(684, 65);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = SystemColors.ControlDarkDark;
            lblSubtitle.Location = new Point(22, 38);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(234, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage your administrator account details";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(20, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Profile";
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.BackColor = SystemColors.ActiveBorder;
            grpPersonalInfo.Controls.Add(btnCancelEdit);
            grpPersonalInfo.Controls.Add(btnEditProfile);
            grpPersonalInfo.Controls.Add(txtPhone);
            grpPersonalInfo.Controls.Add(lblPhone);
            grpPersonalInfo.Controls.Add(txtEmail);
            grpPersonalInfo.Controls.Add(lblEmail);
            grpPersonalInfo.Controls.Add(txtUsername);
            grpPersonalInfo.Controls.Add(lblUsername);
            grpPersonalInfo.Controls.Add(txtFullName);
            grpPersonalInfo.Controls.Add(lblFullName);
            grpPersonalInfo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPersonalInfo.Location = new Point(24, 75);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(636, 185);
            grpPersonalInfo.TabIndex = 1;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Personal Information";
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelEdit.Location = new Point(460, 95);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(150, 30);
            btnCancelEdit.TabIndex = 9;
            btnCancelEdit.Text = "Cancel";
            btnCancelEdit.UseVisualStyleBackColor = true;
            btnCancelEdit.Visible = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = SystemColors.MenuHighlight;
            btnEditProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfile.ForeColor = Color.Black;
            btnEditProfile.Location = new Point(460, 134);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(150, 32);
            btnEditProfile.TabIndex = 8;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.ControlLight;
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(150, 137);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(280, 23);
            txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(20, 140);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(91, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(150, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(20, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email Address:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLight;
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(150, 65);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(280, 23);
            txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(20, 68);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.ControlLight;
            txtFullName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(150, 29);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(280, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(20, 32);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(64, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name:";
            // 
            // grpSecurity
            // 
            grpSecurity.BackColor = SystemColors.ActiveBorder;
            grpSecurity.Controls.Add(btnOpenPasswordChange);
            grpSecurity.Controls.Add(lblPasswordDisplay);
            grpSecurity.Controls.Add(pnlPasswordInputs);
            grpSecurity.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSecurity.Location = new Point(24, 275);
            grpSecurity.Name = "grpSecurity";
            grpSecurity.Size = new Size(636, 225);
            grpSecurity.TabIndex = 2;
            grpSecurity.TabStop = false;
            grpSecurity.Text = "Security & Password";
            // 
            // btnOpenPasswordChange
            // 
            btnOpenPasswordChange.BackColor = SystemColors.MenuHighlight;
            btnOpenPasswordChange.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenPasswordChange.ForeColor = Color.Black;
            btnOpenPasswordChange.Location = new Point(190, 26);
            btnOpenPasswordChange.Name = "btnOpenPasswordChange";
            btnOpenPasswordChange.Size = new Size(160, 32);
            btnOpenPasswordChange.TabIndex = 1;
            btnOpenPasswordChange.Text = "Change Password";
            btnOpenPasswordChange.UseVisualStyleBackColor = false;
            btnOpenPasswordChange.Click += btnOpenPasswordChange_Click;
            // 
            // lblPasswordDisplay
            // 
            lblPasswordDisplay.AutoSize = true;
            lblPasswordDisplay.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordDisplay.Location = new Point(20, 33);
            lblPasswordDisplay.Name = "lblPasswordDisplay";
            lblPasswordDisplay.Size = new Size(64, 17);
            lblPasswordDisplay.TabIndex = 0;
            lblPasswordDisplay.Text = "Password";
            // 
            // pnlPasswordInputs
            // 
            pnlPasswordInputs.BackColor = SystemColors.ActiveBorder;
            pnlPasswordInputs.Controls.Add(btnCancelPassword);
            pnlPasswordInputs.Controls.Add(btnSavePassword);
            pnlPasswordInputs.Controls.Add(chkShowPassword);
            pnlPasswordInputs.Controls.Add(txtConfirmPassword);
            pnlPasswordInputs.Controls.Add(lblConfirmPassword);
            pnlPasswordInputs.Controls.Add(txtNewPassword);
            pnlPasswordInputs.Controls.Add(lblNewPassword);
            pnlPasswordInputs.Controls.Add(txtCurrentPassword);
            pnlPasswordInputs.Controls.Add(lblCurrentPassword);
            pnlPasswordInputs.Location = new Point(10, 65);
            pnlPasswordInputs.Name = "pnlPasswordInputs";
            pnlPasswordInputs.Size = new Size(615, 150);
            pnlPasswordInputs.TabIndex = 2;
            pnlPasswordInputs.Visible = false;
            // 
            // btnCancelPassword
            // 
            btnCancelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelPassword.Location = new Point(445, 75);
            btnCancelPassword.Name = "btnCancelPassword";
            btnCancelPassword.Size = new Size(150, 30);
            btnCancelPassword.TabIndex = 8;
            btnCancelPassword.Text = "Cancel";
            btnCancelPassword.UseVisualStyleBackColor = true;
            btnCancelPassword.Click += btnCancelPassword_Click;
            // 
            // btnSavePassword
            // 
            btnSavePassword.BackColor = SystemColors.MenuHighlight;
            btnSavePassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePassword.ForeColor = Color.Black;
            btnSavePassword.Location = new Point(445, 36);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(150, 32);
            btnSavePassword.TabIndex = 7;
            btnSavePassword.Text = "Update Password";
            btnSavePassword.UseVisualStyleBackColor = false;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(140, 112);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(113, 19);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Passwords";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(140, 77);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(270, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(10, 80);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(107, 15);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(140, 43);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(270, 23);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(10, 46);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(87, 15);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(140, 9);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(270, 23);
            txtCurrentPassword.TabIndex = 1;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPassword.Location = new Point(10, 12);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(103, 15);
            lblCurrentPassword.TabIndex = 0;
            lblCurrentPassword.Text = "Current Password:";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(510, 515);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 32);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(684, 560);
            Controls.Add(btnClose);
            Controls.Add(grpSecurity);
            Controls.Add(grpPersonalInfo);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Profile";
            Load += ProfileForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            grpSecurity.ResumeLayout(false);
            grpSecurity.PerformLayout();
            pnlPasswordInputs.ResumeLayout(false);
            pnlPasswordInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private GroupBox grpPersonalInfo;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnEditProfile;
        private Button btnCancelEdit;
        private GroupBox grpSecurity;
        private Label lblPasswordDisplay;
        private Button btnOpenPasswordChange;
        private Panel pnlPasswordInputs;
        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkShowPassword;
        private Button btnSavePassword;
        private Button btnCancelPassword;
        private Button btnClose;
    }
}