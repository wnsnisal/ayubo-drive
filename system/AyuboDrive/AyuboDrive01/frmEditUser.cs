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
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditAndSave_Click(object sender, EventArgs e)
        {
            if (txtEditAddress.Text == "" || txtEditContact.Text == "" || txtEditUserName.Text == "" || txtEditPassword.Text == "" || cmbEditUserType.Text == "")
            {
                MessageBox.Show("Please fill the Mandatory fields", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtEditAddress.Text.Length > 100)
                {
                    MessageBox.Show("Maximum lenth of Address is 100 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtEditContact.Text.Length > 10)
                    {
                        MessageBox.Show("Maximum lenth of Contact is 100 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtEditUserName.Text.Length > 20)
                        {
                            MessageBox.Show("Maximum lenth of User Name is 10 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txtEditPassword.Text.Length > 20)
                            {
                                MessageBox.Show("Maximum lenth of Password is 20 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            String Password = Convert.ToBase64String(Encoding.Unicode.GetBytes(txtEditPassword.Text));

                            System.Data.SqlClient.SqlConnection con = new
                                System.Data.SqlClient.SqlConnection();

                            System.Data.SqlClient.SqlCommand cmd = new
                                System.Data.SqlClient.SqlCommand();

                            con.ConnectionString = "Data Source=DESKTOP-T5BVRGF;Initial Catalog=AyuboDriveDB;Integrated Security=True;Pooling=False";
                            cmd.Connection = con;
                            cmd.CommandText = "UPDATE tblUser SET Address = '"+txtEditAddress.Text+"', Contact = '"+txtEditContact.Text+"', UserName = '"+txtEditUserName.Text+"', Password = '"+txtEditPassword.Text+"' ";
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Close();
                        }
                    }
                }
            }
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
    
