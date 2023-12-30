using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MainProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        private readonly IBlogService _blogService;
        // GET
        public AdminBlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var values = _blogService.TGetList();
            return View(values);
        }

        public IActionResult DeleteBlog(int id)
        {
            var value = _blogService.TGetById(id);

            if (value != null)
            {
                _blogService.TDelete(value);
                return RedirectToAction("Index");
            }
            else
            {
                // Hata durumu, silinecek veri bulunamadı.
                return NotFound("// Hata durumu, silinecek veri bulunamadı.");
            }
        }

        [HttpGet]
        public ActionResult AddBlog()
        {
            return View("AddBlog");
        }

        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _blogService.TAdd(blog);
                return RedirectToAction("Index"); // Eğer bir listeleme sayfası varsa, ona yönlendirilebilir.
            }

            return View("AddBlog");
        }

        [HttpGet]
        public ActionResult UpdateBlog()
        {
            return View("UpdateBlog");
        }

        [HttpPost]
        public ActionResult UpdateBlogt(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _blogService.TUpdate(blog);
                return RedirectToAction("Index"); // Eğer bir listeleme sayfası varsa, ona yönlendirilebilir.
            }

            return View("UpdateBlog");
        }
    }
}