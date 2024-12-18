using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20_OO_Relacoes.Exemplo;

namespace Aula_20_OO_Relacoes
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // // Criar um objeto do tipo escola
            // Escola escola = new Escola("João");

            // // Criar um objeto do tipo professor
            // Professor professor = new Professor("Maria");

            // // Contratar o professor
            // escola.ContratarProfessor(professor);

            // // Mostrar informações
            // escola.MostrarInfo();

            // Executar exemplo de portaCozinha
            Console.WriteLine("Herança");
            PortaCozinha portaCozinha = new PortaCozinha("Branca", 1.5f, 2.5f, 10);
            portaCozinha.Abrir();
            portaCozinha.Fechar();
            Console.WriteLine($"portaCozinhaCozinha: Cor: {portaCozinha.Cor}, Largura: {portaCozinha.Largura}, Altura: {portaCozinha.Altura}, Peso: {portaCozinha.Peso}");

            Console.WriteLine("Agregação");
            Cozinha cozinha = new Cozinha(true, 20);
            cozinha.Entrar(portaCozinha);

            Console.WriteLine("Composição");
            PortaQuarto portaQuarto = new PortaQuarto("Marrom", 1.5f, 2.5f, 10);
            Quarto quarto = new Quarto(true, 20);
            Console.WriteLine($"quarto: {quarto.PortaQuarto.Cor}");

            Console.WriteLine("Associação simples");
            PortaSala portaSala = new PortaSala("Azul", 1.5f, 2.5f, 10);
            Sala sala = new Sala(portaSala, portaQuarto, 20);
            sala.AbrirPortaAuxiliar();
        }
    }
}