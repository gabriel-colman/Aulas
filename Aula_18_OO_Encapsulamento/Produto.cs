using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_OO_Encapsulamento
{
    public class Produto
    {
        // private string _nome; // Convenção de nomenclatura do C#: _nome
        // Propriedade autoimplementada
        public string Nome { get; set;}


        private double _preco;
        private int _quantidade;


        // Construtor padrão 
        public Produto()
        {
        }

        // Construtor com 2 argumentos
        public Produto(string nome, double preco)
        {
            // _nome = nome;
            // Agora vou utilizar a propriedade
            Nome = nome;
            _preco = preco;
        }

        // Reutilizando contrutor dentro de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        // Encapsulamento, que é Get(retornar) e Set(alterar) de atributos privados
        // public string GetNome()
        // {
        //     return _nome;
        // }

        // public void setNome(string nome)
        // {
        //     if (nome != null && nome.Length > 1)
        //     {
        //         _nome = nome;
        //     }
        // }
        //

        // Agora vou utlizar a propriedade do C# para fazer o Get e Set
        // public string Nome
        // {
        //     get
        //     {
        //         return _nome;
        //     }
        //     set
        //     {
        //         // O value é uma palavra reservada do C# que pega o valor que está sendo passado
        //         if (value != null && value.Length > 1)
        //         {
        //             _nome = value;
        //         }
        //     }
        // }

        // public double GetPreco()
        // {
        //     return _preco;
        // }

        // public void SetPreco(double preco)
        // {
        //     if (preco > 0 && preco < 100000)
        //     {
        //         _preco = preco;
        //     }
        // }

        // Agora vou utlizar a propriedade do C# para fazer o Get e Set
        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                if (value > 0 && value < 100000)
                {
                    _preco = value;
                }
            }
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        // Função adicionaqr quantidade em estoque
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        // Função remover quantidade em estoque
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        // Função calcular valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
            // get { return _preco * _quantidade; }
        }

        // Função TOString
        public override string ToString()
        {
            return Nome + ", $ " + _preco.ToString("F2") +
            ", " + _quantidade + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");
        }



    }
}