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
    public partial class frmLogin : Form
    {
        System.Data.SqlClient.SqlConnection con = new
                System.Data.SqlClient.SqlConnection();

        System.Data.SqlClient.SqlDataAdapter da = new
              System.Data.SqlClient.SqlDataAdapter();

        DataSet ds = new DataSet();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("User Name and Password requard", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.ConnectionString = Commons.DB_CON;
                    con.Open();
                    da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser", con);
                    da.Fill(ds, "tblUser");
                    con.Close();

                    int CurrentRow = 0;
                    int RowCount = ds.Tables["tblUser"].Rows.Count;
                    while (CurrentRow < RowCount)
                    {
                        string password = Encoding.Unicode.GetString(Convert.FromBase64String(ds.Tables["tblUser"].Rows[CurrentRow].ItemArray[7].ToString()));

                        if (txtUserName.Text == ds.Tables["tblUser"].Rows[CurrentRow].ItemArray[5].ToString() && txtPassword.Text == password)
                        {
                            Commons.LogedUser = txtUserName.Text;
                            Loged.UserType = (ds.Tables["tblUser"].Rows[CurrentRow].ItemArray[6].ToString());
                            MessageBox.Show("you logged as" + Loged.UserType + ".", "Loged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            break;                            
                        }
                        CurrentRow++;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Incorrect user name or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
