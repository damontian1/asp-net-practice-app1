using System.ComponentModel.DataAnnotations;

namespace asp_practice_app.Models
{
  public class Post
  {
    public int Id { get; set; }
    public string Title { get; set; }

    [DataType(DataType.MultilineText)]
    public string Body { get; set; }
  }
}