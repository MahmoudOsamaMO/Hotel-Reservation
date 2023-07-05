using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(HotelReservationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Reservation> ReserveRoom(Reservation reservation)
        {
            if (reservation == null)
                return null;
            try
            {

                return reservation;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
