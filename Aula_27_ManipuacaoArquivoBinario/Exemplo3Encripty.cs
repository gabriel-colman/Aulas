using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Aula_27_ManipuacaoArquivoBinario
{
    // Exemplo de encriptar uma arquivo txt
    public class Exemplo3Encripty
    {
        static void Main(string[] args)
        {
            string originalFile = "arquivo_original.txt";
            string encryptedFile = "arquivo_encriptado.txt";
            string decryptedFile = "arquivo_desencriptado.txt";

            // Criar um arquivo de texto simples
            File.WriteAllText(originalFile, "Este é o conteúdo do arquivo original."); // Dados de exemplo

            Console.WriteLine("Arquivo original criado."); // Mensagem de confirmação

            string password = "minhaSenhaSegura"; // Senha para encriptação

            // Encriptar o arquivo
            // EncryptFile é um método que criamos para encriptar um arquivo
            EncryptFile(originalFile, encryptedFile, password); // Encripta o arquivo
            Console.WriteLine("Arquivo encriptado criado."); // Mensagem de confirmação

            // Desencriptar o arquivo
            DecryptFile(encryptedFile, decryptedFile, password);
            Console.WriteLine("Arquivo desencriptado criado.");
        }

        static void EncryptFile(string inputFilePath, string outputFilePath, string password)
        {
            // Encoding.UTF8.GetBytes converte a senha em bytes
            // password.PadRight(32) garante que a senha tenha pelo menos 32 caracteres
            // Substring(0, 32) garante que a senha tenha no máximo 32 caracteres
            // Gera uma chave de 256 bits
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); // Gera uma chave de 256 bits
            // iv é referente ao vetor de inicialização
            // Gera um IV de 128 bits
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16)); // Gera um IV de 128 bits

            using (Aes aes = Aes.Create()) // Cria uma instância de AES
            {
                aes.Key = key; // Define a chave
                aes.IV = iv; // Define o IV

                // Abre o arquivo de entrada
                using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open)) // Abre o arquivo de entrada
                using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create)) // Abre o arquivo de saída
                using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write)) // Cria um CryptoStream
                {
                    inputFileStream.CopyTo(cryptoStream); // Copia o conteúdo do arquivo de entrada para o CryptoStream
                }
            }
        }

        static void DecryptFile(string inputFilePath, string outputFilePath, string password)
        {
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32)); // Gera uma chave de 256 bits
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16)); // Gera um IV de 128 bits

            using (Aes aes = Aes.Create()) // Cria uma instância de AES
            {
                aes.Key = key; // Define a chave
                aes.IV = iv; // Define o IV

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