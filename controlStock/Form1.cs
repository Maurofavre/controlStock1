using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase Conexion
            Conexion conexion = new Conexion();
                
            // Intentar establecer la conexión
            try
            {
                var dbConnection = conexion.EstablecerConexion();
                dbConnection.Open();

                // Si la conexión se establece correctamente, muestra un mensaje
                MessageBox.Show("Conexión exitosa a la base de datos.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar la conexión después de la verificación
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                // Si ocurre un error, muestra un mensaje de error
                MessageBox.Show("Error al establecer la conexión: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModi_Click(object sender, EventArgs e)
        {

        }
    }
}
