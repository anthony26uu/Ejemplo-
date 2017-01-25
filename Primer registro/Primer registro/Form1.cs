using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Primer_registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.EjemploDB db = new DAL.EjemploDB();
            Entidades.Estudiantes estudiantes = new Entidades.Estudiantes();
       
            estudiantes.Nombres="Anthony";
            estudiantes.Deuda = 10;
            estudiantes.EstudianteId = 0;

            db.Estudiantes.Add(estudiantes);
            db.SaveChanges();

            UI.Consulta.Consulta consulta = new UI.Consulta.Consulta();
            consulta.Show();

        }
    }
}
