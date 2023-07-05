using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class HotelReservationDbContext : DbContext
    {
        public HotelReservationDbContext(DbContextOptions<HotelReservationDbContext> options)
    : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedRooms(modelBuilder);
        }
        public void SeedRooms(ModelBuilder modelBuilder)
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room { 
                Id= 1,
                RoomNumber="A1",
                NumberOfBeds=1,
                PricePerNight=10,
                RoomType = "standard"
            });
            rooms.Add(new Room
            {
                Id = 2,
                RoomNumber = "A2",
                NumberOfBeds = 2,
                PricePerNight = 20,
                RoomType = "suite"
            });
            rooms.Add(new Room
            {
                Id = 3,
                RoomNumber = "B1",
                NumberOfBeds = 3,
                PricePerNight = 50,
                RoomType = "deluxe"
            });
            modelBuilder.Entity<Room>().HasData(rooms);

        }
    }
}
