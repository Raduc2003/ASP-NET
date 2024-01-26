using lab4.Entities;

namespace lab4.Repositories

{
    public interface INewsRepository
    {
        Task<IEnumerable<Stire>> GetStiriAsync();
        Task<Stire> GetStireAsync(int Id,bool? includeCategories);


    }
}
