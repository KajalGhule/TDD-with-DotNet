using Microsoft.AspNetCore.Mvc;
using Transflower.WebAPI.Services;

namespace Transflower.WebAPI.Controllers;

[ApiController]
[Route("api")]
public class SubjectsController : ControllerBase
{
    private readonly ISubjectService _service;

    public SubjectsController(ISubjectService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        Console.WriteLine("Fetching all subjects from the controller...");
        var subjects = _service.GetAllSubjects();
        return Ok(subjects);
    }
}
