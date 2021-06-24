using APIBook.Date;
using APIBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace APIBook.Repository
{
    public class BookRepository
    {
        private readonly AppDbContext _dbContext;
        public BookRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void AddBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }

        public void UpdateBook(int id, Book book)
        {
            var findBook = _dbContext.Books.FirstOrDefault(b => b.Id == id); ;
            if (findBook != null)
            {
                findBook.Title = book.Title;
                findBook.Author = book.Author;
                findBook.Description = book.Description;
                findBook.Genre = book.Genre;
                findBook.Rate = book.Rate;
                findBook.DateRead = book.DateRead;

                _dbContext.SaveChanges();
            }
        }
    }
}
