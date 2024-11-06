namespace Aula_8;

public class Mudificadores
{

    public int soma(int a, int b){
        return a + b;
    } 

    // Função estática
    static int subtracao(int a, int b){
        return a - b;
    }
    // static void Main(string[] args){
    static void Teste(){
        // Chamar a função soma
        Mudificadores m = new Mudificadores();
        Console.WriteLine(m.soma(10, 20));

        // Chamar a função subtração
        Console.WriteLine(subtracao(10, 20));
    }
}
