using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class SomaUnitTest
    {
        //AAA : Act, Arrange, Assert
        [Fact]
        public void TestarMetodoSomar()
        {
            //Arrange : Organizar 
            var x1 = 8;
            var y1 = 2;
            var valorEsperadoSoma = 10;

            //Act : Agir 
            var soma = Calculo.Somar(x1, y1);

            //Assert : Provar 
            Assert.Equal(valorEsperadoSoma, soma);
        }
    }
}
