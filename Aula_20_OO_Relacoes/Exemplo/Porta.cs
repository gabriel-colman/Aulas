using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class Porta
    {
        // Propriedades
        // Se quiser fazer de forma extença
        // private string _cor;
        // Ai faz os metodos get e set
        public string Cor { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public double Peso { get; set; }

        // Construtor
        public Porta(string cor, float largura, float altura, double peso)
        {
            Cor = cor;
            Largura = largura;
            Altura = altura;
            Peso = peso;
        }


        // Metodos que serão herdados
        public virtual void Abrir()
        {
            Console.WriteLine("Porta aberta");
        }

        public virtual void Fechar()
        {
            Console.WriteLine("Porta fechada");
        }
    }
}