using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class SC
    {

        public static SqlConnection sqlConn(string dataSource, string dataBase) {

            
            String connString = "Data Source=" + dataSource + "; Initial Catalog=" + dataBase + "; Integrated Security=True;";


            return new SqlConnection(connString);

        }
    }
}
