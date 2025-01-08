using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_24_OO_Excessao.Resolucao3;

namespace Aula_24_OO_Excessao.Resolucao3
{
    public class Reservation3
    {
        public int roomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation3(int RoomNumber, DateTime checkIn,
            DateTime checkOut)
        {
            if (checkIn < DateTime.Now && checkOut < DateTime.Now)
            {
                // throw new é uma exceção que é lançada quando um erro é encontrado
                throw new DomainException("Erro na reserva: As datas para reserva devem ser futuras");
            }
            if (checkOut <= checkIn)
            {
                // A excessão DomainException é lançada com a mensagem "Erro na reserva: A data de Check-out deve ser maior que a data de Check-in"
                // DomainException é uma exceção personalizada, mas que fica dentro do padrão de exceções do C# (ApplicationException)
                throw new DomainException("Erro na reserva: A data de Check-out deve ser maior que a data de Check-in");
            }

            roomNumber = RoomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan timeSpan = CheckOut.Subtract(CheckIn); // Subtract = Subtrair, diferença entre datas
            return (int)timeSpan.TotalDays; // TotalDays = Total de dias
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            if (checkIn < DateTime.Now && checkOut < DateTime.Now)
            {
                // throw new é uma exceção que é lançada quando um erro é encontrado
                throw new DomainException("Erro na reserva: As datas para reserva devem ser futuras");
            }
            if (checkOut <= checkIn)
            {
                // A excessão DomainException é lançada com a mensagem "Erro na reserva: A data de Check-out deve ser maior que a data de Check-in"
                // DomainException é uma exceção personalizada, mas que fica dentro do padrão de exceções do C# (ApplicationException)
                throw new DomainException("Erro na reserva: A data de Check-out deve ser maior que a data de Check-in");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public override string ToString()
        {
            return "Room "
            + roomNumber +
            ", check-in: "
            + CheckIn.ToString("dd/MM/yyyy") +
            ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration() + " nights";
        }
    }
}