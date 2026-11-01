namespace GymMembership.Forms
{
    partial class MembershipForm
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
            panelHeader = new Panel();
            cardExpired = new Panel();
            lblExpiredCount = new Label();
            lblExpiredTitle = new Label();
            cardActive = new Panel();
            lblActiveCount = new Label();
            lblActiveTitle = new Label();
            cardTotal = new Panel();
            lblTotalCount = new Label();
            lblTotalTitle = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelToolbar = new Panel();
            btnNewMember = new Button();
            cmbPlanFilter = new ComboBox();
            cmbStatusFilter = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            panelGrid = new Panel();
            dgvMembers = new DataGridView();
            colMemberId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colPlan = new DataGridViewTextBoxColumn();
            colRegDate = new DataGridViewTextBoxColumn();
            colExpDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panelBottom = new Panel();
            lblSummary = new Label();
            btnExport = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnRenew = new Button();
            panelHeader.SuspendLayout();
            cardExpired.SuspendLayout();
            cardActive.SuspendLayout();
            cardTotal.SuspendLayout();
            panelToolbar.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.Controls.Add(cardExpired);
            panelHeader.Controls.Add(cardActive);
            panelHeader.Controls.Add(cardTotal);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(20, 15);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(840, 60);
            panelHeader.TabIndex = 0;
            // 
            // cardExpired
            // 
            cardExpired.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cardExpired.BackColor = Color.FromArgb(254, 242, 242);
            cardExpired.Controls.Add(lblExpiredCount);
            cardExpired.Controls.Add(lblExpiredTitle);
            cardExpired.Location = new Point(715, 5);
            cardExpired.Name = "cardExpired";
            cardExpired.Size = new Size(125, 50);
            cardExpired.TabIndex = 4;
            // 
            // lblExpiredCount
            // 
            lblExpiredCount.AutoSize = true;
            lblExpiredCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblExpiredCount.ForeColor = Color.FromArgb(220, 38, 38);
            lblExpiredCount.Location = new Point(10, 24);
            lblExpiredCount.Name = "lblExpiredCount";
            lblExpiredCount.Size = new Size(37, 21);
            lblExpiredCount.TabIndex = 1;
            lblExpiredCount.Text = "202";
            // 
            // lblExpiredTitle
            // 
            lblExpiredTitle.AutoSize = true;
            lblExpiredTitle.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            lblExpiredTitle.ForeColor = Color.FromArgb(185, 28, 28);
            lblExpiredTitle.Location = new Point(10, 8);
            lblExpiredTitle.Name = "lblExpiredTitle";
            lblExpiredTitle.Size = new Size(61, 13);
            lblExpiredTitle.TabIndex = 0;
            lblExpiredTitle.Text = "🔴 Expired";
            // 
            // cardActive
            // 
            cardActive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cardActive.BackColor = Color.FromArgb(240, 253, 244);
            cardActive.Controls.Add(lblActiveCount);
            cardActive.Controls.Add(lblActiveTitle);
            cardActive.Location = new Point(575, 5);
            cardActive.Name = "cardActive";
            cardActive.Size = new Size(125, 50);
            cardActive.TabIndex = 3;
            // 
            // lblActiveCount
            // 
            lblActiveCount.AutoSize = true;
            lblActiveCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActiveCount.ForeColor = Color.FromArgb(22, 101, 52);
            lblActiveCount.Location = new Point(10, 24);
            lblActiveCount.Name = "lblActiveCount";
            lblActiveCount.Size = new Size(49, 21);
            lblActiveCount.TabIndex = 1;
            lblActiveCount.Text = "1,048";
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.AutoSize = true;
            lblActiveTitle.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            lblActiveTitle.ForeColor = Color.FromArgb(21, 128, 61);
            lblActiveTitle.Location = new Point(10, 8);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Size = new Size(54, 13);
            lblActiveTitle.TabIndex = 0;
            lblActiveTitle.Text = "🟢 Active";
            // 
            // cardTotal
            // 
            cardTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cardTotal.BackColor = Color.White;
            cardTotal.Controls.Add(lblTotalCount);
            cardTotal.Controls.Add(lblTotalTitle);
            cardTotal.Location = new Point(435, 5);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(125, 50);
            cardTotal.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(30, 41, 59);
            lblTotalCount.Location = new Point(10, 24);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(49, 21);
            lblTotalCount.TabIndex = 1;
            lblTotalCount.Text = "1,250";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalTitle.Location = new Point(10, 8);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(78, 13);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total Members";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(3, 33);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(380, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Track membership statuses, registration dates, and renewal expirations.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(0, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(233, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Members Management";
            // 
            // panelToolbar
            // 
            panelToolbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelToolbar.BackColor = Color.White;
            panelToolbar.Controls.Add(btnNewMember);
            panelToolbar.Controls.Add(cmbPlanFilter);
            panelToolbar.Controls.Add(cmbStatusFilter);
            panelToolbar.Controls.Add(btnSearch);
            panelToolbar.Controls.Add(txtSearch);
            panelToolbar.Controls.Add(lblSearch);
            panelToolbar.Location = new Point(20, 85);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new Size(840, 55);
            panelToolbar.TabIndex = 1;
            // 
            // btnNewMember
            // 
            btnNewMember.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewMember.BackColor = Color.FromArgb(37, 99, 235);
            btnNewMember.Cursor = Cursors.Hand;
            btnNewMember.FlatAppearance.BorderSize = 0;
            btnNewMember.FlatStyle = FlatStyle.Flat;
            btnNewMember.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNewMember.ForeColor = Color.White;
            btnNewMember.Location = new Point(695, 12);
            btnNewMember.Name = "btnNewMember";
            btnNewMember.Size = new Size(130, 30);
            btnNewMember.TabIndex = 5;
            btnNewMember.Text = "+ Add Member";
            btnNewMember.UseVisualStyleBackColor = false;
            // 
            // cmbPlanFilter
            // 
            cmbPlanFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanFilter.Font = new Font("Segoe UI", 9F);
            cmbPlanFilter.FormattingEnabled = true;
            cmbPlanFilter.Items.AddRange(new object[] { "All Plans", "Standard Gym", "Premium VIP", "Student Pass", "Cardio Only" });
            cmbPlanFilter.Location = new Point(480, 16);
            cmbPlanFilter.Name = "cmbPlanFilter";
            cmbPlanFilter.Size = new Size(140, 23);
            cmbPlanFilter.TabIndex = 4;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.Font = new Font("Segoe UI", 9F);
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active Members", "Expired Members" });
            cmbStatusFilter.Location = new Point(330, 16);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(135, 23);
            cmbStatusFilter.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(241, 245, 249);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.FromArgb(51, 65, 85);
            btnSearch.Location = new Point(245, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 26);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(70, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Name, ID, phone...";
            txtSearch.Size = new Size(170, 23);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(71, 85, 105);
            lblSearch.Location = new Point(16, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(46, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvMembers);
            panelGrid.Location = new Point(20, 150);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(15);
            panelGrid.Size = new Size(840, 360);
            panelGrid.TabIndex = 2;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dgvMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembers.ColumnHeadersHeight = 36;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colMemberId, colFullName, colPhone, colPlan, colRegDate, colExpDate, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMembers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.GridColor = Color.FromArgb(226, 232, 240);
            dgvMembers.Location = new Point(15, 15);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowTemplate.Height = 34;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(810, 330);
            dgvMembers.TabIndex = 0;
            // 
            // colMemberId
            // 
            colMemberId.FillWeight = 85F;
            colMemberId.HeaderText = "Member ID";
            colMemberId.Name = "colMemberId";
            colMemberId.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.FillWeight = 130F;
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.FillWeight = 100F;
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colPlan
            // 
            colPlan.FillWeight = 110F;
            colPlan.HeaderText = "Membership Plan";
            colPlan.Name = "colPlan";
            colPlan.ReadOnly = true;
            // 
            // colRegDate
            // 
            colRegDate.FillWeight = 125F;
            colRegDate.HeaderText = "Registration (Last Renewal)";
            colRegDate.Name = "colRegDate";
            colRegDate.ReadOnly = true;
            // 
            // colExpDate
            // 
            colExpDate.FillWeight = 110F;
            colExpDate.HeaderText = "Expiration Date";
            colExpDate.Name = "colExpDate";
            colExpDate.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 80F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // Sample rows for preview
            // 
            dgvMembers.Rows.Add("MEM-101", "Marcus Vance", "+1 (555) 234-5678", "Premium VIP (Annual)", "15 Jan 2026", "15 Jan 2027", "Active");
            dgvMembers.Rows.Add("MEM-102", "Elena Rostova", "+1 (555) 345-6789", "Standard Monthly", "01 Oct 2026", "01 Nov 2026", "Active");
            dgvMembers.Rows.Add("MEM-103", "David Kim", "+1 (555) 456-7890", "Cardio Only (Quarterly)", "10 Jul 2026", "10 Oct 2026", "Expired");
            dgvMembers.Rows.Add("MEM-104", "Sophia Ramirez", "+1 (555) 567-8901", "Student Pass (Monthly)", "15 Sep 2026", "15 Oct 2026", "Expired");
            dgvMembers.Rows.Add("MEM-105", "Alexander Wright", "+1 (555) 678-9012", "Premium VIP (Annual)", "20 Feb 2026", "20 Feb 2027", "Active");
            dgvMembers.Rows.Add("MEM-106", "Chloe Anderson", "+1 (555) 789-0123", "Standard Monthly", "28 Oct 2026", "28 Nov 2026", "Active");
            // 
            // panelBottom
            // 
            panelBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(lblSummary);
            panelBottom.Controls.Add(btnExport);
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Controls.Add(btnEdit);
            panelBottom.Controls.Add(btnRenew);
            panelBottom.Location = new Point(20, 520);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(840, 45);
            panelBottom.TabIndex = 3;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 8.5F);
            lblSummary.ForeColor = Color.FromArgb(100, 116, 139);
            lblSummary.Location = new Point(15, 15);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(244, 15);
            lblSummary.TabIndex = 4;
            lblSummary.Text = "Displaying registered members (Active/Expired)";
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.FromArgb(241, 245, 249);
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 8.5F);
            btnExport.ForeColor = Color.FromArgb(51, 65, 85);
            btnExport.Location = new Point(400, 8);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(95, 30);
            btnExport.TabIndex = 3;
            btnExport.Text = "📥 Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(254, 242, 242);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 8.5F);
            btnDelete.ForeColor = Color.FromArgb(220, 38, 38);
            btnDelete.Location = new Point(740, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑 Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(241, 245, 249);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 8.5F);
            btnEdit.ForeColor = Color.FromArgb(51, 65, 85);
            btnEdit.Location = new Point(640, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 30);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✏️ Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRenew
            // 
            btnRenew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRenew.BackColor = Color.FromArgb(240, 253, 244);
            btnRenew.Cursor = Cursors.Hand;
            btnRenew.FlatAppearance.BorderSize = 0;
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold);
            btnRenew.ForeColor = Color.FromArgb(21, 128, 61);
            btnRenew.Location = new Point(505, 8);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(125, 30);
            btnRenew.TabIndex = 0;
            btnRenew.Text = "💳 Renew Plan";
            btnRenew.UseVisualStyleBackColor = false;
            // 
            // MembershipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(880, 576);
            Controls.Add(panelBottom);
            Controls.Add(panelGrid);
            Controls.Add(panelToolbar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MembershipForm";
            Text = "Members Management";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            cardExpired.ResumeLayout(false);
            cardExpired.PerformLayout();
            cardActive.ResumeLayout(false);
            cardActive.PerformLayout();
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel cardTotal;
        private Label lblTotalTitle;
        private Label lblTotalCount;
        private Panel cardActive;
        private Label lblActiveTitle;
        private Label lblActiveCount;
        private Panel cardExpired;
        private Label lblExpiredTitle;
        private Label lblExpiredCount;
        private Panel panelToolbar;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cmbStatusFilter;
        private ComboBox cmbPlanFilter;
        private Button btnNewMember;
        private Panel panelGrid;
        private DataGridView dgvMembers;
        private DataGridViewTextBoxColumn colMemberId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colPlan;
        private DataGridViewTextBoxColumn colRegDate;
        private DataGridViewTextBoxColumn colExpDate;
        private DataGridViewTextBoxColumn colStatus;
        private Panel panelBottom;
        private Label lblSummary;
        private Button btnRenew;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExport;
    }
}

