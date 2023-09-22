using Biblioteca.Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Capa_Datos;

namespace Biblioteca.Presentacion
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodo_Prestamo GL = new Metodo_Prestamo();
            GL.FechaInicio = DateTime.Parse(txtDesde.Text);
            GL.FechaFin = DateTime.Parse(txtHasta.Text);

            ClsLibros.ColsultarlibrosPorFecha(GL);
            dataGridView1.DataSource = ClsLibros.ds;
            dataGridView1.DataMember = "LibrosPrestados";
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
