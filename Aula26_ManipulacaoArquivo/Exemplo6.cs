using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulacaoArquivo
{
    public class Exemplo6
    {
        // static void Main(string[] args)
        static void Exe6()
        {
            string inicioParh = @"C:\Users\gabri\Desktop\teste1.txt";
            System.Console.WriteLine("Diretory Separator Char" + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Separador de caminho: " + Path.PathSeparator);
            System.Console.WriteLine("Retorna o diretorio do arquivo: " + Path.GetDirectoryName(inicioParh));
            System.Console.WriteLine("Retorna o nome do arquivo" + Path.GetFileName(inicioParh));
            System.Console.WriteLine("Retorna o nome do arquivo sem extenção" +
               Path.GetFileNameWithoutExtension(inicioParh));
            System.Console.WriteLine("Retorna somente extenção do arquivo" + Path.GetExtension(inicioParh));


        }
    }
}