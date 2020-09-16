namespace PuntoDeVenta
{
    partial class FormPuntoDeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelPuntoDeVenta = new System.Windows.Forms.Label();
            this.labelFechaHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCaptura = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPuntoDeVenta
            // 
            this.labelPuntoDeVenta.AutoSize = true;
            this.labelPuntoDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntoDeVenta.Location = new System.Drawing.Point(13, 13);
            this.labelPuntoDeVenta.Name = "labelPuntoDeVenta";
            this.labelPuntoDeVenta.Size = new System.Drawing.Size(154, 24);
            this.labelPuntoDeVenta.TabIndex = 0;
            this.labelPuntoDeVenta.Text = "Punto de Venta";
            // 
            // labelFechaHora
            // 
            this.labelFechaHora.AutoSize = true;
            this.labelFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaHora.Location = new System.Drawing.Point(17, 63);
            this.labelFechaHora.Name = "labelFechaHora";
            this.labelFechaHora.Size = new System.Drawing.Size(120, 24);
            this.labelFechaHora.TabIndex = 1;
            this.labelFechaHora.Text = "Fecha,Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Producto,
            this.Precio,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(35, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(596, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // textBoxCaptura
            // 
            this.textBoxCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaptura.Location = new System.Drawing.Point(35, 418);
            this.textBoxCaptura.Name = "textBoxCaptura";
            this.textBoxCaptura.Size = new System.Drawing.Size(100, 35);
            this.textBoxCaptura.TabIndex = 3;
            this.textBoxCaptura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCaptura_KeyPress);
            this.textBoxCaptura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCaptura_KeyUp);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(518, 286);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(113, 24);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total : $0.0";
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackgroundImage = global::PuntoDeVenta.Properties.Resources.iconfinder_free_27_616650;
            this.buttonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBorrar.Location = new System.Drawing.Point(326, 286);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(129, 109);
            this.buttonBorrar.TabIndex = 7;
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = global::PuntoDeVenta.Properties.Resources.iconfinder_minus_1645995;
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancelar.Location = new System.Drawing.Point(182, 286);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(129, 109);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackgroundImage = global::PuntoDeVenta.Properties.Resources.iconfinder_5_3319635;
            this.buttonCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCalcular.Location = new System.Drawing.Point(38, 286);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(129, 109);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.UseVisualStyleBackColor = true;
            // 
            // FormPuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxCaptura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelFechaHora);
            this.Controls.Add(this.labelPuntoDeVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPuntoDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPuntoDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPuntoDeVenta;
        private System.Windows.Forms.Label labelFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCaptura;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrar;
    }
}