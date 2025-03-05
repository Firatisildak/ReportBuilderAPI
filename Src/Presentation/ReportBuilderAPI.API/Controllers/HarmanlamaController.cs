using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportBuilderAPI.Application.Interfaces;

namespace ReportBuilderAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HarmanlamaController(IHarmanlamaRepository harmanlamaRepository) : ControllerBase
    {
        private readonly IHarmanlamaRepository _harmanlamaRepository = harmanlamaRepository;

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByDate([FromQuery] string startDate, [FromQuery] string endDate)
        {
            if (!DateTime.TryParse(startDate, out DateTime start) || !DateTime.TryParse(endDate, out DateTime end))
            {
                return BadRequest("Geçerli bir tarih formatı giriniz. Örnek: yyyy-MM-dd HH:mm:ss");
            }

            var result = await _harmanlamaRepository.GetHarmanlamaByDateAsync(start, end);
            return Ok(result);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllHarmanlama()
        {
            try
            {
                var result = await _harmanlamaRepository.GetAll().ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }



        [HttpGet("[action]")]
        public async Task<IActionResult> GetByIdHarmanlama(int id) => Ok(await _harmanlamaRepository.GetById(id));

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByReceteAndRevizyon([FromQuery] IList<int> receteler, [FromQuery] IList<int> revizyonlar, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _harmanlamaRepository.GetHarmanlamaByReceteAndRevizyonAsync(receteler, revizyonlar, startDate, endDate);
            return Ok(result);
        }
    }
}
