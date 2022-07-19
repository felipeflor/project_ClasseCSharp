using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe.Src
{
    public class Carrinho
    {
        public string NomePessoa { get; set; }
        public List<Produto> Produtos { get; set; }

        public double TotalAPagar {get;set;}

        public Carrinho(string nomePessoa)
        {
            NomePessoa = nomePessoa;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void ImprimirCarrinho()
        {
            Console.WriteLine($"Carrinho de {NomePessoa}");
            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto.ToString());
                TotalAPagar += produto.Preco + produto.Quantidade;
            }

            
        }

    }
}
