using LearnShop.Services.Interfaces;
using LearnShop.Models;
using System.Net.Http.Json;

namespace LearnShop.Services
{
    public class EbookService : IEbookService
    {
        private readonly HttpClient _httpClient;

        public EbookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Ebook>> GetEbooksAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Ebook>>("data/products.json") ?? new List<Ebook>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar obter os ebooks: {ex.Message}");
                return new List<Ebook>();
            }
        }
    }
}