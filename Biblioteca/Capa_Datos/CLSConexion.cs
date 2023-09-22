using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca.Capa_Datos
{
    class CLSConexion
    {
        public static String CnCadena()
        {
            String Str = "SERVER=14ET202-PC17;DataBase = Biblioteca;UID = sa; PWD = Jhony2075 ";
         return Str;
        }
    }
}
