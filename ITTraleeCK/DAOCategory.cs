using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class DAOCategory
    {

        public static List<Category> SelectAllCategories()
        {
            List<Category> categories = new List<Category>();
            Category category = new Category();
            

            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM ""CATEGORY""";

            cmd.CommandText = cmdText;

            OracleDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
            }

            catch
            {
                throw;
            }

            while (reader != null && reader.Read())
            {
                category.CategoryID = reader.GetInt32(0);
                category.CategoryName = reader.GetString(1);
               

                categories.Add(category);

                foreach (Category c in categories)
                {
                    Console.WriteLine("liste DAO : " + c.ToString());
                }

            }

            return categories.ToList<Category>();
        }


    }
}
