namespace AyuboDrive01
{
    partial class frmSearchVehicle
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
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.libVehicles = new System.Windows.Forms.ListBox();
            this.pnlSearchVehicle = new System.Windows.Forms.Panel();
            this.lblRentedCustomers = new System.Windows.Forms.Label();
            this.libRentedCustomers = new System.Windows.Forms.ListBox();
            this.lblAvailablity = new System.Windows.Forms.Label();
            this.lblInvoicesRegardingVehicle = new System.Windows.Forms.Label();
            this.libInvoiceRegardingVehicle = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchVehicle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAvilability = new System.Windows.Forms.TextBox();
            this.pnlSearchVehicle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleNo.ForeColor = System.Drawing.Color.LightGray;
            this.lblVehicleNo.Location = new System.Drawing.Point(11, 13);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleNo.TabIndex = 84;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // libVehicles
            // 
            this.libVehicles.FormattingEnabled = true;
            this.libVehicles.Location = new System.Drawing.Point(14, 36);
            this.libVehicles.Name = "libVehicles";
            this.libVehicles.Size = new System.Drawing.Size(183, 264);
            this.libVehicles.TabIndex = 83;
            this.libVehicles.SelectedIndexChanged += new System.EventHandler(this.libVehicles_SelectedIndexChanged);
            // 
            // pnlSearchVehicle
            // 
            this.pnlSearchVehicle.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchVehicle.Controls.Add(this.txtAvilability);
            this.pnlSearchVehicle.Controls.Add(this.lblRentedCustomers);
            this.pnlSearchVehicle.Controls.Add(this.libRentedCustomers);
            this.pnlSearchVehicle.Controls.Add(this.lblAvailablity);
            this.pnlSearchVehicle.Controls.Add(this.lblInvoicesRegardingVehicle);
            this.pnlSearchVehicle.Controls.Add(this.libInvoiceRegardingVehicle);
            this.pnlSearchVehicle.Controls.Add(this.libVehicles);
            this.pnlSearchVehicle.Controls.Add(this.lblVehicleNo);
            this.pnlSearchVehicle.Location = new System.Drawing.Point(415, 52);
            this.pnlSearchVehicle.Name = "pnlSearchVehicle";
            this.pnlSearchVehicle.Size = new System.Drawing.Size(435, 313);
            this.pnlSearchVehicle.TabIndex = 87;
            this.pnlSearchVehicle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearchVehicle_Paint);
            // 
            // lblRentedCustomers
            // 
            this.lblRentedCustomers.AutoSize = true;
            this.lblRentedCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblRentedCustomers.ForeColor = System.Drawing.Color.LightGray;
            this.lblRentedCustomers.Location = new System.Drawing.Point(214, 162);
            this.lblRentedCustomers.Name = "lblRentedCustomers";
            this.lblRentedCustomers.Size = new System.Drawing.Size(94, 13);
            this.lblRentedCustomers.TabIndex = 104;
            this.lblRentedCustomers.Text = "Rented Customers";
            // 
            // libRentedCustomers
            // 
            this.libRentedCustomers.FormattingEnabled = true;
            this.libRentedCustomers.Location = new System.Drawing.Point(217, 179);
            this.libRentedCustomers.Name = "libRentedCustomers";
            this.libRentedCustomers.Size = new System.Drawing.Size(199, 121);
            this.libRentedCustomers.TabIndex = 103;
            this.libRentedCustomers.SelectedIndexChanged += new System.EventHandler(this.libRentedCustomers_SelectedIndexChanged);
            // 
            // lblAvailablity
            // 
            this.lblAvailablity.AutoSize = true;
            this.lblAvailablity.ForeColor = System.Drawing.Color.LightGray;
            this.lblAvailablity.Location = new System.Drawing.Point(211, 13);
            this.lblAvailablity.Name = "lblAvailablity";
            this.lblAvailablity.Size = new System.Drawing.Size(56, 13);
            this.lblAvailablity.TabIndex = 101;
            this.lblAvailablity.Text = "Availability";
            // 
            // lblInvoicesRegardingVehicle
            // 
            this.lblInvoicesRegardingVehicle.AutoSize = true;
            this.lblInvoicesRegardingVehicle.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoicesRegardingVehicle.ForeColor = System.Drawing.Color.LightGray;
            this.lblInvoicesRegardingVehicle.Location = new System.Drawing.Point(214, 34);
            this.lblInvoicesRegardingVehicle.Name = "lblInvoicesRegardingVehicle";
            this.lblInvoicesRegardingVehicle.Size = new System.Drawing.Size(137, 13);
            this.lblInvoicesRegardingVehicle.TabIndex = 90;
            this.lblInvoicesRegardingVehicle.Text = "Invoices Regarding Vehicle";
            // 
            // libInvoiceRegardingVehicle
            // 
            this.libInvoiceRegardingVehicle.FormattingEnabled = true;
            this.libInvoiceRegardingVehicle.Location = new System.Drawing.Point(217, 50);
            this.libInvoiceRegardingVehicle.Name = "libInvoiceRegardingVehicle";
            this.libInvoiceRegardingVehicle.Size = new System.Drawing.Size(199, 108);
            this.libInvoiceRegardingVehicle.TabIndex = 89;
            this.libInvoiceRegardingVehicle.SelectedIndexChanged += new System.EventHandler(this.libInvoiceRegardingVehicle_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblSearchVehicle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 38);
            this.panel1.TabIndex = 88;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSearchVehicle
            // 
            this.lblSearchVehicle.AutoSize = true;
            this.lblSearchVehicle.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchVehicle.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.lblSearchVehicle.Location = new System.Drawing.Point(365, 9);
            this.lblSearchVehicle.Name = "lblSearchVehicle";
            this.lblSearchVehicle.Size = new System.Drawing.Size(152, 21);
            this.lblSearchVehicle.TabIndex = 0;
            this.lblSearchVehicle.Text = "Search Vehicle";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(430, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 30);
            this.btnCancel.TabIndex = 90;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(316, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 30);
            this.btnDelete.TabIndex = 92;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AyuboDrive01.Properties.Resources.aaaaa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 292);
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // txtAvilability
            // 
            this.txtAvilability.Enabled = false;
            this.txtAvilability.Location = new System.Drawing.Point(273, 10);
            this.txtAvilability.Name = "txtAvilability";
            this.txtAvilability.Size = new System.Drawing.Size(143, 20);
            this.txtAvilability.TabIndex = 105;
            // 
            // frmSearchVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(862, 431);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSearchVehicle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearchVehicle";
            this.Load += new System.EventHandler(this.frmSearchVehicle_Load);
            this.pnlSearchVehicle.ResumeLayout(false);
            this.pnlSearchVehicle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.ListBox libVehicles;
        private System.Windows.Forms.Panel pnlSearchVehicle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchVehicle;
        private System.Windows.Forms.Label lblInvoicesRegardingVehicle;
        private System.Windows.Forms.ListBox libInvoiceRegardingVehicle;
        private System.Windows.Forms.Label lblRentedCustomers;
        private System.Windows.Forms.ListBox libRentedCustomers;
        private System.Windows.Forms.Label lblAvailablity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAvilability;
    }
}