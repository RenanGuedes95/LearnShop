using LearnShop.Models;

namespace LearnShop.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersAsync();
    }
}