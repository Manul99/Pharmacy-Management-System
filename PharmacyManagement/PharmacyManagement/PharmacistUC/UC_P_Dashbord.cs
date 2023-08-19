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
    public partial class UC_P_Dashbord : UserControl
    {

        Function1 fn = new Function1();
        String query;
        DataSet ds;
        Int64 count;
        public UC_P_Dashbord()
        {
            InitializeComponent();
        }

        private void UC_P_Dashbord_Load(object sender, EventArgs e)
        {
            
        }

       /*public void loadChart()
       {
            
            query = "select count(mname) from medic where eDate >= getdate()";
            ds = fn.getData(query);
            count = Convert.ToInt64(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicines"].Points.AddXY("medicine Validity Chart", count);
          
        }*/
           
    }
}
