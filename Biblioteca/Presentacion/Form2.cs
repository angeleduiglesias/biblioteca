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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodo_Autor autor = new Metodo_Autor();
            autor.idAutor = textid.Text;

            try
            {
                ClsAutor.BuscarAutor(autor);
                txtAutor.Text = autor.nomAutor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar al autor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas actualizar al autor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Metodo_Autor autor = new Metodo_Autor();
                autor.idAutor = txtAutor.Text;
                autor.nomAutor = txtAutor.Text;

                try
                {
                    ClsAutor.ActualizarAutor(autor);
                    MessageBox.Show("Autor actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nuevo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo actualizar al autor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas actualizar los libros?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Metodo_Autor autor = new Metodo_Autor();
                autor.idAutor = txtAutor.Text;
                autor.nomAutor = txtAutor.Text;

                try
                {
                    ClsAutor.ActualizarAutor(autor);
                    MessageBox.Show("Autor actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Metodo_Libro_Autor libroAutor = new Metodo_Libro_Autor();
                    autor.idAutor = txtAutor.Text;
                    autor.nomAutor = txtAutor.Text;

                    Clslibros_Autor.ActualizarLibrosAutor(libroAutor);
                    MessageBox.Show("Libros actualizados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
