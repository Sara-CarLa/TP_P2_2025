
using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Gestores
{
    public class GestorUsuarios
    {
        //Variable de clase
        private List<Usuario> usuarios;

        //Constructor
        public GestorUsuarios()
        {
            usuarios = new List<Usuario>();
        }

        //Metodos
        public void RegistrarUsuario(string nombre, int edad, string objetivo)
        {
            usuarios.Add(new Usuario(nombre, edad, objetivo));
        }

        public Usuario BuscarUsuario(string nombre)
        {
            return usuarios.FirstOrDefault(u => u.Nombre == nombre);
        }


    }
}


