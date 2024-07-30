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
using CafeBillingSystem.DataAccessLayer.Entities;
using CafeBillingSystem.DataAccessLayer.ApplicationDbContext;

namespace CafeBillingSystem.PresentationLayer
{
    public partial class LoginForm : Form
    {
        private readonly Repository<User> _userRepository;
        public LoginForm()
        {
            InitializeComponent();
            var context = new CafeDbContext();
            _userRepository = new Repository<User>(context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepository.GetAll()
                .FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);
            if(user!=null)
            {
                var dashBoard = new AdminDashboardForm(user);
                this.Hide();
                dashBoard.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
