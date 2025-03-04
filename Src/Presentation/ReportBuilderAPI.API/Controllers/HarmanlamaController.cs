using Microsoft.AspNetCore.Mvc;
using ReportBuilderAPI.Application.Interfaces;
using ReportBuilderAPI.Domain.Entities;

namespace ReportBuilderAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HarmanlamaController(IHarmanlamaRepository harmanlamaRepository) : ControllerBase
    {
        private readonly IHarmanlamaRepository _harmanlamaRepository = harmanlamaRepository;

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _harmanlamaRepository.GetHarmanlamaByDateAsync(startDate, endDate);
            return Ok(result);
        }
        [HttpGet("[action]")]
        public Task<IActionResult> GetAllKamyon() => Task.FromResult<IActionResult>(Ok(_harmanlamaRepository.GetAll()));

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByReceteAndRevizyon([FromQuery] IList<int> receteler, [FromQuery] IList<int> revizyonlar, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _harmanlamaRepository.GetHarmanlamaByReceteAndRevizyonAsync(receteler, revizyonlar, startDate, endDate);
            return Ok(result);
        }
    }
}
