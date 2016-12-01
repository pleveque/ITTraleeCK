using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTraleeCK
{
    class DBConnection
    {
        private static bool isOpen;
        private static string queryConn = "DATA SOURCE=test.c2221yhnbscd.eu-west-1.rds.amazonaws.com:1521/ORCL;PERSIST SECURITY INFO=True;USER ID=ADMIN;PASSWORD=itt12345";

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
                Console.WriteLine(ex.Message, "Open Connection doesn't works");

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
