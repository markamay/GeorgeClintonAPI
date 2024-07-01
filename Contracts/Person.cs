using System.ComponentModel.DataAnnotations;

namespace Contracts;

public class Person
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required DateOnly DateOfBirth { get; set; }

    public virtual string DisplayName => $"{FirstName} {LastName}";
}