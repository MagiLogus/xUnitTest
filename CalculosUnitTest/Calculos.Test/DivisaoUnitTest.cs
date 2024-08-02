using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class DivisaoUnitTest
    {
        //AAA : Act, Arrange, Assert
        [Fact]
        public void TestarMetodoDivisao()
        {
            //Arrange : Organizar 
            var x1 = 8;
            var y1 = 2;
            var valorEsperadoDivisao = 4;

            //Act : Agir 
            var divisao = Calculo.Divisao(x1, y1);

            //Assert : Provar 
            Assert.Equal(valorEsperadoDivisao, divisao);
        }
    }
}
