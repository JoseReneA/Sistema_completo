using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace QueryDataBD.Config
{
    public class BD
    {
        public MySqlConnection CreateConection()
        {
            MySqlConnection connector=new MySqlConnection();
            connector.ConnectionString = RetriveConectionstring();
            return connector;
        }
        public void OpenConnection(MySqlConnection connector)
        {
            connector.Open();
        }
        public void CloseConnection(MySqlConnection connector)
        {
            connector.Close();
        }
        public MySqlCommand CreateCommand(MySqlConnection connector, string Query)
        {
            MySqlCommand command = connector.CreateCommand();
            command.CommandText = Query;
            return command;
        }


        #region Helpers;
        private string RetriveConectionstring()
        {
            return ConfigurationManager.ConnectionStrings["MySistem"].ConnectionString;
        }

        #endregion;



    }
}
