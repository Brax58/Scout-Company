using Dapper;
using MySqlConnector;
using Scout.Domain.Entity;
using Scout.Infrastructure.DTO.Response;
using Scout.Infrastructure.Interface;
using Scout.Infrastructure.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scout.Infrastructure.Repository
{
    public class PostRepository : IPostRepository
    {
        private const string connection = "Server=localhost;Database=scout;Uid=root;Pwd=";

        public async Task InsertPost(Post post)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
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
        
        public async Task<IEnumerable<PostUnicoBanco>> GetPosts(Guid id,int quantidade)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                var parametros = new DynamicParameters();
                parametros.Add("@id", id);
                parametros.Add("@quantidade", quantidade);

               return await conn.QueryAsync<PostUnicoBanco>(QueryStringPost.BuscarPostsSQL, parametros);
            }
        }
    }
}
