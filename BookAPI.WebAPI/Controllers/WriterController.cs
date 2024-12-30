using BookAPI.BusinessLayer.Abstract;
using BookAPI.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private readonly IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpGet]
        public IActionResult WriterList()
        {
            var values = _writerService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetWriter(int id)
        {
            var value = _writerService.TGetByID(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddWriter(Writer writer)
        {
            _writerService.TInsert(writer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWriter(int id)
        {
            var value = _writerService.TGetByID(id);
            _writerService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateWriter(Writer writer)
        {
            _writerService.TUpdate(writer);
            return Ok();
        }

        [HttpGet("GetWriterWithBooks")]
        public IActionResult GetWriterWithBooks()
        {
            var values = _writerService.TGetWriterWithBooks();
            return Ok(values);
        }
    }
} 