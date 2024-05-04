using Contracts;
using Microsoft.AspNetCore.Mvc;
using ResourceAccess.Managers;

namespace GeorgeClintonAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GeorgeClintonController(IGeorgeClintonManager georgeClintonManager) : ControllerBase
{
    private readonly IGeorgeClintonManager _georgeClintonManager = georgeClintonManager;

    [HttpGet("GetGeorgeClinton")]
    public ActionResult<Artist> GetGeorgeClinton()
    {
        var georgeClinton = _georgeClintonManager.GetGeorgeClinton();
        if (georgeClinton == null)
            return new NotFoundResult();

        return Ok(georgeClinton);
    }

    [HttpGet("GetGeorgeClintonByDateOfBirth")]
    public ActionResult<Artist> GetGeorgeClintonByDateOfBirth([FromQuery] DateOnly dateOfBirth)
    {
        var georgeClinton = _georgeClintonManager.GetGeorgeClintonByDateOfBirth(dateOfBirth);
        if (georgeClinton == null)
            return new NotFoundObjectResult("No George Clintons found with that date of birth!");

        return Ok(georgeClinton);
    }
}
