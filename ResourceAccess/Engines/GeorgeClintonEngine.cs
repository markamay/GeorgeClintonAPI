using Contracts;

namespace ResourceAccess.Engines;

public class GeorgeClintonEngine : IGeorgeClintonEngine
{
    public Artist GenerateGeorgeClinton()
    {
        return new Artist()
        {
            FirstName = "George",
            LastName = "Clinton",
            DateOfBirth = new DateOnly(1941, 7, 22),
            Songs = [
                new Song()
                {
                    Title = "Atomic Dog",
                    DurationSeconds = 4 * 60 + 15,
                    ReleaseDate = new DateOnly(1982, 12, 1)
                },
                new Song()
                {
                    Title = "Do Fries Go with That Shake?",
                    DurationSeconds = 5 * 60 + 57,
                    ReleaseDate = new DateOnly(1986, 4, 15)
                }
            ]
        };
    }
}
