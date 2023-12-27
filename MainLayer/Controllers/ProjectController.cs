using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MainLayer.Controllers;

public class ProjectController : Controller
{
    private readonly IProjectService _projectService;

    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    // GET
    public IActionResult Index()
    {
        var values = _projectService.TGetList();
        return View(values);
    }
}