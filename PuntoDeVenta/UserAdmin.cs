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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsusuarioId.Clear();
            textBoxNombreUsuario.Clear();
            textBoxContraseña.Clear();
            textBoxCorreo.Clear();
            textBoxUsusuarioId.Focus();

        }

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUsusuarioId.Text = dataGridViewUsuarios[0, e.RowIndex].Value.ToString();
            textBoxNombreUsuario.Text = dataGridViewUsuarios[1, e.RowIndex].Value.ToString();
            textBoxContraseña.Text = dataGridViewUsuarios[2, e.RowIndex].Value.ToString();
            textBoxCorreo.Text = dataGridViewUsuarios[3, e.RowIndex].Value.ToString();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el Usuario: " + textBoxNombreUsuario.Text, "Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string queryEliminar = "DELETE FROM usuarios WHERE usuarioId = '" + textBoxUsusuarioId.Text + "'";
                //MessageBox.Show(queryEliminar);

                MySqlConnection mySqlConnection = new MySqlConnection("server = localhost; user=root;database=pos;");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(queryEliminar, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                //actualizar el datagrid

                UserAdmin_Load(sender, e);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            string queryActualizar = "UPDATE usuarios SET usuarioNombre = '"+textBoxNombreUsuario.Text+"', UsuarioPassword = SHA2('"+textBoxContraseña.Text+"',256), usuarioCorreo = '"+textBoxCorreo.Text+"' WHERE usuarioId = '" + textBoxUsusuarioId.Text + "'";
            MessageBox.Show(queryActualizar);

            MySqlConnection mySqlConnection = new MySqlConnection("server = localhost; user=root;database=pos;");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(queryActualizar, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();

            //actualizar el datagrid

            UserAdmin_Load(sender, e);
        }
    }
}
