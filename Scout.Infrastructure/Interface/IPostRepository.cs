using Scout.Domain.Entity;
using Scout.Service.DTO.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scout.Infrastructure.Interface
{
    public interface IPostRepository
    {
        Task InsertPost(Post post);
        Task<IEnumerable<ResponseGetPostDTO>> GetPosts(Guid id, int quantidade);
    }
}
