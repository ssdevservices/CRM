using CRM.Domain.Models;
using CRM.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Query.GetCustomerById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        private readonly ICustomerRepository _customerRepo;

        public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }

        public Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerRepo.GetById(request.Id));
        }
    }
}
