using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO.Desafio_3
{
    public class Estoque
    {
        public Produto[] Produtos { get; set; }
        public int[] Quantidades { get; set; }

        public bool VerificarEstoque(Produto produto)
        {
            // Array.IndexOf retorna o índice do elemento no array, ou -1 se não encontrar
            int index = Array.IndexOf(Produtos, produto);
            return index >= 0 && Quantidades[index] > 0;
        }

        public Produto ProcurarProduto(string nome)
        {
            foreach (var prduto in Produtos)
            {
                if (prduto.Nome == nome)
                {
                    return prduto;
                }
            }
            return null;
        }

    }
}