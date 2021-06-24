using APIBook.Models;
using APIBook.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookRepository _repository;
        public BooksController(BookRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("get-allbooks")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _repository.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody] Book book)
        {
            _repository.AddBook(book);
            return Ok();
        }

        [HttpDelete("delete-book")]
        public IActionResult DeleteBook(int id)
        {
            _repository.DeleteBook(id);
            return Ok();
        }

        [HttpPut("update-book")]
        public IActionResult UpdateBook(int id, [FromBody] Book book)
        {
            _repository.UpdateBook(id, book);
            return Ok();
        }
    }
}
