using System;

namespace Scout.Service.DTO.Request
{
    public class InsertPostDTO
    {
        public Guid Id { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }
    }
}
