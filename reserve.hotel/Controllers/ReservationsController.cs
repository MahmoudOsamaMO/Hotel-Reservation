using Application.DTOs;
using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hotel.reservation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationsController : ControllerBase
    {

        private readonly ILogger<ReservationsController> _logger;
        private readonly IReservationsService _reservationService;

        public ReservationsController(ILogger<ReservationsController> logger, IReservationsService reservationService)
        {
            _logger = logger;
            _reservationService = reservationService;
        }

        [HttpPost(Name = "Reservation")]
        public bool Reservation(ReservationDTO reservationDTO)
        {
            return _reservationService.CreateReservation(reservationDTO);
        }

    }
}
