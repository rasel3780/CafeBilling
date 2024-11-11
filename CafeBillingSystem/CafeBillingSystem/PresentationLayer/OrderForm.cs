using CafeBillingSystem.DataAccessLayer.ApplicationDbContext;
using CafeBillingSystem.DataAccessLayer.Entities;
using CafeBillingSystem.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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

        private string searchBoxPlaceHolder = "Search item by Id, Name, Category.....";
        private string orderSearchBoxPlaceHolder = "Search order by Order Id, Token Number, Date.....";

        private int tokenNumber;


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
            LoadOrder();

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

        private void LoadOrder()
        {
            var orders = _orderRepository.GetAll()
                .OrderByDescending(order=>order.OrderDate)
                .ToList();
            dgvOrders.DataSource = orders;
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
                ReadOnly = true
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

            //Orders
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear();
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderId",
                Name = "Id",
                HeaderText = "Id",
                ReadOnly = true

            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TokenNumber",
                Name = "TokenNumber",
                HeaderText = "Token No",
                ReadOnly = true
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ServedBy",
                Name = "ServedBy",
                HeaderText = "Served By",
                ReadOnly = true
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderDate",
                Name = "Date",
                HeaderText = "Date",
                ReadOnly = true
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                Name = "Total",
                HeaderText = "Total",
                ReadOnly = true

            });

            dgvOrders.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Details",
                HeaderText = "See Details",
                Text = "Details",
                UseColumnTextForButtonValue = true,
                ReadOnly = true
            });



        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            txtBoxSearchItem.ForeColor = Color.Gray;
            OrderSearchBox.ForeColor = Color.Gray;
            if(_loggedInUser.Role==Role.Admin)
            {
                btnBack.Visible = true;
            }
            else
            {
                btnBack.Visible = false;
            }
            
        }




        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == dgvItems.Columns["Sell"].Index)
                {
                    var itemId = (int)dgvItems.Rows[e.RowIndex].Cells["Id"].Value;
                   
                    var item = _itemRepository.GetById(itemId);
                    if (item != null)
                    {
                        AddToCart(item);
                    }
                }

            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Rest cart?","Confirm rest!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                cartItems.Clear();
                UpdateCartView();
            }
            
            
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {



                var itemId = (int)dgvCart.Rows[e.RowIndex].Cells["Id"].Value;
               

                
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
                SaveOrder();
                GenerateBill();
                cartItems.Clear();
                UpdateCartView();
                MessageBox.Show("Order Confirmed");
                LoadOrder();
            }
        }

        private void SaveOrder()
        {
            tokenNumber = GetNextTokenNumber();
            var order = new Order
            {
                OrderDate = DateTime.Now,
                ServedBy = _loggedInUser.Username,
                SubTotal = subtotal,
                Vat = subtotal * vatRate,
                Discount = subtotal * discountRate,
                Total = (subtotal + (subtotal * vatRate) - (subtotal * discountRate)),
                TokenNumber = tokenNumber

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
            billDetails.AppendLine("Token Number: " + tokenNumber.ToString());
            billDetails.AppendLine("Date: " + DateTime.Now.ToString("dd-MM-yyyy"));
            billDetails.AppendLine("Time: " + DateTime.Now.ToString("hh:mm tt"));
            billDetails.AppendLine("Served By: " + _loggedInUser.Username);
            billDetails.AppendLine("==================================");

            foreach (var item in cartItems.Values)
            {
                billDetails.AppendLine($"{item.Name} - {item.Quantity} x {item.Price.ToString("C", new CultureInfo("bn-BD"))} = {item.Total.ToString("C", new CultureInfo("bn-BD"))}");
            }

            billDetails.AppendLine("==================================");
            billDetails.AppendLine($"Subtotal: {subtotal.ToString("C", new CultureInfo("bn-BD"))}");
            billDetails.AppendLine($"VAT (13%): {(subtotal * vatRate).ToString("C", new CultureInfo("bn-BD"))}");
            billDetails.AppendLine($"Discount: {(subtotal * discountRate).ToString("C", new CultureInfo("bn-BD"))}");
            billDetails.AppendLine($"Total: {(subtotal + (subtotal * vatRate) - (subtotal * discountRate)).ToString("C", new CultureInfo("bn-BD"))}");
            billDetails.AppendLine("==================================");
            billDetails.AppendLine("Thank you for your visit!");

            e.Graphics.DrawString(billDetails.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }

        private void dgvCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex == dgvCart.Columns["Quantity"].Index)
            {
                var itemId = (int)dgvCart.Rows[e.RowIndex].Cells["Id"].Value;
                int newQuantity;

                if (int.TryParse(dgvCart.Rows[e.RowIndex].Cells["Quantity"].Value.ToString(), out newQuantity))
                {
                    if (newQuantity > 0 && cartItems.ContainsKey(itemId))
                    {
                        cartItems[itemId].Quantity = newQuantity;
                        UpdateCartView();
                    }
                    else
                    {
                        MessageBox.Show("Quantity Must be greater than 0.");
                        dgvCart.Rows[e.RowIndex].Cells["Quantity"].Value = cartItems[itemId].Quantity;

                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                    dgvCart.Rows[e.RowIndex].Cells["Quantity"].Value = cartItems[itemId].Quantity;

                }
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvOrders.Columns["Details"].Index)
            {
                var orderId = (int)dgvOrders.Rows[e.RowIndex].Cells["Id"].Value;

                var orderDetails = _orderDetailRepository
                                    .GetAll()
                                    .Where(detail => detail.OrderId == orderId)
                                    .ToList();

                if (orderDetails != null && orderDetails.Count > 0)
                {
                    var orderDetailsForm = new OrderDetailsForm(orderDetails);
                    orderDetailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No details found for the selected order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtBoxSearchItem.Clear();
            txtBoxSearchItem.Text = searchBoxPlaceHolder;
            LoadItems();

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxSearchItem_Enter(object sender, EventArgs e)
        {
            if(txtBoxSearchItem.Text == searchBoxPlaceHolder)
            {
                txtBoxSearchItem.Text = "";
                txtBoxSearchItem.ForeColor = Color.Black;
            }
        }

        private void txtBoxSearchItem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxSearchItem.Text))
            {
                txtBoxSearchItem.Text = searchBoxPlaceHolder;
                txtBoxSearchItem.ForeColor = Color.Gray;
                dgvItems.DataSource = _itemRepository.GetAll() ;
            }
        }

        private void txtBoxSearchItem_TextChanged(object sender, EventArgs e)
        {
            string searchItem = ((TextBox)sender).Text.Trim().ToLower();

            var filteredItems = _itemRepository.GetAll()
                    .Where(item =>
                        item.Id.ToString().Contains(searchItem) ||
                        item.Name.ToLower().Contains(searchItem.ToLower()) ||
                        item.Category.ToLower().Contains(searchItem.ToLower()))
                    .ToList();

            dgvItems.DataSource = filteredItems;
        }

        private void btnClearOrderSearchBox_Click(object sender, EventArgs e)
        {
            OrderSearchBox.Clear();
            OrderSearchBox.Text = orderSearchBoxPlaceHolder;
            LoadOrder();
        }

        private void OrderSearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OrderSearchBox.Text))
            {
                OrderSearchBox.Text = orderSearchBoxPlaceHolder;
                OrderSearchBox.ForeColor = Color.Gray;
                LoadOrder(); 
            }
        }

        private void OrderSearchBox_Enter(object sender, EventArgs e)
        {
            if (OrderSearchBox.Text == orderSearchBoxPlaceHolder)
            {
                OrderSearchBox.Text = "";
                OrderSearchBox.ForeColor = Color.Black;
                LoadOrder();
            }
        }

        private void OrderSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchOrder = ((TextBox)sender).Text.Trim().ToLower();   
            
            var filterOrder = _orderRepository.GetAll()
                                .Where(order=>
                                    order.OrderId.ToString().Contains(searchOrder)||
                                    order.ServedBy.ToLower().Contains(searchOrder)||
                                    order.TokenNumber.ToString().Contains(searchOrder)||
                                    order.OrderDate.ToString().Contains(searchOrder))
                                .ToList();  

            dgvOrders.DataSource = filterOrder;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var adminDashBoardForm = new AdminDashboardForm(_loggedInUser);
            adminDashBoardForm.Show();
            this.Hide();
        }
    }
}
