namespace AyuboDrive01
{
    partial class frmSearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCustomer));
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.libCustomersOrInvoiceNumber = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.libRentedVehicles = new System.Windows.Forms.ListBox();
            this.lblRentedVehicles = new System.Windows.Forms.Label();
            this.libInvoiceNumbers = new System.Windows.Forms.ListBox();
            this.lblInvoiceNumbers = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.lblSearchCustomer.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.lblSearchCustomer.Location = new System.Drawing.Point(240, 9);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(172, 21);
            this.lblSearchCustomer.TabIndex = 20;
            this.lblSearchCustomer.Text = "Search Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblSearchCustomer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 38);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(600, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(34, 25);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.libCustomersOrInvoiceNumber);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(9, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 420);
            this.panel2.TabIndex = 40;
            // 
            // libCustomersOrInvoiceNumber
            // 
            this.libCustomersOrInvoiceNumber.FormattingEnabled = true;
            this.libCustomersOrInvoiceNumber.Location = new System.Drawing.Point(13, 37);
            this.libCustomersOrInvoiceNumber.Name = "libCustomersOrInvoiceNumber";
            this.libCustomersOrInvoiceNumber.Size = new System.Drawing.Size(197, 368);
            this.libCustomersOrInvoiceNumber.TabIndex = 43;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 20);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.libRentedVehicles);
            this.panel3.Controls.Add(this.lblRentedVehicles);
            this.panel3.Controls.Add(this.libInvoiceNumbers);
            this.panel3.Controls.Add(this.lblInvoiceNumbers);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lblAddress);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.txtCustomerId);
            this.panel3.Controls.Add(this.lblCustomerID);
            this.panel3.Controls.Add(this.lblCustomerName);
            this.panel3.Location = new System.Drawing.Point(244, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 420);
            this.panel3.TabIndex = 41;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(285, 345);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 68);
            this.btnPrint.TabIndex = 42;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // libRentedVehicles
            // 
            this.libRentedVehicles.FormattingEnabled = true;
            this.libRentedVehicles.Location = new System.Drawing.Point(111, 218);
            this.libRentedVehicles.Name = "libRentedVehicles";
            this.libRentedVehicles.Size = new System.Drawing.Size(260, 121);
            this.libRentedVehicles.TabIndex = 9;
            // 
            // lblRentedVehicles
            // 
            this.lblRentedVehicles.AutoSize = true;
            this.lblRentedVehicles.Location = new System.Drawing.Point(17, 218);
            this.lblRentedVehicles.Name = "lblRentedVehicles";
            this.lblRentedVehicles.Size = new System.Drawing.Size(85, 13);
            this.lblRentedVehicles.TabIndex = 8;
            this.lblRentedVehicles.Text = "Rented Vehicles";
            // 
            // libInvoiceNumbers
            // 
            this.libInvoiceNumbers.FormattingEnabled = true;
            this.libInvoiceNumbers.Location = new System.Drawing.Point(111, 91);
            this.libInvoiceNumbers.Name = "libInvoiceNumbers";
            this.libInvoiceNumbers.Size = new System.Drawing.Size(260, 121);
            this.libInvoiceNumbers.TabIndex = 7;
            this.libInvoiceNumbers.SelectedIndexChanged += new System.EventHandler(this.libInvoiceNumbers_SelectedIndexChanged);
            // 
            // lblInvoiceNumbers
            // 
            this.lblInvoiceNumbers.AutoSize = true;
            this.lblInvoiceNumbers.Location = new System.Drawing.Point(17, 91);
            this.lblInvoiceNumbers.Name = "lblInvoiceNumbers";
            this.lblInvoiceNumbers.Size = new System.Drawing.Size(87, 13);
            this.lblInvoiceNumbers.TabIndex = 6;
            this.lblInvoiceNumbers.Text = "Invoice Numbers";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(111, 38);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(260, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(111, 12);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(260, 20);
            this.txtCustomerId.TabIndex = 2;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(17, 15);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(17, 41);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // frmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 479);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.frmSearchCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox libCustomersOrInvoiceNumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ListBox libRentedVehicles;
        private System.Windows.Forms.Label lblRentedVehicles;
        private System.Windows.Forms.ListBox libInvoiceNumbers;
        private System.Windows.Forms.Label lblInvoiceNumbers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
    }
}