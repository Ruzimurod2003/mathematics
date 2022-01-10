using Mathematics.Models;
using Mathematics.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mathematics.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly ApplicationDBContext dbContext;

        public AdministratorController(ApplicationDBContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        public ViewResult Index()
        {
           AdministratorIndexViewModel viewModel = new AdministratorIndexViewModel()
           {
               Persons=dbContext.Persons
           };
            return View(viewModel);
        }
    }
}
