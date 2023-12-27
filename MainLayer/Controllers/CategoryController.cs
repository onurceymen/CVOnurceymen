using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MainLayer.Controllers;

public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    // GET
    public IActionResult Index()
    {
        var values = _categoryService.TGetList();
        return View();
    }
}