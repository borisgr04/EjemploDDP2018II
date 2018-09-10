using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operaciones;

namespace OperacionesTest
{
    [TestClass]
    public class ArtimeticaTest
    {
        [TestMethod]
        public void TestSumar()
        {
            // Arrange //Preparación
            var aritmerica = new Artimetica();

            // Act  // Acción
            var total=aritmerica.Sumar(5, 6);

            // Assert // Comparación
            Assert.AreEqual(11, total);
        }
        /// <summary>
        /// Escenario
        /// Dado que el usuario digita los numeros 10, 2
        /// Cuando presiona el botón dividir
        /// El sistema presenta  que el resultado es 5 
        /// </summary>
        [TestMethod]
        public void TestDividir()
        {
            // Arrange //Preparación
            var aritmerica = new Artimetica();

            // Act  // Acción
            var response = aritmerica.Dividir(10, 2);

            // Assert // Comparación
            Assert.AreEqual(5, response.Resultado);
        }

        /// <summary>
        /// Escenario
        /// Dado que el usuario digita el dividendo 2 y el divisor 10
        /// Cuando presiona el botón dividir
        /// El sistema presenta  que el resultado es 0,2
        /// </summary>
        [TestMethod]
        public void TestDividirCaso2()
        {
            // Arrange //Preparación
            var aritmerica = new Artimetica();

            // Act  // Acción
            var response = aritmerica.Dividir(2, 10);

            // Assert // Comparación
            Assert.AreEqual(0.2f, response.Resultado);
        }

        /// <summary>
        /// Escenario
        /// Dado que el usuario digita el dividendo 2 y el divisor 0
        /// Cuando presiona el botón dividir
        /// El sistema presenta  que el resultado es Error Dvisión no válida.
        /// </summary>
        [TestMethod]
        public void TestDividirCasoDivisionEntreCero()
        {
            // Arrange //Preparación
            var aritmerica = new Artimetica();

            // Act  // Acción
            var response = aritmerica.Dividir(2, 0);

            // Assert // Comparación
            Assert.AreEqual("Error Dvisión no válida.", response.MensajeError);
        }
    }
}


