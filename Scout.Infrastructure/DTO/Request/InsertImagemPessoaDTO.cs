using MediatR;
using Scout.Infrastructure.DTO.Response;
using System;
using System.Text.Json.Serialization;

namespace Scout.Infrastructure.DTO.Request
{
    public class InsertImagemPessoaDTO : IRequest<ResponseImagemDTO>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Imagem { get; set; }
    }
}
