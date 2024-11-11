namespace CafeBillingSystem.PresentationLayer
{
    partial class UpdateUserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 608);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.19529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.3266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbRole, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblLoading, 1, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 280);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.progressBar.Location = new System.Drawing.Point(313, 228);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(248, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsername.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(313, 7);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(248, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // cmbRole
            // 
            this.cmbRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbRole.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(313, 128);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(248, 28);
            this.cmbRole.TabIndex = 2;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Role";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(313, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(313, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(127, 16);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "This field is required";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.Red;
            this.lblRole.Location = new System.Drawing.Point(313, 163);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(91, 16);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Select a Role ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(313, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(127, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "This field is required";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(313, 186);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(287, 35);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUpdateUser.BackColor = System.Drawing.Color.Lime;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(3, 3);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(123, 29);
            this.btnUpdateUser.TabIndex = 4;
            this.btnUpdateUser.Text = "Submit";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(160, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Navy;
            this.lblLoading.Location = new System.Drawing.Point(313, 258);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(81, 20);
            this.lblLoading.TabIndex = 8;
            this.lblLoading.Text = "Loading.....";
            this.lblLoading.Visible = false;
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 632);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateUserForm";
            this.Text = "UpdateUserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateUserForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblLoading;
    }
}