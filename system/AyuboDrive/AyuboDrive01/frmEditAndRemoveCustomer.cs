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
    public partial class frmEditAndRemoveCustomer : Form
    {
        public frmEditAndRemoveCustomer()
        {
            InitializeComponent();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "DELETE FROM tblCustomers WHERE CustomerName = '" + libCustomers.SelectedItem + "'";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void libCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblCustomers", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblCustomers");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds.Tables["tblCustomers"].Rows.Count;
            while (currentRow < rowCount)
            {

                try
                {
                    if (libCustomers.SelectedItem.ToString() == frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[1].ToString())
                    {
                        txtCustomerId.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[0].ToString();
                        txtCustomerName.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[1].ToString();
                        txtCountry.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[2].ToString();
                        txtCity.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[3].ToString();
                        txtStreert.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[4].ToString();
                        txtContact.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[5].ToString();
                        break;
                    }
                    currentRow++;
                }
                catch
                {
                    MessageBox.Show("Select the customer name", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                
                


            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            libCustomers.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCustomerName.Text == "" | txtCountry.Text == "" | txtCity.Text == "" | txtStreert.Text == "" | txtContact.Text == "")
            {
                MessageBox.Show("Please Type Mandatory Fields", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmMain.cmd.CommandText = "UPDATE tblCustomers SET CustomerName = '" + txtCustomerName.Text + "', Cuntry = '" + txtCountry.Text + "', City = '" + txtCity.Text + "', street = '" + txtStreert.Text + "', TPNo = '" + txtContact.Text + "'";
                frmMain.con.Open();
                frmMain.cmd.ExecuteNonQuery();
                frmMain.con.Close();
                Close();
            }
            
            
             
        }

        private void frmEditAndRemoveCustomer_Load(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblCustomers", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblCustomers");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds.Tables["tblCustomers"].Rows.Count;
            while(currentRow < rowCount)
            {
                if (Commons.RentedCustomers == frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[1].ToString())
                {
                    txtCustomerId.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[0].ToString();
                    txtCustomerName.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[1].ToString();
                    txtCountry.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[2].ToString();
                    txtCity.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[3].ToString();
                    txtStreert.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[4].ToString();
                    txtContact.Text = frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[5].ToString();
                }
                currentRow++;
            }
            
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
