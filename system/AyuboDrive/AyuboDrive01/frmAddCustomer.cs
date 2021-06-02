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
    public partial class frmAddCustomer : Form
    {
        

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" | txtCountry.Text == "" | txtCity.Text == "" | txtStreert.Text == "" | txtContact.Text == "")
            {
                MessageBox.Show("please fill mandatory fields", "details missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                frmMain.con.ConnectionString = "Data Source=DESKTOP-T5BVRGF;Initial Catalog=AyuboDriveDB;Integrated Security=True;Pooling=False";
                frmMain.cmd.Connection = frmMain.con;
                frmMain.cmd.CommandText = "INSERT INTO tblCustomers(CustomerName, Cuntry, City, Street, TPNo) VALUES('"+txtCustomerName.Text+"','"+txtCountry.Text+"','"+txtCity.Text+"','"+txtStreert.Text+"','"+txtContact.Text+"')";
                frmMain.con.Open();
                frmMain.cmd.ExecuteNonQuery();
                frmMain.con.Close();
                Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            
            pnlAddCustomer.Enabled = true;
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblCustomers", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblCustomers");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds.Tables["tblCustomers"].Rows.Count;
            while (currentRow<rowCount)
            {
                int A = Convert.ToInt32(frmMain.ds.Tables["tblCustomers"].Rows[currentRow].ItemArray[0].ToString()) + 1;
                txtCustomerId.Text = A.ToString();
                currentRow++;
                
            }
            frmMain.ds.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAddCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void txtStreert_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStreet_Click(object sender, EventArgs e)
        {

        }

        private void lblAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCustomerId_Click(object sender, EventArgs e)
        {

        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
