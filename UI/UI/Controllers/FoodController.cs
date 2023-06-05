﻿using BL;
using BL.DTO;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        readonly IFoodService FoodService;
        public FoodController(IFoodService foodService)
        {
            this.FoodService = foodService;
        }
        [HttpGet]
        public async Task<List<FoodDTO>> GetAll()
        {
            return FoodService.GetAllAsync().Result;
        }
        [HttpGet("get/{code}")]
        public async Task<FoodDTO> GetSingle(string code)
        {
            return FoodService.GetSingleAsync(code).Result;

        }
        //[HttpPost("simplex")]
        //public async Task<string> CreateMealStructure(string jsonStracture)
        //{

        //}
        [HttpPost("simplex")]
        public async Task<string> getSimplex(ClientDTO client)
        {
            
            List<FoodDTO> foodList = await GetAll();
            MenuPlanning menuPlanning = new MenuPlanning();//dependency injection
            //return menuPlanning.Option3Async(foodList).Result;
            return await menuPlanning.CreateMenu(foodList, client);
        }
    }
}
