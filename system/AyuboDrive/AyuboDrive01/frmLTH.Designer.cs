namespace AyuboDrive01
{
    partial class frmLTH
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
            this.txtReceptNo = new System.Windows.Forms.TextBox();
            this.lblRiceptNo = new System.Windows.Forms.Label();
            this.btnSaveDraftandPrintRecept = new System.Windows.Forms.Button();
            this.btnPrintBIll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewBill = new System.Windows.Forms.Button();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmStartDate = new System.Windows.Forms.DateTimePicker();
            this.libVehicleNo = new System.Windows.Forms.ListBox();
            this.txtIssuedUser = new System.Windows.Forms.TextBox();
            this.lblIssuedUser = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.grbRentDatials = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtAdvancePayment = new System.Windows.Forms.TextBox();
            this.lblAdvacePayment = new System.Windows.Forms.Label();
            this.txtOverNightChage = new System.Windows.Forms.TextBox();
            this.lblOverNightParkChage = new System.Windows.Forms.Label();
            this.txtTotalExtraKmChage = new System.Windows.Forms.TextBox();
            this.lblTotalExtraKmChage = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.txtEndKm = new System.Windows.Forms.TextBox();
            this.lblStartKm = new System.Windows.Forms.Label();
            this.txtStartKm = new System.Windows.Forms.TextBox();
            this.lblEndKm = new System.Windows.Forms.Label();
            this.btnClaculateTotal = new System.Windows.Forms.Button();
            this.txtLongTourHireValue = new System.Windows.Forms.TextBox();
            this.LongTourHireValue = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblLongTourHire = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVehicleNightParkChage = new System.Windows.Forms.TextBox();
            this.lblVehicleNightParkChage = new System.Windows.Forms.Label();
            this.grbRentDatials.SuspendLayout();
            this.grbCustomerDatials.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReceptNo
            // 
            this.txtReceptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceptNo.Location = new System.Drawing.Point(499, 102);
            this.txtReceptNo.Name = "txtReceptNo";
            this.txtReceptNo.Size = new System.Drawing.Size(157, 20);
            this.txtReceptNo.TabIndex = 56;
            this.txtReceptNo.TextChanged += new System.EventHandler(this.txtReceptNo_TextChanged);
            this.txtReceptNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceptNo_KeyDown);
            // 
            // lblRiceptNo
            // 
            this.lblRiceptNo.AutoSize = true;
            this.lblRiceptNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRiceptNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRiceptNo.Location = new System.Drawing.Point(550, 78);
            this.lblRiceptNo.Name = "lblRiceptNo";
            this.lblRiceptNo.Size = new System.Drawing.Size(55, 13);
            this.lblRiceptNo.TabIndex = 55;
            this.lblRiceptNo.Text = "Recipt No";
            // 
            // btnSaveDraftandPrintRecept
            // 
            this.btnSaveDraftandPrintRecept.BackColor = System.Drawing.Color.Gold;
            this.btnSaveDraftandPrintRecept.FlatAppearance.BorderSize = 0;
            this.btnSaveDraftandPrintRecept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveDraftandPrintRecept.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDraftandPrintRecept.ForeColor = System.Drawing.Color.Black;
            this.btnSaveDraftandPrintRecept.Location = new System.Drawing.Point(526, 279);
            this.btnSaveDraftandPrintRecept.Name = "btnSaveDraftandPrintRecept";
            this.btnSaveDraftandPrintRecept.Size = new System.Drawing.Size(102, 75);
            this.btnSaveDraftandPrintRecept.TabIndex = 54;
            this.btnSaveDraftandPrintRecept.Text = "Save Draft and Print Recipt";
            this.btnSaveDraftandPrintRecept.UseVisualStyleBackColor = false;
            this.btnSaveDraftandPrintRecept.Click += new System.EventHandler(this.btnSaveDraftandPrintRecept_Click);
            // 
            // btnPrintBIll
            // 
            this.btnPrintBIll.BackColor = System.Drawing.Color.Crimson;
            this.btnPrintBIll.FlatAppearance.BorderSize = 0;
            this.btnPrintBIll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintBIll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBIll.ForeColor = System.Drawing.Color.White;
            this.btnPrintBIll.Location = new System.Drawing.Point(526, 143);
            this.btnPrintBIll.Name = "btnPrintBIll";
            this.btnPrintBIll.Size = new System.Drawing.Size(102, 35);
            this.btnPrintBIll.TabIndex = 53;
            this.btnPrintBIll.Text = "Print Bill";
            this.btnPrintBIll.UseVisualStyleBackColor = false;
            this.btnPrintBIll.Click += new System.EventHandler(this.btnPrintBIll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(526, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 35);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewBill
            // 
            this.btnNewBill.BackColor = System.Drawing.Color.Crimson;
            this.btnNewBill.FlatAppearance.BorderSize = 0;
            this.btnNewBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBill.ForeColor = System.Drawing.Color.White;
            this.btnNewBill.Location = new System.Drawing.Point(526, 188);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(102, 35);
            this.btnNewBill.TabIndex = 51;
            this.btnNewBill.Text = "New Bill";
            this.btnNewBill.UseVisualStyleBackColor = false;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmEndDate.Location = new System.Drawing.Point(348, 76);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(94, 20);
            this.dtmEndDate.TabIndex = 55;
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.Enabled = false;
            this.dtmStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmStartDate.Location = new System.Drawing.Point(126, 76);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.Size = new System.Drawing.Size(92, 20);
            this.dtmStartDate.TabIndex = 54;
            // 
            // libVehicleNo
            // 
            this.libVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libVehicleNo.FormattingEnabled = true;
            this.libVehicleNo.Location = new System.Drawing.Point(297, 14);
            this.libVehicleNo.Name = "libVehicleNo";
            this.libVehicleNo.Size = new System.Drawing.Size(146, 56);
            this.libVehicleNo.TabIndex = 48;
            this.libVehicleNo.SelectedIndexChanged += new System.EventHandler(this.libVehicleNo_SelectedIndexChanged);
            // 
            // txtIssuedUser
            // 
            this.txtIssuedUser.Enabled = false;
            this.txtIssuedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssuedUser.Location = new System.Drawing.Point(126, 128);
            this.txtIssuedUser.Name = "txtIssuedUser";
            this.txtIssuedUser.Size = new System.Drawing.Size(152, 20);
            this.txtIssuedUser.TabIndex = 49;
            // 
            // lblIssuedUser
            // 
            this.lblIssuedUser.AutoSize = true;
            this.lblIssuedUser.BackColor = System.Drawing.Color.Transparent;
            this.lblIssuedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIssuedUser.Location = new System.Drawing.Point(44, 131);
            this.lblIssuedUser.Name = "lblIssuedUser";
            this.lblIssuedUser.Size = new System.Drawing.Size(74, 13);
            this.lblIssuedUser.TabIndex = 48;
            this.lblIssuedUser.Text = "Issued User";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStartDate.Location = new System.Drawing.Point(56, 79);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(65, 13);
            this.lblStartDate.TabIndex = 50;
            this.lblStartDate.Text = "Start Date";
            // 
            // grbRentDatials
            // 
            this.grbRentDatials.BackColor = System.Drawing.Color.Silver;
            this.grbRentDatials.Controls.Add(this.txtVehicleNightParkChage);
            this.grbRentDatials.Controls.Add(this.lblVehicleNightParkChage);
            this.grbRentDatials.Controls.Add(this.dtmEndDate);
            this.grbRentDatials.Controls.Add(this.dtmStartDate);
            this.grbRentDatials.Controls.Add(this.libVehicleNo);
            this.grbRentDatials.Controls.Add(this.txtIssuedUser);
            this.grbRentDatials.Controls.Add(this.lblIssuedUser);
            this.grbRentDatials.Controls.Add(this.lblStartDate);
            this.grbRentDatials.Controls.Add(this.lblEndDate);
            this.grbRentDatials.Controls.Add(this.txtAdvancePayment);
            this.grbRentDatials.Controls.Add(this.lblAdvacePayment);
            this.grbRentDatials.Controls.Add(this.txtOverNightChage);
            this.grbRentDatials.Controls.Add(this.lblOverNightParkChage);
            this.grbRentDatials.Controls.Add(this.txtTotalExtraKmChage);
            this.grbRentDatials.Controls.Add(this.lblTotalExtraKmChage);
            this.grbRentDatials.Controls.Add(this.lblPackage);
            this.grbRentDatials.Controls.Add(this.cmbPackage);
            this.grbRentDatials.Controls.Add(this.txtEndKm);
            this.grbRentDatials.Controls.Add(this.lblStartKm);
            this.grbRentDatials.Controls.Add(this.txtStartKm);
            this.grbRentDatials.Controls.Add(this.lblEndKm);
            this.grbRentDatials.Controls.Add(this.btnClaculateTotal);
            this.grbRentDatials.Controls.Add(this.txtLongTourHireValue);
            this.grbRentDatials.Controls.Add(this.LongTourHireValue);
            this.grbRentDatials.Controls.Add(this.txtVehicleNo);
            this.grbRentDatials.Controls.Add(this.lblVehicleNo);
            this.grbRentDatials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRentDatials.ForeColor = System.Drawing.Color.Teal;
            this.grbRentDatials.Location = new System.Drawing.Point(21, 236);
            this.grbRentDatials.Name = "grbRentDatials";
            this.grbRentDatials.Size = new System.Drawing.Size(463, 358);
            this.grbRentDatials.TabIndex = 50;
            this.grbRentDatials.TabStop = false;
            this.grbRentDatials.Text = "Rent Datials";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEndDate.Location = new System.Drawing.Point(282, 79);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(60, 13);
            this.lblEndDate.TabIndex = 52;
            this.lblEndDate.Text = "End Date";
            // 
            // txtAdvancePayment
            // 
            this.txtAdvancePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvancePayment.Location = new System.Drawing.Point(190, 321);
            this.txtAdvancePayment.Name = "txtAdvancePayment";
            this.txtAdvancePayment.Size = new System.Drawing.Size(252, 20);
            this.txtAdvancePayment.TabIndex = 49;
            // 
            // lblAdvacePayment
            // 
            this.lblAdvacePayment.AutoSize = true;
            this.lblAdvacePayment.BackColor = System.Drawing.Color.Silver;
            this.lblAdvacePayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAdvacePayment.Location = new System.Drawing.Point(75, 324);
            this.lblAdvacePayment.Name = "lblAdvacePayment";
            this.lblAdvacePayment.Size = new System.Drawing.Size(109, 13);
            this.lblAdvacePayment.TabIndex = 48;
            this.lblAdvacePayment.Text = "Advance Payment";
            // 
            // txtOverNightChage
            // 
            this.txtOverNightChage.Location = new System.Drawing.Point(190, 246);
            this.txtOverNightChage.Name = "txtOverNightChage";
            this.txtOverNightChage.Size = new System.Drawing.Size(252, 20);
            this.txtOverNightChage.TabIndex = 38;
            // 
            // lblOverNightParkChage
            // 
            this.lblOverNightParkChage.AutoSize = true;
            this.lblOverNightParkChage.BackColor = System.Drawing.Color.Transparent;
            this.lblOverNightParkChage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOverNightParkChage.Location = new System.Drawing.Point(76, 249);
            this.lblOverNightParkChage.Name = "lblOverNightParkChage";
            this.lblOverNightParkChage.Size = new System.Drawing.Size(108, 13);
            this.lblOverNightParkChage.TabIndex = 37;
            this.lblOverNightParkChage.Text = "Over Night Chage";
            // 
            // txtTotalExtraKmChage
            // 
            this.txtTotalExtraKmChage.Location = new System.Drawing.Point(190, 221);
            this.txtTotalExtraKmChage.Name = "txtTotalExtraKmChage";
            this.txtTotalExtraKmChage.Size = new System.Drawing.Size(252, 20);
            this.txtTotalExtraKmChage.TabIndex = 36;
            // 
            // lblTotalExtraKmChage
            // 
            this.lblTotalExtraKmChage.AutoSize = true;
            this.lblTotalExtraKmChage.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExtraKmChage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalExtraKmChage.Location = new System.Drawing.Point(54, 224);
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
            this.lblPackage.Location = new System.Drawing.Point(64, 157);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(57, 13);
            this.lblPackage.TabIndex = 34;
            this.lblPackage.Text = "Package";
            // 
            // cmbPackage
            // 
            this.cmbPackage.Enabled = false;
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Items.AddRange(new object[] {
            "Package01(100Km)",
            "Package02(200Km)"});
            this.cmbPackage.Location = new System.Drawing.Point(126, 154);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(198, 21);
            this.cmbPackage.TabIndex = 33;
            // 
            // txtEndKm
            // 
            this.txtEndKm.Location = new System.Drawing.Point(348, 102);
            this.txtEndKm.Name = "txtEndKm";
            this.txtEndKm.Size = new System.Drawing.Size(94, 20);
            this.txtEndKm.TabIndex = 32;
            // 
            // lblStartKm
            // 
            this.lblStartKm.AutoSize = true;
            this.lblStartKm.BackColor = System.Drawing.Color.Transparent;
            this.lblStartKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStartKm.Location = new System.Drawing.Point(66, 105);
            this.lblStartKm.Name = "lblStartKm";
            this.lblStartKm.Size = new System.Drawing.Size(55, 13);
            this.lblStartKm.TabIndex = 29;
            this.lblStartKm.Text = "Start Km";
            // 
            // txtStartKm
            // 
            this.txtStartKm.Location = new System.Drawing.Point(126, 102);
            this.txtStartKm.Name = "txtStartKm";
            this.txtStartKm.Size = new System.Drawing.Size(92, 20);
            this.txtStartKm.TabIndex = 30;
            // 
            // lblEndKm
            // 
            this.lblEndKm.AutoSize = true;
            this.lblEndKm.BackColor = System.Drawing.Color.Transparent;
            this.lblEndKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEndKm.Location = new System.Drawing.Point(292, 105);
            this.lblEndKm.Name = "lblEndKm";
            this.lblEndKm.Size = new System.Drawing.Size(50, 13);
            this.lblEndKm.TabIndex = 31;
            this.lblEndKm.Text = "End Km";
            // 
            // btnClaculateTotal
            // 
            this.btnClaculateTotal.BackColor = System.Drawing.Color.Lime;
            this.btnClaculateTotal.FlatAppearance.BorderSize = 0;
            this.btnClaculateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClaculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaculateTotal.ForeColor = System.Drawing.Color.Black;
            this.btnClaculateTotal.Location = new System.Drawing.Point(151, 181);
            this.btnClaculateTotal.Name = "btnClaculateTotal";
            this.btnClaculateTotal.Size = new System.Drawing.Size(159, 33);
            this.btnClaculateTotal.TabIndex = 19;
            this.btnClaculateTotal.Text = "Calculate Total";
            this.btnClaculateTotal.UseVisualStyleBackColor = false;
            this.btnClaculateTotal.Click += new System.EventHandler(this.btnClaculateTotal_Click);
            // 
            // txtLongTourHireValue
            // 
            this.txtLongTourHireValue.Location = new System.Drawing.Point(190, 296);
            this.txtLongTourHireValue.Name = "txtLongTourHireValue";
            this.txtLongTourHireValue.Size = new System.Drawing.Size(252, 20);
            this.txtLongTourHireValue.TabIndex = 20;
            // 
            // LongTourHireValue
            // 
            this.LongTourHireValue.AutoSize = true;
            this.LongTourHireValue.BackColor = System.Drawing.Color.Transparent;
            this.LongTourHireValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LongTourHireValue.Location = new System.Drawing.Point(23, 299);
            this.LongTourHireValue.Name = "LongTourHireValue";
            this.LongTourHireValue.Size = new System.Drawing.Size(161, 13);
            this.LongTourHireValue.TabIndex = 19;
            this.LongTourHireValue.Text = "Total Long Tour Hire Value";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Enabled = false;
            this.txtVehicleNo.Location = new System.Drawing.Point(126, 14);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(164, 20);
            this.txtVehicleNo.TabIndex = 22;
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVehicleNo.Location = new System.Drawing.Point(52, 17);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(69, 13);
            this.lblVehicleNo.TabIndex = 21;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerName.Location = new System.Drawing.Point(12, 73);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(110, 15);
            this.lblCustomerName.TabIndex = 16;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblLongTourHire
            // 
            this.lblLongTourHire.AutoSize = true;
            this.lblLongTourHire.BackColor = System.Drawing.Color.Transparent;
            this.lblLongTourHire.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongTourHire.ForeColor = System.Drawing.Color.White;
            this.lblLongTourHire.Location = new System.Drawing.Point(254, 7);
            this.lblLongTourHire.Name = "lblLongTourHire";
            this.lblLongTourHire.Size = new System.Drawing.Size(145, 21);
            this.lblLongTourHire.TabIndex = 0;
            this.lblLongTourHire.Text = "Long Tour Hire";
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
            this.grbCustomerDatials.Location = new System.Drawing.Point(21, 47);
            this.grbCustomerDatials.Name = "grbCustomerDatials";
            this.grbCustomerDatials.Size = new System.Drawing.Size(463, 183);
            this.grbCustomerDatials.TabIndex = 49;
            this.grbCustomerDatials.TabStop = false;
            this.grbCustomerDatials.Text = "Cusromer Datials";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(126, 18);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(317, 20);
            this.txtInvoiceNo.TabIndex = 35;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(46, 21);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(74, 15);
            this.lblInvoiceNo.TabIndex = 34;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // txtInvoiceType
            // 
            this.txtInvoiceType.Enabled = false;
            this.txtInvoiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceType.Location = new System.Drawing.Point(126, 44);
            this.txtInvoiceType.Name = "txtInvoiceType";
            this.txtInvoiceType.Size = new System.Drawing.Size(317, 20);
            this.txtInvoiceType.TabIndex = 33;
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceType.Location = new System.Drawing.Point(34, 47);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(86, 15);
            this.lblInvoiceType.TabIndex = 32;
            this.lblInvoiceType.Text = "Invoice Type";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(126, 148);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(317, 20);
            this.txtAddress.TabIndex = 23;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddress.Location = new System.Drawing.Point(64, 151);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 15);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            // 
            // txtTPNumber
            // 
            this.txtTPNumber.Enabled = false;
            this.txtTPNumber.Location = new System.Drawing.Point(126, 122);
            this.txtTPNumber.Name = "txtTPNumber";
            this.txtTPNumber.Size = new System.Drawing.Size(221, 20);
            this.txtTPNumber.TabIndex = 21;
            // 
            // lblTpNumber
            // 
            this.lblTpNumber.AutoSize = true;
            this.lblTpNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTpNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTpNumber.Location = new System.Drawing.Point(39, 125);
            this.lblTpNumber.Name = "lblTpNumber";
            this.lblTpNumber.Size = new System.Drawing.Size(83, 15);
            this.lblTpNumber.TabIndex = 20;
            this.lblTpNumber.Text = "T.P Number";
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Enabled = false;
            this.txtCustomerid.Location = new System.Drawing.Point(126, 96);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(220, 20);
            this.txtCustomerid.TabIndex = 19;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerId.Location = new System.Drawing.Point(103, 99);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(19, 15);
            this.lblCustomerId.TabIndex = 18;
            this.lblCustomerId.Text = "Id";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(126, 70);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(317, 20);
            this.txtCustomerName.TabIndex = 17;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.lblLongTourHire);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 38);
            this.panel1.TabIndex = 48;
            // 
            // txtVehicleNightParkChage
            // 
            this.txtVehicleNightParkChage.Location = new System.Drawing.Point(190, 271);
            this.txtVehicleNightParkChage.Name = "txtVehicleNightParkChage";
            this.txtVehicleNightParkChage.Size = new System.Drawing.Size(252, 20);
            this.txtVehicleNightParkChage.TabIndex = 57;
            // 
            // lblVehicleNightParkChage
            // 
            this.lblVehicleNightParkChage.AutoSize = true;
            this.lblVehicleNightParkChage.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleNightParkChage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVehicleNightParkChage.Location = new System.Drawing.Point(31, 274);
            this.lblVehicleNightParkChage.Name = "lblVehicleNightParkChage";
            this.lblVehicleNightParkChage.Size = new System.Drawing.Size(153, 13);
            this.lblVehicleNightParkChage.TabIndex = 56;
            this.lblVehicleNightParkChage.Text = "Vehicle Night Park Chage";
            // 
            // frmLTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 620);
            this.Controls.Add(this.txtReceptNo);
            this.Controls.Add(this.lblRiceptNo);
            this.Controls.Add(this.btnSaveDraftandPrintRecept);
            this.Controls.Add(this.btnPrintBIll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewBill);
            this.Controls.Add(this.grbRentDatials);
            this.Controls.Add(this.grbCustomerDatials);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLTH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLTH";
            this.Load += new System.EventHandler(this.frmLTH_Load);
            this.grbRentDatials.ResumeLayout(false);
            this.grbRentDatials.PerformLayout();
            this.grbCustomerDatials.ResumeLayout(false);
            this.grbCustomerDatials.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceptNo;
        private System.Windows.Forms.Label lblRiceptNo;
        private System.Windows.Forms.Button btnSaveDraftandPrintRecept;
        private System.Windows.Forms.Button btnPrintBIll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
        private System.Windows.Forms.DateTimePicker dtmStartDate;
        private System.Windows.Forms.ListBox libVehicleNo;
        private System.Windows.Forms.TextBox txtIssuedUser;
        private System.Windows.Forms.Label lblIssuedUser;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.GroupBox grbRentDatials;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtAdvancePayment;
        private System.Windows.Forms.Label lblAdvacePayment;
        private System.Windows.Forms.TextBox txtOverNightChage;
        private System.Windows.Forms.Label lblOverNightParkChage;
        private System.Windows.Forms.TextBox txtTotalExtraKmChage;
        private System.Windows.Forms.Label lblTotalExtraKmChage;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.TextBox txtEndKm;
        private System.Windows.Forms.Label lblStartKm;
        private System.Windows.Forms.TextBox txtStartKm;
        private System.Windows.Forms.Label lblEndKm;
        private System.Windows.Forms.Button btnClaculateTotal;
        private System.Windows.Forms.TextBox txtLongTourHireValue;
        private System.Windows.Forms.Label LongTourHireValue;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblLongTourHire;
        private System.Windows.Forms.GroupBox grbCustomerDatials;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceType;
        private System.Windows.Forms.Label lblInvoiceType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTPNumber;
        private System.Windows.Forms.Label lblTpNumber;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVehicleNightParkChage;
        private System.Windows.Forms.Label lblVehicleNightParkChage;
    }
}