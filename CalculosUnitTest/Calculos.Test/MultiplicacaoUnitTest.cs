using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class MultiplicacaoUnitTest
    {
        //AAA : Act, Arrange, Assert
        [Fact]
        public void TestarMetodoMultiplicacao()
        {
            //Arrange : Organizar 
            var x1 = 8;
            var y1 = 2;
            var valorEsperadoMultiplicacao = 16;

            //Act : Agir 
            var multiplicacao = Calculo.Multiplicacao(x1, y1);

            //Assert : Provar 
            Assert.Equal(valorEsperadoMultiplicacao, multiplicacao);
        }
    }
}
