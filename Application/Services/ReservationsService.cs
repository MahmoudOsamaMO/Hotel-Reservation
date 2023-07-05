using Application.DTOs;
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
    public class ReservationsService : IReservationsService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ReservationsService(
            ICustomerRepository customerRepository,
            IRoomRepository roomRepository,
            IReservationRepository reservationRepository,
            IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _roomRepository = roomRepository;
            _reservationRepository = reservationRepository;
            _unitOfWork = unitOfWork;
        }


        public  bool CreateReservation(ReservationDTO reservationDTO)
        {
            bool isCreated = false;
            var room =  _roomRepository.GetById(reservationDTO.RoomId);
            var customer =  _customerRepository.GetById(reservationDTO.CustomerId);

            if (room == null || customer == null)
            {
                return isCreated;
            }

            try
            {
                decimal totalPrice = room.PricePerNight * reservationDTO.NightsCount;

                var reservation = new Reservation
                {
                    ReservationDate = reservationDTO.ReservationDate,
                    Room = room,
                    Customer = customer,
                    NumberOfNights = reservationDTO.NightsCount,
                    TotalPrice = totalPrice
                };

                _reservationRepository.Add(reservation);

                _unitOfWork.SaveChanges();
                isCreated = true;
            }
            catch(Exception ex) { return isCreated; }
            return isCreated;
        }

    }
}
