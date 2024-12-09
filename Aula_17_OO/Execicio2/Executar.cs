using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO.Execicio2
{
    public class Executar
    {
        static void Main(string [] args){
            Produto [] produtos = new Produto[3];
            produtos[0] = new Livro(1, 20.0, "Autor 1", 123456789);
            produtos[1] = new CompactDisc(2, 30.0, "Artista 1", "Gravadora 1");
            produtos[2] = new Livro(3, 40.0, "Autor 2", 987654321);

            foreach(Produto produto in produtos){
                Console.WriteLine("Codigo: " + produto.getCodigo());
                Console.WriteLine("Preco: " + produto.getPreco());
                produto.atualizarPreco(produto.getPreco() * 1.1);
                Console.WriteLine("Preco atualizado: " + produto.getPreco());
                Console.WriteLine();
            }
        }
    }
}