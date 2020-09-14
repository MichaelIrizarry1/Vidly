using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CustomersController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        
        public IEnumerable<CustomerDto> GetCustomers()
        { 
            return _context.Customers.Include(m => m.MembershipType).Select(_mapper.Map<Customer,CustomerDto>);
            
        }

        
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer =  _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return NotFound();
            }
            
            return Ok( _mapper.Map<Customer,CustomerDto>(customer));
        }

        [HttpPost]
        public IActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());
            }

            var customer = _mapper.Map<CustomerDto, Customer>(customerDto);

            _context.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(  Request.Path + "/" + customer.Id,customerDto);
           

        }

        [Route("{id}")]
        [HttpPut]
        public void UpdateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());
            }

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
            {
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());
            }

            _mapper.Map<CustomerDto,Customer>(customerDto,customerInDB);
            _context.SaveChanges();
        }

        [Route("{id}")]
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
            {
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());
            }

            _context.Remove(customerInDB);
            _context.SaveChanges();
        }
    }
}
