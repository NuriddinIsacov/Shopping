using FlowerShop.Business.Interfaces;
using FlowerShop.Domain.DTOs;
using FlowerShop.Domain.Models;
using FlowerShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop.Business.Services
{
    public class FlowerServiceAsync : IFlowerServiceAsync
    {
        private readonly IFlowerRepoAsync flowerRepoAsync;

        public FlowerServiceAsync(IFlowerRepoAsync flowerRepoAsync)
        {
            this.flowerRepoAsync = flowerRepoAsync;
        }

        public async Task<IList<Flower>> GetAllFlowerAsync() => await flowerRepoAsync.GetAllProducts();
        public async Task<Flower> GetFlowerByIdAsync(long id) => await flowerRepoAsync.GetByIdAsync(id);

        public async Task<IList<Flower>> GetFovoriteFlowerAsync(IReadOnlyList<long> ListId)
        {
            var flowerList = await flowerRepoAsync.GetAllProducts();

            var resultId = flowerList.Select(x => x.Id).Intersect(ListId);

            List<Flower> resultFlower = new List<Flower>();

            foreach (var item in resultId)
            {
                resultFlower.Add(flowerList.Find(x => x.Id == item));
            }

            return resultFlower;
        }

        public async Task<IList<Flower>> GetNewFlowerAsync()
        {
            var flowers = await flowerRepoAsync.GetAllProducts();
            IList<Flower> newFlowers  = new List<Flower>();

            foreach (var item in flowers)
            {
                if ((DateTime.Now - item.CreatedDate).TotalDays <= 10)
                    newFlowers.Add(item);
            }

            return newFlowers;
        }

        public async Task<IReadOnlyList<Flower>> GetPopularFlowerAsync()
        {
            var flowers = await flowerRepoAsync.GetAllProducts();

            return flowers.Where(x => x.Status == Domain.Enums.Status.Popular).ToList();
        }

        public async Task<Flower> PostFlowerAsync(FlowerDTO entity)
        {
            var flower = (Flower)entity;
            flower.CreatedDate = DateTime.Now;
            return await flowerRepoAsync.AddAsync(flower);
        }
    }
}
