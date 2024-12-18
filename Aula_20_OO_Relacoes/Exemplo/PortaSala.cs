using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class PortaSala : Porta
    {
        // Construtor
        public PortaSala(string cor, float largura, float altura, double peso) : base(cor, largura, altura, peso)
        {
        }

        // Subrescrevendo o metodo Abrir
        public override void Abrir()
        {
            Console.WriteLine("Porta da sala aberta");
        }

        // Subrescrevendo o metodo Fechar
        public override void Fechar()
        {
            Console.WriteLine("Porta da sala fechada");
        }
    }
}