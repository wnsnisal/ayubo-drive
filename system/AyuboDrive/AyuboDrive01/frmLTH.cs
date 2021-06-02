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
    public partial class frmLTH : Form
    {
        public frmLTH()
        {
            InitializeComponent();
        }

        private void btnClaculateTotal_Click(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPackages", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblPackages");
            frmMain.con.Close();

            int ExtraKmRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[2].ItemArray[5].ToString());
            int DriverOverNightRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[2].ItemArray[6].ToString());
            int VehicleNightParkRate = 200;
            int dailyRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[2].ItemArray[3].ToString());
            DateTime EndDate = Convert.ToDateTime(dtmEndDate.Text);
            DateTime StartDate = Convert.ToDateTime(dtmStartDate.Text);
            int totalDays = Convert.ToInt32((EndDate - StartDate).TotalDays.ToString());
            try
            {
                if (cmbPackage.SelectedItem == "Package01(100Km)")
                {
                    int PackageKm = 100;
                    int totalKmforPackage = PackageKm * totalDays;
                    int totalKm = (Convert.ToInt32((txtEndKm.Text).ToString()) - Convert.ToInt32((txtEndKm.Text).ToString()));
                    if (totalKm > totalKmforPackage)
                    {
                        int totalExtraKmChage = (totalKm - totalKmforPackage) * ExtraKmRate;
                        int totalDriverOverNightChage = (totalDays - 1) * DriverOverNightRate;
                        int totalVehicleNightParkeChage = (totalDays - 1) * VehicleNightParkRate;
                        int totalLongTourHireChage = totalDays * dailyRate + totalExtraKmChage + totalVehicleNightParkeChage + 
                            totalDriverOverNightChage;

                        txtTotalExtraKmChage.Text = Convert.ToString(totalExtraKmChage);
                        txtVehicleNightParkChage.Text = Convert.ToString(totalVehicleNightParkeChage);
                        txtOverNightChage.Text = Convert.ToString(totalDriverOverNightChage);
                        txtLongTourHireValue.Text = Convert.ToString(totalLongTourHireChage);
                    }
                    else
                    {
                        if (totalKm < totalKmforPackage)
                        {
                            int totalExtraKmChage = 0;
                            int totalDriverOverNightChage = (totalDays - 1) * DriverOverNightRate;
                            int totalVehicleNightParkeChage = (totalDays - 1) * VehicleNightParkRate;
                            int totalLongTourHireChage = totalDays * dailyRate + totalExtraKmChage + totalVehicleNightParkeChage + 
                                totalDriverOverNightChage;

                            txtTotalExtraKmChage.Text = Convert.ToString(totalExtraKmChage);
                            txtVehicleNightParkChage.Text = Convert.ToString(totalVehicleNightParkeChage);
                            txtOverNightChage.Text = Convert.ToString(totalDriverOverNightChage);
                            txtLongTourHireValue.Text = Convert.ToString(totalLongTourHireChage);
                        }
                    }

                }
                else
                {
                    if (cmbPackage.SelectedItem == "Package02(200Km)")
                    {
                        int PackageKm = 200;
                        int totalKmforPackage = PackageKm * totalDays;
                        int totalKm = (Convert.ToInt32(txtEndKm.Text) - Convert.ToInt32(txtEndKm.Text));
                        if (totalKm > totalKmforPackage)
                        {
                            int totalExtraKmChage = (totalKm - totalKmforPackage) * ExtraKmRate;
                            int totalDriverOverNightChage = (totalDays - 1) * DriverOverNightRate;
                            int totalVehicleNightParkeChage = (totalDays - 1) * VehicleNightParkRate;
                            int totalLongTourHireChage = totalDays * dailyRate + totalExtraKmChage + totalVehicleNightParkeChage + 
                                totalDriverOverNightChage;

                            txtTotalExtraKmChage.Text = Convert.ToString(totalExtraKmChage);
                            txtVehicleNightParkChage.Text = Convert.ToString(totalVehicleNightParkeChage);
                            txtOverNightChage.Text = Convert.ToString(totalDriverOverNightChage);
                            txtLongTourHireValue.Text = Convert.ToString(totalLongTourHireChage);
                        }
                        else
                        {
                            if (totalKm < totalKmforPackage)
                            {
                                int totalExtraKmChage = 0;
                                int totalDriverOverNightChage = (totalDays - 1) * DriverOverNightRate;
                                int totalVehicleNightParkeChage = (totalDays - 1) * VehicleNightParkRate;
                                int totalLongTourHireChage = totalDays * dailyRate + totalExtraKmChage + 
                                    totalVehicleNightParkeChage + totalDriverOverNightChage;

                                txtTotalExtraKmChage.Text = Convert.ToString(totalExtraKmChage);
                                txtVehicleNightParkChage.Text = Convert.ToString(totalVehicleNightParkeChage);
                                txtOverNightChage.Text = Convert.ToString(totalDriverOverNightChage);
                                txtLongTourHireValue.Text = Convert.ToString(totalLongTourHireChage);
                            }
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("some inputs are invalid", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
        }

        private void frmLTH_Load(object sender, EventArgs e)
        {
            cmbPackage.Enabled = true;
            txtInvoiceType.Text = "Long Tour Hire";
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
            frmMain.ds1.Clear();
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

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            btnSaveDraftandPrintRecept.Enabled = true;
            dtmStartDate.Enabled = true;
            libVehicleNo.Enabled = true;
            dtmEndDate.Enabled = false;
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
            dtmStartDate.Text = "";
            dtmEndDate.Text = "";
            txtLongTourHireValue.Text = "";
            txtAdvancePayment.Text = "";
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

        private void txtReceptNo_KeyDown(object sender, KeyEventArgs e)
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
                    if (txtReceptNo.Text == frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[0].ToString())
                    {
                        txtInvoiceType.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[21].ToString();
                        if (txtInvoiceType.Text == "Long Tour Hire")
                        {
                            txtInvoiceNo.Text = txtReceptNo.Text;
                            txtCustomerName.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[1].ToString();
                            txtCustomerid.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[2].ToString();
                            txtTPNumber.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[3].ToString();
                            txtAddress.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[4].ToString();
                            txtVehicleNo.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[5].ToString();
                            txtIssuedUser.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[18].ToString();
                            dtmStartDate.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[6].ToString();
                            dtmEndDate.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[7].ToString();
                            txtLongTourHireValue.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[16].ToString();
                            txtAdvancePayment.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[15].ToString();
                            cmbPackage.SelectedItem = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[20].ToString();
                            txtStartKm.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[10].ToString();
                            txtEndKm.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[11].ToString();
                            txtTotalExtraKmChage.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[13].ToString();
                            txtOverNightChage.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[12].ToString();
                            break;
                        }
                    }
                    currentRow++;
                }
            }
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

        private void btnPrintBIll_Click(object sender, EventArgs e)
        {
            frmMain.ds1.Clear();
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblInvoicessss SET EndDate = '" + dtmEndDate.Text + "', TotalRentValue = '" + txtLongTourHireValue.Text + "' WHERE InvoiceNo = '" + txtReceptNo.Text + "' ";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();

            if (txtLongTourHireValue.Text == "")
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
                Commons.StartDate = dtmStartDate.Value;
                Commons.EndDate = dtmEndDate.Value;
                Commons.TotalRentValue = txtLongTourHireValue.Text;
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
            int RowCount = frmMain.ds.Tables["ttblCustomers"].Rows.Count;
            while (CurrentRow < RowCount)
            {
                if (txtCustomerName.Text == frmMain.ds.Tables["tblCustomers"].Rows[CurrentRow].ItemArray[1].ToString())
                {
                    frmRicept Ricept = new frmRicept();
                    Ricept.ShowDialog();

                    frmMain.con.ConnectionString = Commons.DB_CON;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblInvoicessss(CustomerName,CustomerId,ContactNo,Address,VehicleNo,StartDate,StratKm,AdvancePayment,TotalRentValue,IssuedUser,DriverStatment,PackageKm,InvoiceType) VALUES('" + txtCustomerName.Text + "','" + txtCustomerid.Text + "','" + txtTPNumber.Text + "','" + txtAddress.Text + "','" + txtVehicleNo.Text + "','" + dtmStartDate.Text + "','"+ txtStartKm.Text +"','" + txtAdvancePayment.Text + "','" + txtLongTourHireValue.Text + "','" + txtIssuedUser.Text + "','WithDriver','"+ cmbPackage.Text +"','" + txtInvoiceType.Text + "')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();

                    Commons.InvoiceNo = txtInvoiceNo.Text;
                    Commons.CustomerName = txtCustomerName.Text;
                    Commons.Contact = txtTPNumber.Text;
                    Commons.Address = txtAddress.Text;
                    Commons.VehicleNo = txtVehicleNo.Text;
                    Commons.StartDate = dtmStartDate.Value;
                    Commons.EndDate = dtmEndDate.Value;
                    Commons.InvoiceType = txtInvoiceType.Text;
                    Commons.AdvancePayment = txtAdvancePayment.Text;
                    Commons.PackageKm = cmbPackage.SelectedText;
                    

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

        private void txtReceptNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
