using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace controlStock
{
    class Conexion
    {
        // Ruta del archivo de base de datos Access
        private string route = "E:\\Documentos\\ControlStock.accdb";

        // Cadena de conexión para la base de datos Access
        private string CadenaConexion => $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={route}";

        // Crea un objeto para manejar la conexión a la base de datos.
        private OleDbConnection conexion;

        // Inicializa el objeto de conexión (conexion) 
        // usando la cadena de conexión (CadenaConexion) y lo retorna.
        public OleDbConnection EstablecerConexion()
        {
            try
            {
                // Crear una instancia de la conexión
                this.conexion = new OleDbConnection(this.CadenaConexion);

                // Abrir la conexión
                this.conexion.Open();

                // Retornar la conexión
                return this.conexion;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la conexión
                Console.WriteLine("Error al establecer la conexión: " + ex.Message);
                return null;
            }
        }


    }
}
