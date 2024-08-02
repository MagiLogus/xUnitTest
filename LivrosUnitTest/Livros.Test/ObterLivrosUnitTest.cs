using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Test
{
    public class ObterLivrosUnitTest
    {
        [Fact]
        public void TestarMetodoObterLivros()
        {
            // Arrange
            var livro1 = new Livro("O Alquimista", "Paulo Coelho");
            var livro2 = new Livro("A Menina que Roubava Livros", "Markus Zusak");
            GerenciamentoLivros.LimparLivros();
            GerenciamentoLivros.AdicionarLivro(livro1);
            GerenciamentoLivros.AdicionarLivro(livro2);

            // Act
            var livros = GerenciamentoLivros.ObterLivros();

            // Assert
            Assert.Contains(livro1, livros);
            Assert.Contains(livro2, livros);
        }
    }
}
