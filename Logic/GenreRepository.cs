using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Logic
{
    public class GenreRepository : IGenreRepository
    {

        public BookContext _bookContext;
        public GenreRepository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public void Add(Genre genre)
        {
            _bookContext.Genres.Add(genre);
            _bookContext.SaveChanges();
        }

        public void AddRange(IEnumerable<Genre> genres)
        {
            _bookContext.Genres.AddRange(genres);
            _bookContext.SaveChanges();
        }



        public IEnumerable<Genre> Find(Expression<Func<Genre, bool>> expression)
        {
            return _bookContext.Genres.Where(expression);
        }

        public Genre Get(int id)
        {
            return _bookContext.Genres.Find(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return _bookContext.Genres.ToList();
        }

       

        public void Remove(Genre entity)
        {
            _bookContext.Genres.Remove(entity);
            _bookContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<Genre> entities)
        {
            _bookContext.Genres.RemoveRange(entities);
            _bookContext.SaveChanges();
        }

        public void Update(Genre entity)
        {
            _bookContext.Genres.Update(entity);
            _bookContext.SaveChanges();
        }
    }
}
