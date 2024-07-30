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

namespace CafeBillingSystem.PresentationLayer
{
    public partial class AddEmployeeForm : Form
    {
        private readonly Repository<User> _userRepository;
        public AddEmployeeForm()
        {
            InitializeComponent();
            var context = new CafeDbContext();
            _userRepository = new Repository<User>(context);
            cmbRole.Items.AddRange(new string[] {"Admin", "Employee" });
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)
                || cmbRole.SelectedItem == null) 
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            var emp = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = (Role)Enum.Parse(typeof(Role), cmbRole.SelectedItem.ToString())
            };

            _userRepository.Add(emp);
            MessageBox.Show("User Add successfully.");
            this.Close();
        }
    }
}
