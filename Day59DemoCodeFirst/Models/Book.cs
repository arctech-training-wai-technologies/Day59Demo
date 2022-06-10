using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Day59DemoCodeFirst.Models;

[Table("Book", Schema = "library")]
public class Book
{
    [Key]
    [StringLength(13)]
    [Column(TypeName = "varchar")]
    public string Isbn { get; set; }

    [Required]
    [StringLength(50)]
    [Column(TypeName = "varchar")]
    public string Title { get; set; }

    [Column(TypeName = "date")]
    public DateTime? LaunchDate { get; set; }

    public int AuthorRefId { get; set; }

    [ForeignKey(nameof(AuthorRefId))]
    public Author Author { get; set; }
}