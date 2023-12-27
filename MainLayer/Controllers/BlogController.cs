using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MainLayer.Controllers;

public class BlogController : Controller
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService)
    {
        _blogService = blogService;
    }

    // GET
    public IActionResult Index()
    {
        var values  = _blogService.TGetList(); 
        return View(values);
    }

}