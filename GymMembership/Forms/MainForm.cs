using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMembership.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void LoadForm(Form childForm)
        {
            
            if (this.panelContent.Controls.Count > 0)
            {
                this.panelContent.Controls[0].Dispose();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashForm = new DashboardForm();
            LoadForm(dashForm);
        }
    }
}
