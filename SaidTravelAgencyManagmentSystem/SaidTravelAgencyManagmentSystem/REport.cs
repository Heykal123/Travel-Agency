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

namespace SaidTravelAgencyManagmentSystem
{
    public partial class REport : Form
    {
        MainClass main = new MainClass();
        public REport()
        {
            InitializeComponent();
        }

        private void REport_Load(object sender, EventArgs e)
        {
            getlist();
        }
        void getlist()
        {
            using(SqlConnection conn = main.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from recepReport1",conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
