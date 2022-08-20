using CRM.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Query.GetAllCustomers
{
    public class GetAllCustomersQuery : IRequest<IEnumerable<Customer>>
    {
    }
}
