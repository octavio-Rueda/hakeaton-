using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using WebGuiaCesar.Models;


namespace WebGuiaCesar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalificacionController : ControllerBase
    {
     
        private IWebHostEnvironment _env;
        private AplicactionContext _context;
        public CalificacionController(IWebHostEnvironment env, AplicactionContext context)
        {
            _env = env;
            this._context = context;
        }

            [HttpPost]
        public async Task<IActionResult> OnPostUploadAsync([FromForm]Calificacion model)
        {
            var response = new Calificacion();
            response.Nombre = model.Nombre; 
            response.Puntuacion= model.Puntuacion; 
           

            
            _context.calificacions.Add(response);
            await _context.SaveChangesAsync();
            return Ok(response);
        }




         
       











        
    }
}