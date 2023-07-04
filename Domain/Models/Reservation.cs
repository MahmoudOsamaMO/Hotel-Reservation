using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public string RoomNumber { get; set; }
        public string CustomerName { get; set; }
        public int NumberOfNights { get; set; }
        public decimal TotalPrice { get; set; }

        public Customer Customer { get; set; }
        public Room Room { get; set; }

        public void CalculateTotalPrice()
        {
            TotalPrice = NumberOfNights * Room.PricePerNight;
        }
    }
}
