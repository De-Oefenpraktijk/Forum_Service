using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Dto.Comment
{
    public abstract class BaseCommentDto
    {
        [Required]
        public string Text { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public Guid FormPostId { get; set; }
    }
}
