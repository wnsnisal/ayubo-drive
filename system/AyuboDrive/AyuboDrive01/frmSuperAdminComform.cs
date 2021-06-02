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
    public partial class frmSuperAdminComform : Form
    {
        System.Data.SqlClient.SqlConnection con = new
                System.Data.SqlClient.SqlConnection();

        System.Data.SqlClient.SqlDataAdapter da = new
              System.Data.SqlClient.SqlDataAdapter();

        DataSet ds = new DataSet();

        public frmSuperAdminComform()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void frmSuperAdminComform_Load(object sender, EventArgs e)
        {

        }

        private void btnConform_Click(object sender, EventArgs e)
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
                txtSuperAdminPassword.Text = password;
                if (txtSuperAdminPassword.Text == password)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                CurrentRow++;
            }
        }
    }
}
