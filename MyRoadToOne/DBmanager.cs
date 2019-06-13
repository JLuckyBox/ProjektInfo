using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyRoadToOne
{
    class DBmanager
    {
            private static MySqlConnection MySqlHandle;

            public static void SetupDatabase(string IPadress, string Database, string Uid, string Pwd)
            {
                MySqlHandle = new MySqlConnection("Server=" + IPadress + "; Database=" + Database + "; user="+Uid+"; Pwd=" + Pwd + ";");
                try
                {
                    MySqlHandle.Open();

                    Console.WriteLine("Verbindung mit Datenbank wurde erfolgreich hergestellt", ConsoleColor.Green);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message, ConsoleColor.Red);

                }
            }

            public static void CloseDatabase()
            {
                try
                {
                    MySqlHandle.Close();
                    Console.WriteLine("Verbindung mit Datenbank wurde beendet");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message, ConsoleColor.Red);
                }
            }

            public static void NonExecuteQuery(string Query)
            {
                try
                {
                    MySqlCommand myCommand = new MySqlCommand(Query, MySqlHandle);
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static MySqlDataReader ExecuteQuery(string Query)
            {
                try
                {
                    MySqlCommand myCommand = new MySqlCommand(Query, MySqlHandle);
                    return myCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
    }
}
