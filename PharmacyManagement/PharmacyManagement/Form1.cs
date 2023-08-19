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

namespace PharmacyManagement
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPasseword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
             query = "select * from users";
             ds = fn.getData(query);

             if (ds.Tables[0].Rows.Count != 0)
    
             {
                 if (txtUsername.Text == "admin" && txtPasseword.Text == "admin")
                 {
                     Administrator admin = new Administrator();
                     admin.Show();
                     this.Hide();
                 }
                 else if(txtUsername.Text=="pharm" && txtPasseword.Text=="pharm")
                {
                    Pharmacist pharm = new Pharmacist();
                    pharm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username OR Passeword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           /* else
            {
                query = "select * from users where username='" + txtUsername.Text + "'and pass='" + txtPasseword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Pharmacist")
                    {

                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                        
                    }
                    else if (role == "Administrator")
                    {
                        Administrator admin = new Administrator();
                        admin.Show();
                        this.Hide();

                    }


                }
                


            }*/
            









            /*if (txtUsername.Text == "Manul" && txtPasseword.Text == "19990305")
            {
                Administrator am = new Administrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or passeword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }*/
        }
    }
}
