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
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

using Trabajo_practico.Clases;
using Trabajo_practico.Formularios;

namespace Trabajo_practico
{
    public partial class Productos : Form
    {
        public string rolUsuario;

        public Productos(string rol)
        {
            InitializeComponent();
            Clases.Model model = new Clases.Model();
            model.establecerConexion();
            model.mostrarProductos(dataGridViewProductos);
            rolUsuario = rol;
            configurarRol();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;
        }

        public void configurarRol()
        {
            if (rolUsuario == "consultor")
            {
                btnAgregar.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                btnHistorial.Enabled = false;
                textBoxNombreProducto.Enabled = false;
                textBoxPrecio.Enabled = false;
                textBoxStock.Enabled = false;
                btnLimpiarCampos.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clases.Model model = new Clases.Model();
            model.establecerConexion();
            model.agregarProducto(textBoxNombreProducto, textBoxStock, textBoxPrecio);
            model.mostrarProductos(dataGridViewProductos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clases.Model model = new Model();
            model.establecerConexion();
            model.modificarProductos(dataGridViewProductos, textBoxId, textBoxNombreProducto, textBoxStock, textBoxPrecio);
            model.mostrarProductos(dataGridViewProductos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.Model model = new Clases.Model();
            model.establecerConexion();
            model.eliminarProductos(textBoxId, textBoxNombreProducto, textBoxStock, textBoxPrecio);
            model.mostrarProductos(dataGridViewProductos);
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Model model = new Clases.Model();
            model.seleccionarProductos(dataGridViewProductos, textBoxId, textBoxNombreProducto, textBoxStock, textBoxPrecio);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Model model = new Clases.Model();
            model.establecerConexion();
            model.buscarProductos(textBoxBusqueda, dataGridViewProductos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clases.Model model = new Clases.Model();
            model.establecerConexion();
            model.mostrarProductos(dataGridViewProductos);
            textBoxBusqueda.Text = "";
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clases.Model model = new Model();
            model.establecerConexion();

            Clases.Historiales historiales = new Clases.Historiales();
            historiales.MostrarHistorial();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxNombreProducto.Text = "";
            textBoxPrecio.Text = "";
            textBoxStock.Text = "";
        }

        private void buttonGenerarPdf_Click(object sender, EventArgs e)
        {

            // Ruta base para guardar los PDFs, agregando una marca de tiempo para evitar sobreescrituras
            string basePdfPath = @"C:\\Users\\Usuario\\Desktop\\productos_" + DateTime.Now.ToString("dd-MM-yyyy__HH.mm.ss") + ".pdf";

            try
            {
                using (FileStream fs = new FileStream(basePdfPath, FileMode.Create))
                {

                    Document documento = new Document(PageSize.LETTER, 5, 5, 7, 7);
                    PdfWriter pw = PdfWriter.GetInstance(documento, fs);

                    documento.Open();

                    // Título del documento
                    documento.Add(new Paragraph("Historial de productos"));
                    documento.Add(Chunk.NEWLINE); // Salto de línea después del título principal

                    // Crear una tabla con columnas (por ejemplo, Nombre, Precio, Stock)
                    PdfPTable table = new PdfPTable(3); // 3 columnas para Nombre, Precio, Stock

                    // Agregar encabezados a la tabla
                    table.AddCell(new Phrase("Nombre"));
                    table.AddCell(new Phrase("Precio"));
                    table.AddCell(new Phrase("Stock"));

                    // Recorrer el DataGridView y agregar solo las filas visibles a la tabla del PDF
                    foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                    {
                        // Evitar la fila vacía que aparece al final del DataGridView y agregar solo las filas visibles (filtradas)
                        if (!row.IsNewRow && row.Visible)
                        {
                            table.AddCell(new Phrase(row.Cells["Nombre"].Value.ToString()));
                            table.AddCell(new Phrase(row.Cells["Precio"].Value.ToString()));
                            table.AddCell(new Phrase(row.Cells["Stock"].Value.ToString()));
                        }
                    }

                    // Agregar la tabla al documento
                    documento.Add(table);
                    documento.Add(Chunk.NEWLINE); // Salto de línea al final del documento

                    documento.Close(); // Cerrar el documento
                }

                MessageBox.Show("PDF generado exitosamente en: " + basePdfPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }
    }
}
