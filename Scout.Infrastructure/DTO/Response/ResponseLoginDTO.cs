using Scout.Infrastructure.DTO.BaseDTO;
using System;

namespace Scout.Infrastructure.DTO.Response
{
    public class ResponseLoginDTO : Error
    {
        public Guid Id { get; set; }
    }
}
