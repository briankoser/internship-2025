using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmsDemo.Models;

public class Film
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public IEnumerable<string> Genres { get; set; } = [];

    // [Column(TypeName = "decimal(18, 2)")]
    public double Popularity { get; set; }

    [Display(Name = "Poster")]
    public string PosterPath { get; set; } = string.Empty;

    public string Overview { get; set; } = string.Empty;
}