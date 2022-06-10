using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Day59DemoCodeFirst.Models;

[Table("Author", Schema = "library")]

public class Author
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Required]
    [Column(TypeName = "varchar")]
    public string Name { get; set; }

    [StringLength(50)]
    [Column(TypeName = "varchar")]
    public string Mobile { get; set; }

    [StringLength(50)]
    [Column(TypeName = "varchar")]
    public string Email { get; set; }
}