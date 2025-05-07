using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Servicios
{
    public class AsignadorRutinas
    {
        //Métodos
        public void AsignarRutinaAUsuario(Usuario usuario, Rutina rutina)
        {
            usuario.AsignarRutina(rutina);
        }

        public void AsignarUsuarioAEntrenador(Usuario usuario, Entrenador entrenador) //No sería buena practica tenerlo junto
        {
            entrenador.AsignarUsuario(usuario);
        }

    }
}
