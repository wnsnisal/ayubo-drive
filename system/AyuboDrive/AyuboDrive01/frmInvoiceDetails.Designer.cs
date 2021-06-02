namespace AyuboDrive01
{
    partial class frmInvoiceDetails
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
            this.pnlInvoiceDetails = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblinvoiceDetails = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDriverStatment = new System.Windows.Forms.TextBox();
            this.lblDriverStatment = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtIssuedUser = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.InvoiceNo = new System.Windows.Forms.Label();
            this.lblIssuedUser = new System.Windows.Forms.Label();
            this.libAddress = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtEndKm = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEndKm = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtStartKm = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartKm = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtInvoiceType = new System.Windows.Forms.TextBox();
            this.txtOverNights = new System.Windows.Forms.TextBox();
            this.lblOverNights = new System.Windows.Forms.Label();
            this.txtExtraKmChage = new System.Windows.Forms.TextBox();
            this.lblExtraKmChage = new System.Windows.Forms.Label();
            this.txtTotalPayble = new System.Windows.Forms.TextBox();
            this.lblTotalPayable = new System.Windows.Forms.Label();
            this.txtAdvancePay = new System.Windows.Forms.TextBox();
            this.lblAdavcePay = new System.Windows.Forms.Label();
            this.txtTotalBillValue = new System.Windows.Forms.TextBox();
            this.lblTotalBillValue = new System.Windows.Forms.Label();
            this.txtWeightngHours = new System.Windows.Forms.TextBox();
            this.lblWeightiongHours = new System.Windows.Forms.Label();
            this.libPendingBills = new System.Windows.Forms.ListBox();
            this.lblPendingBills = new System.Windows.Forms.Label();
            this.pnlInvoiceDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInvoiceDetails
            // 
            this.pnlInvoiceDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.pnlInvoiceDetails.Controls.Add(this.button1);
            this.pnlInvoiceDetails.Controls.Add(this.lblinvoiceDetails);
            this.pnlInvoiceDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoiceDetails.Name = "pnlInvoiceDetails";
            this.pnlInvoiceDetails.Size = new System.Drawing.Size(831, 41);
            this.pnlInvoiceDetails.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(788, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblinvoiceDetails
            // 
            this.lblinvoiceDetails.AutoSize = true;
            this.lblinvoiceDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.lblinvoiceDetails.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoiceDetails.ForeColor = System.Drawing.Color.White;
            this.lblinvoiceDetails.Location = new System.Drawing.Point(355, 9);
            this.lblinvoiceDetails.Name = "lblinvoiceDetails";
            this.lblinvoiceDetails.Size = new System.Drawing.Size(137, 21);
            this.lblinvoiceDetails.TabIndex = 21;
            this.lblinvoiceDetails.Text = "Invoice Details";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(96, 21);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(349, 20);
            this.txtInvoiceNo.TabIndex = 88;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            this.txtInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceNo_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtDriverStatment);
            this.panel1.Controls.Add(this.lblDriverStatment);
            this.panel1.Controls.Add(this.txtEndTime);
            this.panel1.Controls.Add(this.lblEndTime);
            this.panel1.Controls.Add(this.txtStartTime);
            this.panel1.Controls.Add(this.lblStartTime);
            this.panel1.Controls.Add(this.txtEndDate);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.txtIssuedUser);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.InvoiceNo);
            this.panel1.Controls.Add(this.lblIssuedUser);
            this.panel1.Controls.Add(this.libAddress);
            this.panel1.Controls.Add(this.txtVehicleNo);
            this.panel1.Controls.Add(this.txtInvoiceNo);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblVehicleNo);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.txtEndKm);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.lblEndKm);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.txtStartKm);
            this.panel1.Controls.Add(this.txtStartDate);
            this.panel1.Controls.Add(this.lblStartKm);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Location = new System.Drawing.Point(27, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 375);
            this.panel1.TabIndex = 89;
            // 
            // txtDriverStatment
            // 
            this.txtDriverStatment.Enabled = false;
            this.txtDriverStatment.Location = new System.Drawing.Point(96, 334);
            this.txtDriverStatment.Name = "txtDriverStatment";
            this.txtDriverStatment.Size = new System.Drawing.Size(349, 20);
            this.txtDriverStatment.TabIndex = 111;
            // 
            // lblDriverStatment
            // 
            this.lblDriverStatment.AutoSize = true;
            this.lblDriverStatment.Location = new System.Drawing.Point(10, 337);
            this.lblDriverStatment.Name = "lblDriverStatment";
            this.lblDriverStatment.Size = new System.Drawing.Size(80, 13);
            this.lblDriverStatment.TabIndex = 110;
            this.lblDriverStatment.Text = "Driver Statment";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Enabled = false;
            this.txtEndTime.Location = new System.Drawing.Point(96, 308);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(349, 20);
            this.txtEndTime.TabIndex = 109;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(38, 311);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblEndTime.TabIndex = 108;
            this.lblEndTime.Text = "End Time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Location = new System.Drawing.Point(96, 282);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(349, 20);
            this.txtStartTime.TabIndex = 107;
            this.txtStartTime.TextChanged += new System.EventHandler(this.txtStartTime_TextChanged);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(34, 285);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 106;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.Click += new System.EventHandler(this.lblStartTime_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(96, 177);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(349, 20);
            this.txtEndDate.TabIndex = 97;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(8, 50);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 84;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtIssuedUser
            // 
            this.txtIssuedUser.Location = new System.Drawing.Point(96, 255);
            this.txtIssuedUser.Name = "txtIssuedUser";
            this.txtIssuedUser.Size = new System.Drawing.Size(349, 20);
            this.txtIssuedUser.TabIndex = 105;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(96, 47);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(349, 20);
            this.txtCustomerName.TabIndex = 85;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.AutoSize = true;
            this.InvoiceNo.Location = new System.Drawing.Point(31, 24);
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Size = new System.Drawing.Size(59, 13);
            this.InvoiceNo.TabIndex = 90;
            this.InvoiceNo.Text = "Invoice No";
            // 
            // lblIssuedUser
            // 
            this.lblIssuedUser.AutoSize = true;
            this.lblIssuedUser.Location = new System.Drawing.Point(26, 258);
            this.lblIssuedUser.Name = "lblIssuedUser";
            this.lblIssuedUser.Size = new System.Drawing.Size(63, 13);
            this.lblIssuedUser.TabIndex = 104;
            this.lblIssuedUser.Text = "Issued User";
            // 
            // libAddress
            // 
            this.libAddress.AutoSize = true;
            this.libAddress.Location = new System.Drawing.Point(45, 76);
            this.libAddress.Name = "libAddress";
            this.libAddress.Size = new System.Drawing.Size(45, 13);
            this.libAddress.TabIndex = 86;
            this.libAddress.Text = "Address";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Location = new System.Drawing.Point(96, 229);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(349, 20);
            this.txtVehicleNo.TabIndex = 103;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 73);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(349, 20);
            this.txtAddress.TabIndex = 87;
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Location = new System.Drawing.Point(30, 232);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleNo.TabIndex = 102;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(45, 102);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 88;
            this.lblContact.Text = "Contact";
            // 
            // txtEndKm
            // 
            this.txtEndKm.Location = new System.Drawing.Point(96, 203);
            this.txtEndKm.Name = "txtEndKm";
            this.txtEndKm.Size = new System.Drawing.Size(349, 20);
            this.txtEndKm.TabIndex = 101;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(96, 99);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(349, 20);
            this.txtContact.TabIndex = 89;
            // 
            // lblEndKm
            // 
            this.lblEndKm.AutoSize = true;
            this.lblEndKm.Location = new System.Drawing.Point(46, 206);
            this.lblEndKm.Name = "lblEndKm";
            this.lblEndKm.Size = new System.Drawing.Size(44, 13);
            this.lblEndKm.TabIndex = 100;
            this.lblEndKm.Text = "End Km";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(34, 128);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 94;
            this.lblStartDate.Text = "Start Date";
            // 
            // txtStartKm
            // 
            this.txtStartKm.Location = new System.Drawing.Point(96, 151);
            this.txtStartKm.Name = "txtStartKm";
            this.txtStartKm.Size = new System.Drawing.Size(349, 20);
            this.txtStartKm.TabIndex = 99;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(96, 125);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(349, 20);
            this.txtStartDate.TabIndex = 95;
            // 
            // lblStartKm
            // 
            this.lblStartKm.AutoSize = true;
            this.lblStartKm.Location = new System.Drawing.Point(42, 154);
            this.lblStartKm.Name = "lblStartKm";
            this.lblStartKm.Size = new System.Drawing.Size(47, 13);
            this.lblStartKm.TabIndex = 98;
            this.lblStartKm.Text = "Start Km";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(38, 180);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 96;
            this.lblEndDate.Text = "End Date";
            // 
            // txtInvoiceType
            // 
            this.txtInvoiceType.BackColor = System.Drawing.SystemColors.Control;
            this.txtInvoiceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInvoiceType.Location = new System.Drawing.Point(251, 56);
            this.txtInvoiceType.Name = "txtInvoiceType";
            this.txtInvoiceType.Size = new System.Drawing.Size(349, 19);
            this.txtInvoiceType.TabIndex = 106;
            this.txtInvoiceType.TextChanged += new System.EventHandler(this.txtInvoiceType_TextChanged);
            // 
            // txtOverNights
            // 
            this.txtOverNights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOverNights.Enabled = false;
            this.txtOverNights.Location = new System.Drawing.Point(645, 343);
            this.txtOverNights.Name = "txtOverNights";
            this.txtOverNights.Size = new System.Drawing.Size(150, 20);
            this.txtOverNights.TabIndex = 161;
            // 
            // lblOverNights
            // 
            this.lblOverNights.AutoSize = true;
            this.lblOverNights.Location = new System.Drawing.Point(575, 347);
            this.lblOverNights.Name = "lblOverNights";
            this.lblOverNights.Size = new System.Drawing.Size(63, 13);
            this.lblOverNights.TabIndex = 160;
            this.lblOverNights.Text = "Over Nights";
            // 
            // txtExtraKmChage
            // 
            this.txtExtraKmChage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtExtraKmChage.Enabled = false;
            this.txtExtraKmChage.Location = new System.Drawing.Point(645, 369);
            this.txtExtraKmChage.Name = "txtExtraKmChage";
            this.txtExtraKmChage.Size = new System.Drawing.Size(150, 20);
            this.txtExtraKmChage.TabIndex = 159;
            // 
            // lblExtraKmChage
            // 
            this.lblExtraKmChage.AutoSize = true;
            this.lblExtraKmChage.Location = new System.Drawing.Point(558, 372);
            this.lblExtraKmChage.Name = "lblExtraKmChage";
            this.lblExtraKmChage.Size = new System.Drawing.Size(83, 13);
            this.lblExtraKmChage.TabIndex = 158;
            this.lblExtraKmChage.Text = "Extra Km Chage";
            // 
            // txtTotalPayble
            // 
            this.txtTotalPayble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalPayble.Location = new System.Drawing.Point(645, 447);
            this.txtTotalPayble.Name = "txtTotalPayble";
            this.txtTotalPayble.Size = new System.Drawing.Size(150, 20);
            this.txtTotalPayble.TabIndex = 167;
            // 
            // lblTotalPayable
            // 
            this.lblTotalPayable.AutoSize = true;
            this.lblTotalPayable.Location = new System.Drawing.Point(566, 450);
            this.lblTotalPayable.Name = "lblTotalPayable";
            this.lblTotalPayable.Size = new System.Drawing.Size(72, 13);
            this.lblTotalPayable.TabIndex = 166;
            this.lblTotalPayable.Text = "Total Payable";
            // 
            // txtAdvancePay
            // 
            this.txtAdvancePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAdvancePay.Location = new System.Drawing.Point(645, 421);
            this.txtAdvancePay.Name = "txtAdvancePay";
            this.txtAdvancePay.Size = new System.Drawing.Size(150, 20);
            this.txtAdvancePay.TabIndex = 165;
            // 
            // lblAdavcePay
            // 
            this.lblAdavcePay.AutoSize = true;
            this.lblAdavcePay.Location = new System.Drawing.Point(573, 425);
            this.lblAdavcePay.Name = "lblAdavcePay";
            this.lblAdavcePay.Size = new System.Drawing.Size(65, 13);
            this.lblAdavcePay.TabIndex = 164;
            this.lblAdavcePay.Text = "Advace Pay";
            // 
            // txtTotalBillValue
            // 
            this.txtTotalBillValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalBillValue.Location = new System.Drawing.Point(645, 395);
            this.txtTotalBillValue.Name = "txtTotalBillValue";
            this.txtTotalBillValue.Size = new System.Drawing.Size(150, 20);
            this.txtTotalBillValue.TabIndex = 163;
            // 
            // lblTotalBillValue
            // 
            this.lblTotalBillValue.AutoSize = true;
            this.lblTotalBillValue.Location = new System.Drawing.Point(561, 398);
            this.lblTotalBillValue.Name = "lblTotalBillValue";
            this.lblTotalBillValue.Size = new System.Drawing.Size(77, 13);
            this.lblTotalBillValue.TabIndex = 162;
            this.lblTotalBillValue.Text = "Total Bill Value";
            // 
            // txtWeightngHours
            // 
            this.txtWeightngHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtWeightngHours.Enabled = false;
            this.txtWeightngHours.Location = new System.Drawing.Point(645, 317);
            this.txtWeightngHours.Name = "txtWeightngHours";
            this.txtWeightngHours.Size = new System.Drawing.Size(150, 20);
            this.txtWeightngHours.TabIndex = 169;
            // 
            // lblWeightiongHours
            // 
            this.lblWeightiongHours.AutoSize = true;
            this.lblWeightiongHours.Location = new System.Drawing.Point(555, 320);
            this.lblWeightiongHours.Name = "lblWeightiongHours";
            this.lblWeightiongHours.Size = new System.Drawing.Size(86, 13);
            this.lblWeightiongHours.TabIndex = 168;
            this.lblWeightiongHours.Text = "Weighting Hours";
            // 
            // libPendingBills
            // 
            this.libPendingBills.FormattingEnabled = true;
            this.libPendingBills.Location = new System.Drawing.Point(617, 125);
            this.libPendingBills.Name = "libPendingBills";
            this.libPendingBills.Size = new System.Drawing.Size(178, 173);
            this.libPendingBills.TabIndex = 170;
            this.libPendingBills.SelectedIndexChanged += new System.EventHandler(this.libPendingBills_SelectedIndexChanged);
            // 
            // lblPendingBills
            // 
            this.lblPendingBills.AutoSize = true;
            this.lblPendingBills.Location = new System.Drawing.Point(614, 109);
            this.lblPendingBills.Name = "lblPendingBills";
            this.lblPendingBills.Size = new System.Drawing.Size(67, 13);
            this.lblPendingBills.TabIndex = 171;
            this.lblPendingBills.Text = "Pending Bills";
            // 
            // frmInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 484);
            this.Controls.Add(this.lblPendingBills);
            this.Controls.Add(this.libPendingBills);
            this.Controls.Add(this.txtWeightngHours);
            this.Controls.Add(this.lblWeightiongHours);
            this.Controls.Add(this.txtInvoiceType);
            this.Controls.Add(this.txtOverNights);
            this.Controls.Add(this.lblOverNights);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtExtraKmChage);
            this.Controls.Add(this.lblExtraKmChage);
            this.Controls.Add(this.pnlInvoiceDetails);
            this.Controls.Add(this.lblTotalBillValue);
            this.Controls.Add(this.txtTotalPayble);
            this.Controls.Add(this.txtTotalBillValue);
            this.Controls.Add(this.lblAdavcePay);
            this.Controls.Add(this.lblTotalPayable);
            this.Controls.Add(this.txtAdvancePay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInvoiceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvoiceDetails";
            this.Load += new System.EventHandler(this.frmInvoiceDetails_Load);
            this.pnlInvoiceDetails.ResumeLayout(false);
            this.pnlInvoiceDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInvoiceDetails;
        private System.Windows.Forms.Label lblinvoiceDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InvoiceNo;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtIssuedUser;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblIssuedUser;
        private System.Windows.Forms.Label libAddress;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtEndKm;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblEndKm;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtStartKm;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartKm;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtInvoiceType;
        private System.Windows.Forms.TextBox txtOverNights;
        private System.Windows.Forms.Label lblOverNights;
        private System.Windows.Forms.TextBox txtExtraKmChage;
        private System.Windows.Forms.Label lblExtraKmChage;
        private System.Windows.Forms.TextBox txtTotalPayble;
        private System.Windows.Forms.Label lblTotalPayable;
        private System.Windows.Forms.TextBox txtAdvancePay;
        private System.Windows.Forms.Label lblAdavcePay;
        private System.Windows.Forms.TextBox txtTotalBillValue;
        private System.Windows.Forms.Label lblTotalBillValue;
        private System.Windows.Forms.TextBox txtWeightngHours;
        private System.Windows.Forms.Label lblWeightiongHours;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtDriverStatment;
        private System.Windows.Forms.Label lblDriverStatment;
        private System.Windows.Forms.ListBox libPendingBills;
        private System.Windows.Forms.Label lblPendingBills;
    }
}