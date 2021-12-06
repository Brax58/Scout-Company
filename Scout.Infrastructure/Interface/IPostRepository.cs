using Scout.Domain.Entity;
using Scout.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scout.Infrastructure.Interface
{
    public interface IPostRepository
    {
        Task InsertPost(Post post);
        Task<IEnumerable<PostUnicoBanco>> GetPosts(Guid id, int quantidade);
    }
}
