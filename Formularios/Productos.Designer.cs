namespace Trabajo_practico
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            label1 = new Label();
            dataGridViewProductos = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            button2 = new Button();
            button3 = new Button();
            textBoxNombreProducto = new TextBox();
            textBoxStock = new TextBox();
            textBoxPrecio = new TextBox();
            textBoxBusqueda = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button4 = new Button();
            btnHistorial = new Button();
            label6 = new Label();
            textBoxId = new TextBox();
            btnCerrarSesion = new Button();
            btnLimpiarCampos = new Button();
            buttonGenerarPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Tempus Sans ITC", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(385, 12);
            label1.Name = "label1";
            label1.Size = new Size(345, 49);
            label1.TabIndex = 0;
            label1.Text = "Listado de productos";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(429, 129);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.Size = new Size(673, 365);
            dataGridViewProductos.TabIndex = 1;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PowderBlue;
            label3.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 164);
            label3.Name = "label3";
            label3.Size = new Size(204, 27);
            label3.TabIndex = 3;
            label3.Text = "Nombre del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PowderBlue;
            label4.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 206);
            label4.Name = "label4";
            label4.Size = new Size(166, 27);
            label4.TabIndex = 4;
            label4.Text = "Cantidad de stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PowderBlue;
            label5.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 250);
            label5.Name = "label5";
            label5.Size = new Size(67, 27);
            label5.TabIndex = 5;
            label5.Text = "Precio";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Green;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(78, 319);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 37);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(78, 373);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 7;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(225, 319);
            button3.Name = "button3";
            button3.Size = new Size(110, 37);
            button3.TabIndex = 8;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBoxNombreProducto
            // 
            textBoxNombreProducto.Location = new Point(225, 164);
            textBoxNombreProducto.Name = "textBoxNombreProducto";
            textBoxNombreProducto.Size = new Size(158, 23);
            textBoxNombreProducto.TabIndex = 10;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(225, 206);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(160, 23);
            textBoxStock.TabIndex = 11;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(225, 250);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(160, 23);
            textBoxPrecio.TabIndex = 12;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Location = new Point(636, 97);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(249, 23);
            textBoxBusqueda.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(553, 97);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 14;
            label2.Text = "Buscador";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(891, 95);
            button1.Name = "button1";
            button1.Size = new Size(31, 28);
            button1.TabIndex = 15;
            button1.Text = "🔍";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(983, 92);
            button4.Name = "button4";
            button4.Size = new Size(83, 31);
            button4.TabIndex = 16;
            button4.Text = "Reiniciar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = SystemColors.HotTrack;
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = SystemColors.ControlLightLight;
            btnHistorial.Location = new Point(45, 19);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(150, 44);
            btnHistorial.TabIndex = 17;
            btnHistorial.Text = "Ver historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PowderBlue;
            label6.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(15, 124);
            label6.Name = "label6";
            label6.Size = new Size(76, 27);
            label6.TabIndex = 18;
            label6.Text = "Codigo";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(225, 124);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(158, 23);
            textBoxId.TabIndex = 19;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Red;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesion.Location = new Point(963, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(139, 42);
            btnCerrarSesion.TabIndex = 20;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.BackColor = SystemColors.WindowText;
            btnLimpiarCampos.Cursor = Cursors.Hand;
            btnLimpiarCampos.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiarCampos.ForeColor = SystemColors.ControlLightLight;
            btnLimpiarCampos.Location = new Point(225, 373);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(133, 37);
            btnLimpiarCampos.TabIndex = 21;
            btnLimpiarCampos.Text = "Limpiar campos";
            btnLimpiarCampos.UseVisualStyleBackColor = false;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // buttonGenerarPdf
            // 
            buttonGenerarPdf.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGenerarPdf.Location = new Point(249, 21);
            buttonGenerarPdf.Name = "buttonGenerarPdf";
            buttonGenerarPdf.Size = new Size(109, 42);
            buttonGenerarPdf.TabIndex = 22;
            buttonGenerarPdf.Text = "Generar PDF";
            buttonGenerarPdf.UseVisualStyleBackColor = true;
            buttonGenerarPdf.Click += buttonGenerarPdf_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1114, 506);
            Controls.Add(buttonGenerarPdf);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(btnCerrarSesion);
            Controls.Add(textBoxId);
            Controls.Add(label6);
            Controls.Add(btnHistorial);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBoxBusqueda);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxNombreProducto);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridViewProductos);
            Controls.Add(label1);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewProductos;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button button2;
        private Button button3;
        private TextBox textBoxNombreProducto;
        private TextBox textBoxStock;
        private TextBox textBoxPrecio;
        private TextBox textBoxBusqueda;
        private Label label2;
        private Button button1;
        private Button button4;
        private Button btnHistorial;
        private Label label6;
        private TextBox textBoxId;
        private Button btnCerrarSesion;
        private Button btnLimpiarCampos;
        private Button buttonGenerarPdf;
    }
}