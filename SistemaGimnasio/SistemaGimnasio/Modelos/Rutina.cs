

namespace SistemaGimnasio.Modelos
{
    public class Rutina
    {
        //Propiedades: se requiere al instanciar el objeto
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        //Variable de clase: se construte en el flujo del programa
        private List<Ejercicio> ejercicios;

        //Constructor
        public Rutina(string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
        }

        //Métodos
        public void AgregarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Add(ejercicio);
        }

        public List<Ejercicio> ObtenerEjercicios()
        {
            return ejercicios;
        }

        public void BorrarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Remove(ejercicio);
        }
         
            
            
            



    }
}
