using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_practico.Formularios
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Clases.Model model = new Clases.Model();
            model.establecerConexion();
            Clases.Login login = new Clases.Login();
            login.RegistrarUsuario(textBoxNombre, textBoxApellido, textBoxUsuario, textBoxClave);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
        }
    }
}
