using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record GameDto(
    int Id,
    string Name,
    string Genre,
    Decimal Price,
    DateTime ReleaseDate,
    string ImageUri
);

public record CreateGameDto(
      
      [Required] [StringLength(50)]   string Name,
    [Required] [StringLength(50)]string Genre,
    [Range(1,100)] Decimal Price,
    DateTime ReleaseDate,
    [Url][StringLength(100)] string ImageUri
);
public record UpdateGameDto(
      
      [Required] [StringLength(50)]   string Name,
    [Required] [StringLength(50)]string Genre,
    [Range(1,100)] Decimal Price,
    DateTime ReleaseDate,
    [Url][StringLength(100)] string ImageUri
);