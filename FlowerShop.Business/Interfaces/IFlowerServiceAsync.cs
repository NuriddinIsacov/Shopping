using FlowerShop.Domain.DTOs;
using FlowerShop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlowerShop.Business.Interfaces
{
    public interface IFlowerServiceAsync
    {
        Task<Flower> PostFlowerAsync(FlowerDTO entity);
        Task<IList<Flower>> GetAllFlowerAsync();
        Task<Flower> GetFlowerByIdAsync(long id);
        Task<IList<Flower>> GetNewFlowerAsync();
        Task<IList<Flower>> GetFovoriteFlowerAsync(IReadOnlyList<long> ListId);
        Task<IReadOnlyList<Flower>> GetPopularFlowerAsync();
    }
}
