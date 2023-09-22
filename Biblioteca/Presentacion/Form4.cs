using Biblioteca.Capa_Datos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Biblioteca.Capa_Logica;

namespace Biblioteca.Presentacion
{
    public partial class Form4 : Form
    {
        private string cadenaConexion = CLSConexion.CnCadena(); // Reemplaza con tu cadena de conexión

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Configura el DataGridView
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            // Configura el DataGridView para mostrar los resultados
            dataGridView1.AutoGenerateColumns = true; // Permitir que las columnas se generen automáticamente
            dataGridView1.ReadOnly = true; // El usuario no puede editar los resultados
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar el ancho de las columnas

            // Agrega columnas personalizadas si es necesario (esto depende de tu diseño)
            // Por ejemplo, puedes agregar columnas como ID de libro, título, autor, etc.
            //dataGridView1.Columns.Add("IdLibro", "ID de Libro");
            //dataGridView1.Columns.Add("Titulo", "Título");

            // Configura las propiedades de las columnas, si es necesario
            // Por ejemplo, puedes ajustar el ancho de una columna específica
            //dataGridView1.Columns["Titulo"].Width = 200;
        }

        private void ObtenerLibrosPorAnio(int anioDesde, int anioHasta)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Define la consulta SQL para buscar libros en el rango de años
                    string consulta = "SELECT * FROM Libros " +
                                      "WHERE año BETWEEN @AnioDesde AND @AnioHasta";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@AnioDesde", anioDesde);
                    comando.Parameters.AddWithValue("@AnioHasta", anioHasta);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaLibros = new DataTable();
                    adaptador.Fill(tablaLibros);

                    // Asigna los resultados al DataGridView
                    dataGridView1.DataSource = tablaLibros;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar libros: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén los valores desde y hasta ingresados por el usuario
            if (!int.TryParse(txtDesde.Text, out int anioDesde) || !int.TryParse(txtHasta.Text, out int anioHasta))
            {
                MessageBox.Show("Por favor, ingrese años válidos.");
                return;
            }

            // Realiza la búsqueda de libros por año
            ObtenerLibrosPorAnio(anioDesde, anioHasta);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHasta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


