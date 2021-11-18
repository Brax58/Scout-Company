using Dapper;
using MySqlConnector;
using Scout.Domain.Entity;
using Scout.Infrastructure.Interface;
using Scout.Infrastructure.Queries;
using System;
using System.Threading.Tasks;

namespace Scout.Infrastructure.Repository
{
    public class PostRepository : IPostRepository
    {
        public async Task InsertPost(Post post)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@id", post.Id);
                parametros.Add("@imagem", post.Imagem);
                parametros.Add("@descricao", post.Descricao);
                parametros.Add("@idPessoa", post.IdPessoa);

                await conn.ExecuteAsync(QueryStringPost.InsertPostSQL, parametros);
            }
        }
    }
}
