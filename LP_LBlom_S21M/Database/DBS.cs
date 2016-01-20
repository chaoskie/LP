using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Database.Exceptions;
using Oracle.ManagedDataAccess.Client;

namespace Database
{
    class DBS
    {
        /// <summary>
        /// The database class to communicate between the application and the database
        /// </summary>
        public static class Database
        {
            /// <summary>
            /// The host IP address
            /// </summary>
            private static string host = "localhost";

            /// <summary>
            /// The username of the host
            /// </summary>
            private static string username = "system";

            /// <summary>
            /// The password of the host
            /// </summary>
            private static string dbpassword = "root";

            /// <summary>
            /// The connection string to connect to the host
            /// </summary>
            private static string connectionstring = "User Id=" + username + ";Password=" + dbpassword + ";Data Source= //" + host + ":1521/XE;";

            /// <summary>
            /// Selects and retrieves values from the database 
            /// </summary>
            /// <param name="query">The selection statement</param>
            /// <returns>A DataTable with the retrieved values></returns>
            public static DataTable RetrieveQuery(string query)
            {
                if (Regex.IsMatch(query, @"-{2,}"))
                {
                    throw new SQLInjectionException();
                }

                using (OracleConnection c = new OracleConnection(@connectionstring))
                {
                    try
                    {
                        c.Open();
                        OracleCommand cmd = new OracleCommand(@query);
                        cmd.Connection = c;
                        try
                        {
                            OracleDataReader r = cmd.ExecuteReader();
                            DataTable result = new DataTable();
                            result.Load(r);
                            c.Close();
                            return result;
                        }
                        catch (OracleException e)
                        {
                            Console.Write(e.Message);
                            throw;
                        }
                    }
                    catch (OracleException e)
                    {
                        Console.Write(e.Message);
                        return new DataTable();
                    }
                }
            }
        }
    }
}


