using System.ComponentModel.DataAnnotations;

namespace Mathematics.ViewModels;

public class HomeIndexViewModel
{
    [Required]
    public string Login { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}

