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
    public partial class OrderForm : Form
    {
        private readonly User _loggedInUser;
        private readonly Repository<Item> _itemRepository;
        private Dictionary<int, OrderItem> cartItems = new Dictionary<int, OrderItem>();

        private decimal subtotal = 0m;
        private decimal vatRate = 0.13m; //13% vat
        private decimal discountRate = 0.05m; //15% discount




        public OrderForm(User user)
        {
            InitializeComponent();
            var context = new CafeDbContext();
            _itemRepository = new Repository<Item>(context);
            _loggedInUser = user;
           
            InitializeComponents();
            LoadItems();

        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }



        private void LoadItems()
        {
            var items = _itemRepository.GetAll();
            dgvItems.DataSource = items;
            
        }



        private void AddToCart(Item item)
        {
            if (cartItems.ContainsKey(item.Id))
            {
                cartItems[item.Id].Quantity++;
            }
            else
            {
                cartItems[item.Id] = new OrderItem
                {
                    ItemId = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = 1
                };
            }
            foreach(var foodItem in  cartItems)
            {
                MessageBox.Show("Key:"+foodItem.Key.ToString()+":"+foodItem.Value.Name+"-Quantity:"+foodItem.Value.Quantity.ToString()+"-id:"+foodItem.Value.ItemId);
            }
            UpdateCartView();
        }

        private void UpdateCartView()
        {


            var cartItemsList = cartItems.Values.ToList();
            dgvCart.DataSource = cartItemsList;
          
            CalculateTotals();
            

        }

        private void CalculateTotals()
        {
            subtotal = cartItems.Values.Sum(item=>item.Total);
            decimal vat = subtotal * vatRate;
            decimal discount = subtotal * discountRate;
            decimal total = subtotal + vat - discount;

            lblSubtotal.Text = subtotal.ToString();
            lblVat.Text = vat.ToString();
            lblDiscount.Text = discount.ToString();
            lblTotal.Text = total.ToString();
        }

        private void InitializeComponents()
        {
            //Items

            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvItems.AutoGenerateColumns = false;
            dgvItems.Columns.Clear();

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id",
                Visible = false
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                Name = "Name"
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price",
                Name = "Price"
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category",
                Name = "Category"
            });

            dgvItems.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Sell",
                HeaderText = "Sell",
                Text = "Sell",
                UseColumnTextForButtonValue = true,
            });

            //Cart

            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.AutoGenerateColumns = false;
            dgvCart.Columns.Clear();


            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemId",
                HeaderText = "Id",
                Name = "Id",
                Visible = false
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn 
            {
                DataPropertyName = "Name",
                Name = "Name",
                HeaderText = "Name"    
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                Name = "Price",
                HeaderText = "Price"
                
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                Name = "Quantity",
                HeaderText = "Quantity"
            });

            dgvCart.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Remove",
                HeaderText = "Remove",
                Text = "Remove",
                UseColumnTextForButtonValue = true,
            });
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
           

        }


       

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                if (e.ColumnIndex == dgvItems.Columns["Sell"].Index)
                {
                    var itemId = (int)dgvItems.Rows[e.RowIndex].Cells["Id"].Value;
                    MessageBox.Show(itemId.ToString());
                    var item = _itemRepository.GetById(itemId);
                    if (item != null)
                    {
                        MessageBox.Show("Name-" + item.Name + "-Price-" + item.Price.ToString());
                        AddToCart(item);
                    }
                }
                
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            UpdateCartView();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvCart.Columns["Remove"].Index)
                {
                  
                    
                    var itemId = (int)dgvCart.Rows[e.RowIndex].Cells["Id"].Value;
                    MessageBox.Show(itemId.ToString());
                    if (cartItems.ContainsKey(itemId))
                    {
                        cartItems.Remove(itemId);
                        UpdateCartView();
                    }
                  
                }
            }
        }
    }
}
