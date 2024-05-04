namespace Contracts;

public class Artist : Person
{
    public required List<Song> Songs { get; set; }
}

