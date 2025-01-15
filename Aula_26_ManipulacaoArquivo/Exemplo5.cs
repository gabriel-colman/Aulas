using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aula26_ManipulacaoArquivo
{
    public class Exemplo5
    {
        // static void Main(string[] args)
        static void Exe5()
        {
            string path = @"C:\Users\gabri\Desktop\teste";

            try
            {
                // Directory é uma classe estatica que permite a manipução dos diretorios
                //EnumerateDirectories que esta listando os diretorios/pasta
                // AllDirectories define a busca de todos os diretorios
                IEnumerable<string> pastas =
                    Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                System.Console.WriteLine("Pastas:");

                foreach (string item in pastas)
                {
                    System.Console.WriteLine(item);
                }

                // Inumerar os arquivos
                IEnumerable<string> arquivos =
                    Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                
                foreach (string item in arquivos)
                {
                    System.Console.WriteLine(item);
                }

                // Criar uma Pasta
                // Directory.CreateDirectory(path + @"\Teste2");

                // Deletar uma pasta
                // Directory.Delete(path + @"\Teste2");

                // Verificar se a pasta existe
                bool existe= Directory.Exists(path + @"\Nova");
                System.Console.WriteLine("A pasta exite: " + existe);
            }
            catch (IOException e)
            {

                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}