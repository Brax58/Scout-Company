using System;

namespace Scout.Domain.Entity
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Login { get; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public byte[] Imagem { get; set; }
        public string Descricao { get; set; }
    }
}
