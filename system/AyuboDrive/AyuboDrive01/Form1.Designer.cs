namespace AyuboDrive01
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAndRemoveUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRemoveCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNormalRent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDayTourHire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLongTourHire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoiceDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddVehicleNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.rentToolStripMenuItem,
            this.mnuAddVehicle});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuLogout,
            this.mnuAddUser,
            this.mnuEditAndRemoveUser,
            this.mnuExit});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.MouseHover += new System.EventHandler(this.userToolStripMenuItem_MouseHover);
            // 
            // mnuLogin
            // 
            this.mnuLogin.BackColor = System.Drawing.Color.Gold;
            this.mnuLogin.ForeColor = System.Drawing.Color.Black;
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(231, 26);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.BackColor = System.Drawing.Color.Gold;
            this.mnuLogout.Enabled = false;
            this.mnuLogout.ForeColor = System.Drawing.Color.Black;
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(231, 26);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuAddUser
            // 
            this.mnuAddUser.BackColor = System.Drawing.Color.Gold;
            this.mnuAddUser.Enabled = false;
            this.mnuAddUser.ForeColor = System.Drawing.Color.Black;
            this.mnuAddUser.Name = "mnuAddUser";
            this.mnuAddUser.Size = new System.Drawing.Size(231, 26);
            this.mnuAddUser.Text = "AddUser";
            this.mnuAddUser.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // mnuEditAndRemoveUser
            // 
            this.mnuEditAndRemoveUser.BackColor = System.Drawing.Color.Gold;
            this.mnuEditAndRemoveUser.Enabled = false;
            this.mnuEditAndRemoveUser.ForeColor = System.Drawing.Color.Black;
            this.mnuEditAndRemoveUser.Name = "mnuEditAndRemoveUser";
            this.mnuEditAndRemoveUser.Size = new System.Drawing.Size(231, 26);
            this.mnuEditAndRemoveUser.Text = "Edit And RemoveUser";
            this.mnuEditAndRemoveUser.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.Gold;
            this.mnuExit.ForeColor = System.Drawing.Color.Black;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(231, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchCustomer,
            this.mnuAddCustomer,
            this.mnuEditRemoveCustomer});
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.customerToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // mnuSearchCustomer
            // 
            this.mnuSearchCustomer.BackColor = System.Drawing.Color.Gold;
            this.mnuSearchCustomer.Enabled = false;
            this.mnuSearchCustomer.Name = "mnuSearchCustomer";
            this.mnuSearchCustomer.Size = new System.Drawing.Size(269, 26);
            this.mnuSearchCustomer.Text = "Search Customer";
            this.mnuSearchCustomer.Click += new System.EventHandler(this.mnuSearchCustomer_Click);
            // 
            // mnuAddCustomer
            // 
            this.mnuAddCustomer.BackColor = System.Drawing.Color.Gold;
            this.mnuAddCustomer.Enabled = false;
            this.mnuAddCustomer.ForeColor = System.Drawing.Color.Black;
            this.mnuAddCustomer.Name = "mnuAddCustomer";
            this.mnuAddCustomer.Size = new System.Drawing.Size(269, 26);
            this.mnuAddCustomer.Text = "AddCustomer";
            this.mnuAddCustomer.Click += new System.EventHandler(this.mnuAddCustomer_Click);
            // 
            // mnuEditRemoveCustomer
            // 
            this.mnuEditRemoveCustomer.BackColor = System.Drawing.Color.Gold;
            this.mnuEditRemoveCustomer.Enabled = false;
            this.mnuEditRemoveCustomer.ForeColor = System.Drawing.Color.Black;
            this.mnuEditRemoveCustomer.Name = "mnuEditRemoveCustomer";
            this.mnuEditRemoveCustomer.Size = new System.Drawing.Size(269, 26);
            this.mnuEditRemoveCustomer.Text = "Edit and Remove Customer";
            this.mnuEditRemoveCustomer.Click += new System.EventHandler(this.mnuEditRemoveCustomer_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNormalRent,
            this.mnuDayTourHire,
            this.mnuLongTourHire,
            this.mnuInvoiceDetails});
            this.rentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rentToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.rentToolStripMenuItem.Text = "Rent";
            // 
            // mnuNormalRent
            // 
            this.mnuNormalRent.BackColor = System.Drawing.Color.Gold;
            this.mnuNormalRent.Enabled = false;
            this.mnuNormalRent.ForeColor = System.Drawing.Color.Black;
            this.mnuNormalRent.Name = "mnuNormalRent";
            this.mnuNormalRent.Size = new System.Drawing.Size(174, 26);
            this.mnuNormalRent.Text = "NormalRent";
            this.mnuNormalRent.Click += new System.EventHandler(this.normalRentToolStripMenuItem_Click);
            // 
            // mnuDayTourHire
            // 
            this.mnuDayTourHire.BackColor = System.Drawing.Color.Gold;
            this.mnuDayTourHire.Enabled = false;
            this.mnuDayTourHire.ForeColor = System.Drawing.Color.Black;
            this.mnuDayTourHire.Name = "mnuDayTourHire";
            this.mnuDayTourHire.Size = new System.Drawing.Size(174, 26);
            this.mnuDayTourHire.Text = "DayToureHire";
            this.mnuDayTourHire.Click += new System.EventHandler(this.dayToureRentToolStripMenuItem_Click);
            // 
            // mnuLongTourHire
            // 
            this.mnuLongTourHire.BackColor = System.Drawing.Color.Gold;
            this.mnuLongTourHire.Enabled = false;
            this.mnuLongTourHire.ForeColor = System.Drawing.Color.Black;
            this.mnuLongTourHire.Name = "mnuLongTourHire";
            this.mnuLongTourHire.Size = new System.Drawing.Size(174, 26);
            this.mnuLongTourHire.Text = "LongTourHire";
            this.mnuLongTourHire.Click += new System.EventHandler(this.longTourRentToolStripMenuItem_Click);
            // 
            // mnuInvoiceDetails
            // 
            this.mnuInvoiceDetails.BackColor = System.Drawing.Color.Gold;
            this.mnuInvoiceDetails.Enabled = false;
            this.mnuInvoiceDetails.Name = "mnuInvoiceDetails";
            this.mnuInvoiceDetails.Size = new System.Drawing.Size(174, 26);
            this.mnuInvoiceDetails.Text = "InoiceDetails";
            this.mnuInvoiceDetails.Click += new System.EventHandler(this.mnuInvoiceDetails_Click);
            // 
            // mnuAddVehicle
            // 
            this.mnuAddVehicle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchVehicle,
            this.mnuReports,
            this.mnuAddVehicleNew});
            this.mnuAddVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuAddVehicle.ForeColor = System.Drawing.Color.Crimson;
            this.mnuAddVehicle.Name = "mnuAddVehicle";
            this.mnuAddVehicle.Size = new System.Drawing.Size(62, 25);
            this.mnuAddVehicle.Text = "Other";
            // 
            // mnuSearchVehicle
            // 
            this.mnuSearchVehicle.BackColor = System.Drawing.Color.Gold;
            this.mnuSearchVehicle.Enabled = false;
            this.mnuSearchVehicle.ForeColor = System.Drawing.Color.Black;
            this.mnuSearchVehicle.Name = "mnuSearchVehicle";
            this.mnuSearchVehicle.Size = new System.Drawing.Size(180, 26);
            this.mnuSearchVehicle.Text = "Search Vehicle";
            this.mnuSearchVehicle.Click += new System.EventHandler(this.mnuSearchVehicle_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.BackColor = System.Drawing.Color.Gold;
            this.mnuReports.Enabled = false;
            this.mnuReports.ForeColor = System.Drawing.Color.Black;
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(180, 26);
            this.mnuReports.Text = "Reports";
            // 
            // mnuAddVehicleNew
            // 
            this.mnuAddVehicleNew.BackColor = System.Drawing.Color.Gold;
            this.mnuAddVehicleNew.Enabled = false;
            this.mnuAddVehicleNew.Name = "mnuAddVehicleNew";
            this.mnuAddVehicleNew.Size = new System.Drawing.Size(180, 26);
            this.mnuAddVehicleNew.Text = "Add Vehicle";
            this.mnuAddVehicleNew.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AyuboDrive01.Properties.Resources.meetr_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 500);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuAddUser;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAndRemoveUser;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRemoveCustomer;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNormalRent;
        private System.Windows.Forms.ToolStripMenuItem mnuDayTourHire;
        private System.Windows.Forms.ToolStripMenuItem mnuLongTourHire;
        private System.Windows.Forms.ToolStripMenuItem mnuAddVehicle;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchVehicle;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuAddVehicleNew;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoiceDetails;
    }
}

