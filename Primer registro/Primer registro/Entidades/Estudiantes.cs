using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Primer_registro.Entidades
{
   public class Estudiantes
    {   
       [Key]
       public int EstudianteId { get; set; }
       public string Nombres { get; set; }
       public double Deuda { get; set; }

        
        public Estudiantes()
        {

        }


    }
}
