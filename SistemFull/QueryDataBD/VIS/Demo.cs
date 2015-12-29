using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using QueryDataBD.Config;
using Models.Models;

namespace QueryDataBD.VIS
{
    public class Demo:BD
    {
        private static MySqlConnection connection=null;
        

        public Demo()
        {
            connection = base.CreateConection();
        }

        public List<CatCountry> SelectData()
        {
            List<CatCountry> listData = new List<CatCountry>();
            string Query = "SELECT * FROM CatCountry";
            base.OpenConnection(connection);

            MySqlCommand command = base.CreateCommand(connection, Query);
            MySqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                CatCountry item = new CatCountry();
                item.id = Convert.ToInt32(data[0].ToString());
                item.strNombre = data[2].ToString();

                listData.Add(item);
            }

            return listData;
            
        }
        //public int insertCountry(object obj)
        //{

        //}
    }
}
