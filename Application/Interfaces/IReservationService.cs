using Application.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReservationService
    {
        bool CreateReservation(ReservationDTO reservationDTO);
        bool CreateCustomer(CustomerDTO customerDTO);
        List<Room> GetRooms();
    }
}
