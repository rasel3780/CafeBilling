namespace CafeBillingSystem.PresentationLayer
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.summeryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxSearchItem = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearOrderSearchBox = new System.Windows.Forms.Button();
            this.OrderSearchBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.summeryTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(1225, 589);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 31);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.btnLogout);
            this.mainPanel.Controls.Add(this.mainTableLayoutPanel);
            this.mainPanel.Location = new System.Drawing.Point(5, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1327, 625);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.54369F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.18953F));
            this.mainTableLayoutPanel.Controls.Add(this.dgvCart, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.label4, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.label5, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.label6, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.summeryTableLayoutPanel, 1, 3);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(23, 20);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.260281F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.83772F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.815275F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.43162F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1290, 563);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // summeryTableLayoutPanel
            // 
            this.summeryTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.summeryTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.summeryTableLayoutPanel.ColumnCount = 2;
            this.summeryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.89027F));
            this.summeryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.10973F));
            this.summeryTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.summeryTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.summeryTableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.summeryTableLayoutPanel.Controls.Add(this.lblSubtotal, 1, 0);
            this.summeryTableLayoutPanel.Controls.Add(this.lblVat, 1, 1);
            this.summeryTableLayoutPanel.Controls.Add(this.lblDiscount, 1, 2);
            this.summeryTableLayoutPanel.Controls.Add(this.label7, 0, 3);
            this.summeryTableLayoutPanel.Controls.Add(this.lblTotal, 1, 3);
            this.summeryTableLayoutPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summeryTableLayoutPanel.Location = new System.Drawing.Point(896, 399);
            this.summeryTableLayoutPanel.Name = "summeryTableLayoutPanel";
            this.summeryTableLayoutPanel.RowCount = 4;
            this.summeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.25F));
            this.summeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.75F));
            this.summeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.summeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.summeryTableLayoutPanel.Size = new System.Drawing.Size(358, 161);
            this.summeryTableLayoutPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vat (13%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount (3%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(162, 3);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(34, 23);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "0.0";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(162, 40);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(35, 23);
            this.lblVat.TabIndex = 4;
            this.lblVat.Text = "0%";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(162, 83);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(35, 23);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(162, 119);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 23);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0.0";
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(863, 32);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(424, 262);
            this.dgvCart.TabIndex = 5;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            this.dgvCart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellEndEdit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.81395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.441861F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.51163F));
            this.tableLayoutPanel1.Controls.Add(this.btnOrder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRest, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(863, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 37);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(228, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(193, 31);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Confirm Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.Gold;
            this.btnRest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRest.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRest.Location = new System.Drawing.Point(3, 3);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(188, 31);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(405, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Items";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1053, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cart";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(399, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Orders";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 56);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(848, 158);
            this.dgvOrders.TabIndex = 8;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvItems, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.73004F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.26996F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(854, 262);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.9465F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.053498F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel3.Controls.Add(this.txtBoxSearchItem, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClearSearch, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(569, 36);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtBoxSearchItem
            // 
            this.txtBoxSearchItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBoxSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchItem.Font = new System.Drawing.Font("Cambria", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchItem.Location = new System.Drawing.Point(128, 6);
            this.txtBoxSearchItem.Name = "txtBoxSearchItem";
            this.txtBoxSearchItem.Size = new System.Drawing.Size(296, 23);
            this.txtBoxSearchItem.TabIndex = 0;
            this.txtBoxSearchItem.Text = "Search item by Id, Name, Category.....";
            this.txtBoxSearchItem.TextChanged += new System.EventHandler(this.txtBoxSearchItem_TextChanged);
            this.txtBoxSearchItem.Enter += new System.EventHandler(this.txtBoxSearchItem_Enter);
            this.txtBoxSearchItem.Leave += new System.EventHandler(this.txtBoxSearchItem_Leave);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.Red;
            this.btnClearSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearSearch.Location = new System.Drawing.Point(472, 3);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(94, 30);
            this.btnClearSearch.TabIndex = 1;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(3, 46);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(848, 213);
            this.dgvItems.TabIndex = 3;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgvOrders, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 343);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.65116F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.34884F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(854, 217);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.77899F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.221006F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel5.Controls.Add(this.btnClearOrderSearchBox, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.OrderSearchBox, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(569, 36);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnClearOrderSearchBox
            // 
            this.btnClearOrderSearchBox.BackColor = System.Drawing.Color.Red;
            this.btnClearOrderSearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearOrderSearchBox.Location = new System.Drawing.Point(479, 3);
            this.btnClearOrderSearchBox.Name = "btnClearOrderSearchBox";
            this.btnClearOrderSearchBox.Size = new System.Drawing.Size(87, 30);
            this.btnClearOrderSearchBox.TabIndex = 0;
            this.btnClearOrderSearchBox.Text = "Clear";
            this.btnClearOrderSearchBox.UseVisualStyleBackColor = false;
            this.btnClearOrderSearchBox.Click += new System.EventHandler(this.btnClearOrderSearchBox_Click);
            // 
            // OrderSearchBox
            // 
            this.OrderSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OrderSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderSearchBox.Font = new System.Drawing.Font("Cambria", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSearchBox.Location = new System.Drawing.Point(128, 6);
            this.OrderSearchBox.Name = "OrderSearchBox";
            this.OrderSearchBox.Size = new System.Drawing.Size(311, 23);
            this.OrderSearchBox.TabIndex = 1;
            this.OrderSearchBox.Text = "Search order by Order Id, Token Number, Date.....";
            this.OrderSearchBox.TextChanged += new System.EventHandler(this.OrderSearchBox_TextChanged);
            this.OrderSearchBox.Enter += new System.EventHandler(this.OrderSearchBox_Enter);
            this.OrderSearchBox.Leave += new System.EventHandler(this.OrderSearchBox_Leave);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 634);
            this.Controls.Add(this.mainPanel);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.summeryTableLayoutPanel.ResumeLayout(false);
            this.summeryTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel summeryTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtBoxSearchItem;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnClearOrderSearchBox;
        private System.Windows.Forms.TextBox OrderSearchBox;
    }
}