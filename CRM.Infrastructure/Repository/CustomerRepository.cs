using CRM.Domain.Models;
using CRM.Domain.Repository;
using CRM.Infrastructure.Context;

namespace CRM.Infrastructure.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CRMDbContext cRMDbContext) : base(cRMDbContext)
        {
        }
    }
}
