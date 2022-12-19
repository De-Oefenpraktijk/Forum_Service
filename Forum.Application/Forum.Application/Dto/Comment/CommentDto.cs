using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Dto.Comment
{
    public class CommentDto : BaseCommentDto
    {
        public Guid Id { get; set; }
    }
}
