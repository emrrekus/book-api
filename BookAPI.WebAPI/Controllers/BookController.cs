using BookAPI.BusinessLayer.Abstract;
using BookAPI.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult BookList()
        {
            var values = _bookService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var value = _bookService.TGetByID(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookService.TInsert(book);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var value = _bookService.TGetByID(id);
            _bookService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            _bookService.TUpdate(book);
            return Ok();
        }

        [HttpGet("GetBookWithCategory")]
        public IActionResult GetBookWithCategory()
        {
            var values = _bookService.TGetBookWithCategory();
            return Ok(values);
        }

        [HttpGet("GetBookWithWriter")]
        public IActionResult GetBookWithWriter()
        {
            var values = _bookService.TGetBookWithWriter();
            return Ok(values);
        }


        [HttpGet("GetLast4Book")]
        public IActionResult GetLast4Book()
        {
            var values = _bookService.TGetLast4Book();
            return Ok(values);
        }

        [HttpGet("GetRandomBook")]
        public IActionResult GetRandomBook()
        {
            var value = _bookService.TRandomBook();
            return Ok(value);
        }
    }
} 