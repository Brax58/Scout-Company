using Dapper;
using MySqlConnector;
using Scout.Domain.Entity;
using Scout.Infrastructure.Interface;
using Scout.Infrastructure.Queries;
using System;
using System.Threading.Tasks;

namespace Scout.Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        public async Task InsertPessoa(Pessoa pessoa)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();
                
                var parametros = new DynamicParameters();
                parametros.Add("@id",pessoa.Id);
                parametros.Add("@login",pessoa.Login);
                parametros.Add("@senha",pessoa.Senha);
                parametros.Add("@email",pessoa.Email);

                await conn.ExecuteAsync(QueryStringPessoa.CadastrarLoginSQL, parametros);  
            }
        }

        public Guid GetPessoaByLogin(string login)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@login", login);

                return conn.QueryFirstOrDefault<Guid>(QueryStringPessoa.LogarLoginSQL, parametros);
            }
        }

        public string GetPessoaById(Guid id)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@id", id);

                    var a = conn.QueryFirstOrDefault<string>(QueryStringPessoa.VerificarPessoaSQL, parametros);
                return a;
            }
        }

        public async Task InsertImagem(Guid id,byte[] imagem)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@id", id);
                parametros.Add("@imagem", imagem);

                await conn.ExecuteAsync(QueryStringPessoa.InsertImagemSQL, parametros);
            }
        }

        public async Task InsertDescricao(Guid id,string descricao) 
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@id", id);
                parametros.Add("@descricao", descricao);

                await conn.ExecuteAsync(QueryStringPessoa.InsertDescricaoSQL, parametros);
            }
        }
    }
}
