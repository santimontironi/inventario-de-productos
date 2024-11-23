namespace Trabajo_practico
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            dataGridViewHistorial = new DataGridView();
            label1 = new Label();
            btnVolver = new Button();
            label2 = new Label();
            buttonBuscarHistorial = new Button();
            buttonReiniciarBusqueda = new Button();
            comboBox1 = new ComboBox();
            buttonGenerarPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.AllowUserToAddRows = false;
            dataGridViewHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorial.Location = new Point(89, 102);
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewHistorial.ReadOnly = true;
            dataGridViewHistorial.Size = new Size(858, 340);
            dataGridViewHistorial.TabIndex = 0;
            dataGridViewHistorial.CellContentClick += dataGridViewHistorial_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(173, 21);
            label1.Name = "label1";
            label1.Size = new Size(430, 62);
            label1.TabIndex = 1;
            label1.Text = "Historial de ingresos";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Cornsilk;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 21);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(144, 55);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver al inicio";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(613, 36);
            label2.Name = "label2";
            label2.Size = new Size(235, 24);
            label2.TabIndex = 3;
            label2.Text = "Buscador de historial por rol";
            // 
            // buttonBuscarHistorial
            // 
            buttonBuscarHistorial.Cursor = Cursors.Hand;
            buttonBuscarHistorial.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuscarHistorial.Location = new Point(777, 66);
            buttonBuscarHistorial.Name = "buttonBuscarHistorial";
            buttonBuscarHistorial.Size = new Size(42, 30);
            buttonBuscarHistorial.TabIndex = 5;
            buttonBuscarHistorial.Text = "🔎";
            buttonBuscarHistorial.UseVisualStyleBackColor = true;
            buttonBuscarHistorial.Click += buttonBuscarHistorial_Click;
            // 
            // buttonReiniciarBusqueda
            // 
            buttonReiniciarBusqueda.Cursor = Cursors.Hand;
            buttonReiniciarBusqueda.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReiniciarBusqueda.Location = new Point(825, 66);
            buttonReiniciarBusqueda.Name = "buttonReiniciarBusqueda";
            buttonReiniciarBusqueda.Size = new Size(75, 30);
            buttonReiniciarBusqueda.TabIndex = 6;
            buttonReiniciarBusqueda.Text = "Reiniciar";
            buttonReiniciarBusqueda.UseVisualStyleBackColor = true;
            buttonReiniciarBusqueda.Click += buttonReiniciarBusqueda_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos", "Administrador", "Consultor" });
            comboBox1.Location = new Point(613, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Todos";
            // 
            // buttonGenerarPdf
            // 
            buttonGenerarPdf.Cursor = Cursors.Hand;
            buttonGenerarPdf.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGenerarPdf.Location = new Point(892, 12);
            buttonGenerarPdf.Name = "buttonGenerarPdf";
            buttonGenerarPdf.Size = new Size(100, 37);
            buttonGenerarPdf.TabIndex = 8;
            buttonGenerarPdf.Text = "Generar pdf";
            buttonGenerarPdf.UseVisualStyleBackColor = true;
            buttonGenerarPdf.Click += buttonGenerarPdf_Click;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 478);
            Controls.Add(buttonGenerarPdf);
            Controls.Add(comboBox1);
            Controls.Add(buttonReiniciarBusqueda);
            Controls.Add(buttonBuscarHistorial);
            Controls.Add(label2);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(dataGridViewHistorial);
            Name = "Historial";
            Text = "Historial";
            Load += Historial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHistorial;
        private Label label1;
        private Button btnVolver;
        private Label label2;
        private Button buttonBuscarHistorial;
        private Button buttonReiniciarBusqueda;
        private ComboBox comboBox1;
        private Button buttonGenerarPdf;
    }
}