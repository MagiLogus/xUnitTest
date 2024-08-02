using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventário
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }
    }

    public static class Inventario
    {
        private static Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

        public static void AdicionarProduto(string nome, int quantidade)
        {
            if (produtos.ContainsKey(nome))
            {
                produtos[nome].Quantidade += quantidade;
            }
            else
            {
                produtos[nome] = new Produto(nome, quantidade);
            }
        }

        public static int ObterQuantidadeProduto(string nome)
        {
            if (produtos.ContainsKey(nome))
            {
                return produtos[nome].Quantidade;
            }
            return 0;
        }

        public static void LimparInventario()
        {
            produtos.Clear();
        }
    }
}
