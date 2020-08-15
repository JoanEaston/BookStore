using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Logic
{
    public class CustomerRepository : ICustomerRepository
    {
        public BookContext _bookContext;
        public CustomerRepository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public void Add(Customer cust)
        {
            _bookContext.Customers.Add(cust);
            _bookContext.SaveChanges();
        }

        public void AddRange(IEnumerable<Customer> customers)
        {
            _bookContext.Customers.AddRange(customers);
            _bookContext.SaveChanges();
        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> expression)
        {
            return _bookContext.Customers.Where(expression);
        }

        public Customer Get(int id)
        {
            return _bookContext.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _bookContext.Customers.ToList();
        }

        public IEnumerable<Customer> GetBooksPurchased()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetWishList()
        {
            throw new NotImplementedException();
        }

        public void Remove(Customer entity)
        {
            _bookContext.Customers.Remove(entity);
            _bookContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<Customer> entities)
        {
            _bookContext.Customers.RemoveRange(entities);
            _bookContext.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _bookContext.Customers.Update(entity);
            _bookContext.SaveChanges();
        }
    }
}
