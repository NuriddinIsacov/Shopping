using FlowerShop.Business.Interfaces;
using FlowerShop.Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlowersShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowerController : ControllerBase
    {
        private readonly IFlowerServiceAsync flowerService;

        public FlowerController(IFlowerServiceAsync flowerService)
        {
            this.flowerService = flowerService;
        }

        [HttpPost, Route("AddFlower")]
        public async Task<IActionResult> PostFlower(FlowerDTO flower)
        {
            return Created("", await flowerService.PostFlowerAsync(flower));
        }

        [HttpGet("id: long")]
        public async Task<IActionResult> GetFlowerById(long id) => Ok(await flowerService.GetFlowerByIdAsync(id));

        [HttpPost, Route("GetFoworiteFlowers")]
        public async Task<IActionResult> GetFoworite(List<long> list)
        {
            var content = await flowerService.GetFovoriteFlowerAsync(list);

            if (content is not null)
                return Ok(content);
            else
                return BadRequest("So'rovda xatolik mavjud!!!");

        }
        [HttpGet("GetAllFlowers")]
        public async Task<IActionResult> GetAllFlowersAsync() => Ok(await flowerService.GetAllFlowerAsync());

        [HttpGet, Route("GetNewFlowers")]
        public async Task<IActionResult> GetNewFlowersAsync() => Ok(await flowerService.GetNewFlowerAsync());

        [HttpGet, Route("GetPopularFlowers")]
        public async Task<IActionResult> GetPopularFlowersAsync() => Ok(await flowerService.GetPopularFlowerAsync());



    }
}
