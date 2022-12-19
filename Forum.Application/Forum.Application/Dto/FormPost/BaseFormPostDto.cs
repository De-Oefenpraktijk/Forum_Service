using System.ComponentModel.DataAnnotations;

namespace Forum.Application.Dto;

public abstract class BaseFormPostDto
{
    [Required]
    public string Title { get; set; } = null!;
    [Required]
    public string FormBody { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string UserName { get; set; } = null!;
}