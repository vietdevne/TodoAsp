using System.ComponentModel.DataAnnotations;

namespace MvcStudent.Models;

public class Teacher
{
    public int Id { get; set; }
    [StringLength(100, MinimumLength = 3)]
    [Required]
    public string Name { get; set; }
}
