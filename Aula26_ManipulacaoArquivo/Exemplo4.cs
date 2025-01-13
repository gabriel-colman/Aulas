using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulacaoArquivo
{
    public class Exemplo4
    {
        // static void Main(string[] args)
        static void Exe4()
        {
            string inicioParh = @"C:\Users\gabri\Desktop\teste1.txt";
            string finalParh = @"C:\Users\gabri\Desktop\teste2.txt";

            try
            {
                string [] lines = File.ReadAllLines(inicioParh);

                using (StreamWriter sw = File.AppendText(finalParh))
                {
                    foreach (string item in lines)
                    {
                        sw.WriteLine(item.ToUpper()); // Escreve a linha em maiusculo
                        //  Quiser em todos minisculos 
                        // sw.WriteLine(item.ToLower());
                        //  Se quiser inverter a ordem
                        // sw.WriteLine(item.Reverse().ToArray());
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