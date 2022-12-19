using AutoMapper;
using Forum.Application.Contracts.Services;
using Forum.Application.Dto.Comment;
using Forum.Domain.Entities;
using Forum.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Features
{
    public class CommentLogic : ICommentLogic
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IForumPostRepository _forumPostRepository;
        private readonly IMapper _mapper;

        public CommentLogic(ICommentRepository commentRepository, IForumPostRepository forumPostRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _forumPostRepository = forumPostRepository;
            _mapper = mapper;
        }

        public async Task<Guid?> addCommentToFormPost(NewCommentDto commentDto)
        {
            var formPost = await _forumPostRepository.GetAsync(commentDto.FormPostId);

            if(formPost == null)
            {
                throw new Exception("Form post doesn't exist");
            }

            var comment = _mapper.Map<Comment>(commentDto);

            comment.FormPost = formPost;

            var result = await _commentRepository.AddAsync(comment);

            if (result == null)
            {
                return null;
            }

            return comment.Id;
        }
    }
}
