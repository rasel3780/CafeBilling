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

        private void btnBack_Click(object sender, EventArgs e)
        {
           
       
                var adminDashBoard = new AdminDashboardForm(_loggedInUser);
                adminDashBoard.Show();
                this.Hide();
            

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            _userToUpdate.Username = txtUsername.Text;
            _userToUpdate.Password = txtPassword.Text;
            _userToUpdate.Role = (Role)Enum.Parse(typeof(Role), cmbRole.SelectedItem.ToString());

            _userRepository.Update(_userToUpdate);
            MessageBox.Show("User updated successfully.");

            var adminDashBoard = new AdminDashboardForm(_loggedInUser);
            adminDashBoard.Show();
            this.Hide();
        }

        
    }
}
