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
using CafeBillingSystem.DataAccessLayer.ApplicationDbContext;

namespace CafeBillingSystem.PresentationLayer
{
    public partial class UpdateUserForm : Form
    {
        private readonly Repository<User> _userRepository;
        private readonly User _loggedInUser;
        private readonly User _userToUpdate;
        public UpdateUserForm(User loggedInUser, User userToUpdate)
        {
            InitializeComponent();
            var context = new CafeDbContext();
            _userRepository = new Repository<User>(context);
            _loggedInUser = loggedInUser;
            _userToUpdate = userToUpdate;

            txtUsername.Text = userToUpdate.Username;
            txtPassword.Text = userToUpdate.Password;
            cmbRole.Items.AddRange(new string[] { "Admin", "Employee" });
            cmbRole.SelectedItem = userToUpdate.Role.ToString();
        }

        private async void btnBack_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            lblLoading.Visible = true;
            await Task.Delay(1000);
            var adminDashBoard = new AdminDashboardForm(_loggedInUser);
            adminDashBoard.Show();
            this.Hide();
        }

        private async void btnUpdateUser_Click(object sender, EventArgs e)
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
            if(cmbRole.SelectedItem == null || string.IsNullOrEmpty(cmbRole.Text))
            {
                lblRole.Visible = true;
                return;
            }

            _userToUpdate.Username = txtUsername.Text;
            _userToUpdate.Password = txtPassword.Text;
            _userToUpdate.Role = (Role)Enum.Parse(typeof(Role), cmbRole.SelectedItem.ToString());

            try
            {
                progressBar.Visible = true;
                lblLoading.Visible = true;
                _userRepository.Update(_userToUpdate);
                await Task.Delay(2000);
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch
            {
                MessageBox.Show("An error occurred while updating user", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                var adminDashBoard = new AdminDashboardForm(_loggedInUser);
                adminDashBoard.Show();
                progressBar.Visible = false;
                lblLoading.Visible = false;
                this.Hide();
            }
           
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            lblUsername.Visible = false;
            lblPassword.Visible = false;
            lblRole.Visible = false;
        }

        private void UpdateUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length > 0)
            {
                lblUsername.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if( txtPassword.Text.Length > 0)
            {
                 lblPassword.Visible = false; 
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRole.SelectedIndex >=0)
            {
                lblRole.Visible = false;
            }
        }
    }
}
