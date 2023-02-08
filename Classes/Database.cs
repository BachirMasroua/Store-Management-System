using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System.Classes
{
    static class Database
    {
        private static string databaseConnection = "Data Source=DESKTOP-QVQ0AMA;Initial Catalog=store_management;User ID=sa;Password=12345";

        public static string DatabaseConnection
        {
            get { return databaseConnection; }
            set { databaseConnection = value; }
        }
    }
}
