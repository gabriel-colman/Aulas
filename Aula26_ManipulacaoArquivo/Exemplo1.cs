using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Aula26_ManipulacaoArquivo
{
    public class Exemplo1
    {
        // static void Main (string [] args){
            static void Exe1() {
            // File é uma classe estatic que contem metodos 
            // para manipulação de arquivos
            string inicioParh = @"C:\Users\gabri\Desktop\teste1.txt";

            string finalFile = @"C:\Users\gabri\Desktop\teste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(inicioParh); // Cria um objeto com referencia endereco criamos do arquivo
                fileInfo.CopyTo(finalFile); // Copia do arquivo de origem para o destino

                // Mostrar o que esta escrito no arquivo do inicioParh
                string[] line = File.ReadAllLines(inicioParh);
                foreach (string item in line) // percorre todas as linhas
                {
                    System.Console.WriteLine(item);
                }
            }
            catch (IOException e) // Tratamento de erro especifico para manipular arquivo
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }

        }
    }
}