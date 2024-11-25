using System;

namespace Aula_14
{
    class ListaEncadeadaDelegate
    {
        // Definindo o delegate corretamente
        delegate void FuncaoDelegate(int valor);

        // Declaração de um delegate nullable
        static FuncaoDelegate? inicio = null;

        // Método para criar um nó
        static FuncaoDelegate CriarNo(int valor, FuncaoDelegate? proximo)
        {
            return v =>
            {
                // Imprime o valor e invoca o próximo, caso exista
                Console.WriteLine(valor); // Imprime o valor
                // proximo?.Invoke(v); // Invoca o próximo, 
                if (proximo != null) proximo(v);
                // Invoke é o mesmo que proximo(v), mas é mais seguro
                // Se não quiser usar o Invoke, pode usar proximo!(v); eu fasso assim:
                // if (proximo != null) proximo(v);

            };
        }

        // Listar todos os valores
        static void Listar(int valor)
        {
            inicio?.Invoke(valor);
        }

        // Exemplo de uso na Main
        static void Main()
        {
            // Criando uma lista encadeada com delegates
            FuncaoDelegate no3 = CriarNo(3, null);
            FuncaoDelegate no2 = CriarNo(2, no3);
            FuncaoDelegate no1 = CriarNo(1, no2);

            // Chamando o primeiro delegate
            no1(0);
        }
    }
}
