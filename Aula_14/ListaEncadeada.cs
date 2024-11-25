using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_14
{
    public class ListaEncadeada
    {
        class Node
        {
            public int Valor;
            public Node? Proximo;
        }


        static Node? inicio = null;

        static void Inserir(int valor)
        {
            // Cria um novo nó com valor fornecedio e aponta para o início
            Node novonode = new Node { Valor = valor, Proximo = inicio };

            if (inicio == null)
            {
                inicio = novonode;
            }
            else
            {
                Node atual = inicio;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novonode;
            }
        }

        static void Excluir(int valor)
        {
            if (inicio == null)
            {
                return;
            }

            if (inicio.Valor == valor)
            {
                inicio = inicio.Proximo;
                return; // Sai do método
            }

            // Percorre a lista proculando o valor
            Node atual = inicio;
            while (atual.Proximo != null)
            {
                if (atual.Proximo.Valor == valor)
                {
                    atual.Proximo = atual.Proximo.Proximo;
                    return;
                }
                atual = atual.Proximo;
            }
        }

        static void Listar()
        {
            Node? atual = inicio;
            System.Console.WriteLine("Valores da lista:");
           
            while (atual != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }

        static void Main()
        {
            Inserir(1);
            Inserir(2);
            Inserir(3);
            Inserir(4);
            Inserir(5);
            
            Listar();
            Excluir(3);
            Listar();
        }
    }
}