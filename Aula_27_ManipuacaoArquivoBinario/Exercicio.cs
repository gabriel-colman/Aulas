using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Aula_27_ManipuacaoArquivoBinario
{
    public class Exercicio
    {
        static void Main(string[] args)
        {
            string arquivoCriado = "itens_vendidos.csv";
            string diretorio = "out";
            string pasta = Path.Combine(diretorio, "sumary.csv");

            try
            {
                // Crair uma pasta out se não existir criar ela
                if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);

                }

                var lines = File.ReadAllLines(arquivoCriado);
                var sumaryLines = new List<string>();


                foreach (var item in lines)
                {
                    var campos = item.Split(',');


                    if (campos.Length != 3)
                    {
                        System.Console.WriteLine("Linha ignorada " + item);
                        continue;
                    }

                    string nome = campos[0];
                    if (!double.TryParse(campos[1], out double preco)) // Tenta converter o valor para double
                    {
                        System.Console.WriteLine("Preço inválido " + campos[1]);
                        continue;
                    }

                    if (!int.TryParse(campos[2], out int quantidade)) // Tenta converter o valor para inteiro
                    {
                        System.Console.WriteLine("Quantidade inválida " + campos[2]);
                        continue;
                    }

                    double total = preco * quantidade;
                    sumaryLines.Add(nome + "," + total.ToString());

                }

                // Escrever o arquivo sumary.csv
                File.WriteAllLines(pasta, sumaryLines);
                Console.WriteLine("Arquivo sumary.csv criado com sucesso");

                // Encriptar o arquivo sumary.csv
                string arquivoEncriptado = pasta + ".enc"; // enc é a extensão de arquivo encriptado
                string senha = "123456";
                Encriptar(pasta, arquivoEncriptado, senha);
                Console.WriteLine("Arquivo sumary.csv encriptado com sucesso");

                // Desencriptas o arquivo sumary.csv
                string arquivoDesencriptado = pasta + ".enc"; // enc é a extensão de arquivo encriptado
                Desencriptar(pasta, arquivoEncriptado, senha);
                Console.WriteLine("Arquivo sumary.csv encriptado com sucesso");

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
        static void Encriptar(string inputFilePath, string outputFilePath, string password)
        {
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); // Gera uma chave de 256 bits
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16)); // Gera um IV de 128 bits

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open))
                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    inputFileStream.CopyTo(cryptoStream);
                }
            }
        }

        static void Desencriptar(string inputFilePath, string outputFilePath, string password)
        {
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); // Gera uma chave de 256 bits
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16)); // Gera um IV de 128 bits

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open))
                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
                using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputFileStream);
                }
            }
        }
    }
}