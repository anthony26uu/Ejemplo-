using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SQLAdapter
{



    class Program
    {
        static void Main()
        
              
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand com = new SqlCommand("LISTAR_CAMPANAS", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Open();

            SqlDataReader drCampanas = da.SelectCommand.ExecuteReader();
            List listaCampanas = new List();

            while (drCampanas.Read())
            {
                listaCampanas.Add(Cargar(drCampanas));
            }

            drCampanas.Close();
            con.Close();
            return listaCampanas;
        }

    }
      
    }




