using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Capa_Datos;
using System.Data.SqlClient;


namespace Biblioteca.Capa_Logica
{
    internal class ClsPrestamo
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
       
        public static void InsertarPrestamo(Metodo_Prestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_Prestamo";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = c.idLibro;
            Cm.Parameters.Add(new SqlParameter("@FechaP", SqlDbType.Date));
            Cm.Parameters["@FechaP"].Value = c.FechaP;
            Cm.Parameters.Add(new SqlParameter("@FechaD", SqlDbType.Date));
            Cm.Parameters["@FechaD"].Value = c.FechaD;
            Cm.Parameters.Add(new SqlParameter("@Anulado", SqlDbType.VarChar));
            Cm.Parameters["@Anulado"].Value = c.anulado;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();

        }
        public static void AnularPrestamo(Metodo_Prestamo c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Anular_Prestamo";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idlibro", SqlDbType.VarChar));
            Cm.Parameters["@idlibro"].Value = c.idLibro;
            Cm.Parameters.Add(new SqlParameter("@Anulado", SqlDbType.VarChar));
            Cm.Parameters["@Anulado"].Value = c.anulado;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();

        }
        
    }
}
