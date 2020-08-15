using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using Domain;
using X.PagedList;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly IGenreRepository genreRepository;

        public HomeController(IBookRepository bookRepository, IGenreRepository genreRepository)
        {
            this.bookRepository = bookRepository;
            this.genreRepository = genreRepository;
        }

        public IActionResult Index()
        {
            var allbooks = bookRepository.GetAll().ToPagedList();


            ViewBag.Genres = genreRepository.GetAll();

            ViewBag.PopularBooks = bookRepository.GetPopularBooks().ToPagedList();
            ViewBag.TopTenBooks = bookRepository.GetTopTen().ToPagedList();



            return View(allbooks);
        }

        public IActionResult GetBooksByGenre(string Type)
        {
         var booksInThisGenre =  bookRepository.GetBooksByGenreName(Type).ToPagedList();
            return View("Index", booksInThisGenre);

        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
