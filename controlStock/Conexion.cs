    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.OleDb;
using System.Data.SqlClient;

    namespace controlStock
    {
        class Conexion
        {
        private string CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Escritorio\ControlStock.accdb;Persist Security Info=False;";


        //crea un objeto para manejar la conexión a la base de datos.
        OleDbConnection conexion;


            
        //Inicializa el objeto de conexión (conexion) 
        //usando la cadena de conexión (CadenaConexion) y lo retorna.
        public OleDbConnection EstablecerConexion()
        {

            //ya lo tenes declarado al objeto asique ponemos This
            //crear una conexion con sql conexion
            //asiganmos la instancia al objeto

            this.conexion = new OleDbConnection(this.CadenaConexion);

            return this.conexion;

        }

        public bool ejecutarComandosSinRetornos(OleDbCommand SqlComando)
        {
            try
            {
                // Comando para poder hacer consultas
                OleDbCommand comando = SqlComando;

                // Establecer la conexión con la base de datos
                comando.Connection = this.EstablecerConexion();

                // Abrir la conexión
                conexion.Open();

                // Ejecutar el comando SQL sin retorno de datos
                comando.ExecuteNonQuery();

                // Cerrar la conexión
                conexion.Close();

                return true;
            }
            catch
            {
                // Si ocurre un error, retornar false
                return false;
            }
        }



    }
}