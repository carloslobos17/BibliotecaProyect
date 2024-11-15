using CapaEntidad.Entidades;

namespace CapaAccesoDatos.Repositorios.UsuarioRepositorios
{
    public interface IUsuarioRepositorio
    {
        Usuario? ObtenerUsuarioPorCorreoyClave(string Correo, string Clave);
    }
}