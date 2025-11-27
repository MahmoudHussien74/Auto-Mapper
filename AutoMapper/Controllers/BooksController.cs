using AutoMapper.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController(IMapper mapper) : ControllerBase
    {
        private readonly IMapper _mapper = mapper;
        List<Book> Books = [
            new(){Id = 1,Title = "OOP" , summary ="Clean Code ", Author="Osama Elzero",price = 230},
            new(){Id = 2,Title = "Design Pattern" , summary ="Clean Code ", Author="Osama Elzero",price = 230},
            new(){Id = 3,Title = "Solid Principle" , summary ="Clean Code ", Author="Osama Elzero",price = 0},
        ]; 

        [HttpGet("")]
        public IActionResult Get()
        {
            var result = _mapper.Map <IEnumerable<BookDto>>(Books);
                
            return Ok(result);    
        }
    }
}
