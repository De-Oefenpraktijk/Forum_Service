using AutoMapper;
using Forum.Domain.Entities;
using Forum.Infrastructure.Contracts;
using Forum.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infrastructure.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
