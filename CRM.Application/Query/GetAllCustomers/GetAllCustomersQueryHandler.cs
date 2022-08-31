using CRM.Domain.Models;
using CRM.Domain.Repository;
using CRM.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CRM.Application.Query.GetAllCustomers
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<Customer>>
    {
        private readonly ICustomerRepository _customerRepo;
        private CRMDbContext _context;

        public GetAllCustomersQueryHandler(ICustomerRepository customerRepository, CRMDbContext context)
        {
            _customerRepo = customerRepository;
            _context = context;
        }

        public Task<IEnumerable<Customer>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerRepo.GetAll(x => x.Invoices));
        }
    }
}
