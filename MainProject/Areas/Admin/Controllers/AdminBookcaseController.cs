using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MainProject.Areas.Admin.Controllers
{ 
    [Area("Admin")]
    public class AdminBookcaseController : Controller
    {

        private readonly IBookcaseService _bookcaseService;
        // GET
        public AdminBookcaseController(IBookcaseService bookcaseService)
        {
            _bookcaseService = bookcaseService;
        }

        public IActionResult Index()
        {
            var values = _bookcaseService.TGetList();
            return View(values);
        }

        public IActionResult DeleteBookcase(int id)
        {
            var value = _bookcaseService.TGetById(id);

            if (value != null)
            {
                _bookcaseService.TDelete(value);
                return RedirectToAction("Index");
            }
            else
            {
                // Hata durumu, silinecek veri bulunamadı.
                return NotFound("// Hata durumu, silinecek veri bulunamadı.");
            }
        }

        [HttpGet]
        public ActionResult AddBookcase()
        {
            return View("AddBookcase");
        }

        [HttpPost]
        public ActionResult AddBookcase(Bookcase bookcase)
        {
            if (ModelState.IsValid)
            {
                _bookcaseService.TAdd(bookcase);
                return RedirectToAction("Index"); // Eğer bir listeleme sayfası varsa, ona yönlendirilebilir.
            }

            return View("AddBookcase");
        }

        [HttpGet]
        public ActionResult UpdateBookcase()
        {
            return View("UpdateBookcase");
        }

        [HttpPost]
        public ActionResult UpdateBookcase(Bookcase bookcase)
        {
            if (ModelState.IsValid)
            {
                _bookcaseService.TUpdate(bookcase);
                return RedirectToAction("Index"); // Eğer bir listeleme sayfası varsa, ona yönlendirilebilir.
            }

            return View("UpdateBookcase");
        }
    }
}
