using AutoMapper;
using Forum.Domain.Entities;
using Forum.Infrastructure.Contracts;
using Forum.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infrastructure.Repository
{
    public class ForumPostRepository : GenericRepository<FormPost>, IForumPostRepository
    {
        private readonly AppDbContext _context;
        public ForumPostRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
        }

        public async Task<FormPost> GetFormPostById(Guid id)
        {
            return await _context.ForumPosts
                         .Include(fp => fp.comments)
                         .SingleOrDefaultAsync(fp => fp.Id == id);

        }
    }
}
