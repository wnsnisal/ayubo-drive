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
    public partial class frmDayTowerHire : Form
    {
        public frmDayTowerHire()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDayTowerHire_Load(object sender, EventArgs e)
        {
            txtInvoiceType.Text = "Day Tour Hire";
            txtAdvancePayment.Enabled = false;
            txtCustomerName.Enabled = false;
            txtIssuedUser.Text = Commons.LogedUser;
            frmMain.ds.Clear();
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblVehicles WHERE availability = 'Available'", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblVehicles");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCuont = frmMain.ds.Tables["tblVehicles"].Rows.Count;
            while (currentRow < rowCuont)
            {
                libVehicleNo.Items.Add(frmMain.ds.Tables["tblVehicles"].Rows[currentRow].ItemArray[0].ToString());
                currentRow++;

            }
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoicessss", frmMain.con);
            frmMain.da.Fill(frmMain.ds1, "tblInvoicessss");
            frmMain.con.Close();
            int currentRow1 = 0;
            int rowcount1 = frmMain.ds1.Tables["tblInvoicessss"].Rows.Count;
            while (currentRow1 < rowcount1)
            {
                int a = Convert.ToInt32(frmMain.ds1.Tables["tblInvoicessss"].Rows[currentRow1].ItemArray[0].ToString()) + 1;
                txtInvoiceNo.Text = a.ToString();
                currentRow1++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            frmMain.ds1.Clear();
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblInvoicessss SET EndDate = '" + dtmEndTime.Text + "', TotalRentValue = '" + txtTotalDTHValue.Text + "' WHERE InvoiceNo = '" + txtRiceptNo.Text + "' ";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();

            if (txtTotalDTHValue.Text == "")
            {
                MessageBox.Show("please calculate the total day tour hire value", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                Commons.InvoiceNo = txtInvoiceNo.Text;
                Commons.CustomerName = txtCustomerName.Text;
                Commons.Contact = txtTPNumber.Text;
                Commons.Address = txtAddress.Text;
                Commons.VehicleNo = txtVehicleNo.Text;
                Commons.StartTime = dtmStartTime.Value;
                Commons.EndTime = dtmEndTime.Value;
                Commons.TotalRentValue = txtTotalDTHValue.Text;
                Commons.AdvancePayment = txtAdvancePayment.Text;

                frmDayTourHireInvoice DTHInvoice = new frmDayTourHireInvoice();
                DTHInvoice.ShowDialog();

                frmMain.con.ConnectionString = Commons.DB_CON;
                frmMain.cmd.Connection = frmMain.con;
                frmMain.cmd.CommandText = "UPDATE tblVehicles SET availability = 'Available' WHERE VehicleNo = '" + txtVehicleNo.Text + "'";
                frmMain.con.Open();
                frmMain.cmd.ExecuteNonQuery();
                frmMain.con.Close();
            }
            Close();
        }

        private void btnSaveDraftandPrintRecept_Click(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblCustomers", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblCustomers");
            frmMain.con.Close();

            int CurrentRow = 0;
            int RowCount = frmMain.ds.Tables["tblCustomers"].Rows.Count;
            while (CurrentRow < RowCount)
            {
                if (txtCustomerName.Text == frmMain.ds.Tables["tblCustomers"].Rows[CurrentRow].ItemArray[1].ToString())
                {
                    frmRicept Ricept = new frmRicept();
                    Ricept.ShowDialog();

                    frmMain.con.ConnectionString = Commons.DB_CON;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblInvoicessss(CustomerName,CustomerId,ContactNo,Address,VehicleNo,StartDate,StartTime,StartKm,AdvancePayment,TotalRentValue,IssuedUser,DriverStatment,PackageKm,InvoiceType) VALUES('" + txtCustomerName.Text + "','" + txtCustomerid.Text + "','" + txtTPNumber.Text + "','" + txtAddress.Text + "','" + txtVehicleNo.Text + "','"+dtmInvoiceDate.Text+"','" + dtmStartTime.Text + "','"+ txtStartKm.Text +"','" + txtAdvancePayment.Text + "','" + txtTotalDTHValue.Text + "','" + txtIssuedUser.Text + "','WithDriver','"+ cmbPackage.Text +"','" + txtInvoiceType.Text + "')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    Commons.InvoiceNo = txtInvoiceNo.Text;
                    Commons.CustomerName = txtCustomerName.Text;
                    Commons.Contact = txtTPNumber.Text;
                    Commons.Address = txtAddress.Text;
                    Commons.VehicleNo = txtVehicleNo.Text;
                    Commons.StartTime = dtmStartTime.Value;
                    Commons.EndTime = dtmEndTime.Value;
                    Commons.InvoiceType = txtInvoiceType.Text;
                    Commons.AdvancePayment = txtAdvancePayment.Text;
                    Commons.PackageKm = cmbPackage.SelectedText;
                    Commons.InvoiceDate = dtmInvoiceDate.Text;

                    frmMain.con.ConnectionString = Commons.DB_CON;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "UPDATE tblVehicles SET availability = 'NotAvailable' WHERE vehicleNo ='" + txtVehicleNo.Text + "'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();
                    
                    Close();
                    break;
                }
                CurrentRow++;
            }
            
            
        }

        private void btnClaculateTotal_Click(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPackages", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblPackages");
            frmMain.con.Close();
            int PackageKm = 0;

            if (cmbPackage.SelectedItem.ToString() == "Package01(100Km)")
            {
                Commons.PackageKm = "100";
            }
            else
            {
                if (cmbPackage.SelectedItem.ToString() == "Package02(200Km)")
                {
                    Commons.PackageKm = "100";
                }
            }

            int rateForHours = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[1].ItemArray[4].ToString());
            int weightingHourRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[1].ItemArray[7].ToString());
            int rateForExtraKm = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[1].ItemArray[5].ToString());
            int dayMaxHours = 12;

            TimeSpan ts = dtmEndTime.Value - dtmStartTime.Value;
            int totalHours = ts.Hours;
            

            /*DateTime starTime = Convert.ToDateTime((dtmStartTime.Text).ToString());
            
            DateTime endTime = Convert.ToDateTime((dtmEndTime.Text).ToString());

            int totalHours = Convert.ToInt32((endTime - starTime).TotalHours.ToString());
            */

            int startKm = Convert.ToInt32((txtStartKm.Text).ToString());
            int endKm = Convert.ToInt32((txtEndKm.Text).ToString());
            
            int totalKm = endKm - startKm;
            int packageKm = Convert.ToInt32((Commons.PackageKm).ToString());
            
            if (totalHours > dayMaxHours)
            {
                int weightiongHours = totalHours - dayMaxHours;
                if(totalKm > packageKm)
                {
                    int extraKm = totalKm - Convert.ToInt32((packageKm).ToString());

                    int totalExtreKmChage = extraKm * rateForExtraKm;
                    int totalWeightingHoursChage = weightiongHours * weightingHourRate;
                    int totalDayTourHireValue = totalHours * rateForHours + totalExtreKmChage + totalWeightingHoursChage;

                    txtTotalExtraKmChage.Text = Convert.ToString(totalExtreKmChage);
                    txtTotalWeitingChage.Text = Convert.ToString(totalWeightingHoursChage);
                    txtTotalDTHValue.Text = Convert.ToString(totalDayTourHireValue);
                }
                else
                {
                    int extraKm = 0;

                    int totalExtreKmChage = extraKm * rateForExtraKm;
                    int totalWeightingHoursChage = weightiongHours * weightingHourRate;
                    int totalDayTourHireValue = totalHours * rateForHours + totalExtreKmChage + totalWeightingHoursChage;

                    txtTotalExtraKmChage.Text = Convert.ToString(totalExtreKmChage);
                    txtTotalWeitingChage.Text = Convert.ToString(totalWeightingHoursChage);
                    txtTotalDTHValue.Text = Convert.ToString(totalDayTourHireValue);
                }
            }
            else
            {
                int weightiongHours = 0;
                if (totalKm > packageKm)
                {
                    int extraKm = totalKm - Convert.ToInt32((packageKm).ToString());

                    int totalExtreKmChage = extraKm * rateForExtraKm;
                    int totalWeightingHoursChage = weightiongHours * weightingHourRate;
                    int totalDayTourHireValue = totalHours * rateForHours + totalExtreKmChage + totalWeightingHoursChage;

                    txtTotalExtraKmChage.Text = Convert.ToString(totalExtreKmChage);
                    txtTotalWeitingChage.Text = Convert.ToString(totalWeightingHoursChage);
                    txtTotalDTHValue.Text = Convert.ToString(totalDayTourHireValue);
                }
                else
                {
                    int extraKm = 0;

                    int totalExtreKmChage = extraKm * rateForExtraKm;
                    int totalWeightingHoursChage = weightiongHours * weightingHourRate;
                    int totalDayTourHireValue = totalHours * rateForHours + totalExtreKmChage + totalWeightingHoursChage;

                    txtTotalExtraKmChage.Text = Convert.ToString(totalExtreKmChage);
                    txtTotalWeitingChage.Text = Convert.ToString(totalWeightingHoursChage);
                    txtTotalDTHValue.Text = Convert.ToString(totalDayTourHireValue);
                }
            }

            

            
        }

        /*private void txtRiceptNo_TextChanged(object sender, EventArgs e)
        {

        }*/

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSaveDraftandPrintRecept.Enabled = true;
            dtmStartTime.Enabled = true;
            libVehicleNo.Enabled = true;
            dtmEndTime.Enabled = false;
            txtAdvancePayment.Enabled = true;
            txtCustomerName.Enabled = true;
            txtEndKm.Enabled = false;
            frmMain.ds.Clear();
            txtInvoiceNo.Text = "";
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoicessss", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblInvoicessss");
            frmMain.con.Close();
            int currentRow = 0;
            int rowcount = frmMain.ds1.Tables["tblInvoicessss"].Rows.Count;
            while (currentRow < rowcount)
            {
                int a = Convert.ToInt32(frmMain.ds1.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[0].ToString()) + 1;
                txtInvoiceNo.Text = a.ToString();
                currentRow++;
            }
            txtCustomerName.Text = "";
            txtCustomerid.Text = "";
            txtTPNumber.Text = "";
            txtAddress.Text = "";
            txtVehicleNo.Text = "";
            dtmStartTime.Text = "";
            dtmEndTime.Text = "";
            txtTotalDTHValue.Text = "";
            txtAdvancePayment.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblCustomers", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblCustomers");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCuont = frmMain.ds.Tables["tblCustomers"].Rows.Count;
            while (currentRow < rowCuont)
            {
                if (txtCustomerName.Text == frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[1].ToString())
                {
                    txtCustomerid.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[0].ToString();
                    txtTPNumber.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[5].ToString();

                    String street = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[4].ToString();
                    String city = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[3].ToString();
                    String country = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[2].ToString();
                    String address = street + "," + city + "," + country;
                    txtAddress.Text = address;
                    break;

                }
                else
                {
                    txtCustomerid.Text = "";
                    txtTPNumber.Text = "";
                    txtAddress.Text = "";
                }
                currentRow++;


            }
        }

        //private void txtRiceptNo(object sender, EventArgs e)
        //{

        //}

        private void txtRiceptNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoicessss", frmMain.con);
                frmMain.da.Fill(frmMain.ds, "tblInvoicessss");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCuont = frmMain.ds.Tables["tblInvoicessss"].Rows.Count;
                while (currentRow < rowCuont)
                {
                    if (txtRiceptNo.Text == frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[0].ToString())
                    {
                        txtInvoiceType.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[21].ToString();
                        if (txtInvoiceType.Text == "Day Tour Hire")
                        {
                            txtInvoiceNo.Text = txtRiceptNo.Text;
                            txtCustomerName.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[1].ToString();
                            txtCustomerid.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[2].ToString();
                            txtTPNumber.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[3].ToString();
                            txtAddress.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[4].ToString();
                            txtVehicleNo.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[5].ToString();
                            txtIssuedUser.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[18].ToString();
                            dtmStartTime.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[8].ToString();
                            dtmEndTime.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[9].ToString();
                            txtTotalDTHValue.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[16].ToString();
                            txtAdvancePayment.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[15].ToString();
                            cmbPackage.SelectedItem = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[20].ToString();
                            txtStartKm.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[10].ToString();
                            txtEndKm.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[11].ToString();
                            txtTotalExtraKmChage.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[13].ToString();
                            txtTotalWeitingChage.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[12].ToString();
                            dtmInvoiceDate.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[6].ToString();
                        }
                        else
                        {
                            Close();
                            MessageBox.Show("this is not Day Tour Hire invoice", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            break;
                        }
                    }
                    currentRow++;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRiceptNo_KeyDown(object sender, EventArgs e)
        {

        }

        private void libVehicleNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtVehicleNo.Text = libVehicleNo.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("please select the valied invoice number", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtVehicleNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
