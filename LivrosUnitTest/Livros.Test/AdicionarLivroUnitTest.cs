using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Test
{
    public class AdicionarLivroUnitTest
    {
        [Fact]
        public void TestarMetodoAdicionarLivro()
        {
            // Arrange
            var livro = new Livro("O Alquimista", "Paulo Coelho");
            GerenciamentoLivros.LimparLivros();

            // Act
            GerenciamentoLivros.AdicionarLivro(livro);

            // Assert
            var livros = GerenciamentoLivros.ObterLivros();
            Assert.Contains(livro, livros);
        }
    }
}
