using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_Excessao.Resolucao2
{
    public class Reservation2
    {
        public int roomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation2(int RoomNumber, DateTime checkIn,
            DateTime checkOut)
        {
            roomNumber = RoomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan timeSpan = CheckOut.Subtract(CheckIn); // Subtract = Subtrair, diferença entre datas
            return (int)timeSpan.TotalDays; // TotalDays = Total de dias
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            if (checkIn < DateTime.Now && checkOut < DateTime.Now)
            {
                return "Erro na reserva: As datas para reserva devem ser futuras";
            }
            if (checkOut <= checkIn)
            {
                return "Erro na reserva: A data de Check-out deve ser maior que a data de Check-in";
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;

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