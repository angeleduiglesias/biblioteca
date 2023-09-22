using Biblioteca.Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;
using Biblioteca.Usuario;
using Biblioteca.Capa_Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Biblioteca.Presentacion;

namespace Biblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ACCESO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodoUsuario US = new MetodoUsuario();

            US.Usuario = textBox1.Text;
            US.Clave = textBox2.Text;

            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                try
                {
                    ClsUsuario.Login(US);
                    Form1 frm = new Form1();

                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Mostrar el mensaje de la excepción
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debes rellenar los campos");
            }
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
