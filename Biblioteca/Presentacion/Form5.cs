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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Metodo Gl = new Metodo();
            Gl.librosP = txtBuscar.Text;
            ClsLibros.consultarLibrosPrestamos(Gl);
            dataGridView1.DataSource = ClsLibros.ds;
            dataGridView1.DataMember = "Cargar LPrestamo";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now;
            LblFecha.Text = Fecha.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;
            Rpt = MessageBox.Show("¿Desea anular el préstamo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Rpt == DialogResult.Yes)
            {
                if (dataGridView2.CurrentRow != null)
                {
                    dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

                    // Crear objeto Metodo_Prestamo para la anulación del préstamo
                    Metodo_Prestamo Gl = new Metodo_Prestamo();

                    Gl.idLibro = lbld.Text;
                    Gl.anulado = "Si";

                    // Llamar al método de anulación de préstamo
                    ClsPrestamo.AnularPrestamo(Gl);

                    // Crear objeto Metodo para la actualización de la existencia del libro
                    Metodo G = new Metodo();
                    G.idLibro = lbld.Text;

                    try
                    {
                        ClsLibros.Buscarlibros(G);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Código no encontrado");
                    }

                    // Actualizar existencia del libro
                    G.existencia = int.Parse(LblExistencia.Text) + 1;
                    ClsLibros.ActualizarLibrosExis(G);

                    MessageBox.Show("Préstamo anulado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado una fila para anular el préstamo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }




        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbld.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LblAutor.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LblLibro.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            LblExistencia.Text = this.dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;
            Rpt = MessageBox.Show("¿Desea agregar el préstamo del libro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Rpt == DialogResult.Yes)
            {
                // Crear objeto Metodo_Prestamo
                Metodo_Prestamo gl = new Metodo_Prestamo();
                gl.idLibro = lbld.Text;
                gl.FechaP = DateTime.Parse(LblFecha.Text);
                gl.FechaD = DTfechaD.Value;
                gl.anulado = "No";

                // Insertar préstamo
                ClsPrestamo.InsertarPrestamo(gl);

                // Validar existencia del libro
                int existencia = int.Parse(LblExistencia.Text);
                if (existencia >= 1)
                {
                    // Actualizar existencia del libro
                    Metodo_Prestamo G = new Metodo_Prestamo();
                    G.idLibro = lbld.Text;
                    G.existencia = existencia - 1;
                    Clslibros_Autor.ActualizarLibrosExis(G);

                    // Agregar detalles del préstamo al DataGridView
                    dataGridView2.Rows.Add(lbld.Text, LblLibro.Text, DTfechaD.Value.ToString("dd/MM/yyyy"));

                    LblTotal.Text = dataGridView2.RowCount.ToString();

                    MessageBox.Show("Préstamo del libro agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay existencias suficientes para realizar el préstamo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }




        private void dataGridView2_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbld.Text = this.dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            LblAutor.Text = this.dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            LblExistencia.Text = this.dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void LblidLibro_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 fr1 = new Form6();
            fr1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;
            Rpt = MessageBox.Show("¿Desea Quitar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                Metodo_Prestamo Gl = new Metodo_Prestamo();
                Gl.idLibro = lbld.Text;

                Gl.anulado = "Si";

                ClsPrestamo.AnularPrestamo(Gl);

                Metodo G = new Metodo();

                G.idLibro = lbld.Text;

                try
                {
                    ClsLibros.Buscarlibros(G);
                }
                catch (Exception) { MessageBox.Show("Codigo no encontrado"); }
                string existencia;
                existencia = Convert.ToString(G.existencia);

                G.idLibro = lbld.Text;
                G.existencia = int.Parse(existencia) + 1;
                ClsLibros.ActualizarLibrosExis(G);

                MessageBox.Show("Quitar Prestamo Libro correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
