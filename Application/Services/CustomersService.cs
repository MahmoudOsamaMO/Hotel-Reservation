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
    public class CustomersService : ICustomersService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomersService(
            ICustomerRepository customerRepository,
            IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }
        public bool CreateCustomer(CustomerDTO customerDTO)
        {
            bool isCreated = false;

            try
            {
                // TODO add mapper
                var customer = new Customer
                {
                    Address = customerDTO.Address,
                    DateOfBirth = customerDTO.DateOfBirth,
                    Email = customerDTO.Email,
                    Name = customerDTO.Name,
                    Phone = customerDTO.Phone,
                };
                _customerRepository.Add(customer);
                _unitOfWork.SaveChanges();
                isCreated = true;
            }
            catch (Exception ex) { return isCreated; }

            return isCreated;
        }

    }
}
