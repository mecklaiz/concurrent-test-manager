using Microsoft.AspNetCore.Mvc;

namespace manager_service.Controllers;

[ApiController]
[Route("[controller]")]
public class TestResultController : ControllerBase
{
    [HttpPost]
    [Route("/result")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult PostResult()
    {
        return Created("test", null);
    }
}