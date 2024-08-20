﻿namespace CafeBillingSystem.PresentationLayer
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.mainPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.summeryTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(1201, 589);
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
            this.mainPanel.Size = new System.Drawing.Size(1303, 625);
            this.mainPanel.TabIndex = 2;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.summeryTableLayoutPanel, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.dgvItems, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.dgvCart, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(19, 20);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.86837F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.058615F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.24156F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1270, 563);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // summeryTableLayoutPanel
            // 
            this.summeryTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.summeryTableLayoutPanel.Location = new System.Drawing.Point(750, 424);
            this.summeryTableLayoutPanel.Name = "summeryTableLayoutPanel";
            this.summeryTableLayoutPanel.RowCount = 4;
            this.summeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.summeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.summeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.summeryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.summeryTableLayoutPanel.Size = new System.Drawing.Size(404, 117);
            this.summeryTableLayoutPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vat (13%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount (3%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(182, 3);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(34, 23);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "0.0";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(182, 34);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(35, 23);
            this.lblVat.TabIndex = 4;
            this.lblVat.Text = "0%";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(182, 60);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(35, 23);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(182, 93);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 21);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0.0";
            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(3, 3);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(629, 347);
            this.dgvItems.TabIndex = 3;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(638, 3);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(629, 347);
            this.dgvCart.TabIndex = 5;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRest, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOrder, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(737, 357);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 41);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnRest
            // 
            this.btnRest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRest.BackColor = System.Drawing.Color.Gold;
            this.btnRest.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRest.Location = new System.Drawing.Point(69, 3);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(77, 35);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Reset";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(247, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(150, 35);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Confirm Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 634);
            this.Controls.Add(this.mainPanel);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.summeryTableLayoutPanel.ResumeLayout(false);
            this.summeryTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
    }
}