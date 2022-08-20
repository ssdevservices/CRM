using CRM.Domain.Models;
using CRM.Domain.Repository;
using MediatR;

namespace CRM.Application.Query.GetAllCustomers
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<Customer>>
    {
        private readonly ICustomerRepository _customerRepo;

        public GetAllCustomersQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }

        public Task<IEnumerable<Customer>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_customerRepo.GetAll());
        }
    }
}
