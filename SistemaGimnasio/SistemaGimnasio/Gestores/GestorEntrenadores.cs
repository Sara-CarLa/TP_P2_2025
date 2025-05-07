using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Gestores
{
    public class GestorEntrenadores
    {
        //Variable de clase
        private List<Entrenador> entrenadores;

        //Constructor
        public GestorEntrenadores()
        {
            entrenadores = new List<Entrenador>();
        }

        //Metodos
        public void RegistrarEntrenador(string nombre, string especialidad)
        {
            entrenadores.Add(new Entrenador(nombre, especialidad));
        }

        public Entrenador BuscarEntrenador(string nombre)
        {
            return entrenadores.FirstOrDefault(e => e.Nombre == nombre);
        }



    }
}
