
using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Gestores
{
    public class GestorRutinas
    {
        //Variable de clase
        private List<Rutina> rutinas;

        //Constructor
        public GestorRutinas()
        {
            rutinas = new List<Rutina>();
        }

        //Metodos
        public void CrearRutina(string nombre, int duracion)
        {
            rutinas.Add(new Rutina(nombre, duracion));
        }

        public Rutina BuscarRutina(string nombre)
        {
            return rutinas.FirstOrDefault(r => r.Nombre == nombre);//el primero que encuentre con la condicion u otro por defecto que va a ser none
        }
            


    }
}
