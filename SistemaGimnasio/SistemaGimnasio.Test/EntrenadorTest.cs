using SistemaGimnasio.Modelos;
namespace SistemaGimnasio.Test
{
    public  class EntrenadorTest
    {
        [Fact]

        public void AsignarUsuario_DebeAgregarUsuarioALista()
        {
            //Arrange
            var usuario = new Usuario("Jorge",27,"resistencia"); //var: objeto generico por lo que si del otro lado de la igualdad 
            var entrenador = new Entrenador("Carlos", "Fuerza");

            //Act
            entrenador.AsignarUsuario(usuario);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());

        }
    }
}
