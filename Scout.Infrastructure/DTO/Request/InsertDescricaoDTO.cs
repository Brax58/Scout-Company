using MediatR;
using Scout.Infrastructure.DTO.Response;
using System;
using System.Text.Json.Serialization;

namespace Scout.Infrastructure.DTO.Request
{
    public class InsertDescricaoDTO : IRequest<ResponseDescricaoDTO>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Descricao { get; set; }
    }
}
