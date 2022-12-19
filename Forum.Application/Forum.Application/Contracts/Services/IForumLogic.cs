using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Application.Dto;

namespace Forum.Application.Contracts.Services
{
    public interface IForumLogic
    {
        Task<FormPostDto> getFormPostById(Guid forumId);
        Task<List<FormPostDto>> getAllAsync();
        Task<Guid?> createFormPost(NewFormPostDto formPost);
        Task updateFormPost(FormPostDto formPost, string userId);
    }
}
