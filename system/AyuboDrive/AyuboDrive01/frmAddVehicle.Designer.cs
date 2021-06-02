namespace AyuboDrive01
{
    partial class frmAddVehicle
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
            this.libAddVehicle = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCencel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.libAddVehicle);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 38);
            this.panel1.TabIndex = 42;
            // 
            // libAddVehicle
            // 
            this.libAddVehicle.AutoSize = true;
            this.libAddVehicle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.libAddVehicle.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libAddVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.libAddVehicle.Location = new System.Drawing.Point(270, 9);
            this.libAddVehicle.Name = "libAddVehicle";
            this.libAddVehicle.Size = new System.Drawing.Size(119, 21);
            this.libAddVehicle.TabIndex = 20;
            this.libAddVehicle.Text = "Add Vehicle";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Crimson;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNew.Location = new System.Drawing.Point(118, 382);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 31);
            this.btnAddNew.TabIndex = 45;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.BackColor = System.Drawing.Color.Crimson;
            this.btnCencel.FlatAppearance.BorderSize = 0;
            this.btnCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCencel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCencel.Location = new System.Drawing.Point(419, 382);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(120, 31);
            this.btnCencel.TabIndex = 44;
            this.btnCencel.Text = "Cancel";
            this.btnCencel.UseVisualStyleBackColor = false;
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Crimson;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(268, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 31);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlVehicle
            // 
            this.pnlVehicle.Controls.Add(this.pictureBox1);
            this.pnlVehicle.Controls.Add(this.lblVehicleNo);
            this.pnlVehicle.Controls.Add(this.txtVehicleNo);
            this.pnlVehicle.Enabled = false;
            this.pnlVehicle.Location = new System.Drawing.Point(11, 50);
            this.pnlVehicle.Name = "pnlVehicle";
            this.pnlVehicle.Size = new System.Drawing.Size(628, 312);
            this.pnlVehicle.TabIndex = 46;
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVehicleNo.Location = new System.Drawing.Point(152, 269);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleNo.TabIndex = 48;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Location = new System.Drawing.Point(217, 266);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(202, 20);
            this.txtVehicleNo.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AyuboDrive01.Properties.Resources.audi_PNG1737;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(107, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 233);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(650, 425);
            this.Controls.Add(this.pnlVehicle);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddVehicle";
            this.Load += new System.EventHandler(this.frmAddVehicle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlVehicle.ResumeLayout(false);
            this.pnlVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label libAddVehicle;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.TextBox txtVehicleNo;
    }
}