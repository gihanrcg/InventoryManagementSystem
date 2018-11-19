using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    class DBConnect : IDisposable
    {
        private static String server = "localhost";
        private static String port = "3306";
        private static String database = "hotel";
        private static String username = "root";
        private static String password = "";

       // private static String connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";Uid=" + username + ";Password=" + password + ";";
        private static String connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Private\InventoryManagementSystem\InventoryManagementSystem\InventoryDB.mdf;Integrated Security=True";
        public SqlConnection con = new SqlConnection(connectionString);

        public DBConnect()
        {
            try
            {
                con.Open();
                Console.WriteLine("Database connected");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Database Connection Failed");
                throw new Exception();
            }
        }

        public void Dispose()
        {
            con.Close();
        }
    }
}
