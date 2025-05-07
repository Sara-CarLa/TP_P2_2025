

namespace SistemaGimnasio.Modelos
{
    public class Entrenador
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Especialidad { get; set; }

        //Variable de clase
        private List<Usuario> usuariosAsignados;

        //Constructor
        public Entrenador(string nombre, string especialidad)
        {
            Nombre = nombre;
            Especialidad = especialidad;
            usuariosAsignados = new List<Usuario>();

        }

        //Metodos
        public void AsignarUsuario(Usuario usuario)
        {
            usuariosAsignados.Add(usuario);
        }

        public List<Usuario> ObtenerUsuariosAsignados()
        {
            return usuariosAsignados;
        }


    }
}
