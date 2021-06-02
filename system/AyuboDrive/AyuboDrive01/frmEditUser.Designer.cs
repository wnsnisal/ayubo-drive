namespace AyuboDrive01
{
    partial class frmEditUser
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
            this.lblEditUser = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditAndSave = new System.Windows.Forms.Button();
            this.grpEditUserForm = new System.Windows.Forms.GroupBox();
            this.cmbEditUserType = new System.Windows.Forms.ComboBox();
            this.txtEditUserName = new System.Windows.Forms.TextBox();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.lblEditUserType = new System.Windows.Forms.Label();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.lblEditContact = new System.Windows.Forms.Label();
            this.lblEditAddress = new System.Windows.Forms.Label();
            this.txtEditContact = new System.Windows.Forms.TextBox();
            this.lblEditUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpEditUserForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblEditUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 38);
            this.panel1.TabIndex = 40;
            // 
            // lblEditUser
            // 
            this.lblEditUser.AutoSize = true;
            this.lblEditUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEditUser.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.lblEditUser.Location = new System.Drawing.Point(291, 9);
            this.lblEditUser.Name = "lblEditUser";
            this.lblEditUser.Size = new System.Drawing.Size(99, 21);
            this.lblEditUser.TabIndex = 20;
            this.lblEditUser.Text = "Edit User";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(324, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 23);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditAndSave
            // 
            this.btnEditAndSave.BackColor = System.Drawing.Color.Crimson;
            this.btnEditAndSave.FlatAppearance.BorderSize = 0;
            this.btnEditAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAndSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditAndSave.Location = new System.Drawing.Point(173, 282);
            this.btnEditAndSave.Name = "btnEditAndSave";
            this.btnEditAndSave.Size = new System.Drawing.Size(132, 23);
            this.btnEditAndSave.TabIndex = 64;
            this.btnEditAndSave.Text = "Edit and Save";
            this.btnEditAndSave.UseVisualStyleBackColor = false;
            this.btnEditAndSave.Click += new System.EventHandler(this.btnEditAndSave_Click);
            // 
            // grpEditUserForm
            // 
            this.grpEditUserForm.Controls.Add(this.cmbEditUserType);
            this.grpEditUserForm.Controls.Add(this.txtEditUserName);
            this.grpEditUserForm.Controls.Add(this.lblEditPassword);
            this.grpEditUserForm.Controls.Add(this.txtEditPassword);
            this.grpEditUserForm.Controls.Add(this.lblEditUserType);
            this.grpEditUserForm.Controls.Add(this.txtEditAddress);
            this.grpEditUserForm.Controls.Add(this.lblEditContact);
            this.grpEditUserForm.Controls.Add(this.lblEditAddress);
            this.grpEditUserForm.Controls.Add(this.txtEditContact);
            this.grpEditUserForm.Controls.Add(this.lblEditUserName);
            this.grpEditUserForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grpEditUserForm.Location = new System.Drawing.Point(46, 56);
            this.grpEditUserForm.Name = "grpEditUserForm";
            this.grpEditUserForm.Size = new System.Drawing.Size(556, 201);
            this.grpEditUserForm.TabIndex = 66;
            this.grpEditUserForm.TabStop = false;
            this.grpEditUserForm.Text = "Edit User Form";
            // 
            // cmbEditUserType
            // 
            this.cmbEditUserType.FormattingEnabled = true;
            this.cmbEditUserType.Items.AddRange(new object[] {
            "User",
            "SuperUser",
            "Administrator"});
            this.cmbEditUserType.Location = new System.Drawing.Point(144, 127);
            this.cmbEditUserType.Name = "cmbEditUserType";
            this.cmbEditUserType.Size = new System.Drawing.Size(205, 21);
            this.cmbEditUserType.TabIndex = 61;
            // 
            // txtEditUserName
            // 
            this.txtEditUserName.Location = new System.Drawing.Point(145, 96);
            this.txtEditUserName.Name = "txtEditUserName";
            this.txtEditUserName.Size = new System.Drawing.Size(243, 20);
            this.txtEditUserName.TabIndex = 55;
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.AutoSize = true;
            this.lblEditPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEditPassword.Location = new System.Drawing.Point(53, 159);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(74, 13);
            this.lblEditPassword.TabIndex = 62;
            this.lblEditPassword.Text = "Edit Password";
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(145, 159);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.Size = new System.Drawing.Size(243, 20);
            this.txtEditPassword.TabIndex = 63;
            // 
            // lblEditUserType
            // 
            this.lblEditUserType.AutoSize = true;
            this.lblEditUserType.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEditUserType.Location = new System.Drawing.Point(53, 127);
            this.lblEditUserType.Name = "lblEditUserType";
            this.lblEditUserType.Size = new System.Drawing.Size(77, 13);
            this.lblEditUserType.TabIndex = 60;
            this.lblEditUserType.Text = "Edit User Type";
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Location = new System.Drawing.Point(145, 30);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(364, 20);
            this.txtEditAddress.TabIndex = 58;
            // 
            // lblEditContact
            // 
            this.lblEditContact.AutoSize = true;
            this.lblEditContact.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEditContact.Location = new System.Drawing.Point(53, 63);
            this.lblEditContact.Name = "lblEditContact";
            this.lblEditContact.Size = new System.Drawing.Size(65, 13);
            this.lblEditContact.TabIndex = 57;
            this.lblEditContact.Text = "Edit Contact";
            // 
            // lblEditAddress
            // 
            this.lblEditAddress.AutoSize = true;
            this.lblEditAddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEditAddress.Location = new System.Drawing.Point(53, 30);
            this.lblEditAddress.Name = "lblEditAddress";
            this.lblEditAddress.Size = new System.Drawing.Size(66, 13);
            this.lblEditAddress.TabIndex = 56;
            this.lblEditAddress.Text = "Edit Address";
            // 
            // txtEditContact
            // 
            this.txtEditContact.Location = new System.Drawing.Point(145, 63);
            this.txtEditContact.Name = "txtEditContact";
            this.txtEditContact.Size = new System.Drawing.Size(243, 20);
            this.txtEditContact.TabIndex = 59;
            // 
            // lblEditUserName
            // 
            this.lblEditUserName.AutoSize = true;
            this.lblEditUserName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEditUserName.Location = new System.Drawing.Point(53, 96);
            this.lblEditUserName.Name = "lblEditUserName";
            this.lblEditUserName.Size = new System.Drawing.Size(81, 13);
            this.lblEditUserName.TabIndex = 54;
            this.lblEditUserName.Text = "Edit User Name";
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(647, 337);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditAndSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpEditUserForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditUser";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpEditUserForm.ResumeLayout(false);
            this.grpEditUserForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEditUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditAndSave;
        private System.Windows.Forms.GroupBox grpEditUserForm;
        private System.Windows.Forms.ComboBox cmbEditUserType;
        private System.Windows.Forms.TextBox txtEditUserName;
        private System.Windows.Forms.Label lblEditPassword;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.Label lblEditUserType;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label lblEditContact;
        private System.Windows.Forms.Label lblEditAddress;
        private System.Windows.Forms.TextBox txtEditContact;
        private System.Windows.Forms.Label lblEditUserName;
    }
}