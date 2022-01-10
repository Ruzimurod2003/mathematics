using Mathematics.Models;
using System.ComponentModel.DataAnnotations;

namespace Mathematics.ViewModels;

public class HomeRegisterViewModel:Person
{
    public int Id { get; set; }

    [Required]
    [Display(Name ="Ismingizni kiriting")]
    public string Name { get; set; }

    [Required]
    [Display(Name ="Tug'ilgan kuningizni kiriting:")]
    public DateTime Birth { get; set; }

    [Required]
    [Display(Name ="Loginingizni kiriting:")]
    public string Login { get; set; }

    [Required]
    [Display(Name ="Parolingizni kiriting:")]
    public string Password { get; set; }

    [Required]
    [Display(Name ="Emailingizni kiriting:")]
    public string Email { get; set; }

}
