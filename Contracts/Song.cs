using System.ComponentModel.DataAnnotations;

namespace Contracts;

public class Song
{
    public required string Title { get; set; }

    public required int DurationSeconds { get; set; }

    public required DateOnly ReleaseDate { get; set; }
}
