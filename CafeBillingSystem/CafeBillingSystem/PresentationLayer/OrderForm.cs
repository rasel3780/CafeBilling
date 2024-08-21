using CafeBillingSystem.DataAccessLayer.ApplicationDbContext;
using CafeBillingSystem.DataAccessLayer.Entities;
using CafeBillingSystem.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private readonly Repository<Order> _orderRepository;
        private readonly Repository<OrderDetail> _orderDetailRepository;
        private Dictionary<int, OrderDetail> cartItems = new Dictionary<int, OrderDetail>();

        private decimal subtotal = 0m;
        private decimal vatRate = 0.13m; //13% vat
        private decimal discountRate = 0.05m; //15% discount




        public OrderForm(User user)
        {
            InitializeComponent();
            var context = new CafeDbContext();
            _orderRepository = new Repository<Order>(context);
            _orderDetailRepository = new Repository<OrderDetail>(context);
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
                cartItems[item.Id] = new OrderDetail
                {
                    ItemId = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = 1
                };
            }
            foreach (var foodItem in cartItems)
            {
                MessageBox.Show("Key:" + foodItem.Key.ToString() + ":" + foodItem.Value.Name + "-Quantity:" + foodItem.Value.Quantity.ToString() + "-id:" + foodItem.Value.ItemId);
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
            subtotal = cartItems.Values.Sum(item => item.Total);
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
                Name = "Name",
                ReadOnly = true
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price",
                Name = "Price",
                ReadOnly = true
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category",
                Name = "Category",
                ReadOnly = true
            });

            dgvItems.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Sell",
                HeaderText = "Sell",
                Text = "Sell",
                UseColumnTextForButtonValue = true,
                ReadOnly = true
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
                HeaderText = "Name",
                ReadOnly = true
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                Name = "Price",
                HeaderText = "Price",
                ReadOnly = true

            });

            dgvCart.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Decrease",
                HeaderText = "",
                Text = "-",
                UseColumnTextForButtonValue = true,

            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                Name = "Quantity",
                HeaderText = "Quantity"
            });

            dgvCart.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Increase",
                HeaderText = "",
                Text = "+",
                UseColumnTextForButtonValue = true
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



                var itemId = (int)dgvCart.Rows[e.RowIndex].Cells["Id"].Value;
                MessageBox.Show(itemId.ToString());

                if (e.ColumnIndex == dgvCart.Columns["Decrease"].Index)
                {
                    if (cartItems.ContainsKey(itemId) && cartItems[itemId].Quantity > 1)
                    {
                        cartItems[itemId].Quantity--;
                        UpdateCartView();
                    }
                }
                else if (e.ColumnIndex == dgvCart.Columns["Increase"].Index)
                {
                    if(cartItems.ContainsKey(itemId))
                    {
                        cartItems[itemId].Quantity++;
                        UpdateCartView();
                    }
                }
                else if (e.ColumnIndex == dgvCart.Columns["Remove"].Index)
                {
                    if (cartItems.ContainsKey(itemId))
                    {
                        cartItems.Remove(itemId);
                        UpdateCartView();
                    }
                }



            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to confirm the order?",
                 "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                GenerateBill();
                SaveOrder();
                MessageBox.Show("Order Confirmed");
            }
        }

        private void SaveOrder()
        {
            var order = new Order
            {
                OrderDate = DateTime.Now,
                ServedBy = _loggedInUser.Username,
                SubTotal = subtotal,
                Vat = subtotal * vatRate,
                Discount = subtotal * discountRate,
                Total = (subtotal + (subtotal * vatRate) - (subtotal * discountRate)),
                TokenNumber = GetNextTokenNumber()

            };
            _orderRepository.Add(order);

            foreach (var detail in cartItems.Values)
            {
                detail.OrderId = order.OrderId;
                _orderDetailRepository.Add(detail);
            }


        }
        private int GetNextTokenNumber()
        {
            var today = DateTime.Today;
            var lastOrder = _orderRepository
                            .GetAll()
                            .Where(o => o.OrderDate >= today)
                            .OrderByDescending(o => o.TokenNumber)
                            .FirstOrDefault();

            int nextTokenNumber = 1;

            if (lastOrder != null)
            {
                nextTokenNumber = lastOrder.TokenNumber + 1;
            }

            return nextTokenNumber;
        }

        private void GenerateBill()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringBuilder billDetails = new StringBuilder();
            billDetails.AppendLine("----- Cafe Billing System -----");
            billDetails.AppendLine("Date: " + DateTime.Now.ToString("dd-MM-yyyy"));
            billDetails.AppendLine("Time: " + DateTime.Now.ToString("hh:mm tt"));
            billDetails.AppendLine("Served By: " + _loggedInUser.Username);
            billDetails.AppendLine("==================================");

            foreach (var item in cartItems.Values)
            {
                billDetails.AppendLine($"{item.Name} - {item.Quantity} x {item.Price:C} = {item.Total:C}");
            }

            billDetails.AppendLine("==================================");
            billDetails.AppendLine($"Subtotal: {subtotal:C}");
            billDetails.AppendLine($"VAT (13%): {subtotal * vatRate:C}");
            billDetails.AppendLine($"Discount: {subtotal * discountRate:C}");
            billDetails.AppendLine($"Total: {(subtotal + (subtotal * vatRate) - (subtotal * discountRate)):C}");
            billDetails.AppendLine("==================================");
            billDetails.AppendLine("Thank you for your visit!");

            e.Graphics.DrawString(billDetails.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }
    }
}
