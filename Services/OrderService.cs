using LearnShop.Services.Interfaces;
using LearnShop.Models;
using System.Net.Http.Json;

namespace LearnShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Order>>("data/orders.json") ?? new List<Order>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar obter os pedidos: {ex.Message}");
                return new List<Order>();
            }
        }
    }
}