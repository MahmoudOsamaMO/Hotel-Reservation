using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelReservationDbContext _dbContext;

        public UnitOfWork(HotelReservationDbContext dbContext)
        {
            _dbContext = dbContext;
            Customers = new CustomerRepository(_dbContext);
            Rooms = new RoomRepository(_dbContext);
            Reservations = new ReservationRepository(_dbContext);
        }

        public ICustomerRepository Customers { get; }
        public IRoomRepository Rooms { get; }
        public IReservationRepository Reservations { get; }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
