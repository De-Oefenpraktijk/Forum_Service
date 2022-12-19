using Forum.Application.Dto.Comment;

namespace Forum.Application.Dto;

public class FormPostDto: BaseFormPostDto
{
    public Guid Id { get; set; }
    public ICollection<CommentDto>? comments { get; set; }
}