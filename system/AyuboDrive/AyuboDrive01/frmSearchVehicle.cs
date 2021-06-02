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
    public partial class frmSearchVehicle : Form
    {
        public frmSearchVehicle()
        {
            InitializeComponent();
        }

        private void pnlSearchVehicle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            libVehicles.ClearSelected();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearchVehicles_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you need to delete this vehicle?", "Conform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain.con.ConnectionString = Commons.DB_CON;
                frmMain.cmd.Connection = frmMain.con;
                frmMain.cmd.CommandText = "DELETE FROM tblVehicles WHERE vehicleNo = '" + libVehicles.SelectedItem + "'";
                frmMain.con.Open();
                frmMain.cmd.ExecuteNonQuery();
                frmMain.con.Close();
                Close();
            }
        }

        private void frmSearchVehicle_Load(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblVehicles", frmMain.con);
            frmMain.da.Fill(frmMain.ds1, "tblVehicles");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds1.Tables["tblVehicles"].Rows.Count;
            while(currentRow < rowCount)
            {
                libVehicles.Items.Add(frmMain.ds1.Tables["tblVehicles"].Rows[currentRow].ItemArray[0].ToString());
                currentRow++;
            }
            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            libVehicles.Items.Clear();
        }

        private void libVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.ds.Clear();
            frmMain.ds1.Clear();
            libRentedCustomers.Items.Clear();
            libInvoiceRegardingVehicle.Items.Clear();

            

            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoicessss WHERE VehicleNo = '" + libVehicles.SelectedItem + "' ORDER BY InvoiceNo", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblInvoicessss");
            frmMain.con.Close();

            
                int currentRow = 0;
                int rowCount = frmMain.ds.Tables["tblInvoicessss"].Rows.Count;
                while (currentRow < rowCount)
                {
                try
                {
                    if (frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[5].ToString().Contains(libVehicles.SelectedItem.ToString()))
                    {
                        

                        libInvoiceRegardingVehicle.Items.Add(frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[0].ToString());

                        libRentedCustomers.Items.Add(frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[1].ToString());
                        
                    }
                    
                }
                catch
                {
                    break;
                }
                currentRow++;
            }

            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblVehicles", frmMain.con);
            frmMain.da.Fill(frmMain.ds1, "tblVehicles");
            frmMain.con.Close();

            int currentRow1 = 0;
            int rowCount1 = frmMain.ds1.Tables["tblVehicles"].Rows.Count;
            while (currentRow1 < rowCount1)
            {
                try
                {
                    if (frmMain.ds1.Tables["tblVehicles"].Rows[currentRow1].ItemArray[0].ToString().Contains(libVehicles.SelectedItem.ToString()))
                    {
                        txtAvilability.Text = frmMain.ds1.Tables["tblVehicles"].Rows[currentRow1].ItemArray[1].ToString();
                    }
                    
                }
                catch
                {
                    break;
                }
                currentRow1++;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void libInvoiceRegardingVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                frmMain.ds.Clear();
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoicessss", frmMain.con);
                frmMain.da.Fill(frmMain.ds, "tblInvoicessss");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.ds.Tables["tblInvoicessss"].Rows.Count;
                while (currentRow < rowCount)
                {
                    if (frmMain.ds.Tables["tblInvoicessss"].Rows[currentRow].ItemArray[0].ToString().Contains(libInvoiceRegardingVehicle.SelectedItem.ToString()))
                    {

                        frmInvoiceDetails InvoiceDetails = new frmInvoiceDetails();
                        InvoiceDetails.ShowDialog();
                        Commons.SearchVehicleInvoiceNo = libInvoiceRegardingVehicle.SelectedItem.ToString();
                        break;
                    }
                    
                    currentRow++;
                    
                }
            }
            catch
            {
                MessageBox.Show("invalide selected", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            
        }

        private void libRentedCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmEditAndRemoveCustomer EditAndRemoveCustomer = new frmEditAndRemoveCustomer();
            EditAndRemoveCustomer.ShowDialog();
            Commons.RentedCustomers = libRentedCustomers.SelectedItem.ToString();
        }
    }
}
