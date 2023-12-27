using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MainLayer.Controllers;

public class BookcaseController : Controller
{
    private readonly IBookcaseService _bookcaseService;

    public BookcaseController(IBookcaseService bookcaseService)
    {
        _bookcaseService = bookcaseService;
    }

    // GET
    public IActionResult Index()
    {
        var values = _bookcaseService.TGetList();
        return View(values);
    }
}