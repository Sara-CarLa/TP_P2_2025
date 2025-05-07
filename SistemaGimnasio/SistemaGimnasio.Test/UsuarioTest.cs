using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class UsuarioTest
    {
        [Fact] //
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            //Arrange
            var usuario = new Usuario("Carlos", 25, "Fuerza");
            var rutina = new Rutina("Rutina de fuerza", 60);

            //Act
            usuario.AsignarRutina(rutina);

            //Assert
            Assert.Equal("Rutina de fuerza", usuario.RutinaAsignada.Nombre);

        }
    }
}