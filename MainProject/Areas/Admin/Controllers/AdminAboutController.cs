using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MainProject.Areas.Admin.Controllers;

[Authorize]
[Area("Admin")]
public class AdminAboutController : Controller
{
    private readonly IAboutService _aboutService;

    // GET
    public AdminAboutController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public IActionResult Index()
    {
        var values = _aboutService.TGetList();
        return View(values);
    }

    public IActionResult DeleteAbout(int id)
    {
        var value = _aboutService.TGetById(id);

        if (value != null)
        {
            _aboutService.TDelete(value);
            return RedirectToAction("Index");
        }
        else
        {
            // Hata durumu, silinecek veri bulunamadı.
            return NotFound("// Hata durumu, silinecek veri bulunamadı.");
        }
    }

    [HttpGet]
    public ActionResult AddAbout()
    {
        return View("AddAbout");
    }

    [HttpPost]
    public ActionResult AddAbout(About about)
    {
        if (ModelState.IsValid)
        {
            _aboutService.TAdd(about);
            return RedirectToAction("Index"); // Eğer bir listeleme sayfası varsa, ona yönlendirilebilir.
        }

        return View("AddAbout");
    }
/*
    [HttpGet]
    public ActionResult UpdateAbout()
    {
        return View("UpdateAbout");
    }

    [HttpPost]
    public ActionResult UpdateAbout(About about)
    {
        var existingAbout = _aboutService.TGetById(about.ID);

        if (existingAbout != null)
        {
            existingAbout.Name = about.Name;
            existingAbout.Surname = about.Surname;
            existingAbout.Content1 = about.Content1;
            existingAbout.Content2 = about.Content2;
            existingAbout.Image1 = about.Image1;
            existingAbout.Image2 = about.Image2;

            _aboutService.TUpdate(existingAbout);

            if (ModelState.IsValid)
            {
                try
                {
                    _aboutService.TUpdate(about);
                    return
                        RedirectToAction(
                            "Index"); // Başarıyla güncellendiği durumda başka bir sayfaya yönlendirme yapabilirsiniz.
                }
                catch (Exception ex)
                {
                    // Hata durumunda uygun bir işlem yapabilirsiniz.
                    ModelState.AddModelError("", "Güncelleme sırasında bir hata oluştu.");
                    return View("UpdateAbout", about);
                }
            }
        }
        // ModelState geçerli değilse tekrar aynı sayfayı göster
        return View("UpdateAbout", about);
    }
    */
}
    

