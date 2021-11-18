using Scout.Domain.Entity;
using System.Threading.Tasks;

namespace Scout.Infrastructure.Interface
{
    public interface IPostRepository
    {
        Task InsertPost(Post post);
    }
}
