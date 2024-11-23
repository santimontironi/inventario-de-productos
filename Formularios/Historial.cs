using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_practico.Clases;

namespace Trabajo_practico
{
    public partial class Historial : Form
    {

        public Historial(DataTable data)
        {
            InitializeComponent();
            dataGridViewHistorial.DataSource = data;
        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos mainForm = new Productos("");
            mainForm.ShowDialog();
        }

        private void buttonBuscarHistorial_Click(object sender, EventArgs e)
        {
            Historiales historial = new Historiales();
            historial.buscarHistorial(comboBox1, dataGridViewHistorial);
        }

        private void buttonReiniciarBusqueda_Click(object sender, EventArgs e)
        {
            Historiales historial = new Historiales();
            this.Hide();
            historial.MostrarHistorial();
        }

        private void buttonGenerarPdf_Click(object sender, EventArgs e)
        {
            // Ruta base para guardar los PDFs, agregando una marca de tiempo para evitar sobreescrituras
            string basePdfPath = @"C:\\Users\\Usuario\\Desktop\\historial_" + DateTime.Now.ToString("dd-MM-yyyy__HH.mm.ss") + ".pdf";

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

                    // Crear una tabla con columnas
                    PdfPTable table = new PdfPTable(3); // 3 columnas para Nombre, Fecha, Rol

                    // Agregar encabezados a la tabla
                    table.AddCell(new Phrase("Nombre"));
                    table.AddCell(new Phrase("Fecha"));
                    table.AddCell(new Phrase("Rol"));

                    // Recorrer el DataGridView y agregar solo las filas visibles a la tabla del PDF
                    foreach (DataGridViewRow row in dataGridViewHistorial.Rows)
                    {
                        // Evitar la fila vacía que aparece al final del DataGridView y agregar solo las filas visibles (filtradas)
                        if (!row.IsNewRow && row.Visible)
                        {
                            table.AddCell(new Phrase(row.Cells["Nombre"].Value.ToString()));
                            table.AddCell(new Phrase(row.Cells["Fecha"].Value.ToString()));
                            table.AddCell(new Phrase(row.Cells["Rol"].Value.ToString()));
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
