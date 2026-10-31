namespace GymMembership.Forms
{
    partial class MainForm
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
            lblUserInfo = new Label();
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            panelFooter = new Panel();
            lblFooterVersion = new Label();
            lblFooterStatus = new Label();
            panelSidebar = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            btnRegistration = new Button();
            btnMembers = new Button();
            btnDashboard = new Button();
            panelContent = new Panel();
            lblContentPlaceholder = new Label();
            panelHeader.SuspendLayout();
            panelFooter.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(24, 30, 44);
            panelHeader.Controls.Add(lblUserInfo);
            panelHeader.Controls.Add(lblHeaderSubtitle);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblUserInfo
            // 
            lblUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserInfo.AutoSize = true;
            lblUserInfo.BackColor = Color.FromArgb(37, 45, 63);
            lblUserInfo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblUserInfo.ForeColor = Color.White;
            lblUserInfo.Location = new Point(940, 24);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Padding = new Padding(8, 4, 8, 4);
            lblUserInfo.Size = new Size(128, 25);
            lblUserInfo.TabIndex = 2;
            lblUserInfo.Text = "👤  Admin Portal";
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 8.5F);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblHeaderSubtitle.Location = new Point(22, 42);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(204, 15);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "GYM MEMBERSHIP ADMIN INTERFACE";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(20, 16);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(149, 25);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "⚡ FITNESS PRO";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(241, 245, 249);
            panelFooter.Controls.Add(lblFooterVersion);
            panelFooter.Controls.Add(lblFooterStatus);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 646);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1100, 34);
            panelFooter.TabIndex = 1;
            // 
            // lblFooterVersion
            // 
            lblFooterVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFooterVersion.AutoSize = true;
            lblFooterVersion.Font = new Font("Segoe UI", 8.5F);
            lblFooterVersion.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooterVersion.Location = new Point(1020, 10);
            lblFooterVersion.Name = "lblFooterVersion";
            lblFooterVersion.Size = new Size(49, 15);
            lblFooterVersion.TabIndex = 1;
            lblFooterVersion.Text = "v1.0.0.0";
            // 
            // lblFooterStatus
            // 
            lblFooterStatus.AutoSize = true;
            lblFooterStatus.Font = new Font("Segoe UI", 8.5F);
            lblFooterStatus.ForeColor = Color.FromArgb(71, 85, 105);
            lblFooterStatus.Location = new Point(20, 10);
            lblFooterStatus.Name = "lblFooterStatus";
            lblFooterStatus.Size = new Size(130, 15);
            lblFooterStatus.TabIndex = 0;
            lblFooterStatus.Text = "🟢 System Status: Ready";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 37, 54);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnProfile);
            panelSidebar.Controls.Add(btnRegistration);
            panelSidebar.Controls.Add(btnMembers);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 70);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 576);
            panelSidebar.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(248, 113, 113);
            btnLogout.Location = new Point(0, 526);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(18, 0, 0, 0);
            btnLogout.Size = new Size(220, 50);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "🚪   Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10F);
            btnProfile.ForeColor = Color.FromArgb(203, 213, 225);
            btnProfile.Location = new Point(0, 150);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(18, 0, 0, 0);
            btnProfile.Size = new Size(220, 50);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "👤   Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnRegistration
            // 
            btnRegistration.Cursor = Cursors.Hand;
            btnRegistration.Dock = DockStyle.Top;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistration.Font = new Font("Segoe UI", 10F);
            btnRegistration.ForeColor = Color.FromArgb(203, 213, 225);
            btnRegistration.Location = new Point(0, 100);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Padding = new Padding(18, 0, 0, 0);
            btnRegistration.Size = new Size(220, 50);
            btnRegistration.TabIndex = 2;
            btnRegistration.Text = "📝   Registration";
            btnRegistration.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistration.UseVisualStyleBackColor = true;
            // 
            // btnMembers
            // 
            btnMembers.Cursor = Cursors.Hand;
            btnMembers.Dock = DockStyle.Top;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI", 10F);
            btnMembers.ForeColor = Color.FromArgb(203, 213, 225);
            btnMembers.Location = new Point(0, 50);
            btnMembers.Name = "btnMembers";
            btnMembers.Padding = new Padding(18, 0, 0, 0);
            btnMembers.Size = new Size(220, 50);
            btnMembers.TabIndex = 1;
            btnMembers.Text = "👥   Members";
            btnMembers.TextAlign = ContentAlignment.MiddleLeft;
            btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.FromArgb(203, 213, 225);
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(18, 0, 0, 0);
            btnDashboard.Size = new Size(220, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "📊   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(248, 250, 252);
            panelContent.Controls.Add(lblContentPlaceholder);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 70);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(880, 576);
            panelContent.TabIndex = 3;
            // 
            // lblContentPlaceholder
            // 
            lblContentPlaceholder.Anchor = AnchorStyles.None;
            lblContentPlaceholder.AutoSize = true;
            lblContentPlaceholder.Font = new Font("Segoe UI", 12F);
            lblContentPlaceholder.ForeColor = Color.FromArgb(148, 163, 184);
            lblContentPlaceholder.Location = new Point(290, 270);
            lblContentPlaceholder.Name = "lblContentPlaceholder";
            lblContentPlaceholder.Size = new Size(295, 21);
            lblContentPlaceholder.TabIndex = 0;
            lblContentPlaceholder.Text = "Main Content Area (Child Forms Display)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1100, 680);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            MinimumSize = new Size(900, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Membership Management System";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Label lblHeaderSubtitle;
        private Label lblUserInfo;
        private Panel panelFooter;
        private Label lblFooterStatus;
        private Label lblFooterVersion;
        private Panel panelSidebar;
        private Button btnDashboard;
        private Button btnMembers;
        private Button btnRegistration;
        private Button btnProfile;
        private Button btnLogout;
        private Panel panelContent;
        private Label lblContentPlaceholder;
    }
}
