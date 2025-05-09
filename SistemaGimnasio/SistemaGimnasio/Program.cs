using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using SistemaGimnasio.Gestores;

Console.WriteLine("=====SISTEMA DE GESTIÓN DE GIMNASIO 'PROGRAM POWER'======");

//Crear ususario
Console.WriteLine("Ingresa el nombre del usuario: ");
string nombreUsuario = Console.ReadLine()??"";

Console.WriteLine("Ingresa la edad del usuario: ");
int edadUsuario = int.Parse(Console.ReadLine() ??"");

Console.WriteLine("Ingresa el objtivo del usuario (ej. Fuerza, Resistencia, etc.)");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear entrenador
Console.WriteLine("Ingresa el nombre del entrenador: ");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador (ej. Fuerza, Resistencia, etc.): ");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador,especialidadEntrenador);

//Crear rutina
Console.WriteLine("Ingresa el nombre de la rutina: ");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duración en minutos de la rutina ");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutiina
Console.WriteLine("¿Cuántos ejercicios tiene la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for(int i=1; i <= numEjercicios; i++)
{
    //Crear ejercicio
    Console.WriteLine($"Ejercicio {i} ");
    Console.WriteLine("Nombre del ejericio: ");
    string nombreEjercicio = Console.ReadLine() ?? "";
    Console.WriteLine("Numero de repeticiones del ejericio: ");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Numero de series del ejericio: ");
    int series = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Tiempo de descanso en minutos del ejercicio: ");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);

    //Asignar ejercicio a rutina
    rutina.AgregarEjercicio(ejercicio);
}

//Asignar rutina y entrenador al usuario

AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Mostrar resumen
Console.WriteLine("=====Resumen de asignación por 'ROGRAM POWER'======");
Console.WriteLine($"Usuario: {usuario.Nombre} \n {usuario.Objetivo}");
Console.WriteLine($"Rutina asignada: {usuario.RutinaAsignada.Nombre}");
Console.WriteLine("Ejercicios a realizar:");

foreach(var e in usuario.RutinaAsignada.ObtenerEjercicios() )
{
    Console.WriteLine($"{e.Nombre} | Series: {e.Series} | Repeticiones: {e.Repeticiones} | Tiempo de descanso: {e.Descanso} ");
}

Console.WriteLine($"Entrenador asignado: {entrenador.Nombre} con especialidad: {entrenador.Especialidad}");

//ACT. 3 ASIGANDOR DE RUTINAS

//PRINCIPIO SOLID, EXCEPTO EL EVALUADOR DE RUTINAS POR LOS DOS TEST QUE SE HICIERON EN LA CLASE

//sUBIR REPORTE Y EL REPOSITORIO