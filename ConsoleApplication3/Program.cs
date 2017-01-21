using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            abrirconexion();
            Console.ReadKey();
        }
        private static void abrirconexion()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
              //  conexion.Open();

                Console.WriteLine("Estado de conexion :"+ conexion.State);
                Console.WriteLine("Conexion: " + conexion.ConnectionString);
            }
        }

        static private string GetConnectionString()
        {
          
            return "Data Source=(local);Initial Catalog=AdventureWorks;"
                + "Integrated Security=SSPI;";
        }
    }

}
