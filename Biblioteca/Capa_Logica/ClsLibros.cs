using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Capa_Datos;
using Biblioteca.Capa_Logica;

namespace Biblioteca.Capa_Logica
{
    class ClsLibros
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;

        public static void InsertarLibros(Metodo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "insertar_libros";

            Cm.Parameters.Add(new SqlParameter("@idLibro", SqlDbType.VarChar));
            Cm.Parameters["@idLibro"].Value = c.idLibro;

            Cm.Parameters.Add(new SqlParameter("@tituloLibro", SqlDbType.VarChar));
            Cm.Parameters["@tituloLibro"].Value = c.tituloLibro;

            Cm.Parameters.Add(new SqlParameter("@editorial", SqlDbType.VarChar));
            Cm.Parameters["@editorial"].Value = c.editorial;

            Cm.Parameters.Add(new SqlParameter("@pais", SqlDbType.VarChar));
            Cm.Parameters["@pais"].Value = c.pais;

            Cm.Parameters.Add(new SqlParameter("@año", SqlDbType.VarChar));
            Cm.Parameters["@año"].Value = c.año;

            Cm.Parameters.Add(new SqlParameter("@nPag", SqlDbType.VarChar));
            Cm.Parameters["@nPag"].Value = c.nPag;

            Cm.Parameters.Add(new SqlParameter("@existencia", SqlDbType.VarChar));
            Cm.Parameters["@existencia"].Value = c.existencia; // Sin espacio en el nombre del parámetro

            Cm.CommandType = CommandType.StoredProcedure;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        

        public static void Buscarlibros(Metodo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "Consultar_libros_idlibro";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@idLibro", c.idLibro);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Libro no encontrado");
            }
            while (dr.Read())
            {
                c.idLibro = dr[0].ToString();
                c.tituloLibro = dr[1].ToString();
                c.editorial = dr[2].ToString();
                c.pais = dr[3].ToString();
                c.año = int.Parse(dr[4].ToString());
                c.nPag = int.Parse(dr[5].ToString());
                c.existencia = int.Parse(dr[6].ToString());
            }
            Cn.Close();
        }

        public static void ConsultarlibrosTitulo(Metodo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultar_libros_titulo";
            da.SelectCommand.Parameters.AddWithValue("@tituLolibro", c.tituloLibro);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Libro");
            Cn.Close();
        }

        

        public static void ListarLibros()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "listar_libros";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Libros");

            Cn.Close();
        }

        public static void consultarLibrosPais(Metodo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultar_libros_Pais";
            da.SelectCommand.Parameters.AddWithValue("@pais", c.pais);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Paises");
            Cn.Close();
        }

        public static void consultarLibrosEditorial(Metodo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultar_libros_editorial";
            da.SelectCommand.Parameters.AddWithValue("@editorial", c.editorial);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Editorial");
            Cn.Close();
        }

        public static void consultarLibrosPrestamos(Metodo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VConsultar_libros_Prestamos";
            da.SelectCommand.Parameters.AddWithValue("@librosP", c.librosP);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar LPrestamo");
            Cn.Close();
        }

        public static void ActualizarLibrosExis(Metodo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_librosExis";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = c.idLibro;

            Cm.Parameters.Add(new SqlParameter("@existencia", SqlDbType.Int));
            Cm.Parameters["@existencia"].Value = c.existencia;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }
        public static void ColsultarlibrosPorFecha(Metodo_Prestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "ListarBusquedaDeLibrosPorFecha";
            da.SelectCommand.Parameters.AddWithValue("@FechaInicio", c.FechaInicio);
            da.SelectCommand.Parameters.AddWithValue("@FechaFin", c.FechaFin);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "LibrosPrestados");

            Cn.Close();

        }
        public static void ActualizarLibros(Metodo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_libros";

            Cm.Parameters.Add(new SqlParameter("@idLibro", SqlDbType.VarChar));
            Cm.Parameters["@idLibro"].Value = c.idLibro;

            Cm.Parameters.Add(new SqlParameter("@tituloLibro", SqlDbType.VarChar));
            Cm.Parameters["@tituloLibro"].Value = c.tituloLibro;

            Cm.Parameters.Add(new SqlParameter("@editorial", SqlDbType.VarChar));
            Cm.Parameters["@editorial"].Value = c.editorial;

            Cm.Parameters.Add(new SqlParameter("@pais", SqlDbType.VarChar));
            Cm.Parameters["@pais"].Value = c.pais;

            Cm.Parameters.Add(new SqlParameter("@año", SqlDbType.VarChar));
            Cm.Parameters["@año"].Value = c.año;

            Cm.Parameters.Add(new SqlParameter("@nPag", SqlDbType.VarChar));
            Cm.Parameters["@nPag"].Value = c.nPag;

            Cm.Parameters.Add(new SqlParameter("@existencia", SqlDbType.VarChar));
            Cm.Parameters["@existencia"].Value = c.existencia; // Sin espacio en el nombre del parámetro

            Cm.CommandType = CommandType.StoredProcedure;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }
    }
}

