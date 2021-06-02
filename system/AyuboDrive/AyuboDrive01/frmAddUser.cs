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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtAddress.Text == "" || txtContact.Text == "" || txtEmpId.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || cmbUserType.Text == "")
            {
                MessageBox.Show("Please fill the Mandatory fields", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtFullName.Text.Length > 50)
                {
                    MessageBox.Show("Maximum lenth of Full name is 50 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtAddress.Text.Length > 100)
                    {
                        MessageBox.Show("Maximum lenth of Address is 100 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtContact.Text.Length > 10)
                        {
                            MessageBox.Show("Maximum lenth of Contact number is 10 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txtEmpId.Text.Length > 20)
                            {
                                MessageBox.Show("Maximum lenth of emp Id is 20 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (txtUserName.Text.Length > 20)
                                {
                                    MessageBox.Show("Maximum lenth of User Name is 20 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (txtPassword.Text.Length > 20)
                                    {
                                        MessageBox.Show("Maximum lenth of Password is 20 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    String Password = Convert.ToBase64String(Encoding.Unicode.GetBytes(txtPassword.Text));

                                    System.Data.SqlClient.SqlConnection con = new
                                        System.Data.SqlClient.SqlConnection();

                                    System.Data.SqlClient.SqlCommand cmd = new
                                        System.Data.SqlClient.SqlCommand();

                                    con.ConnectionString = "Data Source=DESKTOP-T5BVRGF;Initial Catalog=AyuboDriveDB;Integrated Security=True;Pooling=False";
                                    cmd.Connection = con;
                                    cmd.CommandText = "INSERT INTO tblUser(FullName, Address, Contact, EmpId, UserName, UserType, Password) VALUES('" + txtFullName.Text + "', '" + txtAddress.Text + "', '" + txtContact.Text + "', '" + txtEmpId.Text + "', '" + txtUserName.Text + "', '" + cmbUserType.Text + "', '" + Password + "')";
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAddUser_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmpId_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
