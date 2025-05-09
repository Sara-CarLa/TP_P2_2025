using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

namespace SistemaGimnasio.Test
{
    public class AsignadorRutinasTest
    {
        [Fact]

        public void AsignarRutinaAuUsuario_DebeAsiganrUsuarioCorrectamente()
        {
            //Arrange
            var usuario = new Usuario("Carlos", 25, "Fuerza");
            var rutina = new Rutina("FabianRutine", 20);
            var asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarRutinaAUsuario(usuario, rutina);

            //Assert
            Assert.Equal(rutina, usuario.RutinaAsignada);

        }

        [Fact] // Fact: marca la prueba
        public void AsignarUsuarioAEntrenador_DebeIncluirUsuario()
        {
            //Arrange
            var usuario = new Usuario("Carlos", 25, "Fuerza");
            var entrenador = new Entrenador("Carlos", "Fuerza");
            var asignador = new AsignadorRutinas();

            //Act
            asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());

        }

    }
}
