using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Capa_Datos;

namespace Biblioteca.Capa_Logica
{
    class Clslibros_Autor
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
       
        


        public static void InsertarLibrosAutor( Metodo_Libro_Autor lA)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "InsertarLibro_Autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idLibro", SqlDbType.VarChar));
            Cm.Parameters["@idLibro"].Value = lA.ididlibro;
            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.VarChar));
            Cm.Parameters["@idAutor"].Value = lA.idAutor;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        

        public static void BuscarLibrosAutores(Metodo_Libro_Autor lA)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "VConsultar_libros_Autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@idLibro", lA.ididlibro);
            dr = Cm.ExecuteReader();
            if (dr.HasRows==false)
            {
                throw new Exception("Libro no ecncontrado");

            }
            while (dr.Read())
            {
                lA.ididlibro = dr[0].ToString();
                lA.nomAutor = dr[1].ToString();
            }

           
            Cn.Close();
        }
        public static void ActualizarLibrosExis(Metodo_Prestamo c)
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
        public static void ActualizarLibrosAutor(Metodo_Libro_Autor lA)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "ActualizarLibros_Autor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idLibro", SqlDbType.VarChar));
            Cm.Parameters["@idLibro"].Value = lA.ididlibro;
            Cm.Parameters.Add(new SqlParameter("@nuevoIdAutor", SqlDbType.VarChar));
            Cm.Parameters["@nuevoIdAutor"].Value = lA.idAutor;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }



    }
}
