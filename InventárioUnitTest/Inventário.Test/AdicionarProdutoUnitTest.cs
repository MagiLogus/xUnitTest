using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventário.Test
{
    public class AdicionarProdutoUnitTest
    {
        [Theory]
        [InlineData("Produto A", 10, 10)]
        [InlineData("Produto A", 5, 15)]
        [InlineData("Produto B", 20, 20)]
        public void TestarMetodoAdicionarProduto(string nome, int quantidadeAdicionar, int quantidadeEsperada)
        {
            // Arrange
            Inventario.LimparInventario();

            // Act
            Inventario.AdicionarProduto(nome, quantidadeAdicionar);
            var quantidadeAtual = Inventario.ObterQuantidadeProduto(nome);

            // Assert
            Assert.Equal(quantidadeEsperada, quantidadeAtual);
        }
    }
}
