using Dapper;
using MySqlConnector;
using Scout.Domain.Entity;
using Scout.Infrastructure.Interface;
using Scout.Infrastructure.Queries;
using Scout.Service.DTO.Response;
using System;
using System.Collections.Generic;
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
        
        public async Task<IEnumerable<PostUnico>> GetPosts(Guid id,int quantidade)
        {
            using (MySqlConnection conn = new MySqlConnection(Environment.GetEnvironmentVariable("ConnectionBase")))
            {
                conn.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@id", id);
                parametros.Add("@quantidade", quantidade);

               return await conn.QueryAsync<PostUnico>(QueryStringPost.BuscarPostsSQL, parametros);
            }
        }
    }
}
