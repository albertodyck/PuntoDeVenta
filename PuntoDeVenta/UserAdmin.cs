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
    public partial class UserAdmin : Form
    {
        string query = "SELECT * FROM usuarios";
        public UserAdmin()
        {
            InitializeComponent();
        }

        private void UserAdmin_Load(object sender, EventArgs e)
        {
            dataGridViewUsuarios.Rows.Clear();
            MySqlConnection mySqlConnection = new MySqlConnection("server = localhost; user=root;database=pos;");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {


                dataGridViewUsuarios.Rows.Add(mySqlDataReader.GetInt32(0), mySqlDataReader.GetString(1), mySqlDataReader.GetString(2), mySqlDataReader.GetString(3)); 
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string queryInsert = "INSERT INTO usuarios (usuarioId, usuarioNombre, usuarioPassword, usuarioCorreo) VALUES ('" + textBoxUsusuarioId.Text +"','"+textBoxNombreUsuario.Text+"',SHA2('"+ textBoxContraseña.Text+"',256),'" +textBoxCorreo.Text+"')";
            MessageBox.Show(queryInsert);

            MySqlConnection mySqlConnection = new MySqlConnection("server = localhost; user=root;database=pos;");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(queryInsert, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();

            //actualizar el datagrid

            UserAdmin_Load(sender, e);
        }
    }
}
