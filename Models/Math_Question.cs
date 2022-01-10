using System.ComponentModel.DataAnnotations;

namespace Mathematics.Models;

public class Math_Question
{
    [Key]
    public int Question_Id { get; set; }

    public string Question { get; set; }

    public string Answer_A { get; set; }

    public string Answer_B { get; set; }
    
    public string Answer_C { get; set; }
    
    public string Answer_D { get; set; }

    public Answer Answer { get; set; }
}
public enum Answer
{
    A, B, C, D
}