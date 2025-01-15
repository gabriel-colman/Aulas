using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_27_ManipuacaoArquivoBinario
{
    public class Exemplo1
    {
        // Aqui foi gerado o arquivo binario com os dados
        // static void Main(string [] args)
        static void Exe1()
        {
            string filePath = "dados.bin"; // Caminho do arquivo

            using(BinaryWriter writer = new 
                BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(123); // Colocando o valor 123 no arquivo
                writer.Write(45.3546); 
                writer.Write("Hello World");
            }

            System.Console.WriteLine("Dados gravados no: " + filePath);
        }
    }
}