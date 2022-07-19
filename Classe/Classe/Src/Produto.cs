using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe.Src
{
    public class Produto
    {
        Categoria Tipo { get; set; }

        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public Produto(Categoria tipo, string nome, int quantidade, double preco)
        {
            Tipo = tipo;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"\n Nome do Produto: {Nome}" +
                   $"\n Tipo: {Tipo}" + 
                   $"\n Quantidade: {Quantidade}" +
                   $"\n Preco: {Preco}";
        }
    }

    public enum Categoria
    {
        LACTICINIOS,
        FRUTAS,
        FRIOS,
        LIMPEZA,
        AÇOUGUE,
        BEBIDAS
    }

}
