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
    public partial class frmAddVehicle : Form
    {
        public frmAddVehicle()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            pnlVehicle.Enabled = true;
            btnSave.Enabled = true;
            
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtVehicleNo.Text == "")
            {
                MessageBox.Show("Type the vehicle number", "vehicle number is riqured",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                frmMain.con.ConnectionString = Commons.DB_CON;
                frmMain.cmd.Connection = frmMain.con;
                frmMain.cmd.CommandText = "INSERT INTO tblVehicles(vehicleNo, availability) VALUES('" + Convert.ToInt32(txtVehicleNo.Text) + "', 'Available')";
                frmMain.con.Open();
                frmMain.cmd.ExecuteNonQuery();
                frmMain.con.Close();
                Close();
            }
        }

        private void frmAddVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
