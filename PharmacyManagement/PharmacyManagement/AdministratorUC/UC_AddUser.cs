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
    public partial class UC_AddUser : UserControl
    {
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
     
        }
        

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\manul\source\repos\pharmacyDatabase\pharmacyDatabase\pharmacyDB.mdf;Integrated Security=True;Connect Timeout=30");
            string role = txtRole.Text;
            string name = txtName.Text;
            string dob = txtDob.Text;
            Int64 mnumber = Convert.ToInt64(txtMnumber.Text);
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string pass = txtPasseword.Text;

            string query = "INSERT INTO users VALUES('" + role + "','" + name + "','" + dob + "','" + mnumber + "','" + email + "','" + username + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sign up Successful");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtMnumber.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPasseword.Clear();
            txtRole.SelectedIndex = -1;

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
