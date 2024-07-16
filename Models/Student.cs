using System.ComponentModel.DataAnnotations;

namespace MvcStudent.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime BirthDay { get; set; }
    public string? Genre { get; set; }
}
