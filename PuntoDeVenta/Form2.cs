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
    public partial class FormPuntoDeVenta : Form
    {
        float total1 = 0;
        public FormPuntoDeVenta()
        {
            InitializeComponent();
        }

        private void FormPuntoDeVenta_Load(object sender, EventArgs e)
        {
            labelPuntoDeVenta.Location = new Point(this.Width/2-(labelPuntoDeVenta.Width/2),0);
            labelFechaHora.Location = new Point((this.Width/2) - (labelFechaHora.Width/2), labelPuntoDeVenta.Height);
            
            dataGridView1.Location = new Point(10, labelPuntoDeVenta.Height + labelFechaHora.Height);
            dataGridView1.Width = this.Width - 20;
            dataGridView1.Height = this.Height * 7/10;
            textBoxCaptura.Location = new Point(10, (this.Height - textBoxCaptura.Height)-2);
            textBoxCaptura.Width = dataGridView1.Width;

            //Distribuir tamaño de columnas de datagrid
            dataGridView1.Columns[0].Width = dataGridView1.Width * 2 / 10;
            dataGridView1.Columns[1].Width = dataGridView1.Width * 4 / 10;
            dataGridView1.Columns[2].Width = dataGridView1.Width * 2 / 10;
            dataGridView1.Columns[3].Width = dataGridView1.Width * 2 / 10;

            //colocar etiqueta total al margen de la tercer columna
            int x = 10 + dataGridView1.Columns[0].Width + dataGridView1.Columns[1].Width + dataGridView1.Columns[2].Width;
            int y = (this.Height - (labelPuntoDeVenta.Height + labelFechaHora.Height + dataGridView1.Height + textBoxCaptura.Height))/2;

            labelTotal.Location = new Point((x-(labelTotal.Width/2)), this.Height-y-(labelTotal.Height/2)-textBoxCaptura.Height);

            //acomodo del boton
            buttonCalcular.Height = this.Height - labelPuntoDeVenta.Height - labelFechaHora.Height - dataGridView1.Height - textBoxCaptura.Height - 22;
            buttonCalcular.Width = buttonCalcular.Height;
            buttonCalcular.Location = new Point(10, this.Height - y - textBoxCaptura.Height - (buttonCalcular.Height/2)-2);


            //definicion de tamaños:
            int height = this.Height - labelPuntoDeVenta.Height - labelFechaHora.Height - dataGridView1.Height - textBoxCaptura.Height - 22;
            int width = height;

            //boton adicional 1
            buttonCancelar.Height = height;
            buttonCancelar.Width = width;
            buttonCancelar.Location = new Point(10 + buttonCalcular.Width + 10, this.Height - y - textBoxCaptura.Height - (buttonCalcular.Height / 2) - 2);

            //boton adicional 2
            buttonBorrar.Height = height;
            buttonBorrar.Width = width;
            buttonBorrar.Location = new Point(10 + buttonCalcular.Width + 10 + buttonCancelar.Width +10, this.Height - y - textBoxCaptura.Height - (buttonCalcular.Height / 2) - 2);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFechaHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBoxCaptura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
            string query;
            string cantidad;

            if (e.KeyChar == 13 && textBoxCaptura.Text != "")
            {
                if (textBoxCaptura.Text.IndexOf("*") == -1)
                {
                    //MessageBox.Show("Sin asterisco");
                    query = "SELECT * FROM productos WHERE Codigo=" + textBoxCaptura.Text;
                    cantidad = "1";
                }
                else
                {
                    //MessageBox.Show("Con asterisco");
                    string[] cantidad_producto = textBoxCaptura.Text.Split('*');
                    query = "SELECT * FROM productos WHERE Codigo=" + cantidad_producto[1];
                    cantidad = cantidad_producto[0];
                }
                //dataGridView1.Rows.Add(textBoxCaptura.Text,"Mensaje");

               
                MySqlConnection mySqlConnection = new MySqlConnection("server = localhost; user=root;database=pos;");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    float qty = float.Parse(cantidad);
                    float total = qty * mySqlDataReader.GetFloat(2);

                    dataGridView1.Rows.Add(cantidad, mySqlDataReader.GetString(1), mySqlDataReader.GetFloat(2), string.Format("{0:.##}",total));
                }

                //MessageBox.Show(query);
                textBoxCaptura.Clear();
                textBoxCaptura.Focus();

                //calculo de total y en etiqueta
                total1 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    total1 += float.Parse(dataGridView1[3,i].Value.ToString());
                }

                labelTotal.Text = total1.ToString();
            }


            
        }

        private void textBoxCaptura_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                //textBoxCaptura.Text = "";
                //MessageBox.Show(textBoxCaptura.Text.Remove(textBoxCaptura.TextLength-1));

                float pago = float.Parse(textBoxCaptura.Text.Remove(textBoxCaptura.TextLength - 1));
                //MessageBox.Show(pago - total1 + "");
                textBoxCaptura.Focus();
                textBoxCaptura.Clear();

                //limpiar el datagrid
                dataGridView1.Rows.Clear();
                labelTotal.Text = "Cambio: $" + (pago - total1);

            }
        }
    }
}
