using CafeBillingSystem.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBillingSystem.PresentationLayer
{
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm(List<OrderDetail> orderDetails)
        {
            InitializeComponent();
            LoadOrderDetails(orderDetails);
        }

        private void LoadOrderDetails(List<OrderDetail> orderDetails)
        {
            dgvOrderDetails.DataSource = orderDetails;
            dgvOrderDetails.AutoGenerateColumns = false;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrderDetails.Columns.Clear();
            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemId",
                HeaderText = "Item Id",
                Name = "Id",
                ReadOnly = true
            });

            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                Name = "Name",
                HeaderText = "Item Name",
                ReadOnly = true
            });

            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                Name = "Quantity",
                HeaderText = "Quantity",
                ReadOnly = true
            });

            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                Name = "Price",
                HeaderText = "Price",
                ReadOnly = true
            });

         

            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                Name = "Total",
                HeaderText = "Total",
                ReadOnly = true
            });
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
