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
    public partial class AddItemForm : Form
    {
        private readonly Repository<Item> _itemRepository;
        private readonly User _loggedInUser;
        private string _selectedImagePath;
        private bool selectionChange = false;

        public AddItemForm(User user)
        {
            InitializeComponent();
            var context = new CafeDbContext();
            _itemRepository = new Repository<Item>(context);
            LoadCategories();
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            _loggedInUser = user;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtName.Text))
            {
                lblItemName.Visible = true;
                return;
            }

            if(string.IsNullOrEmpty(txtPrice.Text))
            {
                lblPrice.Visible = true; 
                return;
            }
            
            if(cmbCategories.SelectedIndex == -1)
            {
                lblcmbBox.ForeColor = Color.Red;
                lblcmbBox.Visible = true;
                return;
            }

            string imgDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");

            if (!Directory.Exists(imgDirectory))
            {
                Directory.CreateDirectory(imgDirectory);
            }

            string imagePath = Path.Combine(imgDirectory, Path.GetFileName(picItem.ImageLocation));

            if (!File.Exists(imagePath))
            {
                File.Copy(picItem.ImageLocation, imagePath);
            }

            
            progressBar.Visible = true;
            lblLoading.Visible = true;
            try
            {
                var newItem = new Item
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Category = cmbCategories.SelectedItem?.ToString(),
                    PicturePath = imagePath
                };
                _itemRepository.Add(newItem);
                await Task.Delay(2000);
                MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                var adminDashboard = new AdminDashboardForm(_loggedInUser);
                adminDashboard.Show();
                progressBar.Visible = false;
                lblLoading.Visible = false;
                this.Hide();
            }
            
           


        }
    


        private void LoadCategories()
        {
            cmbCategories.Items.Clear();
            cmbCategories.Items.Add("Add New Category");
            var categoires = _itemRepository.GetAll().Select(i=>i.Category).Distinct().ToList();
            cmbCategories.Items.AddRange(categoires.ToArray());
            cmbCategories.SelectedIndex = -1;
        }

     



        private Image ResizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Task.Delay(1000);
            progressBar.Visible = true;
            var adminDashboard = new AdminDashboardForm(_loggedInUser);
            adminDashboard.Show();
            this.Hide();
        }

        private void AddItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectionChange)
            {
                return;
            }
            if (cmbCategories.SelectedItem != null && cmbCategories.SelectedItem.ToString() == "Add New Category")
            {
                using(var addCategoryForm = new AddCategoryForm())
                {
                    if(addCategoryForm.ShowDialog() == DialogResult.OK)
                    {
                        string newCategory = addCategoryForm.NewCategory;
                        selectionChange = true;
                        cmbCategories.Items.Add(newCategory);
                        cmbCategories.SelectedItem = newCategory;
                        selectionChange = false;
                    }
                    else
                    {
                        selectionChange = true;
                        cmbCategories.SelectedIndex = -1;
                        selectionChange = false;
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image orginalImage = Image.FromFile(openFileDialog.FileName);
                Size newSize = new Size(picItem.Width, picItem.Height);
                Image resizedImage = ResizeImage(orginalImage, newSize);
                picItem.Image = resizedImage;
                picItem.ImageLocation = openFileDialog.FileName;

                picItem.ImageLocation = openFileDialog.FileName;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text.Length > 0)
            {
                lblItemName.Visible = false;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if(txtPrice.Text.Length > 0)
            {
                lblPrice.Visible = false;
            }
        }
    }
}
