using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_14
{
    public class ListaDuplamenteEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
            public Node? anterior;
        }

        static Node? inicio = null;

        static void Inserir(int valor)
        {
            Node novoNode = new Node
            {
                valor = valor,
                proximo = null,
                anterior = null
            };
            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.proximo != null)
                {
                    atual = atual.proximo;
                }
                atual.proximo = novoNode;
                novoNode.anterior = atual;
            }
        }

        // Função Excluir
        static void Excluir(int valor)
        {
            // Verifica se a lista está vazia
            if (inicio == null)
                System.Console.WriteLine("Lista vazia");
            return;

            // if (inicio.valor == valor)
            // {
            //     inicio = inicio.proximo;
            //     inicio.anterior = null;
            //     return;
            // }

            // Verificar se o valor excluido esta no inicio
            if (inicio.valor == valor)
            {
                if (inicio.proximo != null)
                {
                    inicio.proximo.anterior = null;
                }
                inicio = inicio.proximo;
                return;
            }

            // Percorrer a lista para encontrar o nó com o valor
            Node atual = inicio;
            while (atual != null && atual.valor != valor)
            {
                atual = atual.proximo;
            }

            // Verificar se o nó foi encontrado
            if (atual != null)
            {
                // Verificar se o nó é o primeiro
                if (atual.anterior != null)
                {
                    atual.anterior.proximo = atual.proximo;
                }
                // Verificar se o nó é o último
                if (atual.proximo != null)
                {
                    atual.proximo.anterior = atual.anterior;
                }
            }
        }

        static void RemoverRecorrenciaTodos(int valor)
        {
            Node? atual = inicio;

            while (atual != null)
            {
                // Caso o nó seja do inicio da lista
                if (atual.anterior == null)
                {
                    inicio = inicio.proximo;
                    if (inicio != null)
                    {
                        inicio.anterior = null;
                    }
                }

                // Caso o nó seja do fim da lista
                else if (atual.proximo == null)
                {
                    atual.anterior.proximo = null; // Remove o nó do fim, atual.anterior.proximo quer dizer que o nó anterior ao atual aponta para null
                }
                else 
                {
                    // Atualiza os ponteiros do nó anterior e do nó posterior
                    atual.anterior.proximo = atual.proximo;
                    atual.proximo.anterior = atual.anterior;
                }
            }

            // Avança para o próximo nó
            atual = atual.proximo;
        }

        static void Listar()
        {
            Node? atual = inicio;
            while (atual != null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void Main()
        {
            Inserir(10);
            Inserir(20);
            Inserir(30);
            Inserir(40);
            Inserir(50);
            Listar();
            Excluir(30);
            Listar();
        }
    }
}

/*
Exercicio adicional:
Exercício Avançado de Lista Duplamente Encadeada
Exercício: Remover Todos os Elementos de um Valor Específico
Crie uma função que remova todas as ocorrências de um valor específico de uma lista duplamente encadeada.

Requisitos:

A função deve percorrer a lista inteira.
Todas as ocorrências do valor especificado devem ser removidas.
A lista deve permanecer íntegra após a remoção (ou seja, os ponteiros Proximo e Anterior devem ser ajustados adequadamente).
Exemplo de Uso:


Copiar código
Lista: 10 <-> 20 <-> 30 <-> 20 <-> 40
Remover(20)
Resultado: 10 <-> 30 <-> 40
*/