using Primer_registro.DAL;
using Primer_registro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Primer_registro.UI.Consulta
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Estudiantes> Lista = new List<Estudiantes>();
            var db = new EjemploDB();
            Lista = db.Estudiantes.ToList();
            dataGridView1.DataSource = Lista;

        }
    }
}
