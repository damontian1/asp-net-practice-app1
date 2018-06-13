using System.ComponentModel.DataAnnotations;

namespace asp_practice_app.Models {
  public class Employee {
    public int EmployeeId { get; set; }
    [Required]
    [Display(Name = "First Name", Prompt = "Enter First Name")]
    public string Name { get; set; }
  }
}