namespace CafeBillingSystem.PresentationLayer
{
    partial class DashboardForm
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(-1075, 824);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(129, 19);
            this.btnAddEmployee.TabIndex = 17;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 450);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddEmployee;
    }
}