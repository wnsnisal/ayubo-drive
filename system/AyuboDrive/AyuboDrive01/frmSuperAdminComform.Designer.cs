namespace AyuboDrive01
{
    partial class frmSuperAdminComform
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblConform = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtSuperAdminPassword = new System.Windows.Forms.Label();
            this.btnConform = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblConform);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 38);
            this.panel1.TabIndex = 39;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(294, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 25);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblConform
            // 
            this.lblConform.AutoSize = true;
            this.lblConform.BackColor = System.Drawing.Color.Transparent;
            this.lblConform.Font = new System.Drawing.Font("Neogrey", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConform.ForeColor = System.Drawing.Color.White;
            this.lblConform.Location = new System.Drawing.Point(121, 9);
            this.lblConform.Name = "lblConform";
            this.lblConform.Size = new System.Drawing.Size(88, 21);
            this.lblConform.TabIndex = 0;
            this.lblConform.Text = "Conform";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(75, 75);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(180, 20);
            this.txtAdminPassword.TabIndex = 40;
            // 
            // txtSuperAdminPassword
            // 
            this.txtSuperAdminPassword.AutoSize = true;
            this.txtSuperAdminPassword.Location = new System.Drawing.Point(103, 54);
            this.txtSuperAdminPassword.Name = "txtSuperAdminPassword";
            this.txtSuperAdminPassword.Size = new System.Drawing.Size(122, 13);
            this.txtSuperAdminPassword.TabIndex = 41;
            this.txtSuperAdminPassword.Text = "Super Admion Password";
            // 
            // btnConform
            // 
            this.btnConform.BackColor = System.Drawing.Color.Crimson;
            this.btnConform.FlatAppearance.BorderSize = 0;
            this.btnConform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConform.ForeColor = System.Drawing.Color.White;
            this.btnConform.Location = new System.Drawing.Point(106, 101);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(119, 25);
            this.btnConform.TabIndex = 42;
            this.btnConform.Text = "Conform";
            this.btnConform.UseVisualStyleBackColor = false;
            this.btnConform.Click += new System.EventHandler(this.btnConform_Click);
            // 
            // frmSuperAdminComform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(333, 152);
            this.Controls.Add(this.btnConform);
            this.Controls.Add(this.txtSuperAdminPassword);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuperAdminComform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conform";
            this.Load += new System.EventHandler(this.frmSuperAdminComform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConform;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label txtSuperAdminPassword;
        private System.Windows.Forms.Button btnConform;
        private System.Windows.Forms.Button btnClose;
    }
}