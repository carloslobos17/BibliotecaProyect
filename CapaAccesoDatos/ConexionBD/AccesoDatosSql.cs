using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CapaAccesoDatos.ConexionBD
{
    public class AccesoDatosSql : IAccesoDatosSql
    {
        private readonly IConfiguration _configuration;
        private readonly string _cadenaDeConexion;

        public AccesoDatosSql(IConfiguration configuration)
        {
            _configuration = configuration;
            _cadenaDeConexion = _configuration.GetConnectionString("default");
        }

        public IDbConnection GetConnection() => new SqlConnection(_cadenaDeConexion);
    }
}
