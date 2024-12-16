using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public interface IAnuidade
    {
        // Função para calcular data de vencimento
        DateTime CalcularDataVencimento();

        // Função para calcular valor da anuidade
        double CalcularValorAnuidade();
    }
}