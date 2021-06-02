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
    public partial class frmNormalRent : Form
    {
        
        public frmNormalRent()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSaveDraftandPrintReceipt.Enabled = true;
            rdoWithDriver.Enabled = true;
            rdoWithoutDriver.Enabled = true;
            dtmStartDate.Enabled = true;
            libVehicleNo.Enabled = true;
            dtmEndDate.Enabled = false;
            txtAdvancePayment.Enabled = true;
            txtCustomerName.Enabled = true;
            frmMain.ds.Clear();
            txtInvoiceNo.Text = "";
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoicessss",frmMain.con);
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
            txtTotalRentValue.Text = "";
            txtAdvancePayment.Text = "";

            
        }

        private void btnSaveDraftandPrintReceipt_Click(object sender, EventArgs e)
        {

            frmMain.ds.Clear();
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblCustomers", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblCustomers");
            frmMain.con.Close();

            int CurrentRow = 0;
            int RowCount = frmMain.ds.Tables["tblCustomers"].Rows.Count;
            while(CurrentRow < RowCount)
            {
                if (txtCustomerName.Text == frmMain.ds.Tables["tblCustomers"].Rows[CurrentRow].ItemArray[1].ToString())
                {
                    if (rdoWithDriver.Checked == true)
                    {
                        Commons.DriverStatment = "WithDriver";
                    }
                    else
                    {
                        if (rdoWithoutDriver.Checked == true)
                        {
                            Commons.DriverStatment = "WithOutDriver";
                        }
                    }

                    String DriverStatment = Commons.DriverStatment;
                    frmMain.con.ConnectionString = Commons.DB_CON;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblInvoicessss(CustomerName,CustomerId,ContactNo,Address,VehicleNo,StartDate,AdvancePayment,TotalRentValue,IssuedUser,DriverStatment,InvoiceType) VALUES('" + txtCustomerName.Text + "','" + txtCustomerid.Text + "','" + txtTPNumber.Text + "','" + txtAddress.Text + "','" + txtVehicleNo.Text + "','" + dtmStartDate.Text + "','" + txtAdvancePayment.Text + "','" + txtTotalRentValue.Text + "','" + txtIssuedUser.Text + "','" + DriverStatment + "','" + txtInvoiceType.Text + "')";
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
            frmRicept Ricept = new frmRicept();
            Ricept.ShowDialog();

        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            
            frmMain.ds1.Clear();
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblInvoicessss SET EndDate = '"+dtmEndDate.Text+"', TotalRentValue = '"+txtTotalRentValue.Text+ "' WHERE InvoiceNo = '"+ txtReceptNo.Text+"' ";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();


            if (txtTotalRentValue.Text == "")
            {
                MessageBox.Show("please calculate the total rent value", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Commons.TotalRentValue = txtTotalRentValue.Text;
                Commons.AdvancePayment = txtAdvancePayment.Text;

                frmRentInvoice Invoice = new frmRentInvoice();
                Invoice.ShowDialog();

                frmMain.con.ConnectionString = Commons.DB_CON;
                frmMain.cmd.Connection = frmMain.con;
                frmMain.cmd.CommandText = "UPDATE tblVehicles SET availability = 'Available' WHERE VehicleNo = '"+txtVehicleNo.Text+"'";
                frmMain.con.Open();
                frmMain.cmd.ExecuteNonQuery();
                frmMain.con.Close(); 
            }
            Close();
        }

        private void btnClaculateTotal_Click(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblPackages", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblPackages");
            frmMain.con.Close();

            try
            {
                if (rdoWithDriver.Checked == true)
                {

                    int withDriverRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[0].ItemArray[8].ToString());
                    int dalyRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[0].ItemArray[3].ToString());
                    int weeklyRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[0].ItemArray[2].ToString());


                    DateTime startDate = Convert.ToDateTime(dtmStartDate.Text);
                    DateTime endDate = Convert.ToDateTime(dtmEndDate.Text);

                    double TotalRentDays = Convert.ToDouble((endDate - startDate).TotalDays.ToString());

                    if (TotalRentDays < 7)
                    {
                        int totalWeeks = 0;
                        int totalDays = Convert.ToInt32(TotalRentDays);
                        int TotalRentValue = (totalWeeks * weeklyRate) + (totalDays * dalyRate) + (withDriverRate * 
                            totalWeeks) + (withDriverRate * totalDays);
                        txtTotalRentValue.Text = Convert.ToString(TotalRentValue);
                    }
                    else
                    {
                        if (TotalRentDays > 7)
                        {
                            int totalWeeks = Convert.ToInt32(Math.Floor(TotalRentDays / 7));
                            int totalDays = Convert.ToInt32(TotalRentDays) % 7;
                            int TotalRentValue = (totalWeeks * weeklyRate) + (totalDays * dalyRate) + (withDriverRate * 
                                totalWeeks) + (withDriverRate * totalDays);
                            txtTotalRentValue.Text = Convert.ToString(TotalRentValue);
                        }
                    }
                }
                else
                {
                    if (rdoWithoutDriver.Checked == true)
                    {

                        int withDriverRate = 0;
                        int dalyRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[0].ItemArray[3].ToString());
                        int weeklyRate = Convert.ToInt32(frmMain.ds.Tables["tblPackages"].Rows[0].ItemArray[2].ToString());


                        DateTime startDate = Convert.ToDateTime(dtmStartDate.Text);
                        DateTime endDate = Convert.ToDateTime(dtmEndDate.Text);

                        double TotalRentDays = Convert.ToDouble((endDate - startDate).TotalDays.ToString());

                        if (TotalRentDays < 7)
                        {
                            int totalWeeks = 0;
                            int totalDays = Convert.ToInt32(TotalRentDays);
                            int TotalRentValue = (totalWeeks * weeklyRate) + (totalDays * dalyRate) + (withDriverRate * 
                                totalWeeks) + (withDriverRate * totalDays);
                            txtTotalRentValue.Text = Convert.ToString(TotalRentValue);
                        }
                        else
                        {
                            if (TotalRentDays > 7)
                            {
                                int totalWeeks = Convert.ToInt32(Math.Floor(TotalRentDays / 7));
                                int totalDays = Convert.ToInt32(TotalRentDays) % 7;
                                int TotalRentValue = (totalWeeks * weeklyRate) + (totalDays * dalyRate) + (withDriverRate * 
                                    totalWeeks) + (withDriverRate * totalDays);
                                txtTotalRentValue.Text = Convert.ToString(TotalRentValue);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("invalid date", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
        }

        private void rdoWithDriver_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoWithoutDriver_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmNormalRent_Load(object sender, EventArgs e)
        {
            txtInvoiceType.Text = "Rent";
            txtAdvancePayment.Enabled = false;
            txtCustomerName.Enabled = false;
            txtIssuedUser.Text = Commons.LogedUser;
            frmMain.ds.Clear();
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblVehicles WHERE availability = 'Available'", frmMain.con);
            frmMain.da.Fill(frmMain.ds,"tblVehicles");    
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
                int a = Convert.ToInt32(frmMain.ds1.Tables["tblInvoicessss"].Rows[currentRow1].ItemArray[0].ToString())+1;
                txtInvoiceNo.Text = a.ToString();
                currentRow1++;
            }
            
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
                if(txtCustomerName.Text == frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[1].ToString())
                {
                    txtCustomerid.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[0].ToString();
                    txtTPNumber.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[5].ToString();

                    string street = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[4].ToString();
                    string city = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[3].ToString();
                    string country = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[2].ToString();
                    string address = street+ "," + city + "," + country;
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

        private void libVehicleNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtVehicleNo.Text = libVehicleNo.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("please select the valied invoice number","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRiceptNo_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void lblInvoiceType_Click(object sender, EventArgs e)
        {

        }

        private void txtVehicleNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRiceptNo_KeyDown(object sender, KeyEventArgs e)
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
                    if (txtReceptNo.Text == frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[0].ToString())
                    {
                        txtInvoiceType.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[21].ToString();
                        if (txtInvoiceType.Text == "Rent")
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
                            txtTotalRentValue.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[16].ToString();
                            txtAdvancePayment.Text = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[15].ToString();
                            Commons.DriverStatment = frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[19].ToString();

                            if (Commons.DriverStatment == "WithDriver")
                            {
                                rdoWithoutDriver.Checked = false;
                                rdoWithDriver.Checked = true;
                            }
                            else
                            {
                                if(Commons.DriverStatment == "WithOutDriver")
                                {
                                    rdoWithoutDriver.Checked = true;
                                    rdoWithDriver.Checked = false;
                                }
                            }
                        }
                        else
                        {
                            
                            MessageBox.Show("this is not rent invoice","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            
                            break;
                        }
                    }
                    currentRow++;
                }
            }
        }

       private void txtRiceptNo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtReceptNo_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
           // this.BackColor = System.Drawing.Color.Black;
        //}
    }
}
