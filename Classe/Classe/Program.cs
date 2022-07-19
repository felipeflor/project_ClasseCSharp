using System;
using Classe.Src;

namespace Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto kiwi = new Produto(Categoria.FRUTAS, "Kiwi", 5, 1.50);
            Produto manga = new Produto(Categoria.FRUTAS, "Manga", 10, 2.00);
            Produto shampo = new Produto(Categoria.LIMPEZA, "Clear", 1, 15.00);
            Produto picanha = new Produto(Categoria.AÇOUGUE, "Fraldinha", 1, 30.00);
            Produto guarana = new Produto(Categoria.BEBIDAS, "Guaraná Antártica", 2, 6.50);

            Console.WriteLine(kiwi.ToString());

            Carrinho felipe = new Carrinho("Felipe");
        }
    }
}
