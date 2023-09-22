using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Capa_Datos;
using Biblioteca.Capa_Logica;
using Biblioteca.Presentacion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LlenarAutores()
        {
            ClsAutor.Llenarcombox();
            cbAutor.DataSource = ClsAutor.dt;
            cbAutor.DisplayMember = "nomAutor";
            cbAutor.ValueMember = "idAutor";
            cbAutor.Text = "Seleccionar";
            


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarAutores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;
            Rpt=MessageBox.Show("¿Deseas grabar  los libros?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo Gl = new Metodo();
                Gl.idLibro = txtid.Text;
                Gl.tituloLibro = txtTitulo.Text;
                Gl.editorial = txtEditorial.Text;
                Gl.pais = txtpais.Text;
                Gl.año = int.Parse(txtaño.Text);
                Gl.nPag = int.Parse(txtpaginas.Text);
                Gl.existencia = int.Parse(txtexistencia.Text);
                ClsLibros.InsertarLibros(Gl);

                Metodo_Libro_Autor Ga = new Metodo_Libro_Autor();
                Ga.ididlibro = txtid.Text;
                Ga.idAutor = cbAutor.SelectedValue.ToString();
                Clslibros_Autor.InsertarLibrosAutor(Ga);

                MessageBox.Show("Libros ingreso correctamente","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
        }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Deseas actualizar los libros?","Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo Gl = new Metodo();
                Gl.idLibro = txtid.Text;
                Gl.tituloLibro = txtid.Text;
                Gl.editorial = txtEditorial.Text;
                Gl.pais = txtpais.Text;
                Gl.año = int.Parse(txtaño.Text);
                Gl.nPag = int.Parse(txtpaginas.Text);
                Gl.existencia = int.Parse(txtexistencia.Text);
                ClsLibros.ActualizarLibros(Gl);


                Metodo_Libro_Autor Ga = new Metodo_Libro_Autor();
                Ga.ididlibro = txtid.Text;
                Ga.idAutor = cbAutor.SelectedValue.ToString();
                Clslibros_Autor.ActualizarLibrosAutor(Ga);
                MessageBox.Show("Libros actualizo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodo Gl = new Metodo();
            Gl.idLibro = txtid.Text;
                try
                {
                    ClsLibros.Buscarlibros(Gl);
                }
                catch (Exception) { MessageBox.Show("Codigo no encontrado"); }

            txtTitulo.Text = Gl.tituloLibro;
            txtEditorial.Text = Gl.editorial;
            txtpais.Text = Gl.pais;
            txtaño.Text =Convert.ToString(Gl.año);
            txtpaginas.Text = Convert.ToString(Gl.nPag);
            txtexistencia.Text = Convert.ToString(Gl.existencia);

            Metodo_Libro_Autor Ga = new Metodo_Libro_Autor();
            Ga.ididlibro = txtid.Text;
            try
            {
                Clslibros_Autor.BuscarLibrosAutores(Ga);
            }
            catch (Exception) { MessageBox.Show("Ups! Codigo no encontrado"); }
            cbAutor.Text = Ga.nomAutor;
            
            
        }
        void nuevo()
        {
            limpiar limp = new limpiar();
            limp.limpiarCampos(this, groupBox1);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nuevo();
          
        }

        private void cbAutor_Click(object sender, EventArgs e)
        {
            LlenarAutores();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 fr1 = new Form2();
            fr1.ShowDialog();
        }
    }
}
