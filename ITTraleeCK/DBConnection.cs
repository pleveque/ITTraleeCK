using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    /**
     * Class to connect my project in my database
     * If you use a database, please change the string queryConn with you own informations
     */
    class DBConnection
    {
        private static bool isOpen;
        private static string queryConn = "DATA SOURCE=localhost:1521/xe;USER ID=PIERRE;PASSWORD=pierre";


        private static OracleConnection connection = new OracleConnection(queryConn);

        public static bool IsOpen
        {
            get
            {
                return isOpen;
            }
        }

        public static OracleConnection Connection
        {
            get
            {
                return connection;
            }
        }

        public static void Open()
        {
            try
            {
                connection.Open();

                isOpen = true;
            }

            catch (Exception ex)
            {
                isOpen = false;
            }
        }

        public static void Close()
        {
            try
            {
                connection.Close();

                isOpen = false;
            }

            catch
            {
                isOpen = !isOpen;
            }
        }
    }
}
