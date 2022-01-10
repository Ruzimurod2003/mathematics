using Mathematics.Models;
using System.ComponentModel.DataAnnotations;

namespace Mathematics.ViewModels;

public class AdministratorIndexViewModel
{
    public IEnumerable<Person> Persons { get; set; }
}