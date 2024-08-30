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
        private readonly string requiredMessage = "This field is required";
        public LoginForm()
        {
            InitializeComponent();
            var context = new CafeDbContext();
            _userRepository = new Repository<User>(context);
        }



        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblUserName.Visible = false;
            lblPassword.Visible = false;
            lblUserName.ForeColor = Color.Red;
            lblPassword.ForeColor = Color.Red;
        }

        private  void btnLogin_Click(object sender, EventArgs e)
        {
            // Checking if textboxes are empty
            if (txtUsername.Text == "")
            {
                lblUserName.Visible = true;
                return;
            }
            if (txtPassword.Text == "")
            {
                lblPassword.Visible = true;
                return;
            }
            progressBar.Visible = true;
            btnLogin.Enabled = false;

            try
            {
                // Filtering user by username and password
                var user = _userRepository.GetAll()
               .FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);


                Task.Delay(2000);

                // If verified and role is admin, then open Admin Dashboard form
                if (user != null && user.Role == Role.Admin)
                {
                    var dashBoard = new AdminDashboardForm(user);
                    dashBoard.Show();
                    this.Hide();

                }
                // If verified and role is Employee, then open Admin Order form
                else if (user != null && user.Role == Role.Employee)
                {
                    var orderForm = new OrderForm(user);
                    orderForm.Show();
                    this.Hide();
                }
                //Username or password is incorrect. User is not verified
                else
                {
                    btnLogin.Enabled = true;
                    progressBar.Visible = false;
                    MessageBox.Show("Invalid Username or Password", "Wrong credentials",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }


            }
            catch
            {
                MessageBox.Show("There was a problem while trying to log in. " +
                    "Please try again later.", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                lblPassword.Visible = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {
                lblUserName.Visible = false;
            }
        }

    }
}
