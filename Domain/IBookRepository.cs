using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IBookRepository: IRepository<Book>
    {
        IEnumerable<Book> GetPopularBooks();
        IEnumerable<Book> GetNewRelease();
        IEnumerable<Book> GetEditorPick();
        IEnumerable<Book> GetTopTen();
        IEnumerable<Book> GetBooksInSameCategory(int id);
        IEnumerable<Book> GetBooksByGenreName(string type);
    }
}
