using Microsoft.AspNetCore.Mvc;
using SpaceTraders.Application.DTO;

namespace SpaceTraders.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ILogger<RegisterController> _logger;

        public RegisterController(ILogger<RegisterController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        public async Task RegisterAgentAsync(RegisterAgentDto command)
        {

        }
    }
}
