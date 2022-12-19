using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Entities;

public class FormPost
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string FormBody { get; set; } = null!; 
    public string UserId { get; set; } = null!;
    public string UserName { get; set; } = null!;

    public ICollection<Comment>? comments { get; set; }
}