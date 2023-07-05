using Application.DTOs;
using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace hotel.reservation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CutomersController
    {
        private readonly ILogger<CutomersController> _logger;
        private readonly ICustomersService _customersService;

        public CutomersController(ILogger<CutomersController> logger, ICustomersService customersService)
        {
            _logger = logger;
            _customersService = customersService;
        }


        [HttpPost(Name = "Customer")]
        public bool CreateCustomer(CustomerDTO customerDTO)
        {
            return _customersService.CreateCustomer(customerDTO);
        }

    }
}
