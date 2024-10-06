using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos.ConexionBD
{
    public class AccesoDatosSql
    {
        private readonly string _cadenaDeConexion;

        public AccesoDatosSql()
        {
            _cadenaDeConexion = "Data Source=DESKTOP-NFDMETJ\\SQLEXPRESS;Initial Catalog=BibliotecaDB;Integrated Security=True;Encrypt=False";
        }

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_cadenaDeConexion);
        }
    }
}
