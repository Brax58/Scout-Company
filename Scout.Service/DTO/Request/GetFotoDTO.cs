using MediatR;
using Scout.Service.DTO.Response;
using System;
using System.Text.Json.Serialization;

namespace Scout.Service.DTO.Request
{
    public class GetFotoDTO : IRequest<ResponseGetFotoDTO>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
    }
}
