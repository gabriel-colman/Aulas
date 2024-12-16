using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Interface
{
    public interface AnimalDeEstimacao
    {
        // Metodo getNome
        string getNome();

        // Metodo setNome
        void setNome(string nome);

        // Metodo brincar
        void brincar();
    }
}