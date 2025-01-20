// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_28_Manipucao2
// {
//     // Classe Task
//     public class ClasseTask
//     {
//         // O ascync é quando função é assincrona, ou seja
//         // ela não é executada de forma que não trava o programa enquanto espera o retorno
//         // O task é uma tarefa que é executada de forma
//         static async Task Main(string [] args)
//         {
//             Console.WriteLine("Inicio do programa");
//             int resultado = await Soma(10, 20); // O await é para esperar o retorno da função
//             Console.WriteLine("Resultado: " + resultado);
//         }

//         static Task<int> Soma(int a, int b)
//         {
//            return Task.Run(() => {
//                Task.Delay(10000).Wait(); // Espera 2 segundos
//                return a + b;
//            });
//         }
//     }
// }