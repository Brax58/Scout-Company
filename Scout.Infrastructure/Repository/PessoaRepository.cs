using Dapper;
using MySqlConnector;
using Scout.Domain.Entity;
using Scout.Infrastructure.Queries;
using System;
using System.Threading.Tasks;

namespace Scout.Infrastructure.Repository
{
    public class PessoaRepository
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

        public Guid GetPessoaById(string login)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@login", login);

                var result = conn.QueryFirstOrDefault<Guid>(QueryStringPessoa.LogarLoginSQL, parametros);
                return result;
            }
        }

        //protected List<T> Query<T>(string sql, object parameters = null)
        //{
        //    using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
        //    {
        //        return conn.Query<T>(sql, parameters).ToList();
        //    }
        //}
    }
}
