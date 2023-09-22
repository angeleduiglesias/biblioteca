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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ReporteLibrosAutor reporte = new ReporteLibrosAutor();
            crystalReportViewer1.ReportSource= reporte;
            reporte.SetDatabaseLogon("sa", "Jhony2075");
            reporte.Refresh();
        }
    }
}
