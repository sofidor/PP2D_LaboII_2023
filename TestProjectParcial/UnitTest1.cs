using BibliotecaDeClases;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestProjectParcial
{
    [TestFixture]
    public class UnitTest1
    {
       
        [Test]
        public void DeserializarJson_DebeDeserializarCorrectamente()
        {
            // Arrange
            Producto producto = new Producto();

            // Act
            string result = producto.DeserializarJson();

            // Assert            
            NUnit.Framework.Assert.IsNotNull(result); // Verifica que el resultado no sea nulo
        }
        
    }
}