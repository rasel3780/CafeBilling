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
            progressBar.Visible = true;
            btnLogin.Enabled = false;

            Task.Run(() =>
            {
                var user = _userRepository.GetAll()
               .FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

                this.Invoke(new Action(() =>

                {

                    if (user != null)
                    {
                       
                        var dashBoard = new AdminDashboardForm(user);
                        dashBoard.Show();
                        progressBar.Visible = false;
                        this.Hide();

                    }
                    else
                    {
                        btnLogin.Enabled = true;
                        progressBar.Visible = false;
                        MessageBox.Show("Invalid Username or Password");
                    }
                }));
            });
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
