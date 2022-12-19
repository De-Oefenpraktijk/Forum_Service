using AutoMapper;
using Forum.Application.Dto;
using Forum.Application.Dto.Comment;
using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<NewFormPostDto, FormPost>().ReverseMap();
            CreateMap<FormPostDto, FormPost>().ReverseMap();
            CreateMap<NewCommentDto, Comment>().ReverseMap();
            CreateMap<CommentDto, Comment>().ReverseMap();
        }
    }
}
