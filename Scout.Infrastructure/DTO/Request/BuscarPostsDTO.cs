using MediatR;
using Scout.Infrastructure.DTO.Response;
using System;

namespace Scout.Service.DTO.Request
{
    public class BuscarPostsDTO : IRequest<ResponseGetPostDTO>
    {

        public int QuantidadePosts { get; set; }
        public Guid Id { get; set; }

        public BuscarPostsDTO(int quantidadePosts, Guid id)
        {
            QuantidadePosts = quantidadePosts;
            Id = id;
        }
    }
}
