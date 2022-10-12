namespace Pact.Poc.Api.Models;

public class Student
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public int Grade { get; set; }
    public List<string>? Subjects { get; set; }
}