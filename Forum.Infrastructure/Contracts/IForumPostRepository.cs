using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infrastructure.Contracts
{
    public interface IForumPostRepository : IGenericRepository<FormPost>
    {
        Task<FormPost> GetFormPostById(Guid id);
    }
}
