using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Struct
{
    public struct PessoaStruct
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaStruct(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

     public class PessoaClasse
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaClasse(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    class ExecutarExe
    {
        // public static void Main(string [] args)
        public static void ExecutarExemplo1()
        {
            // Trabalha com struc Pessoa
            PessoaStruct pessoaStruct1 = new PessoaStruct("João", 20);
            PessoaStruct pessoaStruct2 = pessoaStruct1;
            pessoaStruct2.Nome = "Maria";

            Console.WriteLine(pessoaStruct1);
            Console.WriteLine(pessoaStruct2);

            // Trabalha com classe Pessoa
            PessoaClasse pessoaClasse1 = new PessoaClasse("João", 20);
            PessoaClasse pessoaClasse2 = pessoaClasse1;
            pessoaClasse2.Nome = "Maria";

            Console.WriteLine(pessoaClasse1);
            Console.WriteLine(pessoaClasse2);

            // 1. Struct é um tipo de valor, então atribuções criam copias independentes
            // 2. Classe é um tipo de referência, então atribuições criam referências para o mesmo objeto
            // 3. Struct são mais leves e geralmente são udados parados simples e imutaveis 
            // 4. Classes são mais adequadas para objetos complexos e com estados mutaveis e comportamentos
        }
    }
}