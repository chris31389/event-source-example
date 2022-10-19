using Microsoft.AspNetCore.Mvc;

namespace People.Api.Controllers;

[ApiController]
[Route("api/people")]
public class PersonController : ControllerBase
{
    // GET
    public async Task<IActionResult> GetPersonAsync(Guid fingerPrint, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return NoContent();
    }
}