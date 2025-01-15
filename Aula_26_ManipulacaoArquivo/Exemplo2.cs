using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulacaoArquivo
{
    public class Exemplo2
    {
        // static void Main(string[] args)
        static void Exe2()
        {
            string inicioParh = @"C:\Users\gabri\Desktop\teste1.txt";

            // Isso é uma conversa com o sistema operacional
            //  Não é gerenciado pelo clr
            FileStream fs = null;// Essa é uma classe que permite leitura e escrita de arquivos, e é uma classe de baixo nivel

            StreamReader sr = null; // Também classe de manipução de arquivo como FileStream mas é de alto nivel


            try
            {
                fs = new FileStream(inicioParh, FileMode.Open); // Abre o arquivo

                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                System.Console.WriteLine(line);


                while (line != null)
                {
                    line = sr.ReadLine();
                    System.Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                // Eu preciso fechar o arquivvo, pois o sistema 
                // operacional não faz isso automaticamente
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}