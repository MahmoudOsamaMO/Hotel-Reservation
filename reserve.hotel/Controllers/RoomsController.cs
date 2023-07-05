using Application.Interfaces;
using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace hotel.reservation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly ILogger<RoomsController> _logger;
        private readonly IRoomsService _roomsService;

        public RoomsController(ILogger<RoomsController> logger, IRoomsService roomsService)
        {
            _logger = logger;
            _roomsService = roomsService;
        }



        [HttpGet(Name = "GetRooms")]
        public List<Room> GetRooms()
        {
            return _roomsService.GetRooms();
        }
    }
}
