using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Database
    {
        private static string connString = "Data Source=DESKTOP-1FPMH5D\\MSSQLSERVER1;Initial Catalog=MyCompany;Integrated Security=True";

        public static string ConnectionString
        {
            get { return connString; }
            set { connString = value; }
        }

    }
}
