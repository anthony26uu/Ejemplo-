using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlDataReade
{
    class Program
    {
        private static SqlConnection connection;

        static void Main(string[] args)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT CategoryID, CategoryName FROM Categories;",
                  connection);
                connection.Open();

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
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
        }
    }
}

