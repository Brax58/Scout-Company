using Scout.Service.DTO.BaseDTO;
using System;

namespace Scout.Service.DTO.Response
{
    public class ResponseLoginDTO : Errors
    {
        public Guid Id { get; set; }
    }
}
