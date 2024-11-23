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

namespace Trabajo_practico.Formularios
{
    public partial class CambiarClave : Form
    {
        public CambiarClave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
        }

        private void btnEnviarClaveNueva_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.establecerConexion();
            model.cambiarClave(textBoxUsuario,textBoxClaveNueva);
        }
    }
}
