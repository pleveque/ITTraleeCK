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

            if (!DBConnection.IsOpen)
            {
                // opens the connection 
                DBConnection.Open();
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = DBConnection.Connection;

            string cmdText = @"SELECT * FROM CATEGORY";

            cmd.CommandText = cmdText;

            OracleDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    Category category = new Category();

                    category.CategoryID = reader.GetInt32(0);
                    category.CategoryName = reader.GetString(1);

                    categories.Add(category);
                }
            }

            catch
            {
                throw;
            }

            return categories;
        }
    }
}
