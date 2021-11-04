using Scout.Service.DTO.BaseDTO;
using System;

namespace Scout.Service.DTO.Response
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
