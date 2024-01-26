using lab4.ContextModels;
using lab4.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using lab4.Repositories;

namespace lab4.Controllers
{
    

    

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase

    {
        private readonly IMapper _mapper;

        private readonly INewsRepository _newsRepository;
        private readonly StiriContext _stiriContext;

        public ValuesController(StiriContext stiriContext, IMapper mapper,INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
            _stiriContext = stiriContext;
            _mapper = mapper;

        }
        [HttpGet]
        /*public  List<Stire> GetStiri()
        {
            return ( _stiriContext.Stire.ToList());
        }*/

      /*  public async Task<IActionResult> GetContacts()
        {
            return Ok(await _stiriContext.Stire.ToListAsync());
        }*/
        public async Task<List<StireDto>>GetStires()
        {
         /*   var stiri = from b in _stiriContext.Stire
                        select new StireDto()
                        {
                            Id = b.Id,
                            Titlu = b.Titlu,
                            Lead = b.Lead,
                            Continut = b.Continut,
                            Autor = b.Autor,
                            CategorieFK = b.CategorieFK,
                        };
*/
            var stiri = await _newsRepository.GetStiriAsync();

            var stiri2 = _mapper.Map<List<StireDto>>(stiri);
            return stiri2;
        }

        [HttpPut]
        public async Task<IActionResult> PutStire(int Id,PostStireDto s)
        {

            var stire = await _stiriContext.Stire.FindAsync(Id);
            if (stire == null)
            {
                return NotFound();
            }

            stire = _mapper.Map<Stire>(s);
           
            stire.Id = Id;
            _stiriContext.Entry(stire).State = EntityState.Modified;

            await _stiriContext.SaveChangesAsync();


            return Ok(stire);
        }
        
        
        
        [HttpPost]

        
        public async Task<IActionResult> PostStireDtos(PostStireDto s) 
        {



            Stire stire = _mapper.Map<Stire>(s);


            _stiriContext.Stire.Add(stire);
            await _stiriContext.SaveChangesAsync();

            /*stiriContext.Entry(stire).References(x=> x.Categorie);*/

            return Created("created", s);
        }


        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> ChangeStire([FromRoute] int Id,Stire s)
        {
            Stire stire = await _stiriContext.Stire.FindAsync(Id);
            if (stire != null)
            {
                stire.Autor = s.Autor;
                stire.Titlu = s.Titlu;
                stire.Id = Id;
                stire.Continut = s.Continut;
                stire.CategorieFK =s.CategorieFK;
                await _stiriContext.SaveChangesAsync();
                return Ok(stire);

            }
               return NotFound();
    
        }

    }
}

