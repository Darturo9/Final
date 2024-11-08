using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; // Asegúrate de agregar esta referencia

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Leer la cadena de conexión desde el archivo App.config
            string connectionString = ConfigurationManager.ConnectionStrings["DBSISTEMA_VENTA"].ConnectionString;

            // Consulta SQL para obtener los datos de la tabla Estudiante
            string query = "SELECT * FROM Estudiante";

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un adaptador de datos
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Crear un DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos obtenidos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error en caso de que ocurra una excepción
                    MessageBox.Show("Error al obtener los datos: " + ex.Message);
                }
            }
        }
    }
}

