using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive01
{
    public partial class frmRicept : Form
    {
        public frmRicept()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sucess", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void frmRicept_Load(object sender, EventArgs e)
        {
            txtInvoiceType.Text = Commons.InvoiceType;
            txtInvoiceNo.Text = Commons.InvoiceNo;
            txtCustomerName.Text = Commons.CustomerName;
            txtTpNo.Text = Commons.Contact;
            txtAddress.Text = Commons.Address;
            txtUserName.Text = Commons.LogedUser;
            txtVehicleNo.Text = Commons.VehicleNo;
            txtStartDate.Text = Convert.ToString(Commons.StartDate);
            txtAdvancePayment.Text = Commons.AdvancePayment;
            txtDriver.Text = Commons.DriverStatment;
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void lblUsirName_Click(object sender, EventArgs e)
        {

        }

        private void lblVehicleNo_Click(object sender, EventArgs e)
        {

        }
    }
}
