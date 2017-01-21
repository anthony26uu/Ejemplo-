using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlDataReade
{
    class Program
    {
        private static SqlConnection coneccion;

        static void Main(string[] args)
        {
            using (coneccion)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT ID, NAME FROM categoria;",
                  coneccion);
                coneccion.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                            reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("Esta vacio.");
                }
                reader.Close();
            }
        }
    }
}

