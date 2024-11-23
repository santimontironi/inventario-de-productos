using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Trabajo_practico.Formularios;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Policy;
using System.Security.Cryptography;

namespace Trabajo_practico.Clases
{
    internal class Model
    {
        string stringConexion = "Server=localhost;Database=inventario;Port=3306;Uid=root;Pwd=;";
        MySqlConnection conexion = new MySqlConnection();

        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = stringConexion;
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Ha ocurrido un error: " + ex.Message));
            }
            return conexion;
        }

        public void mostrarProductos(DataGridView listadoProductos)
        {
            try
            {
                string query = "SELECT * FROM productos"; // Extrae todos los datos de la tabla
                MySqlCommand cmd = new MySqlCommand(query, conexion); //se crea un command
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //recupera los datos de la consulta
                System.Data.DataTable dt = new System.Data.DataTable(); //se crea la tabla en memoria para colocar los datos.
                da.Fill(dt); // Llena el DataTable con los datos obtenidos de la consulta 

                listadoProductos.DataSource = dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message);
            }
        }

        public void agregarProducto(TextBox nombreProducto, TextBox stock, TextBox precio)
        {

            if(nombreProducto.Text == "" || stock.Text == "" || precio.Text == "")
            {
                MessageBox.Show("No se puede agregar un producto vacio.");
                return; //hace que la funcion deje de ejecutarse.
            }

            if(!int.TryParse(stock.Text, out int cantidadStock))
            {
                MessageBox.Show("El stock debe ser un numero");
                return;
            }

            if (!int.TryParse(precio.Text, out int precioProducto))
            {
                MessageBox.Show("El precio debe ser un numero");
                return;
            }

            try
            {
                string verProductoRepetido = $"SELECT * FROM productos WHERE nombre = ('{nombreProducto.Text}')";
                MySqlCommand cmd = new MySqlCommand(verProductoRepetido, conexion);

                MySqlDataReader newReader = cmd.ExecuteReader();
                if (newReader.HasRows)
                {
                    MessageBox.Show("Ya existe este producto");
                    newReader.Close();
                    return;
                }

                newReader.Close();

                string agregarProducto = $"INSERT INTO productos (nombre,stock,precio) VALUES ('{nombreProducto.Text}','{stock.Text}','{precio.Text}')";
                MySqlCommand cmd2 = new MySqlCommand(agregarProducto, conexion);

                // Abrir la conexión si está cerrada
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }

                cmd2.ExecuteNonQuery(); // Ejecutar la consulta

                MessageBox.Show("Producto agregado correctamente.");

                nombreProducto.Text = "";
                stock.Text = "";
                precio.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " +  ex.Message);
            }
            finally
            {
                conexion.Close(); //se cierra la conexion de la bd para no gastar recursos.
            }
        }

        public void seleccionarProductos(DataGridView tabla, TextBox id, TextBox nombreProducto, TextBox stock, TextBox precio)
        {
            try
            {
                id.Text = tabla.CurrentRow.Cells[0].Value.ToString();
                nombreProducto.Text = tabla.CurrentRow.Cells[1].Value.ToString(); //seleccion de la primer columna [0]
                stock.Text = tabla.CurrentRow.Cells[2].Value.ToString(); //seleccion de la segunda columna [1]
                precio.Text = tabla.CurrentRow.Cells[3].Value.ToString(); //seleccion de la tercer columna [2]
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        public void eliminarProductos(TextBox id,TextBox nombreProducto, TextBox stock, TextBox precio)
        {

            DialogResult cartelAdvertencia = MessageBox.Show("¿Seguro que deseas eliminar este producto?",
                                                   "Confimar eliminación",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (cartelAdvertencia == DialogResult.Yes)
            {
                try
                {
                    string eliminarProducto = $"DELETE FROM productos WHERE nombre = ('{nombreProducto.Text}')";
                    MySqlCommand myCommand = new MySqlCommand(eliminarProducto, conexion);


                    if (conexion.State == System.Data.ConnectionState.Closed)
                    {
                        conexion.Open();
                    }

                    myCommand.ExecuteNonQuery(); // Ejecutar la eliminación
                    MessageBox.Show("Se eliminaron los datos correctamente.");

                    id.Text = "";
                    nombreProducto.Text = "";
                    stock.Text = "";
                    precio.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.Close(); // Cierra la conexión
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada");
            }
        }

        public void modificarProductos(DataGridView tabla,TextBox id,TextBox nombre, TextBox stock, TextBox precio)
        {
            DialogResult cartelAdvertencia = MessageBox.Show("¿Seguro que deseas modificar este producto?",
                                                   "Confimar modificación",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if (cartelAdvertencia == DialogResult.Yes)
            {
                try
                {
                    if (!int.TryParse(stock.Text, out int cantidadStock))
                    {
                        MessageBox.Show("El stock debe ser un numero");
                        return;
                    }

                    if (!int.TryParse(precio.Text, out int precioProducto))
                    {
                        MessageBox.Show("El precio debe ser un numero");
                        return;
                    }

                    if (nombre.Text == tabla.CurrentRow.Cells[1].Value.ToString() 
                        && stock.Text == tabla.CurrentRow.Cells[2].Value.ToString()
                        && precio.Text == tabla.CurrentRow.Cells[3].Value.ToString())
                    {
                        MessageBox.Show("No se modificó nada ya que no se ingresaron nuevos valores.");
                        return;
                    }
                    else
                    {
                        string modificarProductos = $"UPDATE productos SET nombre = '{nombre.Text}',stock = '{stock.Text}', precio = '{precio.Text}' WHERE id = '{id.Text}'";
                        MySqlCommand myCommand = new MySqlCommand(modificarProductos, conexion);
                        MySqlDataReader reader = myCommand.ExecuteReader();
                        MessageBox.Show("Se modificaron los datos correctamente.");
                        id.Text = "";
                        nombre.Text = "";
                        stock.Text = "";
                        precio.Text = "";
                    }
   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Modificación cancelada");
            }
        }

        public void buscarProductos(TextBox busqueda, DataGridView listado)
        {
            try
            {
                if(busqueda.Text == "")
                {
                    MessageBox.Show("Por favor ingrese un producto a buscar.");
                }

                string consulta = $"SELECT * FROM productos WHERE nombre LIKE '%{busqueda.Text}%'";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                if(dt.Rows.Count < 1)
                {
                    MessageBox.Show("No hay un producto con ese nombre");
                    return;
                }

                listado.DataSource = dt;


            }catch(Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }

        }

        public void cambiarClave(TextBox usuario,TextBox claveNueva)
        {
            try
            {
                if (claveNueva.Text == "")
                {
                    MessageBox.Show("Por favor ingrese una clave nueva.");
                    return;
                }

                string claveNuevaHash = HashPassword(claveNueva.Text);

                string modificarClave = $"UPDATE usuarios SET clave = '{claveNuevaHash}' WHERE usuario = '{usuario.Text}'";
                MySqlCommand myCommand = new MySqlCommand(modificarClave, conexion);
                MySqlDataReader newReader = myCommand.ExecuteReader();
                MessageBox.Show("Se modificó la clave correctamente");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la clave: " + ex.Message);
            }
        }

        public static string HashPassword(string claveNueva)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(claveNueva));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
