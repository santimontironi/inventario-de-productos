using MySql.Data.MySqlClient;
using System.Data;

namespace Trabajo_practico.Clases
{
    internal class Historiales
    {      
        public void MostrarHistorial()
        {

            try
            {
                //Establecer conexion
                Clases.Model conexion = new Clases.Model();
                MySqlConnection con = conexion.establecerConexion();
              
                string query = $"SELECT DATE_FORMAT(historial.fecha, '%Y-%m-%d %H:%i:%s') as fecha, usuarios.nombre, usuarios.apellido, usuarios.rol " +
                               $"FROM historial " +
                               $"JOIN usuarios ON historial.id_usuario = usuarios.id " +
                               $"ORDER BY historial.fecha DESC"; // Extrae todos los datos de la tabla mostrandose en orden de fecha

                MySqlCommand cmd = new MySqlCommand(query, con); //se crea un command
               
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //recupera los datos de la consulta
                DataTable dt = new DataTable(); //se crea la tabla en memoria para colocar los datos.

                da.Fill(dt);
              
                Historial historial = new Historial(dt);
                
                historial.ShowDialog();
        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar historial: " + ex.Message);
            }
        }

        public void buscarHistorial(ComboBox comboBoxRol, DataGridView listado)
        {
            // Establecer la conexión
            Clases.Model conexion = new Clases.Model();
            MySqlConnection con = conexion.establecerConexion();

            try
            {
                // Obtener el valor seleccionado del ComboBox
                string rolSeleccionado = comboBoxRol.SelectedItem.ToString();

                // Construir la consulta base SQL
                string query = "SELECT DATE_FORMAT(historial.fecha, '%Y-%m-%d %H:%i:%s') as fecha, usuarios.nombre, usuarios.apellido, usuarios.rol " +
                               "FROM historial " +
                               "JOIN usuarios ON historial.id_usuario = usuarios.id ";

                // Si la opción seleccionada es "TODOS", no agregamos cláusula WHERE
                if (rolSeleccionado == "Todos")
                {
                    query += "ORDER BY historial.fecha DESC";
                }
                else
                {
                    // Si no es "TODOS", se agrega la cláusula WHERE para filtrar por el rol seleccionado
                    query += $"WHERE usuarios.rol = '{rolSeleccionado}' " +
                             "ORDER BY historial.fecha DESC";
                }

                // Crear el comando MySQL
                MySqlCommand cmd = new MySqlCommand(query, con);

                // Ejecutar la consulta
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);

                // Verificar si hay resultados
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("No hay historial disponible para el rol seleccionado.");
                    return;
                }

                // Asignar los resultados al DataGridView
                listado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el historial: " + ex.Message);
            }
        }

    }
}
