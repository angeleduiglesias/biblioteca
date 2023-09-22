using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Capa_Datos
{
    class Metodo
    {
        public string idLibro { get; set; }
        public string tituloLibro { get; set; }
        public string editorial { get; set; }
        public string pais { get; set; }
        public int año { get; set; }
        public int nPag { get; set; }
        public int existencia { get; set; }

        public string nomAutor { get; set; }
        public string librosP { get; set; }

        public string idAutor { get; set; }
        




    }
    public class limpiar
    {
        public void limpiarCampos(Control control, GroupBox gb)
        {
            foreach (var tc in control.Controls)
            {
                if (tc is TextBox)
                    ((TextBox)tc).Clear();
                else if (tc is ComboBox)
                    ((ComboBox)tc).SelectedIndex = -1;

            }
            foreach (var tc in gb.Controls)
            {
                if (tc is TextBox)
                    ((TextBox)tc).Clear();
                else if (tc is ComboBox)
                    ((ComboBox)tc).SelectedIndex = -1;
            }
        }
    }


}
