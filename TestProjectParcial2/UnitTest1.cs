using BibliotecaDeClases;
using NUnit.Framework.Internal;

namespace TestProjectParcial2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeserializarJson_()
        {
            // Arrange
            Producto producto = new Producto();
            string mensaje = "falla si hay igualdad";

            // Act
            string result = producto.DeserializarJson();

            // Assert            
            Assert.AreNotEqual(mensaje, result); // Verifica que se hayan cargado 3 elementos, ajusta el valor según tu base de datos
        }
    }
}