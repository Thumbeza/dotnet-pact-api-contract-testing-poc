using Microsoft.AspNetCore.Mvc;
using Pact.Poc.Api.Models;

namespace Pact.Poc.Api.Controllers;

public class StudentController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public StudentController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
    
    //GET api/students
    [HttpGet(Name = "GetStudents")]
    public IEnumerable<Student> Get()
    {
        var student = new Student
        {
            Name = "Siphesihle",
            Address = "Hlophe",
            Grade = 10,
            Subjects = new List<string>
                { "Maths", "IsiZulu", "Physical Sciences", "Life Sciences", "Geography", "English" }
        };
        
        _logger.Log(LogLevel.Information, "new student record has been created");

        return new List<Student> { student };
    }

}