﻿using BlazingShop.Server.Services.StatsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService _statsService;

        public StatsController(IStatsService statsService)
        {
            _statsService = statsService;
        }
        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statsService.GetVisits();
        }

        public async Task IncrementVisits()
        {
            await _statsService.IncrementVisits();
        }
    }
}
