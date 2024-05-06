using Contracts;

namespace ResourceAccess.Managers;

public interface IGeorgeClintonManager
{
    Artist? GetGeorgeClinton();
    Artist? GetGeorgeClintonByDateOfBirth(DateOnly dateOfBirth);
}

