using Primer_registro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Primer_registro.DAL
{
   public class EjemploDB :DbContext

    {
        public EjemploDB() : base ("ConStr")
        {

        }

        public DbSet<Estudiantes> Estudiantes { get; set; }

    }   
}
