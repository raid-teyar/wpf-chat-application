using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using HandyControl.Controls;


namespace Chat_app_2._0.Helpers
{
    public class DataAccessHelper
    {
        public string getConnectionString(string name)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public void connectDatabase(string name)
        {
            string connectionString = getConnectionString(name);

            using (IDbConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    Growl.Success( "Connection successfull to database:  " + cnn.Database);
                }
                catch (Exception e)
                {
                    Growl.Error(e.Message);
                }
            }
            
        }
    }
}
