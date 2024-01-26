using lab4.ContextModels;
using lab4.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;


namespace lab4.Repositories

{
    public class NewsRepository : INewsRepository
    {
        private readonly StiriContext _stiriContext;

        public NewsRepository(StiriContext stiriContext) 
        {
            _stiriContext = stiriContext;
        }

      
        public async Task<Stire> GetStireAsync(int Id, bool? includeCategories)
        {

            if (includeCategories == true)
            {
                var stire = await _stiriContext.Stire.Include(S => S.Categorie).FirstOrDefaultAsync(S => S.Id == Id);
                return stire;
            }
            else { var stire = await _stiriContext.Stire.FirstOrDefaultAsync(S => S.Id == Id);

                return stire;
            }
           
        }


        public async Task<IEnumerable<Stire>> GetStiriAsync()
        {
            var stiri =await _stiriContext.Stire.ToListAsync();
              
            return stiri;
        }

    }


}
