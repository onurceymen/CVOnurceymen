using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MainLayer.Controllers;

public class CommentController : Controller
{
    private readonly ICommentService _commentService;

    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    // GET
    public IActionResult Index()
    {
        var values = _commentService;
        return View(values);
    }
}