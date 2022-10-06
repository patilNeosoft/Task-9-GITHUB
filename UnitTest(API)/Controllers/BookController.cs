using Microsoft.AspNetCore.Mvc;
using UnitTest_API_.Model;

namespace UnitTest_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        List<Book> books = new List<Book>() { 
            new Book { BookId = 1, Name = "a", Quantity = 20 ,Price= 199},
             new Book { BookId = 2, Name = "b", Quantity = 2 ,Price= 100},
              new Book { BookId = 3, Name = "c", Quantity = 12 ,Price= 200},
               new Book { BookId = 4, Name = "d", Quantity = 31 ,Price= 350}
        };

        [HttpGet]
       public int GetAllBooks()
        {
            List<Book> allbooks = books;
            int count = allbooks.Count();
            return (count);
        }


    }
}