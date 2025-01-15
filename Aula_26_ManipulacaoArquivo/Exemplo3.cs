using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulacaoArquivo
{
    public class Exemplo3
    {
        // static void Main(string[] args)
        static void Exe3()
        {
            string inicioParh = @"C:\Users\gabri\Desktop\teste1.txt";

            try
            {
                using (FileStream fs = new FileStream(inicioParh, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}