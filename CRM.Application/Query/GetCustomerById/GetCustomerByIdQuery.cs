using CRM.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Query.GetCustomerById
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public GetCustomerByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
