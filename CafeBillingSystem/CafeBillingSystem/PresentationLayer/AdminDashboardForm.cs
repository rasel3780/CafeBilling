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
    public partial class AdminDashboardForm : Form
    {
        private readonly User _loggedInUser;
        private readonly Repository<User> _userRepository;
        public AdminDashboardForm(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            var context = new CafeDbContext();
            _userRepository = new Repository<User>(context);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if(_loggedInUser.Role== Role.Admin)
            {
                var addEmployeeFrom = new AddEmployeeForm();
                addEmployeeFrom.ShowDialog();
            }
            

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _userRepository.GetAll();
            dgvUsers.DataSource = users;
            dgvUsers.Columns["Password"].Visible = false;

            if (!dgvUsers.Columns.Contains("Delete"))
            {
                var deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dgvUsers.Columns.Add(deleteButtonColumn);
            }
        }

    

        private void DeleteUser(int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user != null)
            {
                _userRepository.Delete(userId);
                LoadUsers();
                MessageBox.Show("User deleted succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var userId = (int)dgvUsers.Rows[e.RowIndex].Cells["UserId"].Value;
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteUser(userId);
                }
            }
        }
    }
}
