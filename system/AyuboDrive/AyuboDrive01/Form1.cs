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
    public partial class frmMain : Form
    {
        

        public static System.Data.SqlClient.SqlConnection
            con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlCommand
            cmd = new System.Data.SqlClient.SqlCommand();
        public static System.Data.SqlClient.SqlDataAdapter
            da = new System.Data.SqlClient.SqlDataAdapter();

        public static DataSet ds = new DataSet();
        public static DataSet ds1 = new DataSet();
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void normalRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormalRent NormalRent = new frmNormalRent();
            NormalRent.ShowDialog();
        }

        private void userToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void dayToureRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDayTowerHire DayTowerHire = new frmDayTowerHire();
            DayTowerHire.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmLogin Login = new frmLogin();
            if (Login.ShowDialog() == DialogResult.OK)
            {
                if (Loged.UserType == "Administrator")
                {
                    mnuLogout.Enabled = true;
                    mnuAddUser.Enabled = true;
                    mnuAddCustomer.Enabled = true;
                    mnuEditAndRemoveUser.Enabled = true;
                    mnuAddUser.Enabled = true;
                    mnuDayTourHire.Enabled = true;
                    mnuLongTourHire.Enabled = true;
                    mnuNormalRent.Enabled = true;
                    mnuEditRemoveCustomer.Enabled = true;
                    mnuReports.Enabled = true;
                    mnuSearchVehicle.Enabled = true;
                    mnuSearchCustomer.Enabled = true;
                    mnuAddVehicleNew.Enabled = true;
                    mnuLogin.Enabled = false;
                    mnuInvoiceDetails.Enabled = true;
                }
                else
                {
                    if (Loged.UserType == "User")
                    {
                        mnuLogout.Enabled = true;
                        mnuAddUser.Enabled = false;
                        mnuAddCustomer.Enabled = true;
                        mnuEditAndRemoveUser.Enabled = false;
                        mnuAddUser.Enabled = false;
                        mnuDayTourHire.Enabled = true;
                        mnuLongTourHire.Enabled = true;
                        mnuNormalRent.Enabled = true;
                        mnuEditRemoveCustomer.Enabled = false;
                        mnuReports.Enabled = false;
                        mnuSearchVehicle.Enabled = false;
                        mnuSearchCustomer.Enabled = true;
                        mnuAddVehicleNew.Enabled = false;
                        mnuLogin.Enabled = false;

                    }

                }
            }
                

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser AddUser = new frmAddUser();
            AddUser.ShowDialog();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditUser EditUser = new frmEditUser();
            EditUser.ShowDialog();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAndRemoveUser EditAndRemoveUser = new frmEditAndRemoveUser();
            EditAndRemoveUser.ShowDialog();
        }

        private void longTourRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLTH LongToureHire = new frmLTH();
            LongToureHire.ShowDialog();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            mnuLogout.Enabled = false;
            mnuAddUser.Enabled = false;
            mnuAddCustomer.Enabled = false;
            mnuEditAndRemoveUser.Enabled = false;
            mnuAddUser.Enabled = false;
            mnuDayTourHire.Enabled = false;
            mnuLongTourHire.Enabled = false;
            mnuNormalRent.Enabled = false;
            mnuEditRemoveCustomer.Enabled = false;
            mnuReports.Enabled = false;
            mnuSearchCustomer.Enabled = false;
            mnuSearchVehicle.Enabled = false;
            mnuAddVehicleNew.Enabled = false;
            mnuLogin.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            IsMdiContainer = true;
            con.ConnectionString = "Data Source=DESKTOP-T5BVRGF;Initial Catalog=AyuboDriveDB;Integrated Security=True;Pooling=False";
            cmd.Connection = con;

        }

        private void mnuAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer AddCustomer = new frmAddCustomer();
            AddCustomer.ShowDialog();
        }

        private void mnuEditRemoveCustomer_Click(object sender, EventArgs e)
        {
            frmEditAndRemoveCustomer EditAndRemoveCustomer = new frmEditAndRemoveCustomer();
            EditAndRemoveCustomer.ShowDialog();
        }

        private void mnuSearchCustomer_Click(object sender, EventArgs e)
        {
            frmSearchCustomer SearchCustomer = new frmSearchCustomer();
            SearchCustomer.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuSearchVehicle_Click(object sender, EventArgs e)
        {
            frmSearchVehicle SearchVehicle = new frmSearchVehicle();
            SearchVehicle.ShowDialog();
            
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVehicle addVehicle = new frmAddVehicle();
            addVehicle.ShowDialog();
        }

        private void mnuInvoiceDetails_Click(object sender, EventArgs e)
        {
            frmInvoiceDetails InvoiceDetails = new frmInvoiceDetails();
            InvoiceDetails.ShowDialog();
        }
    }
}
