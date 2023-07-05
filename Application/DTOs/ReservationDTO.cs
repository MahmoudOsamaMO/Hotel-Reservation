using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ReservationDTO
    {
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NightsCount { get; set; }
    }
}
