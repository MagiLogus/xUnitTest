using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.Test
{
    public class ValidarEmailUnitTest
    {
        [Theory]
        [InlineData("teste@dominio.com", true)]
        [InlineData("usuario@site.org", true)]
        [InlineData("nome@dominio", false)]
        [InlineData("email@com", false)]
        [InlineData("semarroba.com", false)]
        [InlineData("sem_ponto@dominio", false)]
        [InlineData("completamente_invalido", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void TestarMetodoValidarEmail(string email, bool resultadoEsperado)
        {
            // Arrange & Act
            var resultado = Validacao.ValidarEmail(email);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
