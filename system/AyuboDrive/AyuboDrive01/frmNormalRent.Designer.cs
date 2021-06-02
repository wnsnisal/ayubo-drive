namespace AyuboDrive01
{
    partial class frmNormalRent
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
            this.lblRent = new System.Windows.Forms.Label();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.rdoWithDriver = new System.Windows.Forms.RadioButton();
            this.rdoWithoutDriver = new System.Windows.Forms.RadioButton();
            this.lblDriver = new System.Windows.Forms.Label();
            this.grbRentDatials = new System.Windows.Forms.GroupBox();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtIssuedUser = new System.Windows.Forms.TextBox();
            this.lblIssuedUser = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.libVehicleNo = new System.Windows.Forms.ListBox();
            this.txtAdvancePayment = new System.Windows.Forms.TextBox();
            this.lblAdvacePayment = new System.Windows.Forms.Label();
            this.btnClaculateTotal = new System.Windows.Forms.Button();
            this.txtTotalRentValue = new System.Windows.Forms.TextBox();
            this.lblTotalRentValue = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnSaveDraftandPrintReceipt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbCustomerDatials = new System.Windows.Forms.GroupBox();
            this.txtInvoiceType = new System.Windows.Forms.TextBox();
            this.lblInvoiceType = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtTPNumber = new System.Windows.Forms.TextBox();
            this.lblTpNumber = new System.Windows.Forms.Label();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblRiceptNo = new System.Windows.Forms.Label();
            this.txtReceptNo = new System.Windows.Forms.TextBox();
            this.grbRentDatials.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbCustomerDatials.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.BackColor = System.Drawing.Color.Transparent;
            this.lblRent.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.ForeColor = System.Drawing.Color.White;
            this.lblRent.Location = new System.Drawing.Point(300, 9);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(50, 21);
            this.lblRent.TabIndex = 0;
            this.lblRent.Text = "Rent";
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.BackColor = System.Drawing.Color.Silver;
            this.lblVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVehicleNo.Location = new System.Drawing.Point(10, 16);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(69, 13);
            this.lblVehicleNo.TabIndex = 1;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Silver;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStartDate.Location = new System.Drawing.Point(10, 100);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(65, 13);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Silver;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEndDate.Location = new System.Drawing.Point(285, 100);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(60, 13);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date";
            // 
            // rdoWithDriver
            // 
            this.rdoWithDriver.AutoSize = true;
            this.rdoWithDriver.BackColor = System.Drawing.Color.Silver;
            this.rdoWithDriver.Checked = true;
            this.rdoWithDriver.Enabled = false;
            this.rdoWithDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWithDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoWithDriver.Location = new System.Drawing.Point(127, 127);
            this.rdoWithDriver.Name = "rdoWithDriver";
            this.rdoWithDriver.Size = new System.Drawing.Size(89, 17);
            this.rdoWithDriver.TabIndex = 10;
            this.rdoWithDriver.TabStop = true;
            this.rdoWithDriver.Text = "With Driver";
            this.rdoWithDriver.UseVisualStyleBackColor = false;
            this.rdoWithDriver.CheckedChanged += new System.EventHandler(this.rdoWithDriver_CheckedChanged);
            // 
            // rdoWithoutDriver
            // 
            this.rdoWithoutDriver.AutoSize = true;
            this.rdoWithoutDriver.BackColor = System.Drawing.Color.Silver;
            this.rdoWithoutDriver.Enabled = false;
            this.rdoWithoutDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWithoutDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoWithoutDriver.Location = new System.Drawing.Point(241, 127);
            this.rdoWithoutDriver.Name = "rdoWithoutDriver";
            this.rdoWithoutDriver.Size = new System.Drawing.Size(107, 17);
            this.rdoWithoutDriver.TabIndex = 12;
            this.rdoWithoutDriver.TabStop = true;
            this.rdoWithoutDriver.Text = "Without Driver";
            this.rdoWithoutDriver.UseVisualStyleBackColor = false;
            this.rdoWithoutDriver.CheckedChanged += new System.EventHandler(this.rdoWithoutDriver_CheckedChanged);
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.BackColor = System.Drawing.Color.Silver;
            this.lblDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDriver.Location = new System.Drawing.Point(11, 131);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(41, 13);
            this.lblDriver.TabIndex = 13;
            this.lblDriver.Text = "Driver";
            // 
            // grbRentDatials
            // 
            this.grbRentDatials.BackColor = System.Drawing.Color.Silver;
            this.grbRentDatials.Controls.Add(this.dtmEndDate);
            this.grbRentDatials.Controls.Add(this.dtmStartDate);
            this.grbRentDatials.Controls.Add(this.txtIssuedUser);
            this.grbRentDatials.Controls.Add(this.lblIssuedUser);
            this.grbRentDatials.Controls.Add(this.txtVehicleNo);
            this.grbRentDatials.Controls.Add(this.libVehicleNo);
            this.grbRentDatials.Controls.Add(this.txtAdvancePayment);
            this.grbRentDatials.Controls.Add(this.lblAdvacePayment);
            this.grbRentDatials.Controls.Add(this.btnClaculateTotal);
            this.grbRentDatials.Controls.Add(this.txtTotalRentValue);
            this.grbRentDatials.Controls.Add(this.lblTotalRentValue);
            this.grbRentDatials.Controls.Add(this.lblVehicleNo);
            this.grbRentDatials.Controls.Add(this.lblDriver);
            this.grbRentDatials.Controls.Add(this.rdoWithoutDriver);
            this.grbRentDatials.Controls.Add(this.rdoWithDriver);
            this.grbRentDatials.Controls.Add(this.lblStartDate);
            this.grbRentDatials.Controls.Add(this.lblEndDate);
            this.grbRentDatials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRentDatials.ForeColor = System.Drawing.Color.Teal;
            this.grbRentDatials.Location = new System.Drawing.Point(12, 233);
            this.grbRentDatials.Name = "grbRentDatials";
            this.grbRentDatials.Size = new System.Drawing.Size(462, 255);
            this.grbRentDatials.TabIndex = 14;
            this.grbRentDatials.TabStop = false;
            this.grbRentDatials.Text = "Rent Datials";
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmEndDate.Location = new System.Drawing.Point(351, 97);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(94, 20);
            this.dtmEndDate.TabIndex = 109;
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmStartDate.Location = new System.Drawing.Point(130, 97);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.Size = new System.Drawing.Size(94, 20);
            this.dtmStartDate.TabIndex = 108;
            // 
            // txtIssuedUser
            // 
            this.txtIssuedUser.Enabled = false;
            this.txtIssuedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedUser.Location = new System.Drawing.Point(127, 54);
            this.txtIssuedUser.Name = "txtIssuedUser";
            this.txtIssuedUser.Size = new System.Drawing.Size(157, 20);
            this.txtIssuedUser.TabIndex = 107;
            // 
            // lblIssuedUser
            // 
            this.lblIssuedUser.AutoSize = true;
            this.lblIssuedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.lblIssuedUser.Location = new System.Drawing.Point(10, 57);
            this.lblIssuedUser.Name = "lblIssuedUser";
            this.lblIssuedUser.Size = new System.Drawing.Size(74, 13);
            this.lblIssuedUser.TabIndex = 106;
            this.lblIssuedUser.Text = "Issued User";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Enabled = false;
            this.txtVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Location = new System.Drawing.Point(127, 13);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(157, 20);
            this.txtVehicleNo.TabIndex = 24;
            this.txtVehicleNo.TextChanged += new System.EventHandler(this.txtVehicleNo_TextChanged);
            // 
            // libVehicleNo
            // 
            this.libVehicleNo.Enabled = false;
            this.libVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libVehicleNo.FormattingEnabled = true;
            this.libVehicleNo.Location = new System.Drawing.Point(291, 13);
            this.libVehicleNo.Name = "libVehicleNo";
            this.libVehicleNo.Size = new System.Drawing.Size(154, 82);
            this.libVehicleNo.TabIndex = 23;
            this.libVehicleNo.SelectedIndexChanged += new System.EventHandler(this.libVehicleNo_SelectedIndexChanged);
            // 
            // txtAdvancePayment
            // 
            this.txtAdvancePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvancePayment.Location = new System.Drawing.Point(130, 220);
            this.txtAdvancePayment.Name = "txtAdvancePayment";
            this.txtAdvancePayment.Size = new System.Drawing.Size(317, 20);
            this.txtAdvancePayment.TabIndex = 22;
            // 
            // lblAdvacePayment
            // 
            this.lblAdvacePayment.AutoSize = true;
            this.lblAdvacePayment.BackColor = System.Drawing.Color.Silver;
            this.lblAdvacePayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAdvacePayment.Location = new System.Drawing.Point(12, 223);
            this.lblAdvacePayment.Name = "lblAdvacePayment";
            this.lblAdvacePayment.Size = new System.Drawing.Size(109, 13);
            this.lblAdvacePayment.TabIndex = 21;
            this.lblAdvacePayment.Text = "Advance Payment";
            // 
            // btnClaculateTotal
            // 
            this.btnClaculateTotal.BackColor = System.Drawing.Color.Lime;
            this.btnClaculateTotal.FlatAppearance.BorderSize = 0;
            this.btnClaculateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClaculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaculateTotal.ForeColor = System.Drawing.Color.Black;
            this.btnClaculateTotal.Location = new System.Drawing.Point(208, 150);
            this.btnClaculateTotal.Name = "btnClaculateTotal";
            this.btnClaculateTotal.Size = new System.Drawing.Size(159, 35);
            this.btnClaculateTotal.TabIndex = 19;
            this.btnClaculateTotal.Text = "Calculate Total";
            this.btnClaculateTotal.UseVisualStyleBackColor = false;
            this.btnClaculateTotal.Click += new System.EventHandler(this.btnClaculateTotal_Click);
            // 
            // txtTotalRentValue
            // 
            this.txtTotalRentValue.Enabled = false;
            this.txtTotalRentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRentValue.Location = new System.Drawing.Point(130, 193);
            this.txtTotalRentValue.Name = "txtTotalRentValue";
            this.txtTotalRentValue.Size = new System.Drawing.Size(317, 20);
            this.txtTotalRentValue.TabIndex = 20;
            // 
            // lblTotalRentValue
            // 
            this.lblTotalRentValue.AutoSize = true;
            this.lblTotalRentValue.BackColor = System.Drawing.Color.Silver;
            this.lblTotalRentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalRentValue.Location = new System.Drawing.Point(12, 196);
            this.lblTotalRentValue.Name = "lblTotalRentValue";
            this.lblTotalRentValue.Size = new System.Drawing.Size(103, 13);
            this.lblTotalRentValue.TabIndex = 19;
            this.lblTotalRentValue.Text = "Total Rent Value";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(516, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 33);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "New Bill";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(516, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 33);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.Crimson;
            this.btnPrintBill.FlatAppearance.BorderSize = 0;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.Location = new System.Drawing.Point(516, 143);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(102, 33);
            this.btnPrintBill.TabIndex = 18;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnSaveDraftandPrintReceipt
            // 
            this.btnSaveDraftandPrintReceipt.BackColor = System.Drawing.Color.Gold;
            this.btnSaveDraftandPrintReceipt.Enabled = false;
            this.btnSaveDraftandPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnSaveDraftandPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveDraftandPrintReceipt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDraftandPrintReceipt.ForeColor = System.Drawing.Color.Black;
            this.btnSaveDraftandPrintReceipt.Location = new System.Drawing.Point(516, 280);
            this.btnSaveDraftandPrintReceipt.Name = "btnSaveDraftandPrintReceipt";
            this.btnSaveDraftandPrintReceipt.Size = new System.Drawing.Size(102, 80);
            this.btnSaveDraftandPrintReceipt.TabIndex = 19;
            this.btnSaveDraftandPrintReceipt.Text = "Save Draft and Print Receipt";
            this.btnSaveDraftandPrintReceipt.UseVisualStyleBackColor = false;
            this.btnSaveDraftandPrintReceipt.Click += new System.EventHandler(this.btnSaveDraftandPrintReceipt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblRent);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 38);
            this.panel1.TabIndex = 38;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(615, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 23);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbCustomerDatials
            // 
            this.grbCustomerDatials.BackColor = System.Drawing.Color.Silver;
            this.grbCustomerDatials.Controls.Add(this.txtInvoiceType);
            this.grbCustomerDatials.Controls.Add(this.lblInvoiceType);
            this.grbCustomerDatials.Controls.Add(this.txtInvoiceNo);
            this.grbCustomerDatials.Controls.Add(this.lblInvoiceNo);
            this.grbCustomerDatials.Controls.Add(this.txtAddress);
            this.grbCustomerDatials.Controls.Add(this.lblAddress);
            this.grbCustomerDatials.Controls.Add(this.txtTPNumber);
            this.grbCustomerDatials.Controls.Add(this.lblTpNumber);
            this.grbCustomerDatials.Controls.Add(this.txtCustomerid);
            this.grbCustomerDatials.Controls.Add(this.lblCustomerId);
            this.grbCustomerDatials.Controls.Add(this.txtCustomerName);
            this.grbCustomerDatials.Controls.Add(this.lblCustomerName);
            this.grbCustomerDatials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCustomerDatials.ForeColor = System.Drawing.Color.Teal;
            this.grbCustomerDatials.Location = new System.Drawing.Point(12, 51);
            this.grbCustomerDatials.Name = "grbCustomerDatials";
            this.grbCustomerDatials.Size = new System.Drawing.Size(462, 176);
            this.grbCustomerDatials.TabIndex = 39;
            this.grbCustomerDatials.TabStop = false;
            this.grbCustomerDatials.Text = "Cusromer Datials";
            // 
            // txtInvoiceType
            // 
            this.txtInvoiceType.Enabled = false;
            this.txtInvoiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceType.Location = new System.Drawing.Point(127, 43);
            this.txtInvoiceType.Name = "txtInvoiceType";
            this.txtInvoiceType.Size = new System.Drawing.Size(318, 20);
            this.txtInvoiceType.TabIndex = 27;
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceType.Location = new System.Drawing.Point(35, 46);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(86, 15);
            this.lblInvoiceType.TabIndex = 26;
            this.lblInvoiceType.Text = "Invoice Type";
            this.lblInvoiceType.Click += new System.EventHandler(this.lblInvoiceType_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(127, 17);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(318, 20);
            this.txtInvoiceNo.TabIndex = 25;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(47, 20);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(74, 15);
            this.lblInvoiceNo.TabIndex = 24;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(128, 147);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(317, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddress.Location = new System.Drawing.Point(63, 150);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 15);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            // 
            // txtTPNumber
            // 
            this.txtTPNumber.Enabled = false;
            this.txtTPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPNumber.Location = new System.Drawing.Point(128, 121);
            this.txtTPNumber.Name = "txtTPNumber";
            this.txtTPNumber.Size = new System.Drawing.Size(221, 20);
            this.txtTPNumber.TabIndex = 21;
            // 
            // lblTpNumber
            // 
            this.lblTpNumber.AutoSize = true;
            this.lblTpNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTpNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTpNumber.Location = new System.Drawing.Point(38, 124);
            this.lblTpNumber.Name = "lblTpNumber";
            this.lblTpNumber.Size = new System.Drawing.Size(83, 15);
            this.lblTpNumber.TabIndex = 20;
            this.lblTpNumber.Text = "T.P Number";
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Enabled = false;
            this.txtCustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerid.Location = new System.Drawing.Point(128, 95);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(220, 20);
            this.txtCustomerid.TabIndex = 19;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerId.Location = new System.Drawing.Point(102, 98);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(19, 15);
            this.lblCustomerId.TabIndex = 18;
            this.lblCustomerId.Text = "Id";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(128, 69);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(317, 20);
            this.txtCustomerName.TabIndex = 17;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerName.Location = new System.Drawing.Point(11, 72);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(110, 15);
            this.lblCustomerName.TabIndex = 16;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblRiceptNo
            // 
            this.lblRiceptNo.AutoSize = true;
            this.lblRiceptNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRiceptNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRiceptNo.Location = new System.Drawing.Point(538, 73);
            this.lblRiceptNo.Name = "lblRiceptNo";
            this.lblRiceptNo.Size = new System.Drawing.Size(55, 13);
            this.lblRiceptNo.TabIndex = 26;
            this.lblRiceptNo.Text = "Recipt No";
            // 
            // txtReceptNo
            // 
            this.txtReceptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptNo.Location = new System.Drawing.Point(483, 97);
            this.txtReceptNo.Name = "txtReceptNo";
            this.txtReceptNo.Size = new System.Drawing.Size(157, 20);
            this.txtReceptNo.TabIndex = 40;
            this.txtReceptNo.TextChanged += new System.EventHandler(this.txtReceptNo_TextChanged);
            this.txtReceptNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRiceptNo_KeyDown);
            // 
            // frmNormalRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 496);
            this.Controls.Add(this.txtReceptNo);
            this.Controls.Add(this.lblRiceptNo);
            this.Controls.Add(this.grbCustomerDatials);
            this.Controls.Add(this.btnSaveDraftandPrintReceipt);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbRentDatials);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNormalRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNormalRent";
            this.Load += new System.EventHandler(this.frmNormalRent_Load);
            this.grbRentDatials.ResumeLayout(false);
            this.grbRentDatials.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbCustomerDatials.ResumeLayout(false);
            this.grbCustomerDatials.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.RadioButton rdoWithDriver;
        private System.Windows.Forms.RadioButton rdoWithoutDriver;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.GroupBox grbRentDatials;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnClaculateTotal;
        private System.Windows.Forms.TextBox txtTotalRentValue;
        private System.Windows.Forms.Label lblTotalRentValue;
        private System.Windows.Forms.Button btnSaveDraftandPrintReceipt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbCustomerDatials;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTPNumber;
        private System.Windows.Forms.Label lblTpNumber;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtAdvancePayment;
        private System.Windows.Forms.Label lblAdvacePayment;
        private System.Windows.Forms.ListBox libVehicleNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtIssuedUser;
        private System.Windows.Forms.Label lblIssuedUser;
        private System.Windows.Forms.Label lblRiceptNo;
        private System.Windows.Forms.TextBox txtInvoiceType;
        private System.Windows.Forms.Label lblInvoiceType;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.TextBox txtReceptNo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtmStartDate;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
    }
}