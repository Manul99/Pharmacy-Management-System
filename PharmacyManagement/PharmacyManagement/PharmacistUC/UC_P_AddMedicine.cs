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


namespace PharmacyManagement.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (txtMediId.Text !="" && txtMediName.Text!="" &&txtMediNumber.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text!="")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\manul\source\repos\PharmacyManagement\pmedicineDB.mdf;Integrated Security=True;Connect Timeout=30");
                String mid = txtMediId.Text;
                String mname = txtMediName.Text;
                String mnumber = txtMediNumber.Text;
                String mdate = txtManufacturingDate.Text;
                String edate = txtExpireDate.Text;
                Int64 quantity = Convert.ToInt64(txtQuantity.Text);
                Int64 perunit = Convert.ToInt64(txtPricePerUnit.Text);

                query = "insert into medic(mid,mname,mnumber,mDate,eDate,quantity,perUnit)values('"+mid+"','"+mname+"','"+mnumber+"','"+mdate+"','"+edate+"',"+quantity+","+perunit+")";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records inserted successfully");
                }
                catch(Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
        }
    }
}
