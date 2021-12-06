using MediatR;
using Scout.Infrastructure.DTO.Response;
using System;
using System.Text.Json.Serialization;

namespace Scout.Infrastructure.DTO.Request
{
    public class DeletePessoaDTO : IRequest<ResponseDeletePostDTO>
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public DeletePessoaDTO(Guid id)
        {
            Id = id;
        }
    }
}
