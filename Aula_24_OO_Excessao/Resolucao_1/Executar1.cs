using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_24_OO_Excessao.Resolucao_1;
namespace Aula_24_OO_Excessao
{
    public class Executar1
    {
        // public static void Main(string[] args)
        public static void Exe()
        {
            Console.WriteLine("Entre com os dados Rum Number");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a data de Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkIn < DateTime.Now && checkOut < DateTime.Now)
            // Aqui é feita se data é maiior que a data atual
            {
                Console.WriteLine("Erro na reserva: As datas para reserva devem ser futuras");
            }
            else if (checkOut <= checkIn)
            {
                Console.WriteLine("Erro na reserva: A data de Check-out deve ser maior que a data de Check-in");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva: ");
                Console.WriteLine("Entre com a data de Check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now && checkOut < now)
                {
                    Console.WriteLine("Erro na reserva: As datas para reserva devem ser futuras");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Erro na reserva: A data de Check-out deve ser maior que a data de Check-in");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reserva: " + reservation);
                }
            }
        }
    }
}