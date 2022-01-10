using Mathematics.Models;
using Mathematics.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mathematics.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDBContext dbcontext;

    public HomeController(ApplicationDBContext _dbcontext)
    {
        dbcontext = _dbcontext;
    }

    [HttpGet]
    public ViewResult Index()
    {
        return View();
    }
    [HttpGet]
    public ViewResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(HomeRegisterViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            viewModel.Id = dbcontext.Persons.Max(i => i.Id) + 1;

            Person person = new Person()
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Email = viewModel.Email,
                Birth = viewModel.Birth,
                Login = viewModel.Login,
                Password = viewModel.Password

            };
            dbcontext.Persons.Add(person);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();

    }
    public JsonResult Data()
    {
        return Json(new { id = 1, name = "Ruzimurod", age = 18, birth = "23-11-2003" });
    }
}

