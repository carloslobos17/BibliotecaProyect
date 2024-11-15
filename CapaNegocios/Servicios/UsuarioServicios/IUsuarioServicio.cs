using CapaEntidad.Entidades;

namespace CapaNegocios.Servicios.UsuarioServicios
{
    public interface IUsuarioServicio
    {
        Usuario? Inicio(string correo, string clave);
    }
}