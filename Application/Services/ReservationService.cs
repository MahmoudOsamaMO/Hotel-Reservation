using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(
            ICustomerRepository customerRepository,
            IRoomRepository roomRepository,
            IReservationRepository reservationRepository)
        {
            _customerRepository = customerRepository;
            _roomRepository = roomRepository;
            _reservationRepository = reservationRepository;
        }

        public void CreateReservation(Reservation reservation)
        {
            _reservationRepository.Add(reservation);
        }
    }
}
