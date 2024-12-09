using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO.Execicio2
{
    public class CompactDisc: Produto
    {
        public string Artista;
        public string Gravadora;

        // construtor
        public CompactDisc(int codigo, double preco, string artista, string gravadora)
         : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }

        public string getArtista()
        {
            return Artista;
        }

        public string getGravadora()
        {
            return Gravadora;
        }

        public void setArtista(string artista)
        {
            Artista = artista;
        }

        public void setGravadora(string gravadora)
        {
            Gravadora = gravadora;
        }

        public override void setCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public override void setPreco(double preco)
        {
            Preco = preco;
        }

        public override int getCodigo()
        {
            return Codigo;
        }

        public override double getPreco()
        {
            return Preco;
        }

        public override void atualizarPreco(double preco)
        {
            Preco = preco;
        }
    }
}