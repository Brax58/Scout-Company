using Scout.Infrastructure.DTO.BaseDTO;
using System;

namespace Scout.Infrastructure.DTO.Response
{
    public class ResponseCadastroPessoaDTO : Error
    {
        public Guid Id { get; set; }

        public void AddId(Guid id)
        {
            Id = id;
        }

    }
}
