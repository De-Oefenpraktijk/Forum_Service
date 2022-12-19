using Forum.Application.Dto.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Contracts.Services
{
    public interface ICommentLogic
    {
        Task<Guid?> addCommentToFormPost(NewCommentDto commentDto);
    }
}
