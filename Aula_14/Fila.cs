using System;

namespace Exemplo12ListPilhFilaENCADEADA
{
    class Fila
    {
        // Estrutura de um nó na fila
        class Node
        {
            public int Valor;       // Valor armazenado no nó
            public Node? Proximo;   // Referência para o próximo nó
        }

        private Node? inicio = null;
        private Node? fim = null;

        // Função para enfileirar um novo valor no fim da fila
        public void Enfileirar(int valor)
        {
            Node novoNode = new Node { Valor = valor, Proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
                fim = novoNode;
            }
            else
            {
                fim.Proximo = novoNode;
                fim = novoNode;
            }
        }

        // Função para desenfileirar o valor do início da fila
        public int? Desenfileirar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A fila está vazia!");
                return null;
            }

            int valor = inicio.Valor;
            inicio = inicio.Proximo;

            if (inicio == null)
                fim = null;

            return valor;
        }

        // Função para listar todos os valores na fila
        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A fila está vazia!");
                return;
            }

            Console.WriteLine("Elementos na fila (do início ao fim):");
            Node? atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        // Função para inserir todos os valores de outra fila na fila atual
        public void InserirDeOutraFila(Fila outraFila)
        {
            while (outraFila.inicio != null)
            {
                int? valor = outraFila.Desenfileirar();
                if (valor.HasValue) // Se o valor não for nulo
                // if (valor != null) // Alternativa para a linha anterior
                {
                    Enfileirar(valor.Value);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Criando duas filas
            Fila fila1 = new Fila();
            Fila fila2 = new Fila();

            // Enfileirando valores na primeira fila
            fila1.Enfileirar(10);
            fila1.Enfileirar(20);
            fila1.Enfileirar(30);

            Console.WriteLine("Fila 1 antes de adicionar elementos de Fila 2:");
            fila1.Listar();

            // Enfileirando valores na segunda fila
            fila2.Enfileirar(40);
            fila2.Enfileirar(50);

            Console.WriteLine("Fila 2:");
            fila2.Listar();

            // Inserindo os valores de Fila 2 em Fila 1
            fila1.InserirDeOutraFila(fila2);

            Console.WriteLine("Fila 1 após adicionar elementos de Fila 2:");
            fila1.Listar();

            Console.WriteLine("Fila 2 após transferência:");
            fila2.Listar();
        }
    }
}
