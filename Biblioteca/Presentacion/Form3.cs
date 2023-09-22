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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void prestamosLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form1= new Form5();
            form1.ShowDialog();
        }

        private void consultaFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form1= new Form6();
            form1.ShowDialog();
        }

        private void consultaAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            form1.ShowDialog();
        }

        private void examinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Examinar ex = new Examinar();
            ex.ShowDialog();
        }

        private void aCCESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login AC = new Login();
            AC.ShowDialog();
        }
    }
}
