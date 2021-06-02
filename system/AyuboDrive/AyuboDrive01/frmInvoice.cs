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
    public partial class frmRentInvoice : Form
    {
        public frmRentInvoice()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSavAndPrint_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnOpenInvoice_Click(object sender, EventArgs e)
        {

        }

        private void frmRentInvoice_Load(object sender, EventArgs e)
        {
            txtInvoiceNo.Text = Commons.InvoiceNo;
            txtCustomerName.Text = Commons.CustomerName;
            txtContact.Text = Commons.Contact;
            txtAddress.Text = Commons.Address;
            txtStartDate.Text = Convert.ToString(Commons.StartDate);
            txtEndDate.Text = Convert.ToString(Commons.EndDate);
            txtIssuedUser.Text = Commons.LogedUser;
            txtTotalBillValue.Text = Convert.ToInt32(Commons.TotalRentValue).ToString();
            txtAdvancePay.Text = Convert.ToInt32(Commons.AdvancePayment).ToString();
            txtVehicleNo.Text = Commons.VehicleNo;

            int TBillValue = Convert.ToInt32(txtTotalBillValue.Text);
            int APay = Convert.ToInt32(txtAdvancePay.Text);
            txtTotalPayble.Text = Convert.ToString(TBillValue-APay);
        }
    }
}
