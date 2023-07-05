using Application.DTOs;
using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using reserve.hotel.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hotel.reservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {

        private readonly ILogger<ReservationController> _logger;
        private readonly IReservationService _reservationService;

        public ReservationController(ILogger<ReservationController> logger, IReservationService reservationService)
        {
            _logger = logger;
            _reservationService = reservationService;
        }


        [HttpGet(Name = "GetRooms")]
        public List<Room> GetRooms()
        {
            return _reservationService.GetRooms();
        }

        [HttpPost(Name = "CreateCustomer")]
        public bool CreateCustomer(CustomerDTO customerDTO)
        {
            return _reservationService.CreateCustomer(customerDTO);
        }

        [HttpPost(Name = "CreateReservation")]
        public bool CreateReservation(ReservationDTO reservationDTO)
        {
            return _reservationService.CreateReservation(reservationDTO);
        }

    }
}
