using CafeBillingSystem.DataAccessLayer.ApplicationDbContext;
using CafeBillingSystem.DataAccessLayer.Entities;
using CafeBillingSystem.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private readonly Repository<Item> _itemRepository;
        private readonly SaleRepository _salesRepository;

        public AdminDashboardForm(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            var context = new CafeDbContext();
            _userRepository = new Repository<User>(context);
            _itemRepository = new Repository<Item>(context);
            _salesRepository = new SaleRepository(context);
  
            this.Load += AdminDashboardForm_Load;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadItems();
            LoadSalesData();
            dtpYearlySales.Format = DateTimePickerFormat.Custom;
            dtpYearlySales.CustomFormat = "yyyy";
        }

        private void LoadSalesData()
        {
            lblTodaysSales.Text = _salesRepository.GetTodaysSale().ToString("C");
           
            var selectedDate = dtpMonthlySales.Value;
            var monthlySales = _salesRepository.GetMonthlySales(selectedDate.Year, selectedDate.Month);
            lblMonthlySales.Text = monthlySales.ToString("C");
            
            var selectedYear = dtpYearlySales.Value;
            var yearlySales = _salesRepository.GetYearlySales(selectedYear.Year);
            lblYearlySales.Text = yearlySales.ToString("C");

            var quantity = int.Parse(txtBoxTopSellingQuantity.Text);
            LoadTopSellingItems(quantity);
        }

        private void LoadTopSellingItems(int quantity)
        {
            dgvTopSellingItems.AutoGenerateColumns = false;
            dgvTopSellingItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!dgvTopSellingItems.Columns.Contains("Id"))
            {
                dgvTopSellingItems.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Id",
                    Name = "Id",
                    HeaderText = "Id",
                    ReadOnly = true

                });
            }

            if (!dgvTopSellingItems.Columns.Contains("Name"))
            {
                dgvTopSellingItems.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Name",
                    Name = "Name",
                    HeaderText = "Name",
                    ReadOnly = true

                });
            }

            if (!dgvTopSellingItems.Columns.Contains("Category"))
            {
                dgvTopSellingItems.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Category",
                    Name = "Category",
                    HeaderText = "Category",
                    ReadOnly = true

                });
            }

            if (!dgvTopSellingItems.Columns.Contains("Price"))
            {
                dgvTopSellingItems.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Price",
                    Name = "Price",
                    HeaderText = "Price",
                    ReadOnly = true

                });
            }

            dgvTopSellingItems.DataSource = _salesRepository.GetTopSellingItems(quantity);
        }



        #region LOAD USERS
        private void LoadUsers()
        {

            var users = _userRepository.GetAll();

            // Set default cell styles
            dgvUsers.DefaultCellStyle.Font = new Font("Cambria", 10);
    

            // Set alternating row styles
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 229, 229, 229);
            dgvUsers.RowTemplate.Height = 30;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            // Customize header styles
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 10);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvUsers.EnableHeadersVisualStyles = false;

            // Add padding to cells
            Padding cellPadding = new Padding(1);
            dgvUsers.DefaultCellStyle.Padding = cellPadding;

            dgvUsers.DataSource = users;
            dgvUsers.Columns["Password"].Visible = false;

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            if (!dgvUsers.Columns.Contains("Update"))
            {
                var updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name="Update",
                    HeaderText = "Update",
                    Text = "Update",
                    UseColumnTextForButtonValue = true
                };
                updateButtonColumn.FlatStyle = FlatStyle.Popup;
                updateButtonColumn.DefaultCellStyle.ForeColor = Color.Green;                
                dgvUsers.Columns.Add(updateButtonColumn);
            }
            
            if (!dgvUsers.Columns.Contains("Delete"))
            {
                var deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };

                deleteButtonColumn.FlatStyle = FlatStyle.Popup;
                deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Red;
                dgvUsers.Columns.Add(deleteButtonColumn);
            }

            
            

        }
        #endregion
        private void LoadItems()
        {

            var items = _itemRepository.GetAll();
            dgvItems.DataSource = items;


            // Set default cell styles
            dgvItems.DefaultCellStyle.Font = new Font("Cambria", 10);
            dgvItems.DefaultCellStyle.SelectionBackColor = Color.Green;


            // Set alternating row styles
            dgvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255,229,229,229);
            dgvItems.RowTemplate.Height = 30;
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            // Customize header styles
            dgvItems.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 10);
            dgvItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255,29,204,0) ;
            dgvItems.EnableHeadersVisualStyles = false;

            // Add padding to cells
            Padding cellPadding = new Padding(1);
            dgvItems.DefaultCellStyle.Padding = cellPadding;


            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            if (dgvItems.Columns.Contains("PicturePath"))
            {
                dgvItems.Columns["PicturePath"].Visible = false;
            }

            if (dgvItems.Columns.Contains("Image"))
            {
                dgvItems.Columns.Remove("Image");
            }

            var imageColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
            };
            dgvItems.Columns.Add(imageColumn); 

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var item = row.DataBoundItem as Item;
                if (item != null)
                {
                    if (!string.IsNullOrEmpty(item.PicturePath) && File.Exists(item.PicturePath))
                    {
                        row.Cells["Image"].Value = ResizeImage(Image.FromFile(item.PicturePath), new Size(50, 25)); // Resize the image to fit the cell
                    }
                    else
                    {
                        string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "default.png");
                        row.Cells["Image"].Value = ResizeImage(Image.FromFile(defaultImagePath), new Size(50, 25)); // Resize the image to fit the cell
                    }
                }
            }

            if (!dgvItems.Columns.Contains("Update"))
            {
                var updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Update",
                    UseColumnTextForButtonValue = true,
                };
                updateButtonColumn.FlatStyle = FlatStyle.Popup;
                updateButtonColumn.DefaultCellStyle.ForeColor = Color.Green;
                dgvItems.Columns.Add(updateButtonColumn);
            }

            if (!dgvItems.Columns.Contains("Delete"))
            {
                var deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                };
                deleteButtonColumn.FlatStyle = FlatStyle.Popup;
                deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Red;
                dgvItems.Columns.Add(deleteButtonColumn);
            }

            dgvItems.Columns["Id"].DisplayIndex = 0;
            dgvItems.Columns["Name"].DisplayIndex = 1;
            dgvItems.Columns["Price"].DisplayIndex = 2;
            dgvItems.Columns["Category"].DisplayIndex = 3;
            dgvItems.Columns["Image"].DisplayIndex = 4;
            dgvItems.Columns["Update"].DisplayIndex = 5;
            dgvItems.Columns["Delete"].DisplayIndex = 6;

           
        }




        private Image ResizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }


        #region DELETE USER
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
        #endregion

   

        private void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (_loggedInUser.Role == Role.Admin)
            {
                this.Hide();
                var addEmployeeFrom = new AddUserForm(_loggedInUser);
                addEmployeeFrom.Show();
            }
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            var addItemForm = new AddItemForm(_loggedInUser);
            addItemForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var itemId = (int)dgvItems.Rows[e.RowIndex].Cells["Id"].Value;

                if (e.ColumnIndex == dgvItems.Columns["Update"].Index)
                {
                    var item = _itemRepository.GetById(itemId);
                    if (item != null)
                    {
                        var updateItemForm = new UpdateItemForm(_loggedInUser, item);
                        updateItemForm.Show();
                        this.Hide();
                    }
                }

                else if (e.ColumnIndex == dgvItems.Columns["Delete"].Index)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _itemRepository.Delete(itemId);
                        LoadItems();
                        MessageBox.Show("Item deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0)
            {
                var userId = (int)dgvUsers.Rows[e.RowIndex ].Cells["UserId"].Value;


                if(e.ColumnIndex == dgvUsers.Columns["Update"].Index)
                {
                    var user = _userRepository.GetById(userId);

                    var updateUserForm = new UpdateUserForm(_loggedInUser, user);
                    updateUserForm.Show();
                    this.Hide();

                }

                else if(e.ColumnIndex == dgvUsers.Columns["Delete"].Index)
                {
                    var user = _userRepository.GetById(userId);
                    if (user != null)
                    {
                        var confirm = MessageBox.Show("Are you sure, you want to delete the user?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            _userRepository.Delete(userId);
                            LoadUsers();
                            MessageBox.Show("User removed", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(_loggedInUser);
            orderForm.Show();
            this.Hide();
        }

        //REPORT 

        private void dtpMonthlySales_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void dtpYearlySales_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void txtBoxTopSellingQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTopSellingQuantity.Text != string.Empty)
            {
                var quantity = int.Parse(txtBoxTopSellingQuantity.Text);
                if (quantity > 0)
                {
                    LoadTopSellingItems(quantity);
                }
            }
        }
    }
}
