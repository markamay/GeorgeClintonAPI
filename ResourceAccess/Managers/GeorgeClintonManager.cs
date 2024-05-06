using Contracts;
using Microsoft.Extensions.Logging;
using ResourceAccess.Engines;

namespace ResourceAccess.Managers;

public class GeorgeClintonManager(
    IGeorgeClintonEngine engine,
    ILogger<GeorgeClintonManager> logger) : IGeorgeClintonManager
{
    public Artist? GetGeorgeClinton()
    {
        logger.LogDebug("Retrieving George Clinton...");
        var georgeClinton = engine.GenerateGeorgeClinton();
        logger.LogDebug("George Clinton retrieved!");

        return georgeClinton;
    }

    public Artist? GetGeorgeClintonByDateOfBirth(DateOnly dateOfBirth)
    {
        logger.LogDebug("Retrieving George Clinton...");
        var georgeClinton = engine.GenerateGeorgeClinton();
        logger.LogDebug("George Clinton retrieved!");

        // Check to make sure George Clinton has the chosen date of birth... 
        if (georgeClinton.DateOfBirth != dateOfBirth)
            return null;

        return georgeClinton;
    }
}

