using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using Domain;

namespace BookStore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly ICustomerRepository customerRepository;

        public CustomerController(IBookRepository bookRepository, ICustomerRepository customerRepository)
        {
            this.bookRepository = bookRepository;
            this.customerRepository = customerRepository;
        }

        public void AddToWishList(int CustomerId, int BookId)
        {
            var customer = customerRepository.Get(CustomerId);
            var book = bookRepository.Get(BookId);
            customer.WishList.Add(book);

            customerRepository.Update(customer);
        }
        
    }
}
