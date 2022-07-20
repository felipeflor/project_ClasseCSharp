using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEntrega.Src
{
    public class Filmes
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Classificacao { get; set; }
        public int Duracao { get; set; }
        public string Estudio { get; set; }
        public string Idioma { get; set; }
        public string tipoReproducao { get; set; }

        public Filmes(string titulo, string genero, 
            int classificacao, int duracao, string estudio, string idioma, string tipoReproducao)
        {
            Titulo = titulo;
            Genero = genero;
            Classificacao = classificacao;
            Duracao = duracao;
            Estudio = estudio;
            Idioma = idioma;
            this.tipoReproducao = tipoReproducao;
        }

        public override string ToString()
        {
            return $"\n Título do filme: {Titulo}" +
                $"\n Genero: {Genero}" +
                $"\n Classificação Indicativa: {Classificacao}" +
                $"\n Duração: {Duracao}" +
                $"\n Estúdio: {Estudio}" +
                $"\n Idioma: {Idioma}" +
                $"\n Tipo de Reprodução: {this.tipoReproducao}";
        }
    }

    public enum Categoria
    {
        COMEDIA, ROMANCE, FICCAO, ACAO, SUSPENSE
    }
}
