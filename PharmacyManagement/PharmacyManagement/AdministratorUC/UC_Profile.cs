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

namespace PharmacyManagement.AdministratorUC
{

    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String query;
        public UC_Profile()
        {
            InitializeComponent();
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\manul\source\repos\pharmacyDatabase\pharmacyDatabase\pharmacyDB.mdf;Integrated Security=True;Connect Timeout=30");
            query = "update users set userRole='" + txtuserRole.Text + "',name='" + txtName.Text + "',Dob='" + txtDob.Text + "',mobile='" + txtMobile.Text + "',email='" + txtEmail.Text + "',pass='" + txtPasseword.Text + "'where Id='" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");


            }
            catch (SqlException ec)
            {
                MessageBox.Show("" + ec);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtDob.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            txtPasseword.Clear();
            txtuserRole.SelectedIndex = -1;
        }
    }
}
