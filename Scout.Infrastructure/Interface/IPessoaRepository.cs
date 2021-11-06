using Scout.Domain.Entity;
using System;
using System.Threading.Tasks;

namespace Scout.Infrastructure.Interface
{
    public interface IPessoaRepository
    {
        Guid GetPessoaByLogin(string login);
        Task InsertPessoa(Pessoa pessoa);
        string GetPessoaById(Guid id);
        Task InsertImagem(Guid id, byte[] imagem);
        Task InsertDescricao(Guid id, string descricao);
    }
}
