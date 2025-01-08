using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_Excessao.Resolucao_1
{
    public class Reservation
    {
        public int roomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int RoomNumber, DateTime checkIn,
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

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
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