using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using WebGuiaCesar.Models;

namespace WebGuiaCesar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalificacionController
    {
     
        private IWebHostEnvironment _env;
        private AplicactionContext _context;
        public CalificacionController(IWebHostEnvironment env, AplicactionContext context)
        {
            _env = env;
            this._context = context;
        }


         
       











        
    }
}