using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace CargoFirm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string sql = "SELECT ID,ISADMIN,BRANCHID,NAME FROM MEMBER WHERE LOGINNAME = @LOGINNAME AND PASSWORD = @PASSWORD";
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@LOGINNAME", txtLoginName.Text));
                param.Add(new SqlParameter("@PASSWORD", txtPassword.Text));

                DataSet ds = DBHelper.ExecuteDataset(sql, param);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    GlobalVariables.ONLINEMEMBERID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                    GlobalVariables.ONLINEMEMBERBRANCHID = Convert.ToInt32(ds.Tables[0].Rows[0]["BRANCHID"]);
                    GlobalVariables.ONLINEMEMBERISADMIN = Convert.ToBoolean(ds.Tables[0].Rows[0]["ISADMIN"]);
                    GlobalVariables.ONLINEMEMBERNAME = ds.Tables[0].Rows[0]["NAME"].ToString();

                    this.Hide();
                    CargoList f = new CargoList();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                }
            }
        }
        private bool ValidateInput()
        {
            bool retval = true;
            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                retval = false;
                MessageBox.Show("Kullanıcı adı alanı boş olamaz!");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                retval = false;
                MessageBox.Show("Şifre alanı boş olamaz!");
            }
            return retval;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
