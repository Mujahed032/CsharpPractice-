using ManyToMany_Relation_Using_EF_Core.Interface;
using ManyToMany_Relation_Using_EF_Core.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ManyToMany_Relation_Using_EF_Core.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
      public class BookController : Controller
    {
        private readonly BookInterface _bookRepository;

        public BookController(BookInterface BookRepository)
        {
            _bookRepository = BookRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerator<Book>))]

        public IActionResult GetBook()
        {
            var Book = _bookRepository.GetBook();

            if(!ModelState.IsValid) 
                return BadRequest(ModelState);

            return Ok(Book);
        }
    }
}
