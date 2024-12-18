using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes.Exemplo
{
    public class Quarto
    {
        // Propriedades do Quarto
        public PortaQuarto PortaQuarto { get; set; }
        public bool Banheiro { get; set; }
        public float MetragemQuadrada { get; set; }

        // Construtor, vai ter uma relação de Composição com a porta do quarto
        public Quarto(bool banheiro, float metragemQuadrada)
        {
            Banheiro = banheiro;
            MetragemQuadrada = metragemQuadrada;
            // Aqui estou instanciando a porta do quarto por estar tendo relação de Composição
            PortaQuarto = new PortaQuarto("Branca", 0.80f, 2.10f, 10.0);
        }
    }
}