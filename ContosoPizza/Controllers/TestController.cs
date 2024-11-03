using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]

public class TestController : ControllerBase {
    private static readonly string[] foo = new[] {
        "Fizz", "Buzz", "Baz"
    };

    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger) {
        _logger = logger;
    }

    [HttpGet(Name = "GetFoo")]
    public IEnumerable<string> Get() {
        return foo;
    }
}