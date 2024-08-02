using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class SubtracaoUnitTest
    {
        //AAA : Act, Arrange, Assert
        [Fact]
        public void TestarMetodoSubtracao()
        {

            //Arrange : Organizar 
            var x1 = 8;
            var y1 = 2;
            var valorEsperadoSubtracao = 6;

            //Act : Agir 
            var subtracao = Calculo.Subtracao(x1, y1);

            //Assert : Provar 
            Assert.Equal(valorEsperadoSubtracao, subtracao);
        }
    }
}
