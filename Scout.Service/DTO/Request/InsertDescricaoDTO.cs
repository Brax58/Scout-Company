using MediatR;
using Scout.Service.DTO.Response;
using System;
using System.Text.Json.Serialization;

namespace Scout.Service.DTO.Request
{
    public class InsertDescricaoDTO : IRequest<ResponseDescricaoDTO>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Descricao { get; set; }
    }
}
