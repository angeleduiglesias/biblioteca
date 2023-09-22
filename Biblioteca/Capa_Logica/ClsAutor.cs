using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Capa_Datos;
using Biblioteca.Capa_Logica;

namespace Biblioteca.Capa_Logica
{
    class ClsAutor
    {
        private const string ParameterName = "@nomAutor";
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataTable dt;

        public static void Llenarcombox()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "llenar_Autor";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            Cn.Close();
        }

        public static void BuscarAutor(Metodo_Autor c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "BUSCAR_AUTOR";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@idAutor", c.idAutor);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Autor no encontrado!");
            }
            while (dr.Read())
            {
                c.idAutor = dr[0].ToString();
                c.nomAutor = dr[1].ToString();
            }
            Cn.Close();
        }

        public static void ActualizarAutor(Metodo_Autor c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "EDITAR_AUTOR";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.VarChar)); // Aquí he cambiado SqlDbType.Char por SqlDbType.VarChar
            Cm.Parameters["@idAutor"].Value = c.idAutor;

            Cm.Parameters.Add(new SqlParameter(ParameterName, SqlDbType.VarChar));
            Cm.Parameters["@nomAutor"].Value = c.nomAutor;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void InsertarAutor(Metodo_Autor c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "INSERTAR_AUTOR";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@idAutor", SqlDbType.Char, 4)); // Ajusta el tamaño si es diferente
            Cm.Parameters["@idAutor"].Value = c.idAutor;

            Cm.Parameters.Add(new SqlParameter("@nomAutor", SqlDbType.VarChar, 50)); // Ajusta el tamaño si es diferente
            Cm.Parameters["@nomAutor"].Value = c.nomAutor;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

    }
}
