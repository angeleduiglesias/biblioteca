using System;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Capa_Datos;

namespace Biblioteca.Usuario
{
    public class ValidarUsuario
    {
        private static string cadenaConexion = CLSConexion.CnCadena();

        public static string VerificarUsuario(Acceso acceso)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand("VerificarAcceso", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Usuario", acceso.Usuario);
                        comando.Parameters.AddWithValue("@Clave", acceso.Clave);

                        SqlParameter mensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 50);
                        mensaje.Direction = ParameterDirection.Output;
                        comando.Parameters.Add(mensaje);

                        comando.ExecuteNonQuery();

                        return comando.Parameters["@Mensaje"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones aquí (registra o muestra el error)
                    Console.WriteLine("Error: " + ex.Message);
                    return "Error al verificar el acceso";
                }
            }
        }
    }
}
