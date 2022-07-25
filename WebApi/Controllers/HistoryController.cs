using Core.Dtos;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryService _historyService;
        public HistoryController(IHistoryService historyService)
        {
            _historyService = historyService;
        }
        [HttpPost("operations")]
        public async Task<IActionResult> Operations(HistoryRequest historyRequest)
        {
            var result = await _historyService.InsertHistory(historyRequest);
            return Ok(result);
        }
    }
}
