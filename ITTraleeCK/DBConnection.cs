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
        //private static string queryConn = "DATA SOURCE=studentoracle.students.ittralee.ie:1521/orcl;PERSIST SECURITY INFO=True;USER ID=T00191900;PASSWORD=sxauet79";
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
