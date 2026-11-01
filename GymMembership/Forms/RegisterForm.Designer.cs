namespace GymMembership.Forms
{
    partial class RegisterForm
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
            cardMemberDetails = new Panel();
            txtAddress = new TextBox();
            lblAddress = new Label();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            cmbGender = new ComboBox();
            lblGender = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblCard1Title = new Label();
            cardMembershipPlan = new Panel();
            btnClear = new Button();
            btnRegister = new Button();
            panelFeeSummary = new Panel();
            lblCurrencyNote = new Label();
            lblFeeValue = new Label();
            lblFeeTitle = new Label();
            panelDumbbell = new Panel();
            lblDumbbellPrice = new Label();
            lblDumbbellDesc = new Label();
            lblDumbbellTitle = new Label();
            panelMachine = new Panel();
            lblMachinePrice = new Label();
            lblMachineDesc = new Label();
            lblMachineTitle = new Label();
            panelAerobics = new Panel();
            lblAerobicsPrice = new Label();
            lblAerobicsDesc = new Label();
            lblAerobicsTitle = new Label();
            cmbCategory = new ComboBox();
            lblSelectCategory = new Label();
            lblCard2Title = new Label();
            panelHeader.SuspendLayout();
            cardMemberDetails.SuspendLayout();
            cardMembershipPlan.SuspendLayout();
            panelFeeSummary.SuspendLayout();
            panelDumbbell.SuspendLayout();
            panelMachine.SuspendLayout();
            panelAerobics.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(20, 15);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(840, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(3, 30);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(395, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Register a new gym member and choose their workout category package.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "New Member Registration";
            // 
            // cardMemberDetails
            // 
            cardMemberDetails.BackColor = Color.White;
            cardMemberDetails.Controls.Add(txtAddress);
            cardMemberDetails.Controls.Add(lblAddress);
            cardMemberDetails.Controls.Add(dtpStartDate);
            cardMemberDetails.Controls.Add(lblStartDate);
            cardMemberDetails.Controls.Add(cmbGender);
            cardMemberDetails.Controls.Add(lblGender);
            cardMemberDetails.Controls.Add(txtEmail);
            cardMemberDetails.Controls.Add(lblEmail);
            cardMemberDetails.Controls.Add(txtPhone);
            cardMemberDetails.Controls.Add(lblPhone);
            cardMemberDetails.Controls.Add(txtName);
            cardMemberDetails.Controls.Add(lblName);
            cardMemberDetails.Controls.Add(lblCard1Title);
            cardMemberDetails.Location = new Point(20, 75);
            cardMemberDetails.Name = "cardMemberDetails";
            cardMemberDetails.Padding = new Padding(20);
            cardMemberDetails.Size = new Size(410, 480);
            cardMemberDetails.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(20, 395);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Sub-city, woreda, house no...";
            txtAddress.Size = new Size(370, 24);
            txtAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(71, 85, 105);
            lblAddress.Location = new Point(20, 375);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(147, 15);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address / Residence (Opt):";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Font = new Font("Segoe UI", 9.5F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(210, 325);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(180, 24);
            dtpStartDate.TabIndex = 10;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStartDate.ForeColor = Color.FromArgb(71, 85, 105);
            lblStartDate.Location = new Point(210, 305);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(63, 15);
            lblStartDate.TabIndex = 9;
            lblStartDate.Text = "Start Date:";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI", 9.5F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(20, 325);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(170, 25);
            cmbGender.TabIndex = 8;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(71, 85, 105);
            lblGender.Location = new Point(20, 305);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(20, 255);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "e.g. member@email.com";
            txtEmail.Size = new Size(370, 24);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(71, 85, 105);
            lblEmail.Location = new Point(20, 235);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(115, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email Address (Opt):";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9.5F);
            txtPhone.Location = new Point(20, 185);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "e.g. 0911 234 567 / 0922 000 000";
            txtPhone.Size = new Size(370, 24);
            txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(71, 85, 105);
            lblPhone.Location = new Point(20, 165);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(96, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone Numbers:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.5F);
            txtName.Location = new Point(20, 115);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter member full name...";
            txtName.Size = new Size(370, 24);
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(71, 85, 105);
            lblName.Location = new Point(20, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name:";
            // 
            // lblCard1Title
            // 
            lblCard1Title.AutoSize = true;
            lblCard1Title.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblCard1Title.ForeColor = Color.FromArgb(30, 41, 59);
            lblCard1Title.Location = new Point(16, 15);
            lblCard1Title.Name = "lblCard1Title";
            lblCard1Title.Size = new Size(139, 20);
            lblCard1Title.TabIndex = 0;
            lblCard1Title.Text = "👤 Member Details";
            // 
            // cardMembershipPlan
            // 
            cardMembershipPlan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardMembershipPlan.BackColor = Color.White;
            cardMembershipPlan.Controls.Add(btnClear);
            cardMembershipPlan.Controls.Add(btnRegister);
            cardMembershipPlan.Controls.Add(panelFeeSummary);
            cardMembershipPlan.Controls.Add(panelDumbbell);
            cardMembershipPlan.Controls.Add(panelMachine);
            cardMembershipPlan.Controls.Add(panelAerobics);
            cardMembershipPlan.Controls.Add(cmbCategory);
            cardMembershipPlan.Controls.Add(lblSelectCategory);
            cardMembershipPlan.Controls.Add(lblCard2Title);
            cardMembershipPlan.Location = new Point(450, 75);
            cardMembershipPlan.Name = "cardMembershipPlan";
            cardMembershipPlan.Padding = new Padding(20);
            cardMembershipPlan.Size = new Size(410, 480);
            cardMembershipPlan.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(241, 245, 249);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.25F);
            btnClear.ForeColor = Color.FromArgb(71, 85, 105);
            btnClear.Location = new Point(20, 425);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 38);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(37, 99, 235);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(140, 425);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 38);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "✓ Register / Activate Member";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelFeeSummary
            // 
            panelFeeSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFeeSummary.BackColor = Color.FromArgb(240, 253, 244);
            panelFeeSummary.Controls.Add(lblCurrencyNote);
            panelFeeSummary.Controls.Add(lblFeeValue);
            panelFeeSummary.Controls.Add(lblFeeTitle);
            panelFeeSummary.Location = new Point(20, 340);
            panelFeeSummary.Name = "panelFeeSummary";
            panelFeeSummary.Padding = new Padding(12);
            panelFeeSummary.Size = new Size(370, 65);
            panelFeeSummary.TabIndex = 6;
            // 
            // lblCurrencyNote
            // 
            lblCurrencyNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrencyNote.AutoSize = true;
            lblCurrencyNote.Font = new Font("Segoe UI", 8F);
            lblCurrencyNote.ForeColor = Color.FromArgb(21, 128, 61);
            lblCurrencyNote.Location = new Point(205, 38);
            lblCurrencyNote.Name = "lblCurrencyNote";
            lblCurrencyNote.Size = new Size(155, 13);
            lblCurrencyNote.TabIndex = 2;
            lblCurrencyNote.Text = "Currency: Ethiopian Birr (ETB)";
            // 
            // lblFeeValue
            // 
            lblFeeValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFeeValue.AutoSize = true;
            lblFeeValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFeeValue.ForeColor = Color.FromArgb(22, 101, 52);
            lblFeeValue.Location = new Point(255, 6);
            lblFeeValue.Name = "lblFeeValue";
            lblFeeValue.Size = new Size(97, 30);
            lblFeeValue.TabIndex = 1;
            lblFeeValue.Text = "500 ETB";
            // 
            // lblFeeTitle
            // 
            lblFeeTitle.AutoSize = true;
            lblFeeTitle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblFeeTitle.ForeColor = Color.FromArgb(22, 101, 52);
            lblFeeTitle.Location = new Point(12, 16);
            lblFeeTitle.Name = "lblFeeTitle";
            lblFeeTitle.Size = new Size(167, 17);
            lblFeeTitle.TabIndex = 0;
            lblFeeTitle.Text = "Monthly Membership Fee:";
            // 
            // panelDumbbell
            // 
            panelDumbbell.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDumbbell.BackColor = Color.FromArgb(248, 250, 252);
            panelDumbbell.Controls.Add(lblDumbbellPrice);
            panelDumbbell.Controls.Add(lblDumbbellDesc);
            panelDumbbell.Controls.Add(lblDumbbellTitle);
            panelDumbbell.Location = new Point(20, 260);
            panelDumbbell.Name = "panelDumbbell";
            panelDumbbell.Padding = new Padding(10);
            panelDumbbell.Size = new Size(370, 60);
            panelDumbbell.TabIndex = 5;
            // 
            // lblDumbbellPrice
            // 
            lblDumbbellPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDumbbellPrice.AutoSize = true;
            lblDumbbellPrice.BackColor = Color.FromArgb(254, 243, 199);
            lblDumbbellPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDumbbellPrice.ForeColor = Color.FromArgb(180, 83, 9);
            lblDumbbellPrice.Location = new Point(285, 18);
            lblDumbbellPrice.Name = "lblDumbbellPrice";
            lblDumbbellPrice.Padding = new Padding(6, 2, 6, 2);
            lblDumbbellPrice.Size = new Size(68, 21);
            lblDumbbellPrice.TabIndex = 2;
            lblDumbbellPrice.Text = "400 ETB";
            // 
            // lblDumbbellDesc
            // 
            lblDumbbellDesc.AutoSize = true;
            lblDumbbellDesc.Font = new Font("Segoe UI", 8.25F);
            lblDumbbellDesc.ForeColor = Color.FromArgb(100, 116, 139);
            lblDumbbellDesc.Location = new Point(10, 34);
            lblDumbbellDesc.Name = "lblDumbbellDesc";
            lblDumbbellDesc.Size = new Size(212, 13);
            lblDumbbellDesc.TabIndex = 1;
            lblDumbbellDesc.Text = "Free weights, dumbbells, barbells & racks";
            // 
            // lblDumbbellTitle
            // 
            lblDumbbellTitle.AutoSize = true;
            lblDumbbellTitle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblDumbbellTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblDumbbellTitle.Location = new Point(10, 12);
            lblDumbbellTitle.Name = "lblDumbbellTitle";
            lblDumbbellTitle.Size = new Size(89, 17);
            lblDumbbellTitle.TabIndex = 0;
            lblDumbbellTitle.Text = "💪 Dumbbell";
            // 
            // panelMachine
            // 
            panelMachine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMachine.BackColor = Color.FromArgb(248, 250, 252);
            panelMachine.Controls.Add(lblMachinePrice);
            panelMachine.Controls.Add(lblMachineDesc);
            panelMachine.Controls.Add(lblMachineTitle);
            panelMachine.Location = new Point(20, 185);
            panelMachine.Name = "panelMachine";
            panelMachine.Padding = new Padding(10);
            panelMachine.Size = new Size(370, 60);
            panelMachine.TabIndex = 4;
            // 
            // lblMachinePrice
            // 
            lblMachinePrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMachinePrice.AutoSize = true;
            lblMachinePrice.BackColor = Color.FromArgb(238, 242, 255);
            lblMachinePrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMachinePrice.ForeColor = Color.FromArgb(37, 99, 235);
            lblMachinePrice.Location = new Point(285, 18);
            lblMachinePrice.Name = "lblMachinePrice";
            lblMachinePrice.Padding = new Padding(6, 2, 6, 2);
            lblMachinePrice.Size = new Size(68, 21);
            lblMachinePrice.TabIndex = 2;
            lblMachinePrice.Text = "500 ETB";
            // 
            // lblMachineDesc
            // 
            lblMachineDesc.AutoSize = true;
            lblMachineDesc.Font = new Font("Segoe UI", 8.25F);
            lblMachineDesc.ForeColor = Color.FromArgb(100, 116, 139);
            lblMachineDesc.Location = new Point(10, 34);
            lblMachineDesc.Name = "lblMachineDesc";
            lblMachineDesc.Size = new Size(204, 13);
            lblMachineDesc.TabIndex = 1;
            lblMachineDesc.Text = "Treadmills, cables & resistance machines";
            // 
            // lblMachineTitle
            // 
            lblMachineTitle.AutoSize = true;
            lblMachineTitle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblMachineTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMachineTitle.Location = new Point(10, 12);
            lblMachineTitle.Name = "lblMachineTitle";
            lblMachineTitle.Size = new Size(81, 17);
            lblMachineTitle.TabIndex = 0;
            lblMachineTitle.Text = "🏋️ Machine";
            // 
            // panelAerobics
            // 
            panelAerobics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelAerobics.BackColor = Color.FromArgb(248, 250, 252);
            panelAerobics.Controls.Add(lblAerobicsPrice);
            panelAerobics.Controls.Add(lblAerobicsDesc);
            panelAerobics.Controls.Add(lblAerobicsTitle);
            panelAerobics.Location = new Point(20, 110);
            panelAerobics.Name = "panelAerobics";
            panelAerobics.Padding = new Padding(10);
            panelAerobics.Size = new Size(370, 60);
            panelAerobics.TabIndex = 3;
            // 
            // lblAerobicsPrice
            // 
            lblAerobicsPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAerobicsPrice.AutoSize = true;
            lblAerobicsPrice.BackColor = Color.FromArgb(238, 242, 255);
            lblAerobicsPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAerobicsPrice.ForeColor = Color.FromArgb(37, 99, 235);
            lblAerobicsPrice.Location = new Point(285, 18);
            lblAerobicsPrice.Name = "lblAerobicsPrice";
            lblAerobicsPrice.Padding = new Padding(6, 2, 6, 2);
            lblAerobicsPrice.Size = new Size(68, 21);
            lblAerobicsPrice.TabIndex = 2;
            lblAerobicsPrice.Text = "500 ETB";
            // 
            // lblAerobicsDesc
            // 
            lblAerobicsDesc.AutoSize = true;
            lblAerobicsDesc.Font = new Font("Segoe UI", 8.25F);
            lblAerobicsDesc.ForeColor = Color.FromArgb(100, 116, 139);
            lblAerobicsDesc.Location = new Point(10, 34);
            lblAerobicsDesc.Name = "lblAerobicsDesc";
            lblAerobicsDesc.Size = new Size(241, 13);
            lblAerobicsDesc.TabIndex = 1;
            lblAerobicsDesc.Text = "Cardio sessions, floor exercises & step workout";
            // 
            // lblAerobicsTitle
            // 
            lblAerobicsTitle.AutoSize = true;
            lblAerobicsTitle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblAerobicsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblAerobicsTitle.Location = new Point(10, 12);
            lblAerobicsTitle.Name = "lblAerobicsTitle";
            lblAerobicsTitle.Size = new Size(80, 17);
            lblAerobicsTitle.TabIndex = 0;
            lblAerobicsTitle.Text = "🏃 Aerobics";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 9.5F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Aerobics — 500 ETB / month", "Machine — 500 ETB / month", "Dumbbell — 400 ETB / month" });
            cmbCategory.Location = new Point(20, 68);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(370, 25);
            cmbCategory.TabIndex = 2;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblSelectCategory
            // 
            lblSelectCategory.AutoSize = true;
            lblSelectCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSelectCategory.ForeColor = Color.FromArgb(71, 85, 105);
            lblSelectCategory.Location = new Point(20, 48);
            lblSelectCategory.Name = "lblSelectCategory";
            lblSelectCategory.Size = new Size(162, 15);
            lblSelectCategory.TabIndex = 1;
            lblSelectCategory.Text = "Select Membership Category:";
            // 
            // lblCard2Title
            // 
            lblCard2Title.AutoSize = true;
            lblCard2Title.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblCard2Title.ForeColor = Color.FromArgb(30, 41, 59);
            lblCard2Title.Location = new Point(16, 15);
            lblCard2Title.Name = "lblCard2Title";
            lblCard2Title.Size = new Size(188, 20);
            lblCard2Title.TabIndex = 0;
            lblCard2Title.Text = "💳 Membership Category";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(880, 580);
            Controls.Add(cardMembershipPlan);
            Controls.Add(cardMemberDetails);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            cardMemberDetails.ResumeLayout(false);
            cardMemberDetails.PerformLayout();
            cardMembershipPlan.ResumeLayout(false);
            cardMembershipPlan.PerformLayout();
            panelFeeSummary.ResumeLayout(false);
            panelFeeSummary.PerformLayout();
            panelDumbbell.ResumeLayout(false);
            panelDumbbell.PerformLayout();
            panelMachine.ResumeLayout(false);
            panelMachine.PerformLayout();
            panelAerobics.ResumeLayout(false);
            panelAerobics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel cardMemberDetails;
        private Label lblCard1Title;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblAddress;
        private TextBox txtAddress;
        private Panel cardMembershipPlan;
        private Label lblCard2Title;
        private Label lblSelectCategory;
        private ComboBox cmbCategory;
        private Panel panelAerobics;
        private Label lblAerobicsTitle;
        private Label lblAerobicsDesc;
        private Label lblAerobicsPrice;
        private Panel panelMachine;
        private Label lblMachineTitle;
        private Label lblMachineDesc;
        private Label lblMachinePrice;
        private Panel panelDumbbell;
        private Label lblDumbbellTitle;
        private Label lblDumbbellDesc;
        private Label lblDumbbellPrice;
        private Panel panelFeeSummary;
        private Label lblFeeTitle;
        private Label lblFeeValue;
        private Label lblCurrencyNote;
        private Button btnRegister;
        private Button btnClear;
    }
}

