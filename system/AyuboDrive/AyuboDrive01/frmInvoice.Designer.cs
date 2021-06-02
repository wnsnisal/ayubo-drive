namespace AyuboDrive01
{
    partial class frmRentInvoice
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblRntInvoice = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.libAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnSavAndPrint = new System.Windows.Forms.Button();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.lblIssuedUser = new System.Windows.Forms.Label();
            this.txtIssuedUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtAdvancePay = new System.Windows.Forms.TextBox();
            this.lblAdavcePay = new System.Windows.Forms.Label();
            this.txtTotalBillValue = new System.Windows.Forms.TextBox();
            this.lblTotalBillValue = new System.Windows.Forms.Label();
            this.txtTotalPayble = new System.Windows.Forms.TextBox();
            this.lblTotalPayable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblInvoice);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 38);
            this.panel1.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(701, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 85;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoice.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.ForeColor = System.Drawing.Color.White;
            this.lblInvoice.Location = new System.Drawing.Point(332, 9);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(70, 21);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Invoice";
            // 
            // lblRntInvoice
            // 
            this.lblRntInvoice.AutoSize = true;
            this.lblRntInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRntInvoice.Location = new System.Drawing.Point(310, 48);
            this.lblRntInvoice.Name = "lblRntInvoice";
            this.lblRntInvoice.Size = new System.Drawing.Size(119, 25);
            this.lblRntInvoice.TabIndex = 81;
            this.lblRntInvoice.Text = "Rent Invoice";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(11, 40);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 84;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(99, 37);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(349, 20);
            this.txtCustomerName.TabIndex = 85;
            // 
            // libAddress
            // 
            this.libAddress.AutoSize = true;
            this.libAddress.Location = new System.Drawing.Point(48, 66);
            this.libAddress.Name = "libAddress";
            this.libAddress.Size = new System.Drawing.Size(45, 13);
            this.libAddress.TabIndex = 86;
            this.libAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(99, 63);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(349, 20);
            this.txtAddress.TabIndex = 87;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(48, 92);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 88;
            this.lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(99, 89);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(349, 20);
            this.txtContact.TabIndex = 89;
            // 
            // btnSavAndPrint
            // 
            this.btnSavAndPrint.BackColor = System.Drawing.Color.Lime;
            this.btnSavAndPrint.FlatAppearance.BorderSize = 0;
            this.btnSavAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavAndPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSavAndPrint.Location = new System.Drawing.Point(575, 244);
            this.btnSavAndPrint.Name = "btnSavAndPrint";
            this.btnSavAndPrint.Size = new System.Drawing.Size(114, 47);
            this.btnSavAndPrint.TabIndex = 78;
            this.btnSavAndPrint.Text = "Save and Print";
            this.btnSavAndPrint.UseVisualStyleBackColor = false;
            this.btnSavAndPrint.Click += new System.EventHandler(this.btnSavAndPrint_Click);
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Location = new System.Drawing.Point(33, 188);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleNo.TabIndex = 102;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Enabled = false;
            this.txtVehicleNo.Location = new System.Drawing.Point(99, 185);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(349, 20);
            this.txtVehicleNo.TabIndex = 103;
            // 
            // lblIssuedUser
            // 
            this.lblIssuedUser.AutoSize = true;
            this.lblIssuedUser.Location = new System.Drawing.Point(29, 214);
            this.lblIssuedUser.Name = "lblIssuedUser";
            this.lblIssuedUser.Size = new System.Drawing.Size(63, 13);
            this.lblIssuedUser.TabIndex = 104;
            this.lblIssuedUser.Text = "Issued User";
            // 
            // txtIssuedUser
            // 
            this.txtIssuedUser.Enabled = false;
            this.txtIssuedUser.Location = new System.Drawing.Point(99, 211);
            this.txtIssuedUser.Name = "txtIssuedUser";
            this.txtIssuedUser.Size = new System.Drawing.Size(349, 20);
            this.txtIssuedUser.TabIndex = 105;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txtInvoiceNo);
            this.panel2.Controls.Add(this.lblInvoiceNo);
            this.panel2.Controls.Add(this.txtIssuedUser);
            this.panel2.Controls.Add(this.lblIssuedUser);
            this.panel2.Controls.Add(this.txtVehicleNo);
            this.panel2.Controls.Add(this.lblVehicleNo);
            this.panel2.Controls.Add(this.txtEndDate);
            this.panel2.Controls.Add(this.lblEndDate);
            this.panel2.Controls.Add(this.txtStartDate);
            this.panel2.Controls.Add(this.lblStartDate);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.lblContact);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.libAddress);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 240);
            this.panel2.TabIndex = 83;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Location = new System.Drawing.Point(99, 11);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(349, 20);
            this.txtInvoiceNo.TabIndex = 107;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(29, 14);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(59, 13);
            this.lblInvoiceNo.TabIndex = 106;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Enabled = false;
            this.txtEndDate.Location = new System.Drawing.Point(324, 137);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(124, 20);
            this.txtEndDate.TabIndex = 97;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(266, 140);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 96;
            this.lblEndDate.Text = "End Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Enabled = false;
            this.txtStartDate.Location = new System.Drawing.Point(99, 137);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(124, 20);
            this.txtStartDate.TabIndex = 95;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(37, 140);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 94;
            this.lblStartDate.Text = "Start Date";
            // 
            // txtAdvancePay
            // 
            this.txtAdvancePay.Enabled = false;
            this.txtAdvancePay.Location = new System.Drawing.Point(575, 192);
            this.txtAdvancePay.Name = "txtAdvancePay";
            this.txtAdvancePay.Size = new System.Drawing.Size(150, 20);
            this.txtAdvancePay.TabIndex = 113;
            // 
            // lblAdavcePay
            // 
            this.lblAdavcePay.AutoSize = true;
            this.lblAdavcePay.Location = new System.Drawing.Point(503, 196);
            this.lblAdavcePay.Name = "lblAdavcePay";
            this.lblAdavcePay.Size = new System.Drawing.Size(65, 13);
            this.lblAdavcePay.TabIndex = 112;
            this.lblAdavcePay.Text = "Advace Pay";
            // 
            // txtTotalBillValue
            // 
            this.txtTotalBillValue.Enabled = false;
            this.txtTotalBillValue.Location = new System.Drawing.Point(575, 166);
            this.txtTotalBillValue.Name = "txtTotalBillValue";
            this.txtTotalBillValue.Size = new System.Drawing.Size(150, 20);
            this.txtTotalBillValue.TabIndex = 111;
            // 
            // lblTotalBillValue
            // 
            this.lblTotalBillValue.AutoSize = true;
            this.lblTotalBillValue.Location = new System.Drawing.Point(491, 169);
            this.lblTotalBillValue.Name = "lblTotalBillValue";
            this.lblTotalBillValue.Size = new System.Drawing.Size(77, 13);
            this.lblTotalBillValue.TabIndex = 110;
            this.lblTotalBillValue.Text = "Total Bill Value";
            // 
            // txtTotalPayble
            // 
            this.txtTotalPayble.Enabled = false;
            this.txtTotalPayble.Location = new System.Drawing.Point(575, 218);
            this.txtTotalPayble.Name = "txtTotalPayble";
            this.txtTotalPayble.Size = new System.Drawing.Size(150, 20);
            this.txtTotalPayble.TabIndex = 115;
            // 
            // lblTotalPayable
            // 
            this.lblTotalPayable.AutoSize = true;
            this.lblTotalPayable.Location = new System.Drawing.Point(496, 221);
            this.lblTotalPayable.Name = "lblTotalPayable";
            this.lblTotalPayable.Size = new System.Drawing.Size(72, 13);
            this.lblTotalPayable.TabIndex = 114;
            this.lblTotalPayable.Text = "Total Payable";
            // 
            // frmRentInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(742, 350);
            this.Controls.Add(this.txtTotalPayble);
            this.Controls.Add(this.lblTotalPayable);
            this.Controls.Add(this.txtAdvancePay);
            this.Controls.Add(this.lblAdavcePay);
            this.Controls.Add(this.txtTotalBillValue);
            this.Controls.Add(this.lblTotalBillValue);
            this.Controls.Add(this.btnSavAndPrint);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblRntInvoice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRentInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRentInvoice";
            this.Load += new System.EventHandler(this.frmRentInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblRntInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label libAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnSavAndPrint;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label lblIssuedUser;
        private System.Windows.Forms.TextBox txtIssuedUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAdvancePay;
        private System.Windows.Forms.Label lblAdavcePay;
        private System.Windows.Forms.TextBox txtTotalBillValue;
        private System.Windows.Forms.Label lblTotalBillValue;
        private System.Windows.Forms.TextBox txtTotalPayble;
        private System.Windows.Forms.Label lblTotalPayable;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
    }
}