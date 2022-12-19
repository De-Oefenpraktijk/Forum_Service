using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Forum.Application.Contracts.Services;
using Forum.Application.Features;

namespace Forum.Application
{
    public static class RegisterApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IForumLogic, ForumLogic>();
            services.AddScoped<ICommentLogic, CommentLogic>();

            return services;
        }
    }
}
