using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Logic
{
    public class BookRepository : IBookRepository
    {
        public BookContext _bookContext;
        public BookRepository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public void Add(Book book)
        {
            _bookContext.Books.Add(book);
            _bookContext.SaveChanges();
        }

        public void AddRange(IEnumerable<Book> books)
        {
            _bookContext.Books.AddRange(books);
            _bookContext.SaveChanges();
        }

       

        public IEnumerable<Book> Find(Expression<Func<Book, bool>> expression)
        {
            return _bookContext.Books.Where(expression);
        }

        public Book Get(int id)
        {
            return _bookContext.Books.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookContext.Books.ToList();
        }

        public IEnumerable<Book> GetBooksByGenreName(string type)
        {
            return Find(b => b.Genre.Type == type);
        }

        public IEnumerable<Book> GetBooksInSameCategory(int id)
        {
            return _bookContext.Books.Where(b => b.Genre.Id == id);
        }

        public IEnumerable<Book> GetEditorPick()
        {
            return _bookContext.Books.Where(b => b.IsEditorsPick == true);
        }

        public IEnumerable<Book> GetNewRelease()
        {
            return _bookContext.Books.Where(b => b.DateAdded.Day >= (DateTime.Now.Day - 5));
        }

        public IEnumerable<Book> GetPopularBooks()
        {
            return _bookContext.Books.OrderByDescending(b => b.Views).Take(5).ToList();
        }

        public IEnumerable<Book> GetTopTen()
        {
            return _bookContext.Books.OrderByDescending(b => b.Rating).Take(10).ToList();
        }

        public void Remove(Book entity)
        {
            _bookContext.Books.Remove(entity);
            _bookContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<Book> entities)
        {
            _bookContext.Books.RemoveRange(entities);
            _bookContext.SaveChanges();
        }

        public void Update(Book entity)
        {
            _bookContext.Books.Update(entity);
            _bookContext.SaveChanges();
        }
    }
}
