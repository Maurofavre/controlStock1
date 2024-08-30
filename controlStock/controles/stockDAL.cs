using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.OleDb;
using controlStock.Bll;

namespace controlStock.controles
{
    internal class stockDAL
    {
        Conexion conexion;

        public stockDAL()
        {
            conexion = new Conexion();
        }
        public bool Agregar(stockBll oStockbll )

        {
            //"+odepartamentoBLL.Departamento+" asi se llama a las partes del objeto
            string query = "INSERT INTO idstock (id, descripcion, cantidad, precio, foto) VALUES (@id, @descripcion, @cantidad, @precio, @foto)";


            // Crear y configurar el comando OleDb
            OleDbCommand SqlComando = new OleDbCommand(query);

            // Añadir el valor del objeto oStock
            SqlComando.Parameters.AddWithValue("@id", oStockbll.Id);
            SqlComando.Parameters.AddWithValue("@descripcion", oStockbll.descripcion);
            SqlComando.Parameters.AddWithValue("@cantidad", oStockbll.stock);
            SqlComando.Parameters.AddWithValue("@precio",oStockbll.precio);
            SqlComando.Parameters.AddWithValue("@foto", oStockbll.categoria);

            return conexion.ejecutarComandosSinRetornos(SqlComando);
        }


    }
}
