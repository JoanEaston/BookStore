using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetWishList();
        IEnumerable<Customer> GetBooksPurchased();
    }
}
