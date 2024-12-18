using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class Cozinha
    {
        // Vou utilizar Agregação com o objeto PortaCozinha
        // Propriedades
        public PortaCozinha PortaCozinha { get; set; }
        public bool Americana { get; set; }
        public float MetragemQuadrada { get; set; }

        // Como eu não vou instanciar a porta da cozinha no construtor
        // Ele pode ser relação de Agregação
        // Construtor
        public Cozinha(bool americana, float metragemQuadrada)
        {
            Americana = americana;
            MetragemQuadrada = metragemQuadrada; 
        }
       
        // Metodo entrou pela porta da cozinha
        public void Entrar (PortaCozinha portaCozinha)
        {
            // Aqui esta ocorrendo a relação de Agregação
            Console.WriteLine("Entrou pela porta da cozinha" + portaCozinha.Cor);
        }

    }
}