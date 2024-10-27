namespace Aula_2;

public class Entrada_dados
{
    static void Main(string[] args) {
        // Utilizar entrada dados para pegar os valores

        System.Console.WriteLine("Digite um texto: ");
        string texto = System.Console.ReadLine(); // Pega o texto digitado
        System.Console.WriteLine("O texto digitado foi: " + texto);

        System.Console.WriteLine("Digite um numero: ");
        int numero = int.Parse(System.Console.ReadLine()); // Converte a string para inteiro
        System.Console.WriteLine("O numero digitado foi: " + numero);

        System.Console.WriteLine("Digite se é verdadeiro ou falso: ");
        bool verdadeiroOuFalso = bool.Parse(System.Console.ReadLine()); // Converte a string para booleano
        System.Console.WriteLine("O valor digitado foi: " + verdadeiroOuFalso);
    }
    
}
