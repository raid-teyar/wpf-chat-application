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

            using (var cnn = new MySqlConnection(connectionString))
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

        public async Task<User> getUser(string email, string password)
        {
            using (IDbConnection cnn = new MySqlConnection(getConnectionString("LocalConnectionString")))
            {
                try
                {
                    var users = await cnn.QueryAsync<User>($"Select * From user Where email = '{email}' And password = '{password}'");
                    if (users.Count() > 0)
                    {
                        var user = users.First();
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    Growl.Error(e.Message);
                    return null;
                }
            }
        }
    }
}
