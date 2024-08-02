using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura.Test
{
    public class ConverterCelsiusParaFahrenheitUnitTest
    {
        [Theory]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        [InlineData(-40, -40)]
        [InlineData(37, 98.6)]
        [InlineData(-273.15, -459.67)]  // Ponto de zero absoluto
        public void TestarMetodoConverterCelsiusParaFahrenheit(double celsius, double fahrenheitEsperado)
        {
            // Arrange & Act
            var resultado = Conversao.ConverterCelsiusParaFahrenheit(celsius);

            // Assert
            Assert.Equal(fahrenheitEsperado, resultado, precision: 2);
        }
    }
}
