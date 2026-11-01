namespace GymMembership.Forms
{
    partial class DashboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelDashHeader = new Panel();
            lblDashSubtitle = new Label();
            lblDashTitle = new Label();
            cardTotalMembers = new Panel();
            lblTotalSub = new Label();
            lblTotalValue = new Label();
            lblTotalTitle = new Label();
            cardActiveMembers = new Panel();
            lblActiveSub = new Label();
            lblActiveValue = new Label();
            lblActiveTitle = new Label();
            cardTodayVisits = new Panel();
            lblVisitsSub = new Label();
            lblVisitsValue = new Label();
            lblVisitsTitle = new Label();
            cardRevenue = new Panel();
            lblRevenueSub = new Label();
            lblRevenueValue = new Label();
            lblRevenueTitle = new Label();
            panelRecent = new Panel();
            dgvRecentActivity = new DataGridView();
            colMemberId = new DataGridViewTextBoxColumn();
            colMemberName = new DataGridViewTextBoxColumn();
            colPlan = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblRecentTitle = new Label();
            panelQuickActions = new Panel();
            panelGymStatus = new Panel();
            lblLockers = new Label();
            lblTrainers = new Label();
            lblCapacity = new Label();
            lblStatusCardTitle = new Label();
            btnQuickMembers = new Button();
            btnQuickRenew = new Button();
            btnQuickRegister = new Button();
            lblQuickActionsTitle = new Label();
            panelDashHeader.SuspendLayout();
            cardTotalMembers.SuspendLayout();
            cardActiveMembers.SuspendLayout();
            cardTodayVisits.SuspendLayout();
            cardRevenue.SuspendLayout();
            panelRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivity).BeginInit();
            panelQuickActions.SuspendLayout();
            panelGymStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panelDashHeader
            // 
            panelDashHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDashHeader.Controls.Add(lblDashSubtitle);
            panelDashHeader.Controls.Add(lblDashTitle);
            panelDashHeader.Location = new Point(20, 15);
            panelDashHeader.Name = "panelDashHeader";
            panelDashHeader.Size = new Size(840, 50);
            panelDashHeader.TabIndex = 0;
            // 
            // lblDashSubtitle
            // 
            lblDashSubtitle.AutoSize = true;
            lblDashSubtitle.Font = new Font("Segoe UI", 9F);
            lblDashSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblDashSubtitle.Location = new Point(3, 30);
            lblDashSubtitle.Name = "lblDashSubtitle";
            lblDashSubtitle.Size = new Size(387, 15);
            lblDashSubtitle.TabIndex = 1;
            lblDashSubtitle.Text = "Welcome back! Here is your gym's daily overview and activity summary.";
            // 
            // lblDashTitle
            // 
            lblDashTitle.AutoSize = true;
            lblDashTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblDashTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblDashTitle.Location = new Point(0, 0);
            lblDashTitle.Name = "lblDashTitle";
            lblDashTitle.Size = new Size(217, 30);
            lblDashTitle.TabIndex = 0;
            lblDashTitle.Text = "Dashboard Overview";
            // 
            // cardTotalMembers
            // 
            cardTotalMembers.BackColor = Color.White;
            cardTotalMembers.Controls.Add(lblTotalSub);
            cardTotalMembers.Controls.Add(lblTotalValue);
            cardTotalMembers.Controls.Add(lblTotalTitle);
            cardTotalMembers.Location = new Point(20, 75);
            cardTotalMembers.Name = "cardTotalMembers";
            cardTotalMembers.Padding = new Padding(14);
            cardTotalMembers.Size = new Size(195, 100);
            cardTotalMembers.TabIndex = 1;
            // 
            // lblTotalSub
            // 
            lblTotalSub.AutoSize = true;
            lblTotalSub.Font = new Font("Segoe UI", 8.25F);
            lblTotalSub.ForeColor = Color.FromArgb(16, 185, 129);
            lblTotalSub.Location = new Point(14, 73);
            lblTotalSub.Name = "lblTotalSub";
            lblTotalSub.Size = new Size(115, 13);
            lblTotalSub.TabIndex = 2;
            lblTotalSub.Text = "▲ +12% from last mo";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalValue.Location = new Point(10, 35);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(77, 32);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "1,250";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalTitle.Location = new Point(14, 12);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(102, 15);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "👥 Total Members";
            // 
            // cardActiveMembers
            // 
            cardActiveMembers.BackColor = Color.White;
            cardActiveMembers.Controls.Add(lblActiveSub);
            cardActiveMembers.Controls.Add(lblActiveValue);
            cardActiveMembers.Controls.Add(lblActiveTitle);
            cardActiveMembers.Location = new Point(230, 75);
            cardActiveMembers.Name = "cardActiveMembers";
            cardActiveMembers.Padding = new Padding(14);
            cardActiveMembers.Size = new Size(195, 100);
            cardActiveMembers.TabIndex = 2;
            // 
            // lblActiveSub
            // 
            lblActiveSub.AutoSize = true;
            lblActiveSub.Font = new Font("Segoe UI", 8.25F);
            lblActiveSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblActiveSub.Location = new Point(14, 73);
            lblActiveSub.Name = "lblActiveSub";
            lblActiveSub.Size = new Size(116, 13);
            lblActiveSub.TabIndex = 2;
            lblActiveSub.Text = "84% active subscriber";
            // 
            // lblActiveValue
            // 
            lblActiveValue.AutoSize = true;
            lblActiveValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblActiveValue.ForeColor = Color.FromArgb(37, 99, 235);
            lblActiveValue.Location = new Point(10, 35);
            lblActiveValue.Name = "lblActiveValue";
            lblActiveValue.Size = new Size(77, 32);
            lblActiveValue.TabIndex = 1;
            lblActiveValue.Text = "1,048";
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.AutoSize = true;
            lblActiveTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblActiveTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblActiveTitle.Location = new Point(14, 12);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Size = new Size(109, 15);
            lblActiveTitle.TabIndex = 0;
            lblActiveTitle.Text = "💳 Active Members";
            // 
            // cardTodayVisits
            // 
            cardTodayVisits.BackColor = Color.White;
            cardTodayVisits.Controls.Add(lblVisitsSub);
            cardTodayVisits.Controls.Add(lblVisitsValue);
            cardTodayVisits.Controls.Add(lblVisitsTitle);
            cardTodayVisits.Location = new Point(440, 75);
            cardTodayVisits.Name = "cardTodayVisits";
            cardTodayVisits.Padding = new Padding(14);
            cardTodayVisits.Size = new Size(195, 100);
            cardTodayVisits.TabIndex = 3;
            // 
            // lblVisitsSub
            // 
            lblVisitsSub.AutoSize = true;
            lblVisitsSub.Font = new Font("Segoe UI", 8.25F);
            lblVisitsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblVisitsSub.Location = new Point(14, 73);
            lblVisitsSub.Name = "lblVisitsSub";
            lblVisitsSub.Size = new Size(127, 13);
            lblVisitsSub.TabIndex = 2;
            lblVisitsSub.Text = "Peak: 5:00 PM - 8:00 PM";
            // 
            // lblVisitsValue
            // 
            lblVisitsValue.AutoSize = true;
            lblVisitsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblVisitsValue.ForeColor = Color.FromArgb(234, 88, 12);
            lblVisitsValue.Location = new Point(10, 35);
            lblVisitsValue.Name = "lblVisitsValue";
            lblVisitsValue.Size = new Size(56, 32);
            lblVisitsValue.TabIndex = 1;
            lblVisitsValue.Text = "162";
            // 
            // lblVisitsTitle
            // 
            lblVisitsTitle.AutoSize = true;
            lblVisitsTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblVisitsTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblVisitsTitle.Location = new Point(14, 12);
            lblVisitsTitle.Name = "lblVisitsTitle";
            lblVisitsTitle.Size = new Size(94, 15);
            lblVisitsTitle.TabIndex = 0;
            lblVisitsTitle.Text = "🏋️ Today's Visits";
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.White;
            cardRevenue.Controls.Add(lblRevenueSub);
            cardRevenue.Controls.Add(lblRevenueValue);
            cardRevenue.Controls.Add(lblRevenueTitle);
            cardRevenue.Location = new Point(650, 75);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Padding = new Padding(14);
            cardRevenue.Size = new Size(195, 100);
            cardRevenue.TabIndex = 4;
            // 
            // lblRevenueSub
            // 
            lblRevenueSub.AutoSize = true;
            lblRevenueSub.Font = new Font("Segoe UI", 8.25F);
            lblRevenueSub.ForeColor = Color.FromArgb(16, 185, 129);
            lblRevenueSub.Location = new Point(14, 73);
            lblRevenueSub.Name = "lblRevenueSub";
            lblRevenueSub.Size = new Size(107, 13);
            lblRevenueSub.TabIndex = 2;
            lblRevenueSub.Text = "▲ +8.5% target met";
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRevenueValue.ForeColor = Color.FromArgb(16, 185, 129);
            lblRevenueValue.Location = new Point(10, 35);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(105, 32);
            lblRevenueValue.TabIndex = 1;
            lblRevenueValue.Text = "$18,450";
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblRevenueTitle.Location = new Point(14, 12);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(114, 15);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "💰 Monthly Revenue";
            // 
            // panelRecent
            // 
            panelRecent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRecent.BackColor = Color.White;
            panelRecent.Controls.Add(dgvRecentActivity);
            panelRecent.Controls.Add(lblRecentTitle);
            panelRecent.Location = new Point(20, 195);
            panelRecent.Name = "panelRecent";
            panelRecent.Padding = new Padding(15);
            panelRecent.Size = new Size(590, 360);
            panelRecent.TabIndex = 5;
            // 
            // dgvRecentActivity
            // 
            dgvRecentActivity.AllowUserToAddRows = false;
            dgvRecentActivity.AllowUserToDeleteRows = false;
            dgvRecentActivity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentActivity.BackgroundColor = Color.White;
            dgvRecentActivity.BorderStyle = BorderStyle.None;
            dgvRecentActivity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentActivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentActivity.ColumnHeadersHeight = 36;
            dgvRecentActivity.Columns.AddRange(new DataGridViewColumn[] { colMemberId, colMemberName, colPlan, colTime, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentActivity.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentActivity.EnableHeadersVisualStyles = false;
            dgvRecentActivity.GridColor = Color.FromArgb(226, 232, 240);
            dgvRecentActivity.Location = new Point(15, 45);
            dgvRecentActivity.Name = "dgvRecentActivity";
            dgvRecentActivity.ReadOnly = true;
            dgvRecentActivity.RowHeadersVisible = false;
            dgvRecentActivity.RowTemplate.Height = 34;
            dgvRecentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentActivity.Size = new Size(560, 300);
            dgvRecentActivity.TabIndex = 1;
            // 
            // colMemberId
            // 
            colMemberId.FillWeight = 85F;
            colMemberId.HeaderText = "Member ID";
            colMemberId.Name = "colMemberId";
            colMemberId.ReadOnly = true;
            // 
            // colMemberName
            // 
            colMemberName.FillWeight = 120F;
            colMemberName.HeaderText = "Name";
            colMemberName.Name = "colMemberName";
            colMemberName.ReadOnly = true;
            // 
            // colPlan
            // 
            colPlan.FillWeight = 110F;
            colPlan.HeaderText = "Plan Type";
            colPlan.Name = "colPlan";
            colPlan.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.FillWeight = 80F;
            colTime.HeaderText = "Time";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 75F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblRecentTitle.Location = new Point(15, 15);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(194, 20);
            lblRecentTitle.TabIndex = 0;
            lblRecentTitle.Text = "📋 Recent Member Activity";
            // 
            // panelQuickActions
            // 
            panelQuickActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelQuickActions.BackColor = Color.White;
            panelQuickActions.Controls.Add(panelGymStatus);
            panelQuickActions.Controls.Add(btnQuickMembers);
            panelQuickActions.Controls.Add(btnQuickRenew);
            panelQuickActions.Controls.Add(btnQuickRegister);
            panelQuickActions.Controls.Add(lblQuickActionsTitle);
            panelQuickActions.Location = new Point(625, 195);
            panelQuickActions.Name = "panelQuickActions";
            panelQuickActions.Padding = new Padding(15);
            panelQuickActions.Size = new Size(235, 360);
            panelQuickActions.TabIndex = 6;
            // 
            // panelGymStatus
            // 
            panelGymStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGymStatus.BackColor = Color.FromArgb(248, 250, 252);
            panelGymStatus.Controls.Add(lblLockers);
            panelGymStatus.Controls.Add(lblTrainers);
            panelGymStatus.Controls.Add(lblCapacity);
            panelGymStatus.Controls.Add(lblStatusCardTitle);
            panelGymStatus.Location = new Point(15, 220);
            panelGymStatus.Name = "panelGymStatus";
            panelGymStatus.Padding = new Padding(10);
            panelGymStatus.Size = new Size(205, 125);
            panelGymStatus.TabIndex = 5;
            // 
            // lblLockers
            // 
            lblLockers.AutoSize = true;
            lblLockers.Font = new Font("Segoe UI", 8.25F);
            lblLockers.ForeColor = Color.FromArgb(71, 85, 105);
            lblLockers.Location = new Point(10, 95);
            lblLockers.Name = "lblLockers";
            lblLockers.Size = new Size(127, 13);
            lblLockers.TabIndex = 3;
            lblLockers.Text = "🔐 Lockers: 42 Available";
            // 
            // lblTrainers
            // 
            lblTrainers.AutoSize = true;
            lblTrainers.Font = new Font("Segoe UI", 8.25F);
            lblTrainers.ForeColor = Color.FromArgb(71, 85, 105);
            lblTrainers.Location = new Point(10, 68);
            lblTrainers.Name = "lblTrainers";
            lblTrainers.Size = new Size(120, 13);
            lblTrainers.TabIndex = 2;
            lblTrainers.Text = "🏋️ Trainers On Duty: 4";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 8.25F);
            lblCapacity.ForeColor = Color.FromArgb(71, 85, 105);
            lblCapacity.Location = new Point(10, 40);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(139, 13);
            lblCapacity.TabIndex = 1;
            lblCapacity.Text = "👥 Gym Capacity: 65% Full";
            // 
            // lblStatusCardTitle
            // 
            lblStatusCardTitle.AutoSize = true;
            lblStatusCardTitle.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            lblStatusCardTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblStatusCardTitle.Location = new Point(10, 12);
            lblStatusCardTitle.Name = "lblStatusCardTitle";
            lblStatusCardTitle.Size = new Size(104, 15);
            lblStatusCardTitle.TabIndex = 0;
            lblStatusCardTitle.Text = "Facility Live Status";
            // 
            // btnQuickMembers
            // 
            btnQuickMembers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnQuickMembers.BackColor = Color.FromArgb(241, 245, 249);
            btnQuickMembers.Cursor = Cursors.Hand;
            btnQuickMembers.FlatAppearance.BorderSize = 0;
            btnQuickMembers.FlatStyle = FlatStyle.Flat;
            btnQuickMembers.Font = new Font("Segoe UI", 9F);
            btnQuickMembers.ForeColor = Color.FromArgb(51, 65, 85);
            btnQuickMembers.Location = new Point(15, 126);
            btnQuickMembers.Name = "btnQuickMembers";
            btnQuickMembers.Size = new Size(205, 34);
            btnQuickMembers.TabIndex = 3;
            btnQuickMembers.Text = "👥  View Members List";
            btnQuickMembers.TextAlign = ContentAlignment.MiddleLeft;
            btnQuickMembers.UseVisualStyleBackColor = false;
            btnQuickMembers.Click += btnQuickMembers_Click;
            // 
            // btnQuickRenew
            // 
            btnQuickRenew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnQuickRenew.BackColor = Color.FromArgb(241, 245, 249);
            btnQuickRenew.Cursor = Cursors.Hand;
            btnQuickRenew.FlatAppearance.BorderSize = 0;
            btnQuickRenew.FlatStyle = FlatStyle.Flat;
            btnQuickRenew.Font = new Font("Segoe UI", 9F);
            btnQuickRenew.ForeColor = Color.FromArgb(51, 65, 85);
            btnQuickRenew.Location = new Point(15, 84);
            btnQuickRenew.Name = "btnQuickRenew";
            btnQuickRenew.Size = new Size(205, 34);
            btnQuickRenew.TabIndex = 2;
            btnQuickRenew.Text = "💳  Renew Membership";
            btnQuickRenew.TextAlign = ContentAlignment.MiddleLeft;
            btnQuickRenew.UseVisualStyleBackColor = false;
            btnQuickRenew.Click += btnQuickRenew_Click;
            // 
            // btnQuickRegister
            // 
            btnQuickRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnQuickRegister.BackColor = Color.FromArgb(37, 99, 235);
            btnQuickRegister.Cursor = Cursors.Hand;
            btnQuickRegister.FlatAppearance.BorderSize = 0;
            btnQuickRegister.FlatStyle = FlatStyle.Flat;
            btnQuickRegister.Font = new Font("Segoe UI Semibold", 9.25F, FontStyle.Bold);
            btnQuickRegister.ForeColor = Color.White;
            btnQuickRegister.Location = new Point(15, 42);
            btnQuickRegister.Name = "btnQuickRegister";
            btnQuickRegister.Size = new Size(205, 34);
            btnQuickRegister.TabIndex = 1;
            btnQuickRegister.Text = "+  Register New Member";
            btnQuickRegister.TextAlign = ContentAlignment.MiddleLeft;
            btnQuickRegister.UseVisualStyleBackColor = false;
            btnQuickRegister.Click += btnQuickRegister_Click;
            // 
            // lblQuickActionsTitle
            // 
            lblQuickActionsTitle.AutoSize = true;
            lblQuickActionsTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblQuickActionsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblQuickActionsTitle.Location = new Point(15, 15);
            lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            lblQuickActionsTitle.Size = new Size(127, 20);
            lblQuickActionsTitle.TabIndex = 0;
            lblQuickActionsTitle.Text = "⚡ Quick Actions";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(880, 570);
            Controls.Add(panelQuickActions);
            Controls.Add(panelRecent);
            Controls.Add(cardRevenue);
            Controls.Add(cardTodayVisits);
            Controls.Add(cardActiveMembers);
            Controls.Add(cardTotalMembers);
            Controls.Add(panelDashHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "Dashboard";
            panelDashHeader.ResumeLayout(false);
            panelDashHeader.PerformLayout();
            cardTotalMembers.ResumeLayout(false);
            cardTotalMembers.PerformLayout();
            cardActiveMembers.ResumeLayout(false);
            cardActiveMembers.PerformLayout();
            cardTodayVisits.ResumeLayout(false);
            cardTodayVisits.PerformLayout();
            cardRevenue.ResumeLayout(false);
            cardRevenue.PerformLayout();
            panelRecent.ResumeLayout(false);
            panelRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivity).EndInit();
            panelQuickActions.ResumeLayout(false);
            panelQuickActions.PerformLayout();
            panelGymStatus.ResumeLayout(false);
            panelGymStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDashHeader;
        private Label lblDashTitle;
        private Label lblDashSubtitle;
        private Panel cardTotalMembers;
        private Label lblTotalTitle;
        private Label lblTotalValue;
        private Label lblTotalSub;
        private Panel cardActiveMembers;
        private Label lblActiveTitle;
        private Label lblActiveValue;
        private Label lblActiveSub;
        private Panel cardTodayVisits;
        private Label lblVisitsTitle;
        private Label lblVisitsValue;
        private Label lblVisitsSub;
        private Panel cardRevenue;
        private Label lblRevenueTitle;
        private Label lblRevenueValue;
        private Label lblRevenueSub;
        private Panel panelRecent;
        private Label lblRecentTitle;
        private DataGridView dgvRecentActivity;
        private DataGridViewTextBoxColumn colMemberId;
        private DataGridViewTextBoxColumn colMemberName;
        private DataGridViewTextBoxColumn colPlan;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colStatus;
        private Panel panelQuickActions;
        private Label lblQuickActionsTitle;
        private Button btnQuickRegister;
        private Button btnQuickRenew;
        private Button btnQuickMembers;
        private Panel panelGymStatus;
        private Label lblStatusCardTitle;
        private Label lblCapacity;
        private Label lblTrainers;
        private Label lblLockers;
    }
}
