using System;
using System.ComponentModel.DataAnnotations;

namespace Mathematics.Models;

public class Person
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Ismingizni kiriting")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "Tug'ilgan kuningizni kiriting:")]
    public DateTime Birth { get; set; }

    [Required]
    [Display(Name = "Loginingizni kiriting:")]
    public string Login { get; set; }

    [Required]
    [Display(Name = "Parolingizni kiriting:")]
    public string Password { get; set; }

    [Required]
    [Display(Name = "Emailingizni kiriting:")]
    public string Email { get; set; }

    [Required]
    public Role Role { get; set; }= Role.User;
}
public enum Role
{
    Administrator,User,TestCompiler
}