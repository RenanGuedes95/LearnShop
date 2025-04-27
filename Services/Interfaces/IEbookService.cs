using LearnShop.Models;

namespace LearnShop.Services.Interfaces
{
    public interface IEbookService
    {
        Task<List<Ebook>> GetEbooksAsync();
        Task<List<Ebook>> GetEbooksByCategoryAsync(string category);
    }
}