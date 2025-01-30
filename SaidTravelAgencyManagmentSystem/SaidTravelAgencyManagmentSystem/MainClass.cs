using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaidTravelAgencyManagmentSystem
{
    public class MainClass
    {
        public SqlConnection connection() 
        {
            SqlConnection conn = new SqlConnection("data source = ABDIWALI\\SQLEXPRESS; initial catalog = travelAgence; integrated security = true;");
            conn.Open();
            return conn;
        }
    }
}
