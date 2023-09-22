using Biblioteca.Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Capa_Logica
{
    internal class ClsUsuario
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
       

        public static void Login(MetodoUsuario c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.CnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "VerificarAcceso";
            Cm.CommandType = CommandType.StoredProcedure;

            Cm.Parameters.Add(new SqlParameter("@Usuario", c.Usuario));
            Cm.Parameters.Add(new SqlParameter("@Clave", c.Clave));
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("No Encontrado");
            }
            while (dr.Read())
            {
                c.Usuario = dr[0].ToString();
                c.Clave = dr[1].ToString();
            }
            Cn.Close();


        }
    }
}
