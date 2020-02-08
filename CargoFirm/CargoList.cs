using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace CargoFirm
{
    public partial class CargoList : Form
    {
        public CargoList()
        {
            InitializeComponent();
        }

        private void CargoList_Load(object sender, EventArgs e)
        {
            lblMemberName.Text = "Hoşgeldiniz " + GlobalVariables.ONLINEMEMBERNAME;
            dgwList2.AutoGenerateColumns = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String sql = "SELECT ID,SENDERNAME,SENDERSURNAME,SENDERPHONE,RECIEVERNAME,RECIEVERSURNAME,RECIEVERPHONE,PRICE,WEIGHT,CONTENT,ISSENDERPAYS FROM CARGO WHERE (SENDERBRANCHID = @BRANCHID OR DESTINATIONBRANCHID = @BRANCHID)";
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@BRANCHID", GlobalVariables.ONLINEMEMBERBRANCHID));


            if (!string.IsNullOrEmpty(txtSenderName.Text))
            {
                sql += " and SENDERNAME like @SENDERNAME";
                param.Add(new SqlParameter("@SENDERNAME", txtSenderName.Text + "%"));
            }
            if (!string.IsNullOrEmpty(txtSenderSurname.Text))
            {
                sql += " and SENDERSURNAME like @SENDERSURNAME";
                param.Add(new SqlParameter("@SENDERSURNAME", txtSenderSurname.Text + "%"));
            }
            if (!string.IsNullOrEmpty(txtSenderTelephone.Text))
            {
                sql += " and SENDERPHONE like @SENDERPHONE";
                param.Add(new SqlParameter("@SENDERPHONE", txtSenderTelephone.Text + "%"));
            }
            if (!string.IsNullOrEmpty(txtReceiverName.Text))
            {
                sql += " and RECIEVERNAME like @RECIEVERNAME";
                param.Add(new SqlParameter("@RECIEVERNAME", txtReceiverName.Text + "%"));
            }
            if (!string.IsNullOrEmpty(txtReceiverSurname.Text))
            {
                sql += " and RECIEVERSURNAME like @RECIEVERSURNAME";
                param.Add(new SqlParameter("@RECIEVERSURNAME", txtReceiverSurname.Text + "%"));
            }
            if (!string.IsNullOrEmpty(txtReceiverTelephone.Text))
            {
                sql += " and RECIEVERPHONE like @RECIEVERPHONE";
                param.Add(new SqlParameter("@RECIEVERPHONE", txtReceiverTelephone.Text + "%"));
            }
            if (txtCBStatus.SelectedItem != null && txtCBStatus.SelectedItem.ToString() != "Hepsi")
            {
               if(txtCBStatus.SelectedItem != null && txtCBStatus.SelectedValue.ToString() == "Teslim Edildi.")
                {
                    sql += " and ISDELIVERED = 1";
                }
               else
                {
                    sql += " and ISDELIVERED = 0";
                }
            }

            dgwList2.DataSource = DBHelper.ExecuteDataset(sql, param).Tables[0];
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            CargoUpdate f = new CargoUpdate();
            f.ShowDialog();
        }

        private void dgwList2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid selectedValue =  Guid.Parse( dgwList2[0, e.RowIndex].Value.ToString());
            CargoUpdate f = new CargoUpdate();
            f.RECID = selectedValue;
            f.ShowDialog();

        }

       
    }
}
