using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_24_OO_Excessao.Resolucao_1;
using Aula_24_OO_Excessao.Resolucao3;

namespace Aula_24_OO_Excessao
{
    public class Execução3
    {
        public static void Main(string[] args)
        {
            try 
            {
            Console.WriteLine("Entre com os dados Rum Number");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a data de Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation3 reservation3 = new Reservation3(roomNumber, checkIn, checkOut);
            Console.WriteLine("Reserva: " + reservation3);

            Console.WriteLine("Escreva os dados para atualizar a reserva: ");
            Console.WriteLine("Entre com a data de Check-in (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation3.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reserva atualizada: " + reservation3);
        }
        catch (DomainException e) // Exceção personalizada
        {
            Console.WriteLine("Erro na reserva: " + e.Message);
        }
        catch (FormatException e)
        // Exceção de formato de entrada
        {
            Console.WriteLine("Erro de formato: " + e.Message);
        }
        catch (Exception e)
        // Exceção genérica
        {
            Console.WriteLine("Erro inesperado: " + e.Message);
        }
    }
    }
}