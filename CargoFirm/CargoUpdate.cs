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
namespace CargoFirm
{
    public partial class CargoUpdate : Form
    {
        public CargoUpdate()
        {
            InitializeComponent();
        }
        public Guid RECID { get; set; } = Guid.Empty;

        private void CargoUpdate_Load(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM (SELECT 0 AS ID,' Seçiniz' AS NAME UNION ALL SELECT * FROM CITY) TMP ORDER BY NAME ";

            cbCity.DisplayMember = "NAME";
            cbCity.ValueMember = "ID";
            cbCity.DataSource = DBHelper.ExecuteDataset(sql).Tables[0];

            if (RECID != Guid.Empty)
            {
                sql = "SELECT * FROM CARGO WHERE ID = @ID";
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@ID", RECID));
                DataSet ds = DBHelper.ExecuteDataset(sql, param);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    txtSenderName.Text = ds.Tables[0].Rows[0]["SENDERNAME"].ToString();
                    txtSenderName.Enabled = false;
                    txtSenderSurname.Text = ds.Tables[0].Rows[0]["SENDERSURNAME"].ToString();
                    txtSenderSurname.Enabled = false;
                    txtSenderTelephone.Text = ds.Tables[0].Rows[0]["SENDERPHONE"].ToString();
                    txtSenderTelephone.Enabled = false;
                    txtReceiverName.Text = ds.Tables[0].Rows[0]["RECIEVERNAME"].ToString();
                    txtReceiverName.Enabled = false;
                    txtReceiverSurname.Text = ds.Tables[0].Rows[0]["RECIEVERSURNAME"].ToString();
                    txtReceiverSurname.Enabled = false;
                    txtReceiverTelephone.Text = ds.Tables[0].Rows[0]["RECIEVERPHONE"].ToString();
                    txtReceiverTelephone.Enabled = false;
                    txtPrice.Text = ds.Tables[0].Rows[0]["PRICE"].ToString();
                    txtPrice.Enabled = false;
                    txtWeight.Text = ds.Tables[0].Rows[0]["WEIGHT"].ToString();
                    txtPrice.Enabled = false;
                    txtContent.Text = ds.Tables[0].Rows[0]["CONTENT"].ToString();
                    txtContent.Enabled = false;
                    txtCBStatus.Text = ds.Tables[0].Rows[0]["ISSENDERPAYS"].ToString();
                    txtCBStatus.Enabled = false;

                }
                else
                {
                    RECID = Guid.Empty;

                }
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCity.SelectedValue.ToString() != "0")
            {
                String sql = "SELECT * FROM (SELECT 0 AS ID,' Seçiniz' AS NAME UNION ALL SELECT ID,NAME FROM BRANCH WHERE CITYID = @CITYID) TMP ORDER BY NAME ";
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@CITYID", cbCity.SelectedValue));
                cbBranch.DisplayMember = "NAME";
                cbBranch.ValueMember = "ID";
                cbBranch.DataSource = DBHelper.ExecuteDataset(sql, param).Tables[0];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string sql = string.Empty;
                List<SqlParameter> param = new List<SqlParameter>();
                if (RECID == Guid.Empty)
                {//yeni kayit
                    sql = @"INSERT INTO CARGO(ID,SENDERBRANCHID,SENDERMEMBERID,DESTINATIONBRANCHID,SENTDATE,ISDELIVERED,SENDERNAME,SENDERSURNAME,SENDERPHONE,RECIEVERNAME,RECIEVERSURNAME,RECIEVERPHONE,PRICE,WEIGHT,CONTENT,ISSENDERPAYS) 
                                 VALUES(NEWID(),@SENDERBRANCHID,@SENDERMEMBERID,@DESTINATIONBRANCHID,@SENTDATE,@ISDELIVERED,@SENDERNAME,@SENDERSURNAME,@SENDERPHONE,@RECIEVERNAME,@RECIEVERSURNAME,@RECIEVERPHONE,@PRICE,@WEIGHT,@CONTENT,@ISSENDERPAYS) ";

                    param.Add(new SqlParameter("@SENDERBRANCHID", GlobalVariables.ONLINEMEMBERBRANCHID));
                    param.Add(new SqlParameter("@SENDERMEMBERID", GlobalVariables.ONLINEMEMBERID));
                    param.Add(new SqlParameter("@DESTINATIONBRANCHID", cbBranch.SelectedValue));
                    param.Add(new SqlParameter("@SENTDATE", DateTime.Now));
                    param.Add(new SqlParameter("@ISDELIVERED", false));
                    param.Add(new SqlParameter("@SENDERNAME", txtSenderName.Text));
                    param.Add(new SqlParameter("@SENDERSURNAME", txtSenderSurname.Text));
                    param.Add(new SqlParameter("@SENDERPHONE", txtSenderTelephone.Text));
                    param.Add(new SqlParameter("@RECIEVERNAME", txtReceiverName.Text));
                    param.Add(new SqlParameter("@RECIEVERSURNAME", txtReceiverSurname.Text));
                    param.Add(new SqlParameter("@RECIEVERPHONE", txtReceiverTelephone.Text));
                    param.Add(new SqlParameter("@PRICE", txtPrice.Text));
                    param.Add(new SqlParameter("@WEIGHT", txtWeight.Text));
                    param.Add(new SqlParameter("@CONTENT", txtContent.Text));
                    if (cbPaymentType.SelectedItem.ToString() == "Gönderici Ödemeli")
                    {
                        param.Add(new SqlParameter("@ISSENDERPAYS", true));
                    }
                    else
                    {
                        param.Add(new SqlParameter("@ISSENDERPAYS", false));
                    }
                }
                else
                {//guncelleme
                    sql = "UPDATE CARGO SET ISDELIVERED = @ISDELIVERED WHERE ID = @ID";
                    param.Add(new SqlParameter("@ID", RECID));
                    if (txtCBStatus.SelectedItem.ToString() == "Teslim Edildi.")
                    {
                        param.Add(new SqlParameter("@ISDELIVERED", true));
                    }
                    else
                    {
                        param.Add(new SqlParameter("@ISDELIVERED", false));
                    }

                }
                DBHelper.ExecuteNoneQuery(sql, param);
                this.Close();
            }
        }
        private bool ValidateInput()
        {
            bool retval = true;

            return retval;
        }

    }
}
