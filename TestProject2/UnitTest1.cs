using BibliotecaDeClases;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeserializarXml_ValidarDeserialization() //retorna un string 
        {
            Producto producto = new Producto();

            string mensaje = "La deserialización del archivo XML no devolvió ningún resultado válido";

            string rta = producto.DeserializarXml();

            Assert.AreNotEqual(mensaje,rta);
        }

        [TestMethod]
        public void DeserializarJson_ValidDeserialization()
        {
            Producto producto = new Producto();

            string mensaje = "La deserialización del archivo JSON no devolvió ningún resultado válido";

            string rta = producto.DeserializarJson();

            Assert.AreNotEqual(mensaje, rta);
        }

        [TestMethod]
        public void ValidarNombre_InvalidName_ReturnsFalse()
        {
            // Arrange
            string nombre = "66123";

            // Act
            bool result = nombre.EsNombreValido(); 

            // Assert
            Assert.IsFalse(result);
        }

    }
}