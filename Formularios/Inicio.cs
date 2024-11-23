using Trabajo_practico.Formularios;

namespace Trabajo_practico
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Login login = new Clases.Login();
            login.login(textBoxUsuario, textBoxContrasena, this);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuarios registroUsuarios = new RegistroUsuarios();
            registroUsuarios.ShowDialog();
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
           this.Hide();
           CambiarClave formularioCambiarClave = new CambiarClave();
           formularioCambiarClave.ShowDialog();
        }
    }
}
