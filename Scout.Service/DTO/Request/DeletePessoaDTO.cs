using MediatR;
using Scout.Service.DTO.Response;
using System;
using System.Text.Json.Serialization;

namespace Scout.Service.DTO.Request
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
