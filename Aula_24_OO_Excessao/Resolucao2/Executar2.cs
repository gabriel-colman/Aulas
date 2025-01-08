using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_24_OO_Excessao.Resolucao_1;
using Aula_24_OO_Excessao.Resolucao2;

namespace Aula_24_OO_Excessao
{
    public class Execução2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados Rum Number");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a data de Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a data de Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation2 reservation2 = new Reservation2(roomNumber, checkIn, checkOut);

            string error = reservation2.UpdateDates(checkIn, checkOut);
            if(error != null) // Se error for diferente de nulo
            {
                Console.WriteLine(error);
            }
            else
            {
                Console.WriteLine("Reserva: " + reservation2);
            }
        }
    }
}