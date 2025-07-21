using Microsoft.AspNetCore.Mvc;

namespace dotnetMCP.Controllers;

[ApiController]
[Route("[controller]")]
public class ToolController : ControllerBase
{
    private readonly ILogger<ToolController> _logger;

    public ToolController(ILogger<ToolController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<string> GetTools()
    {
        _logger.LogInformation("Fetching tool information.");
        return Ok("Tool information retrieved successfully.");
    }

    [HttpGet]
    [Route("add")]
    public ActionResult<string> Add(int a, int b)
    {
        _logger.LogInformation($"Adding numbers {a} and {b}.");
        return Ok(Tools.Add(a, b));
    }

    [HttpGet]
    [Route("reverse")]
    public ActionResult<string> Reverse(string message)
    {
        _logger.LogInformation($"Reversing message: {message}");
        return Ok(Tools.Reverse(message));
    }
}