using manager_service.Models;
using Microsoft.AspNetCore.Mvc;

namespace manager_service.Controllers;

[ApiController]
[Route("[controller]")]
public class LoggingController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult LogInfo(LogMessage msg)
    {
        return Ok();
    }
    
}