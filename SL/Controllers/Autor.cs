using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Autor : ControllerBase
    {
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = BL.Autor.GetAllAutor();
            if(list != null)
            {
                return Ok(list);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
