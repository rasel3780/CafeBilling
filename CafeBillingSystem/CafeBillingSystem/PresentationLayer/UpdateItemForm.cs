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
    public partial class UpdateItemForm : Form
    {
        private readonly User _loggedInUser;
        private readonly Item _itemToUpdate;
        private readonly ItemRepository _itemRepository;
        private string _previousPicturePath;

        public UpdateItemForm(User user, Item item)
        {
            InitializeComponent();
            _loggedInUser = user;
            var context = new CafeDbContext();
            _itemRepository = new ItemRepository(context);
            _itemToUpdate = item;
            this.Load += UpdateItemForm_Load;
        }

        private void LoadCategories()
        {
            var categories = _itemRepository.GetDistinctCategories();
            cmbCategories.Items.Clear();
            foreach (var category in categories)
            {
                if (!cmbCategories.Items.Contains(category))
                {
                    cmbCategories.Items.Add(category);
                }
            }
        }

        private void LoadItemDetails()
        {

            txtName.Text = _itemToUpdate.Name;
            txtPrice.Text = _itemToUpdate.Price.ToString();

            if (!cmbCategories.Items.Contains(_itemToUpdate.Category))
            {
                cmbCategories.Items.Add(_itemToUpdate.Category);
            }
            cmbCategories.SelectedItem = _itemToUpdate.Category;
            txtNewCategory.Text = _itemToUpdate.Category;


            if (!string.IsNullOrEmpty(_itemToUpdate.PicturePath) && File.Exists(_itemToUpdate.PicturePath))
            {
                picItem.Image = ResizeImage(Image.FromFile(_itemToUpdate.PicturePath), new Size(picItem.Width, picItem.Height));
                _previousPicturePath = _itemToUpdate.PicturePath;
            }
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            return new Bitmap(imgToResize, size);
        }

        private void UpdateItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            var adminDashBoardFrom = new AdminDashboardForm(_loggedInUser);
            adminDashBoardFrom.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string imgDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");

            if (!Directory.Exists(imgDirectory))
            {
                Directory.CreateDirectory(imgDirectory);
            }

            string imagePath = _previousPicturePath;

            if (!string.IsNullOrEmpty(picItem.ImageLocation) && picItem.ImageLocation != _previousPicturePath)
            {
                imagePath = Path.Combine(imgDirectory, Path.GetFileName(picItem.ImageLocation));

                if (!File.Exists(imagePath))
                {
                    File.Copy(picItem.ImageLocation, imagePath);
                }
            }


            // Update item details
            string updatedCategory = !string.IsNullOrEmpty(txtNewCategory.Text) ? txtNewCategory.Text : cmbCategories.SelectedItem?.ToString();


            _itemToUpdate.Name = txtName.Text;
            _itemToUpdate.Price = decimal.Parse(txtPrice.Text);
            _itemToUpdate.Category = updatedCategory;
            _itemToUpdate.PicturePath = imagePath;

            _itemRepository.Update(_itemToUpdate);
            MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var adminDashboard = new AdminDashboardForm(_loggedInUser);
            adminDashboard.Show();

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
                picItem.ImageLocation = openFileDialog.FileName;
            }
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadItemDetails();
        }
    }
}
