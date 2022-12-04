using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
//May have to install this package (below), just search for System.Data.SqlClient in NuGet packet manager
using System.Data.SqlClient;

namespace Investment_ideas_platform
{
    class DBConnection
    {
        private static DBConnection _instance;

        private string dBConnectionString;

        private DBConnection()
        {
            //Gets the connection string that was set in settings instead of having to type the connection string out manually in the code
            dBConnectionString = Properties.Settings.Default.InvestmentIdeasDBConnectionString;
        }

        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }

            return _instance;
        }
    }
}
