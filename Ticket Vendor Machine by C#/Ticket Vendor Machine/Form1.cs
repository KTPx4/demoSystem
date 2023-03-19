using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Vendor_Machine
{
    public partial class TicketM : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        public TicketM()
        {
            InitializeComponent();
        }

        private void TicketM_Load(object sender, EventArgs e)
        {
            string s = "initial catalog = Demo; data source = DESKTOP-VGVFSE4\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(s);
            cn.Open();
            txtDes.Enabled = false;
            cmbTran.Focus();

        }
        private void cmbTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tran = cmbTran.Text;
            String s = "Select nameDes, Distance, Price from Destinations where Transport like '" + tran +"'";
            showData(s);

        }
        public void showData(string s)
        {
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            dGVDes.DataSource = tb;
            dGVDes.Columns["nameDes"].HeaderText = "location";
            dGVDes.Columns["Distance"].HeaderText = "Distance";
            dGVDes.Columns["Price"].HeaderText = "Price";
        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {
            if (txtQuan.Text == null || txtQuan.Text is null || txtQuan.Text == "")
                return;

            int n;
            bool isNumeric = int.TryParse(txtQuan.Text, out n);

            if (!isNumeric)
            {

                MessageBox.Show("Invalid Quantity!");
                txtQuan.Text = null;
                txtQuan.Focus();
            }
            else
            {
                if(int.Parse(txtQuan.Text) < 1)
                {
                    MessageBox.Show("Please input Quantity > 0");
                    txtQuan.Text = null;
                    txtQuan.Focus();
                }    
            }

        }

        private void dGVDes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVDes.CurrentRow.Index;
            String des = dGVDes.Rows[index].Cells[0].Value.ToString();
            txtDes.Text = des;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            cmbTran.Text = null;
            cmbTran.Focus();
            txtDes.Text = null;
            txtQuan.Text = null;
            dGVDes.DataSource = null;
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if(cmbTran.Text == "")
            {
                MessageBox.Show("Please Select type of Transport!");
                cmbTran.Focus();
                return;
            }
            if (txtDes.Text == "")
            {
                MessageBox.Show("Please Select Destination by Click in list!");
                dGVDes.Focus();
                return;
            }
            if(txtQuan.Text == "")
            {
                MessageBox.Show("Please input Quantity!");
                txtQuan.Focus();
                return;
            }
            bool result = false;
            using (Credit form2 = new Credit())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                  
                     result = form2.Result;
                }
            }
            if(result)
            {
                MessageBox.Show("Your Ticket: XXXXXXXXXXXXXXXX");
                return;
            }
            else
            {
                MessageBox.Show("Please Payment again!");
                return;
            }
        }

        private void btnQRcode_Click(object sender, EventArgs e)
        {
            if (cmbTran.Text == "")
            {
                MessageBox.Show("Please Select type of Transport!");
                cmbTran.Focus();
                return;
            }
            if (txtDes.Text == "")
            {
                MessageBox.Show("Please Select Destination by Click in list!");
                dGVDes.Focus();
                return;
            }
            if (txtQuan.Text == "")
            {
                MessageBox.Show("Please input Quantity!");
                txtQuan.Focus();
                return;
            }
            MessageBox.Show("QR code is work!");

        }
    }
}
