using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public static List<Animal> Animale = new List<Animal>()
        {
            new Animal{ Id=1, Name="Azorel" , Description="Azorel cu parul cret"},
            new Animal{ Id=2, Name="Mieunel" , Description="Mieunel cu parul cret"},
            new Animal{ Id=3, Name="PUPUNEL" , Description="PUPUNEL cu parul cret"},
            new Animal{ Id=4, Name="Miorlau" , Description="Miorlau cu parul cret"},

        };
        [HttpGet]
        public List<Animal> GetAnimale()
        {
            return Animale;
        }
    }
}
