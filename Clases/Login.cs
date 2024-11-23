using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.Drawing;
using System.Text.RegularExpressions;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Trabajo_practico.Clases
{
    internal class Login
    {
        public void login(TextBox usuario, TextBox contrasena, Form inicio)
        {
           
            try
            {
                //Establecer conexion
                Clases.Model conexion = new Clases.Model();
                MySqlConnection con = conexion.establecerConexion();

                // Hashear la contraseña ingresada
                string hashedPassword = HashPassword(contrasena.Text);

                //Generar la consulta y ejecutarla
                string controlDatos = $"SELECT id,rol FROM usuarios where usuario = '{usuario.Text}' AND clave = '{hashedPassword}'";
                MySqlCommand cmd = new MySqlCommand(controlDatos, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                

                //Verifica que haya coincidencias
                if (reader.HasRows)
                {

                    MessageBox.Show("Ingreso exitoso");
                    reader.Read();
                    int id = reader.GetInt32("id");  //obtener el id del usuario
                    string rol = reader["rol"].ToString(); //obtener el rol del usuario

                    RegistrarHistorial(id);

                    //Cerrar el formulario actual de login.
                    inicio.Hide();

                    //Abrir el formulario de productos.
                    Productos mainForm = new Productos(rol);
                    mainForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }

                //Cerrar la conexion y el lector
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " +  ex.Message);
            }
        }

        // Método para hashear la contraseña
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void RegistrarHistorial(int idUsuario)
        {
            DateTime fecha = DateTime.Now;
            string fechaFormateada = fecha.ToString("yyyy/MM/dd HH:mm:ss");

            try
            {
                //Establecer conexion
                Clases.Model conexion = new Clases.Model();
                MySqlConnection con = conexion.establecerConexion();

                string query = $"INSERT INTO historial(id_usuario,fecha) VALUES ('{idUsuario}','{fechaFormateada}')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery(); //se ejecuta la consulta
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al registrar historial: " + ex.Message);
            }
        }

        public void RegistrarUsuario(TextBox nombre, TextBox apellido, TextBox usuario, TextBox clave)
        {
            try
            {
                Clases.Model model = new Model();
                MySqlConnection con = model.establecerConexion();

                if (nombre.Text == "" || apellido.Text == "" || usuario.Text == "" || clave.Text == "")
                {
                    MessageBox.Show("Debe rellenar todos los campos");
                    return;
                }

                if (!ValidarClave(clave.Text))
                {
                    MessageBox.Show("La contraseña debe tener un caracter especial, una mayuscula y minimo 8 caracteres.");
                    return;
                }

                string controlDatos = $"SELECT usuario FROM usuarios where usuario = '{usuario.Text}'";
                MySqlCommand cmd = new MySqlCommand(controlDatos, con);
                MySqlDataReader reader = cmd.ExecuteReader();


                //Verifica que haya coincidencias
                if (reader.HasRows)
                {
                    MessageBox.Show("Ya hay un usuario con este nombre de usuario");
                    reader.Close();
                    return;
                }

                reader.Close();

                string claveHash = HashPassword(clave.Text);

                string query = $"INSERT INTO usuarios(nombre,apellido,usuario,clave) VALUES ('{nombre.Text}','{apellido.Text}', '{usuario.Text}', '{claveHash}')";
                MySqlCommand cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();
                

                string modificarProductos = $"UPDATE usuarios SET rol = 'consultor' WHERE usuario = '{usuario.Text}'";
                MySqlCommand myCommand = new MySqlCommand(modificarProductos, con);
                MySqlDataReader reader2 = myCommand.ExecuteReader();

                MessageBox.Show("Se creó el usuario correctamente");

                nombre.Text = "";
                apellido.Text = "";
                usuario.Text = "";
                clave.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
            }
        }

        private bool ValidarClave(string clave)
        {
            // Expresión regular para verificar al menos 1 mayúscula1, un carácter especial y mínimo 8 caracteres
            string pattern = @"^(?=.*[A-Z])(?=.*[!@#$%^&*()_+{}\[\]:;'"",.<>?|\\/~`-])(?=.{8,})";
            return Regex.IsMatch(clave, pattern);
        }
    }
}
