using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Libro : ControllerBase
    {
        [Route("getbyAutor/{autor}")]
        [HttpGet]
        public IActionResult GetByAutor(string autor)
        {
            var list = BL.Libro.GetLibrosAutor(autor);
            if (list != null)
            {
                return Ok(list);
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("getbytitulo/{titulo}")]
        [HttpGet]
        public IActionResult GetByTitulo(string titulo)
        {
            var list = BL.Libro.GetByTitulo(titulo);
            if (list != null)
            {
                return Ok(list);
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("getbyanio/{anio}")]
        [HttpGet]
        public IActionResult GetByanio(string anio)
        {
            var list = BL.Libro.GetByAnio(anio);
            if (list != null)
            {
                return Ok(list);
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("deleteautor/{IdAutor}")]
        [HttpDelete]
        public IActionResult DeleteAutor(int IdAutor)
        {
            bool result = BL.Libro.DeleteAutor(IdAutor);
            if (result)
            {
                return Ok("Se ha eliminado correctamente");
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("deleteeditorial/{IdEditorial}")]
        [HttpDelete]
        public IActionResult DeleteEditorial(int IdEditorial)
        {
            bool result = BL.Libro.DeleteEditorial(IdEditorial);
            if (result)
            {
                return Ok("Se ha eliminado correctamente");
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("")]
        [HttpPost]
        public IActionResult Add(ML.Libro libro)
        {
            bool result = BL.Libro.Add(libro);
            if (result)
            {
                return Ok("Se ha agregado Correctamente");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
