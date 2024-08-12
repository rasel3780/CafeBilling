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

        public AdminDashboardForm(User loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            var context = new CafeDbContext();
            _userRepository = new Repository<User>(context);
            _itemRepository = new Repository<Item>(context);
            SetEqualColumnFillWeights(dgvItems);
            SetEqualColumnFillWeights(dgvUsers);
            this.Load += AdminDashboardForm_Load;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadItems();
        }
        private void SetEqualColumnFillWeights(DataGridView dgv)
        {
            int columnCount = dgv.ColumnCount;
            if (columnCount == 0) return;

            float equalWeight = 1f / columnCount;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.FillWeight = equalWeight;
            }
        }


        #region LOAD USERS
        private void LoadUsers()
        {
            var users = _userRepository.GetAll();
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
                dgvUsers.Columns.Add(deleteButtonColumn);
            }

            
            SetEqualColumnFillWeights(dgvUsers);

        }
        #endregion
        private void LoadItems()
        {
            var items = _itemRepository.GetAll();
            dgvItems.DataSource = items;

            

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
            dgvItems.Columns.Add(imageColumn); // Add the image column

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var item = row.DataBoundItem as Item;
                if (item != null)
                {
                    if (!string.IsNullOrEmpty(item.PicturePath) && File.Exists(item.PicturePath))
                    {
                        row.Cells["Image"].Value = ResizeImage(Image.FromFile(item.PicturePath), new Size(100, 100)); // Resize the image to fit the cell
                    }
                    else
                    {
                        string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "default.png");
                        row.Cells["Image"].Value = ResizeImage(Image.FromFile(defaultImagePath), new Size(100, 100)); // Resize the image to fit the cell
                    }
                }
            }

            // Ensure Update button column exists
            if (!dgvItems.Columns.Contains("Update"))
            {
                var updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Update",
                    UseColumnTextForButtonValue = true,
                };
                dgvItems.Columns.Add(updateButtonColumn);
            }

            // Ensure Delete button column exists
            if (!dgvItems.Columns.Contains("Delete"))
            {
                var deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                };
                dgvItems.Columns.Add(deleteButtonColumn);
            }

            // Set the DisplayIndex for each column to arrange them in the desired order
            dgvItems.Columns["Id"].DisplayIndex = 0;
            dgvItems.Columns["Name"].DisplayIndex = 1;
            dgvItems.Columns["Price"].DisplayIndex = 2;
            dgvItems.Columns["Category"].DisplayIndex = 3;
            dgvItems.Columns["Image"].DisplayIndex = 4;
            dgvItems.Columns["Update"].DisplayIndex = 5;
            dgvItems.Columns["Delete"].DisplayIndex = 6;

            SetEqualColumnFillWeights(dgvItems);
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
            if (dgvItems.Columns[e.ColumnIndex].Name == "Delete")
            {
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dgvItems.Columns[e.ColumnIndex].Name == "Update")
            {
                e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;
            }
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
    }
}
