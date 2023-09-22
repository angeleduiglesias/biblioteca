using Biblioteca.Capa_Datos;
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

namespace Biblioteca.Presentacion
{
    public partial class Examinar : Form
    {
        public Examinar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Metodo Gl = new Metodo();
            
            if (cbelegir.SelectedIndex == 0)
            {
                Gl.tituloLibro = txtbuscar.Text;
                ClsLibros.ConsultarlibrosTitulo(Gl);
                dataGridView1.DataSource = ClsLibros.ds;
                dataGridView1.DataMember = "Cargar Libro";
            }
            if (cbelegir.SelectedIndex == 1)
            {
                Gl.pais = txtbuscar.Text;
                ClsLibros.consultarLibrosPais(Gl);
                dataGridView1.DataSource = ClsLibros.ds;
                dataGridView1.DataMember = "Cargar Paises";
            }
            if (cbelegir.SelectedIndex == 2)
            {
                Gl.editorial = txtbuscar.Text;
                ClsLibros.consultarLibrosEditorial(Gl);
                dataGridView1.DataSource = ClsLibros.ds;
                dataGridView1.DataMember = "Cargar Editorial";
            }
        }

        private void Examinar_Load(object sender, EventArgs e)
        {
            cbelegir.Items.Add("Titulo");
            cbelegir.Items.Add("Pais");
            cbelegir.Items.Add("Editorial");



            ClsLibros.ListarLibros();
            dataGridView1.DataSource = ClsLibros.ds;
            dataGridView1.DataMember = "Cargar Libros";

        }

        private void cbelegir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
