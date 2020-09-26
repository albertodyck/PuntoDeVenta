using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PuntoDeVenta
{
    public partial class Login : Form
    {
        public static string nombre = "";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {


            if (textBoxUsuario.Text == "")
            {
                label1.Text = "Te falta el Usuario";
                CambiaColor(textBoxUsuario);
                textBoxUsuario.Focus();
            }
            else if (textBoxContraseña.Text == "")
            {
                label1.Text = "Te falta la contraseña";
                CambiaColor(textBoxContraseña);
                textBoxContraseña.Focus();
            }
            else
            {
                string query = "SELECT * FROM usuarios WHERE usuarioCorreo = '" + textBoxUsuario.Text + "' AND usuarioPassword = SHA2('" + textBoxContraseña.Text + "',256)";
                //label1.Text = "Acceso Correcto";
                //textBoxUsuario.Text = query;
                MySqlConnection mySqlConnection = new MySqlConnection("server = localhost; user=root;database=pos;");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    mySqlDataReader.Read();
                    nombre = mySqlDataReader.GetString(1);

                    this.Hide();
                    new FormPuntoDeVenta().ShowDialog();
                    this.Show();
                }
                else
                {
                    label1.Text = "Usuario o Password Incorrecto";
                }

            }
        }

        private void CambiaColor(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                textBox.BackColor = Color.White;
            }
            else
            {
                textBox.BackColor = Color.LightBlue;
            }
        }
    }
}
