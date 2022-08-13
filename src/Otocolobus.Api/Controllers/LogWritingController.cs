using Microsoft.AspNetCore.Mvc;

namespace Otocolobus.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LogWritingController : ControllerBase
{
    private readonly ILogger<LogWritingController> _logger;

    public LogWritingController(ILogger<LogWritingController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Write")]
    public IActionResult Get()
    {
        _logger.LogInformation("Write controller call");
        return Ok();
    }
}