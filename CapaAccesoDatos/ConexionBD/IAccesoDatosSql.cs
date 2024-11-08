using System.Data;


namespace CapaAccesoDatos.ConexionBD
{
    public interface IAccesoDatosSql
    {
        IDbConnection GetConnection();
    }
}
