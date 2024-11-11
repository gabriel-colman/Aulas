using System;


namespace Aula_10
{
    class Ref
    {
        static int Quadrado(int x)
        {
            return x * x;
        }

        // usando ref para passar a variavel por referencia
        static int QuadradoRef(ref int x)
        {
            x *= 2;
            return x * x;
        }
        //  out é usado para passar a variavel por referencia, mas não é necessário inicializar a variavel
        static int QuadradoOut(out int x)
        {
            x = 6;
            return x * x;
        }
        // static void Main(string[] args)
        static void Teste()
        {
            int a = 10;
            // Console.WriteLine(Quadrado(a));
            // Console.WriteLine(a);
            // QuadradoRef(ref a);
            // Console.WriteLine(QuadradoRef(ref a));
            // Console.WriteLine(a);
            a = Quadrado(a);
            Console.WriteLine(a);

            int b;
            Console.WriteLine(QuadradoOut(out b));
        }


    }
}