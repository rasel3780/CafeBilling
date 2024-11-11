using CafeBillingSystem.DataAccessLayer.ApplicationDbContext;
using CafeBillingSystem.DataAccessLayer.Entities;
using CafeBillingSystem.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeBillingSystem.PresentationLayer
{
    public partial class AddUserForm : Form
    {
        private readonly Repository<User> _userRepository;
        private readonly User _loggedInUser;

        public AddUserForm(User loggedInUser)
        {
            InitializeComponent();
            var context = new CafeDbContext();
            _userRepository = new Repository<User>(context);
            cmbRole.Items.AddRange(new string[] { "Admin", "Employee" });
            _loggedInUser = loggedInUser;
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;

            Task.Run(() =>
            {

                System.Threading.Thread.Sleep(1000);
                this.Invoke((Action)(() =>
                {
                    var adminDashBoard = new AdminDashboardForm(_loggedInUser);
                    adminDashBoard.Show();
                    this.Hide();
                }));
            });
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblUsername.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPassword.Visible = true;
                return;
            }
            if (cmbRole.SelectedItem == null || string.IsNullOrEmpty(cmbRole.Text))
            {
                lblRole.Visible = true;
                return;
            }

            var emp = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = (Role)Enum.Parse(typeof(Role), cmbRole.SelectedItem.ToString())
            };

            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;

            try
            {
                Task.Run(() =>
                {
                    _userRepository.Add(emp);

                    this.Invoke((Action)(() =>
                    {
                        MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var adminDashBoard = new AdminDashboardForm(_loggedInUser);
                        adminDashBoard.Show();
                        this.Hide();
                    }));
                });
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    MessageBox.Show("There was a problem while trying to add the user. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            lblUsername.Visible = false;
            lblPassword.Visible = false;
            lblRole.Visible = false;
            cmbRole.SelectedIndex = 1;
            progressBar.Visible = false; 
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {
                lblUsername.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtPassword.Text.Length > 0)
            {
                lblPassword.Visible = false;
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRole.SelectedIndex>=0)
            {
                lblRole.Visible = false;
            }
        }
    }
}
