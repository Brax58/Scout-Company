using Scout.Infrastructure.Repository;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class InsertImagemPessoaService
    {
        public readonly PessoaRepository _repository;

        public InsertImagemPessoaService(PessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseImagemDTO> InsertImagemPessoa(InsertImagemPessoaDTO request) 
        {
            if (_repository.GetPessoaById(request.Id) != "") 
            {
                
            }
        }
    }
}
