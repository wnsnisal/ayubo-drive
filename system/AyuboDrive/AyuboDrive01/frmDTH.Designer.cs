namespace AyuboDrive01
{
    partial class frmDayTowerHire
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
            this.btnSaveDraftandPrintRecept = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbCustomerDatials = new System.Windows.Forms.GroupBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvoiceType = new System.Windows.Forms.TextBox();
            this.lblInvoiceType = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtTPNumber = new System.Windows.Forms.TextBox();
            this.lblTpNumber = new System.Windows.Forms.Label();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblDayTowerHire = new System.Windows.Forms.Label();
            this.grbRentDatials = new System.Windows.Forms.GroupBox();
            this.dtmEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtmStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.dtmInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.btnClaculateTotal = new System.Windows.Forms.Button();
            this.txtAdvancePayment = new System.Windows.Forms.TextBox();
            this.lblAdvancePayment = new System.Windows.Forms.Label();
            this.txtIssuedUser = new System.Windows.Forms.TextBox();
            this.lblIssuedUser = new System.Windows.Forms.Label();
            this.libVehicleNo = new System.Windows.Forms.ListBox();
            this.txtTotalWeitingChage = new System.Windows.Forms.TextBox();
            this.lblTotalWeightingChage = new System.Windows.Forms.Label();
            this.txtTotalExtraKmChage = new System.Windows.Forms.TextBox();
            this.lblTotalExtraKmChage = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.txtEndKm = new System.Windows.Forms.TextBox();
            this.lblStartKm = new System.Windows.Forms.Label();
            this.txtStartKm = new System.Windows.Forms.TextBox();
            this.lblEndKm = new System.Windows.Forms.Label();
            this.txtTotalDTHValue = new System.Windows.Forms.TextBox();
            this.lblTotalDTHValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRiceptNo = new System.Windows.Forms.Label();
            this.txtRiceptNo = new System.Windows.Forms.TextBox();
            this.grbCustomerDatials.SuspendLayout();
            this.grbRentDatials.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveDraftandPrintRecept
            // 
            this.btnSaveDraftandPrintRecept.BackColor = System.Drawing.Color.Gold;
            this.btnSaveDraftandPrintRecept.FlatAppearance.BorderSize = 0;
            this.btnSaveDraftandPrintRecept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveDraftandPrintRecept.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDraftandPrintRecept.ForeColor = System.Drawing.Color.Black;
            this.btnSaveDraftandPrintRecept.Location = new System.Drawing.Point(517, 278);
            this.btnSaveDraftandPrintRecept.Name = "btnSaveDraftandPrintRecept";
            this.btnSaveDraftandPrintRecept.Size = new System.Drawing.Size(102, 75);
            this.btnSaveDraftandPrintRecept.TabIndex = 36;
            this.btnSaveDraftandPrintRecept.Text = "Save Draft and Print Recipt";
            this.btnSaveDraftandPrintRecept.UseVisualStyleBackColor = false;
            this.btnSaveDraftandPrintRecept.Click += new System.EventHandler(this.btnSaveDraftandPrintRecept_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.Crimson;
            this.btnPrintBill.FlatAppearance.BorderSize = 0;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.Location = new System.Drawing.Point(517, 142);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(102, 35);
            this.btnPrintBill.TabIndex = 35;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(517, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 35);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(517, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 35);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "New BIll";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grbCustomerDatials
            // 
            this.grbCustomerDatials.BackColor = System.Drawing.Color.Silver;
            this.grbCustomerDatials.Controls.Add(this.txtInvoiceNo);
            this.grbCustomerDatials.Controls.Add(this.lblInvoiceNo);
            this.grbCustomerDatials.Controls.Add(this.txtInvoiceType);
            this.grbCustomerDatials.Controls.Add(this.lblInvoiceType);
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
            this.grbCustomerDatials.Location = new System.Drawing.Point(23, 47);
            this.grbCustomerDatials.Name = "grbCustomerDatials";
            this.grbCustomerDatials.Size = new System.Drawing.Size(463, 175);
            this.grbCustomerDatials.TabIndex = 32;
            this.grbCustomerDatials.TabStop = false;
            this.grbCustomerDatials.Text = "Cusromer Datials";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(126, 15);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(317, 20);
            this.txtInvoiceNo.TabIndex = 31;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(46, 18);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(74, 15);
            this.lblInvoiceNo.TabIndex = 30;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // txtInvoiceType
            // 
            this.txtInvoiceType.Enabled = false;
            this.txtInvoiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceType.Location = new System.Drawing.Point(126, 67);
            this.txtInvoiceType.Name = "txtInvoiceType";
            this.txtInvoiceType.Size = new System.Drawing.Size(318, 20);
            this.txtInvoiceType.TabIndex = 29;
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceType.Location = new System.Drawing.Point(34, 70);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(86, 15);
            this.lblInvoiceType.TabIndex = 28;
            this.lblInvoiceType.Text = "Invoice Type";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(126, 145);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(317, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddress.Location = new System.Drawing.Point(62, 148);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 15);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            // 
            // txtTPNumber
            // 
            this.txtTPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPNumber.Location = new System.Drawing.Point(126, 119);
            this.txtTPNumber.Name = "txtTPNumber";
            this.txtTPNumber.Size = new System.Drawing.Size(221, 20);
            this.txtTPNumber.TabIndex = 21;
            // 
            // lblTpNumber
            // 
            this.lblTpNumber.AutoSize = true;
            this.lblTpNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTpNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTpNumber.Location = new System.Drawing.Point(37, 122);
            this.lblTpNumber.Name = "lblTpNumber";
            this.lblTpNumber.Size = new System.Drawing.Size(83, 15);
            this.lblTpNumber.TabIndex = 20;
            this.lblTpNumber.Text = "T.P Number";
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerid.Location = new System.Drawing.Point(126, 93);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(220, 20);
            this.txtCustomerid.TabIndex = 19;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerId.Location = new System.Drawing.Point(101, 96);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(19, 15);
            this.lblCustomerId.TabIndex = 18;
            this.lblCustomerId.Text = "Id";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(126, 41);
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
            this.lblCustomerName.Location = new System.Drawing.Point(10, 44);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(110, 15);
            this.lblCustomerName.TabIndex = 16;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEndTime.Location = new System.Drawing.Point(266, 101);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(60, 13);
            this.lblEndTime.TabIndex = 25;
            this.lblEndTime.Text = "End Time";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStartTime.Location = new System.Drawing.Point(54, 101);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(65, 13);
            this.lblStartTime.TabIndex = 23;
            this.lblStartTime.Text = "Start Time";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Location = new System.Drawing.Point(127, 16);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(152, 20);
            this.txtVehicleNo.TabIndex = 22;
            this.txtVehicleNo.TextChanged += new System.EventHandler(this.txtVehicleNo_TextChanged);
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVehicleNo.Location = new System.Drawing.Point(50, 19);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(69, 13);
            this.lblVehicleNo.TabIndex = 21;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // lblDayTowerHire
            // 
            this.lblDayTowerHire.AutoSize = true;
            this.lblDayTowerHire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.lblDayTowerHire.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayTowerHire.ForeColor = System.Drawing.Color.White;
            this.lblDayTowerHire.Location = new System.Drawing.Point(235, 9);
            this.lblDayTowerHire.Name = "lblDayTowerHire";
            this.lblDayTowerHire.Size = new System.Drawing.Size(150, 21);
            this.lblDayTowerHire.TabIndex = 20;
            this.lblDayTowerHire.Text = "Day Tower Hire";
            // 
            // grbRentDatials
            // 
            this.grbRentDatials.BackColor = System.Drawing.Color.Silver;
            this.grbRentDatials.Controls.Add(this.dtmEndTime);
            this.grbRentDatials.Controls.Add(this.dtmStartTime);
            this.grbRentDatials.Controls.Add(this.lblInvoiceDate);
            this.grbRentDatials.Controls.Add(this.dtmInvoiceDate);
            this.grbRentDatials.Controls.Add(this.btnClaculateTotal);
            this.grbRentDatials.Controls.Add(this.txtAdvancePayment);
            this.grbRentDatials.Controls.Add(this.lblAdvancePayment);
            this.grbRentDatials.Controls.Add(this.txtIssuedUser);
            this.grbRentDatials.Controls.Add(this.lblIssuedUser);
            this.grbRentDatials.Controls.Add(this.libVehicleNo);
            this.grbRentDatials.Controls.Add(this.txtTotalWeitingChage);
            this.grbRentDatials.Controls.Add(this.lblTotalWeightingChage);
            this.grbRentDatials.Controls.Add(this.txtTotalExtraKmChage);
            this.grbRentDatials.Controls.Add(this.lblTotalExtraKmChage);
            this.grbRentDatials.Controls.Add(this.lblPackage);
            this.grbRentDatials.Controls.Add(this.cmbPackage);
            this.grbRentDatials.Controls.Add(this.txtEndKm);
            this.grbRentDatials.Controls.Add(this.lblStartKm);
            this.grbRentDatials.Controls.Add(this.txtStartKm);
            this.grbRentDatials.Controls.Add(this.lblEndKm);
            this.grbRentDatials.Controls.Add(this.txtTotalDTHValue);
            this.grbRentDatials.Controls.Add(this.lblTotalDTHValue);
            this.grbRentDatials.Controls.Add(this.txtVehicleNo);
            this.grbRentDatials.Controls.Add(this.lblVehicleNo);
            this.grbRentDatials.Controls.Add(this.lblStartTime);
            this.grbRentDatials.Controls.Add(this.lblEndTime);
            this.grbRentDatials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRentDatials.ForeColor = System.Drawing.Color.Teal;
            this.grbRentDatials.Location = new System.Drawing.Point(23, 230);
            this.grbRentDatials.Name = "grbRentDatials";
            this.grbRentDatials.Size = new System.Drawing.Size(463, 339);
            this.grbRentDatials.TabIndex = 31;
            this.grbRentDatials.TabStop = false;
            this.grbRentDatials.Text = "Rent Datials";
            // 
            // dtmEndTime
            // 
            this.dtmEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmEndTime.Location = new System.Drawing.Point(332, 95);
            this.dtmEndTime.Name = "dtmEndTime";
            this.dtmEndTime.Size = new System.Drawing.Size(111, 20);
            this.dtmEndTime.TabIndex = 46;
            // 
            // dtmStartTime
            // 
            this.dtmStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmStartTime.Location = new System.Drawing.Point(126, 95);
            this.dtmStartTime.Name = "dtmStartTime";
            this.dtmStartTime.Size = new System.Drawing.Size(110, 20);
            this.dtmStartTime.TabIndex = 45;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceDate.Location = new System.Drawing.Point(38, 46);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(80, 13);
            this.lblInvoiceDate.TabIndex = 44;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // dtmInvoiceDate
            // 
            this.dtmInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmInvoiceDate.Location = new System.Drawing.Point(127, 40);
            this.dtmInvoiceDate.Name = "dtmInvoiceDate";
            this.dtmInvoiceDate.Size = new System.Drawing.Size(152, 20);
            this.dtmInvoiceDate.TabIndex = 40;
            // 
            // btnClaculateTotal
            // 
            this.btnClaculateTotal.BackColor = System.Drawing.Color.Lime;
            this.btnClaculateTotal.FlatAppearance.BorderSize = 0;
            this.btnClaculateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClaculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaculateTotal.ForeColor = System.Drawing.Color.Black;
            this.btnClaculateTotal.Location = new System.Drawing.Point(216, 180);
            this.btnClaculateTotal.Name = "btnClaculateTotal";
            this.btnClaculateTotal.Size = new System.Drawing.Size(159, 33);
            this.btnClaculateTotal.TabIndex = 43;
            this.btnClaculateTotal.Text = "Calculate Total";
            this.btnClaculateTotal.UseVisualStyleBackColor = false;
            this.btnClaculateTotal.Click += new System.EventHandler(this.btnClaculateTotal_Click);
            // 
            // txtAdvancePayment
            // 
            this.txtAdvancePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvancePayment.Location = new System.Drawing.Point(152, 300);
            this.txtAdvancePayment.Name = "txtAdvancePayment";
            this.txtAdvancePayment.Size = new System.Drawing.Size(291, 20);
            this.txtAdvancePayment.TabIndex = 42;
            // 
            // lblAdvancePayment
            // 
            this.lblAdvancePayment.AutoSize = true;
            this.lblAdvancePayment.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvancePayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAdvancePayment.Location = new System.Drawing.Point(38, 303);
            this.lblAdvancePayment.Name = "lblAdvancePayment";
            this.lblAdvancePayment.Size = new System.Drawing.Size(109, 13);
            this.lblAdvancePayment.TabIndex = 41;
            this.lblAdvancePayment.Text = "Advance Payment";
            // 
            // txtIssuedUser
            // 
            this.txtIssuedUser.Enabled = false;
            this.txtIssuedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedUser.Location = new System.Drawing.Point(127, 65);
            this.txtIssuedUser.Name = "txtIssuedUser";
            this.txtIssuedUser.Size = new System.Drawing.Size(152, 20);
            this.txtIssuedUser.TabIndex = 40;
            // 
            // lblIssuedUser
            // 
            this.lblIssuedUser.AutoSize = true;
            this.lblIssuedUser.BackColor = System.Drawing.Color.Transparent;
            this.lblIssuedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIssuedUser.Location = new System.Drawing.Point(45, 68);
            this.lblIssuedUser.Name = "lblIssuedUser";
            this.lblIssuedUser.Size = new System.Drawing.Size(74, 13);
            this.lblIssuedUser.TabIndex = 39;
            this.lblIssuedUser.Text = "Issued User";
            // 
            // libVehicleNo
            // 
            this.libVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libVehicleNo.FormattingEnabled = true;
            this.libVehicleNo.Location = new System.Drawing.Point(285, 16);
            this.libVehicleNo.Name = "libVehicleNo";
            this.libVehicleNo.Size = new System.Drawing.Size(158, 69);
            this.libVehicleNo.TabIndex = 38;
            this.libVehicleNo.SelectedIndexChanged += new System.EventHandler(this.libVehicleNo_SelectedIndexChanged);
            // 
            // txtTotalWeitingChage
            // 
            this.txtTotalWeitingChage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalWeitingChage.Location = new System.Drawing.Point(153, 248);
            this.txtTotalWeitingChage.Name = "txtTotalWeitingChage";
            this.txtTotalWeitingChage.Size = new System.Drawing.Size(292, 20);
            this.txtTotalWeitingChage.TabIndex = 38;
            // 
            // lblTotalWeightingChage
            // 
            this.lblTotalWeightingChage.AutoSize = true;
            this.lblTotalWeightingChage.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWeightingChage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalWeightingChage.Location = new System.Drawing.Point(10, 251);
            this.lblTotalWeightingChage.Name = "lblTotalWeightingChage";
            this.lblTotalWeightingChage.Size = new System.Drawing.Size(137, 13);
            this.lblTotalWeightingChage.TabIndex = 37;
            this.lblTotalWeightingChage.Text = "Total Weighting Chage";
            // 
            // txtTotalExtraKmChage
            // 
            this.txtTotalExtraKmChage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalExtraKmChage.Location = new System.Drawing.Point(153, 222);
            this.txtTotalExtraKmChage.Name = "txtTotalExtraKmChage";
            this.txtTotalExtraKmChage.Size = new System.Drawing.Size(292, 20);
            this.txtTotalExtraKmChage.TabIndex = 36;
            // 
            // lblTotalExtraKmChage
            // 
            this.lblTotalExtraKmChage.AutoSize = true;
            this.lblTotalExtraKmChage.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExtraKmChage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalExtraKmChage.Location = new System.Drawing.Point(17, 224);
            this.lblTotalExtraKmChage.Name = "lblTotalExtraKmChage";
            this.lblTotalExtraKmChage.Size = new System.Drawing.Size(130, 13);
            this.lblTotalExtraKmChage.TabIndex = 35;
            this.lblTotalExtraKmChage.Text = "Total Extra Km Chage";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.BackColor = System.Drawing.Color.Transparent;
            this.lblPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPackage.Location = new System.Drawing.Point(62, 153);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(57, 13);
            this.lblPackage.TabIndex = 34;
            this.lblPackage.Text = "Package";
            // 
            // cmbPackage
            // 
            this.cmbPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Items.AddRange(new object[] {
            "Package01(100Km)",
            "Package02(200Km)"});
            this.cmbPackage.Location = new System.Drawing.Point(127, 150);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(186, 21);
            this.cmbPackage.TabIndex = 33;
            // 
            // txtEndKm
            // 
            this.txtEndKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndKm.Location = new System.Drawing.Point(343, 124);
            this.txtEndKm.Name = "txtEndKm";
            this.txtEndKm.Size = new System.Drawing.Size(101, 20);
            this.txtEndKm.TabIndex = 32;
            // 
            // lblStartKm
            // 
            this.lblStartKm.AutoSize = true;
            this.lblStartKm.BackColor = System.Drawing.Color.Transparent;
            this.lblStartKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStartKm.Location = new System.Drawing.Point(64, 127);
            this.lblStartKm.Name = "lblStartKm";
            this.lblStartKm.Size = new System.Drawing.Size(55, 13);
            this.lblStartKm.TabIndex = 29;
            this.lblStartKm.Text = "Start Km";
            // 
            // txtStartKm
            // 
            this.txtStartKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartKm.Location = new System.Drawing.Point(127, 124);
            this.txtStartKm.Name = "txtStartKm";
            this.txtStartKm.Size = new System.Drawing.Size(109, 20);
            this.txtStartKm.TabIndex = 30;
            // 
            // lblEndKm
            // 
            this.lblEndKm.AutoSize = true;
            this.lblEndKm.BackColor = System.Drawing.Color.Transparent;
            this.lblEndKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEndKm.Location = new System.Drawing.Point(287, 127);
            this.lblEndKm.Name = "lblEndKm";
            this.lblEndKm.Size = new System.Drawing.Size(50, 13);
            this.lblEndKm.TabIndex = 31;
            this.lblEndKm.Text = "End Km";
            // 
            // txtTotalDTHValue
            // 
            this.txtTotalDTHValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDTHValue.Location = new System.Drawing.Point(152, 274);
            this.txtTotalDTHValue.Name = "txtTotalDTHValue";
            this.txtTotalDTHValue.Size = new System.Drawing.Size(291, 20);
            this.txtTotalDTHValue.TabIndex = 20;
            // 
            // lblTotalDTHValue
            // 
            this.lblTotalDTHValue.AutoSize = true;
            this.lblTotalDTHValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDTHValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalDTHValue.Location = new System.Drawing.Point(44, 277);
            this.lblTotalDTHValue.Name = "lblTotalDTHValue";
            this.lblTotalDTHValue.Size = new System.Drawing.Size(99, 13);
            this.lblTotalDTHValue.TabIndex = 19;
            this.lblTotalDTHValue.Text = "Total Hire Value";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblDayTowerHire);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 38);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(611, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRiceptNo
            // 
            this.lblRiceptNo.AutoSize = true;
            this.lblRiceptNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRiceptNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRiceptNo.Location = new System.Drawing.Point(538, 76);
            this.lblRiceptNo.Name = "lblRiceptNo";
            this.lblRiceptNo.Size = new System.Drawing.Size(55, 13);
            this.lblRiceptNo.TabIndex = 38;
            this.lblRiceptNo.Text = "Recipt No";
            // 
            // txtRiceptNo
            // 
            this.txtRiceptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiceptNo.Location = new System.Drawing.Point(492, 100);
            this.txtRiceptNo.Name = "txtRiceptNo";
            this.txtRiceptNo.Size = new System.Drawing.Size(148, 20);
            this.txtRiceptNo.TabIndex = 39;
            this.txtRiceptNo.TextChanged += new System.EventHandler(this.txtRiceptNo_KeyDown);
            this.txtRiceptNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRiceptNo_KeyDown);
            // 
            // frmDayTowerHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 581);
            this.ControlBox = false;
            this.Controls.Add(this.lblRiceptNo);
            this.Controls.Add(this.txtRiceptNo);
            this.Controls.Add(this.btnSaveDraftandPrintRecept);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbCustomerDatials);
            this.Controls.Add(this.grbRentDatials);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDayTowerHire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDTH";
            this.Load += new System.EventHandler(this.frmDayTowerHire_Load);
            this.grbCustomerDatials.ResumeLayout(false);
            this.grbCustomerDatials.PerformLayout();
            this.grbRentDatials.ResumeLayout(false);
            this.grbRentDatials.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDraftandPrintRecept;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grbCustomerDatials;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTPNumber;
        private System.Windows.Forms.Label lblTpNumber;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblDayTowerHire;
        private System.Windows.Forms.GroupBox grbRentDatials;
        private System.Windows.Forms.TextBox txtTotalDTHValue;
        private System.Windows.Forms.Label lblTotalDTHValue;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.TextBox txtEndKm;
        private System.Windows.Forms.Label lblStartKm;
        private System.Windows.Forms.TextBox txtStartKm;
        private System.Windows.Forms.Label lblEndKm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalWeitingChage;
        private System.Windows.Forms.Label lblTotalWeightingChage;
        private System.Windows.Forms.TextBox txtTotalExtraKmChage;
        private System.Windows.Forms.Label lblTotalExtraKmChage;
        private System.Windows.Forms.TextBox txtIssuedUser;
        private System.Windows.Forms.Label lblIssuedUser;
        private System.Windows.Forms.ListBox libVehicleNo;
        private System.Windows.Forms.Button btnClaculateTotal;
        private System.Windows.Forms.TextBox txtAdvancePayment;
        private System.Windows.Forms.Label lblAdvancePayment;
        private System.Windows.Forms.Label lblRiceptNo;
        private System.Windows.Forms.TextBox txtRiceptNo;
        private System.Windows.Forms.TextBox txtInvoiceType;
        private System.Windows.Forms.Label lblInvoiceType;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtmInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtmEndTime;
        private System.Windows.Forms.DateTimePicker dtmStartTime;
    }
}