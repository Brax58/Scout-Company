using MediatR;
using Scout.Infrastructure.DTO.Response;
using System;
using System.Text.Json.Serialization;

namespace Scout.Infrastructure.DTO.Request
{
    public class GetFotoDTO : IRequest<ResponseGetFotoDTO>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
    }
}
