using Forum.Application.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Application.Dto;
using Forum.Infrastructure.Contracts;
using AutoMapper;
using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Forum.Application.Features
{
    public class ForumLogic: IForumLogic
    {
        private readonly IForumPostRepository _forumPostRepository;
        private readonly IMapper _mapper;

        public ForumLogic(IForumPostRepository forumPostRepository, IMapper mapper)
        {
            _forumPostRepository = forumPostRepository;
            _mapper = mapper;
        }

        public async Task<FormPostDto> getFormPostById(Guid forumId)
        {
            var result = await _forumPostRepository.GetFormPostById(forumId);

            if (result == null)
            {
                return null;
            }

            var formPostDto = _mapper.Map<FormPostDto>(result);

            return formPostDto;
        }


        public async Task<List<FormPostDto>> getAllAsync()
        {
            var result = await _forumPostRepository.GetAllAsync();

            if (result == null)
            {
                return null;
            }

            var dtos = _mapper.Map<List<FormPostDto>>(result);

            return dtos;

        }

        public async Task<Guid?> createFormPost(NewFormPostDto formPostDto)
        {
            var formPost = _mapper.Map<FormPost>(formPostDto);

            var result = await _forumPostRepository.AddAsync(formPost);

            if (result == null)
            {
                return null;
            }

            return formPost.Id;
        }

        public async Task updateFormPost(FormPostDto formPostDto, string userId)
        {
            if (formPostDto.UserId != userId)
            {
                // TODO: log / return error
            }
            var formPost = _mapper.Map<FormPost>(formPostDto);

            try
            {
                await _forumPostRepository.UpdateAsync(formPost);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _forumPostRepository.Exists(formPost.Id))
                {
                    throw new Exception("FormPost not found");
                }
                else
                {
                    throw;
                }
            }   
        }
    }
}
