namespace Aula_8;

public class FuncaoFlexivel
{
    // Eles permitem a criação de "ponteiros de função" que podem referenciar qualquer método que tenha a mesma assinatura do delegate.
    // Ponteiros de função ele são usados para passar métodos como argumentos para outros métodos.
    // Ponteiros de função é um recurso que permite que você armazene referências a métodos em variáveis.

    public delegate int Operacao(int a, int b);



    public delegate double CalculaMedia(int [] valores);



    // Exepressão lambda
    static int Soma(int a, int b) => a + b;
    // Isso é mesmo que isso aqui
    // static int Soma(int a, int b) { 
    //  return a + b; 
    // }

    // Juntar 2 funções no delagate
    public delegate void Notificar();
    public static void EnvioEmail() => Console.WriteLine("Email enviado");
    public static void EnviarSMS() => Console.WriteLine("SMS enviado");

    // static void Main(string[] args)
    static void Teste()
    {
        Operacao op = Soma;
        Console.WriteLine(op(3, 2)); // 5
        
        // Atribuir diretamente a expressão lambda
        Operacao op2 = (int a, int b) => a * b;
        Console.WriteLine(op2(3, 2)); // 6

        // Métodos anônimos foram uma das primeiras maneiras de criar funções inline em C#. Embora expressões lambda sejam mais populares, os métodos anônimos ainda são válidos e têm usos específicos.
        Func<int, int, int> op3 = delegate(int a, int b) { return a - b; };
        Console.WriteLine(op3(3, 2)); // 1

        // Delegates Multicast
        Notificar notificar = EnvioEmail;
        notificar += EnviarSMS;
        notificar(); // Email enviado, SMS enviado
       
       
    }
}
