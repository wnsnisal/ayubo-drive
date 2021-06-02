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
    public partial class frmInvoiceDetails : Form
    {
        public frmInvoiceDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblStartTime_Click(object sender, EventArgs e)
        {

        }

        private void txtStartTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.Enter)
            {
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoicessss", frmMain.con);
                frmMain.da.Fill(frmMain.ds, "tblInvoicessss");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCuont = frmMain.ds.Tables["tblInvoicessss"].Rows.Count;
                while (currentRow < rowCuont)
                {
                    if (txtInvoiceNo.Text == frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[0].ToString())
                    {
                        txtInvoiceType.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[21].ToString();
                        txtCustomerName.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[1].ToString();
                        txtAddress.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[4].ToString();
                        txtContact.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[3].ToString();
                        txtStartDate.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[6].ToString();
                        txtStartKm.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[10].ToString();
                        txtEndDate.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[7].ToString();
                        txtEndKm.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[11].ToString();
                        txtVehicleNo.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[5].ToString();
                        txtIssuedUser.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[18].ToString();
                        txtStartTime.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[8].ToString();
                        txtEndTime.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[9].ToString();
                        txtWeightngHours.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[12].ToString();
                        txtOverNights.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[14].ToString();
                        txtExtraKmChage.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[13].ToString();
                        txtTotalBillValue.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[16].ToString();
                        txtAdvancePay.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[15].ToString();
                        txtTotalPayble.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[17].ToString();
                        txtDriverStatment.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[19].ToString();
                        break;
                        
                    }
                    
                    currentRow++;
                }
            }
        }

        private void frmInvoiceDetails_Load(object sender, EventArgs e)
        {
            frmMain.ds.Clear();
            frmMain.ds1.Clear();
            libPendingBills.Items.Clear();
            txtInvoiceNo.Text = Commons.SearchVehicleInvoiceNo;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoicessss WHERE TotalRentValue = ''", frmMain.con);
            frmMain.da.Fill(frmMain.ds1, "tblInvoicessss");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCuont = frmMain.ds1.Tables["tblInvoicessss"].Rows.Count;
            while (currentRow < rowCuont)
            {
                libPendingBills.Items.Add(frmMain.ds1.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[0].ToString());
                currentRow++;
            }
        }

        private void libPendingBills_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInvoiceNo.Text = libPendingBills.SelectedItem.ToString();
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {

            frmMain.ds.Clear();
            txtInvoiceType.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtStartDate.Text = "";
            txtStartKm.Text = "";
            txtEndDate.Text = "";
            txtEndKm.Text = "";
            txtVehicleNo.Text = "";
            txtIssuedUser.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
            txtWeightngHours.Text = "";
            txtOverNights.Text = "";
            txtExtraKmChage.Text = "";
            txtTotalBillValue.Text = "";
            txtAdvancePay.Text = "";
            txtTotalPayble.Text = "";
            txtDriverStatment.Text = "";
        }

        private void txtInvoiceType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
