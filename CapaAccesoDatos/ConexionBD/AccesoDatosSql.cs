using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos.ConexionBD
{
    public class AccesoDatosSql : IAccesoDatosSql
    {
        private readonly string _cadenaDeConexion;

        public AccesoDatosSql()
        {
            _cadenaDeConexion = "Data Source=DESKTOP-NFDMETJ\\SQLEXPRESS;Initial Catalog=BibliotecaDB;Integrated Security=True;Trust Server Certificate=True";
        }

        public IDbConnection GetConnection() => new SqlConnection(_cadenaDeConexion);
    }
}
