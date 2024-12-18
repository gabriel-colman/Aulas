using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Relacoes.Composicao
{
    public class Computador
    {
        public Processador processador;

        // Na composição, a classe principal não pode existir sem a parte essencial.
        // Então é instanciado a parte essencial no construtor.
        public Computador()
        {
            // Precisa instanciar o processador para que o computador possa existir.
            processador = new Processador();
        }

        void iniciar() {
            System.Console.WriteLine("Iniciando...");
            processador.processar();
        }
    }
}

// A composição é quando classe principal 
// contem partes essenciais que não podem existir 
// sem ela.