﻿using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {

        string conexion =
            "Data Source=(local);Initial Catalog=Northwind;"
            + "Integrated Security=true";

     
        string queryString =
            "SELECT prodcutoID, UnitPrice, nombreproducto from dbo.productos "
                + "WHERE unidadprecio > @pricePoint "
                + "ORDER BY unidadprecio DESC;";

       
        int parametro = 5;       
        using (SqlConnection connection =
            new SqlConnection(conexion))
        {
            
            SqlCommand comando = new SqlCommand(queryString, connection);
            comando.Parameters.AddWithValue("@pricePoint", parametro);

            
            try
            {
                connection.Open();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        leer[0], leer[1], leer[2]);
                }
                leer.Close();
              //A
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
    