using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventário.Test
{
    public class ObterQuantidadeProdutoUnitTest
    {
        [Theory]
        [InlineData("Produto A", 10, 10)]
        [InlineData("Produto B", 0, 0)]
        [InlineData("Produto C", 5, 5)]
        public void TestarMetodoObterQuantidadeProduto(string nome, int quantidadeAdicionar, int quantidadeEsperada)
        {
            // Arrange
            Inventario.LimparInventario();
            Inventario.AdicionarProduto(nome, quantidadeAdicionar);

            // Act
            var quantidade = Inventario.ObterQuantidadeProduto(nome);

            // Assert
            Assert.Equal(quantidadeEsperada, quantidade);
        }
    }
}
