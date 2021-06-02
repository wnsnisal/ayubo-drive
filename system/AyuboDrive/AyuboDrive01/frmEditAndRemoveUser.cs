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
    public partial class frmEditAndRemoveUser : Form
    {
        
        public frmEditAndRemoveUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void frmEditAndRemoveUser_Load(object sender, EventArgs e)
        {
            frmMain.ds.Clear();

            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblUser");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds.Tables["tblUser"].Rows.Count;
            while (currentRow < rowCount)
            {
                libUsers.Items.Add(frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString());
                currentRow++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void libUsers_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            libUsers.Items.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEditAndRemoveUser_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you need to delete this user?", "Conform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain.con.ConnectionString = Commons.DB_CON;
                frmMain.cmd.Connection = frmMain.con;
                frmMain.cmd.CommandText = "DELETE FROM tblUser WHERE FullName = '" + libUser.SelectedItem + "'";
                frmMain.con.Open();
                frmMain.cmd.ExecuteNonQuery();
                frmMain.con.Close();
                Close();
            }
        }

        private void cmb_User_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveAndUpdate(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void libUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_CON;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblUser");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds.Tables["tblUser"].Rows.Count;
            while (currentRow < rowCount)
            {
                try
                {
                    if (libUser.SelectedItem.ToString() == frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString())
                    {
                        txtuserFullName.Text = frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString();
                        txtAddresss.Text = frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[2].ToString();
                        txtContacts.Text = frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[3].ToString();
                        txtEmplyeeId.Text = frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[4].ToString();
                        txtusernames.Text = frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[5].ToString();
                        cmb_User_Type.Text = frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[6].ToString();
                        txt_Password.Text = Encoding.Unicode.GetString(Convert.FromBase64String(frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[7].ToString()));
                        txtconform_password.Text = Encoding.Unicode.GetString(Convert.FromBase64String(frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[7].ToString()));
                        break;
                    }
                    currentRow++;
                }
                catch
                {
                    MessageBox.Show("Select the user name", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            libUser.Items.Clear();
            frmMain.ds.Clear();

            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser", frmMain.con);
            frmMain.da.Fill(frmMain.ds, "tblUser");
            frmMain.con.Close();

            int currentRow = 0;
            int count = frmMain.ds.Tables["tblUser"].Rows.Count;
            while (currentRow < count)
            {
                if (frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString().Contains(txtSearchUsers.Text))
                {
                    libUser.Items.Add(frmMain.ds.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString());
                }
                currentRow++;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            libUser.Items.Clear();
        }

        private void btnSave_And_Update_Click(object sender, EventArgs e)
        {
            if (txtuserFullName.Text == "" && txtAddresss.Text == "" && txtContacts.Text == "" && txtEmplyeeId.Text == "" && txtusernames.Text == "" && txt_Password.Text == "" && cmb_User_Type.Text == "" && txtconform_password.Text == "")
            {
                MessageBox.Show("Please Type Mandatory Fields", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txt_Password.Text != txtconform_password.Text)
                {
                    MessageBox.Show("conform password is not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmMain.cmd.CommandText = "UPDATE tblCustomers SET FullName = '" + txtuserFullName.Text + "', Address = '" + txt_Password.Text + "', Contact = '" + txtContacts.Text + "', EmpId = '" + txtEmplyeeId.Text + "', UserName = '" + txtusernames.Text + "', UserType = '" + cmb_User_Type.Text + "', Password = '" + txt_Password.Text + "'";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();
                    Close();
                }
            }
            
        }

        private void pnlEditAndRemoveUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
