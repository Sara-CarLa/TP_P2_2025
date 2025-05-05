
namespace SistemaGimnasio.Modelos
{
    public class Usuario
    {
        //Propiedades
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string Objetivo { get; set; }
        public Rutina RutinaAsignada { get; set; }

        //Constructor
        public Usuario (string nombre, int edad, string objetivo)
        {
            Nombre = nombre;
            Edad = edad;
            Objetivo = objetivo;
        }

        //Métodos
        public void AsignarRutina (Rutina rutina)
        {
            RutinaAsignada = rutina;
        }



    }
}
