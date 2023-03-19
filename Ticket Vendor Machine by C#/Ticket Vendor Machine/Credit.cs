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
    public partial class Credit : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int timeCheck = 0;
        public bool Result { get; set; }
        public Credit()
        {
            InitializeComponent();
        }

        private void Credit_Load(object sender, EventArgs e)
        {
            string s = "initial catalog = Demo; data source = DESKTOP-VGVFSE4\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(s);
            cn.Open();

        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text == "")
            {
                MessageBox.Show("Please input number card!");
                txtNumber.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Please input your name!");
                txtName.Focus();
                return;
            }
            if (txtExp.Text == "")
            {
                MessageBox.Show("Please input expiration date!");
                txtExp.Focus();
                return;
            }
            if (txtCvv.Text == "")
            {
                MessageBox.Show("Please input number cvv!");
                txtCvv.Focus();
                return;
            }
            String number, s, name, exp, cvv;
            number = txtNumber.Text;
            name = txtName.Text;
            exp = txtExp.Text;
            cvv = txtCvv.Text;
            s = "Select * from CreditCard where IDcredit = '" + number + "' and NameUser = '" + name + "' and expDate = '" + exp + "' and cvv = '" + cvv +"'";

            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            if(tb.Rows.Count == 0 )
            {
                MessageBox.Show("Your Credit Card is Invalid!");
                Result = false;
                timeCheck++;
                if(timeCheck >= 5)
                {
                    this.Close();
                }
            }
            else
            {

                MessageBox.Show("Payment successfull!");
                this.DialogResult = DialogResult.OK;
                Result = true;               
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successfull!");
            this.DialogResult = DialogResult.OK;
            Result = true;
            this.Close();
        }
    }
}
