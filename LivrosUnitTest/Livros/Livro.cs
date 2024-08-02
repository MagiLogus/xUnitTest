using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    public static class GerenciamentoLivros
    {
        private static List<Livro> livros = new List<Livro>();

        public static void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public static List<Livro> ObterLivros()
        {
            return new List<Livro>(livros);
        }

        public static void LimparLivros()
        {
            livros.Clear();
        }
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
