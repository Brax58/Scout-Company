using System;

namespace Scout.Domain.Entity
{
    public class Post
    {
        public Guid Id { get; set; }
        public byte[] Imagem { get; set; }
        public string Descricao { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
