using System;
using System.Text.Json.Serialization;

namespace Scout.Service.DTO.Request
{
    public class InsertImagemPessoaDTO
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Imagem { get; set; }
    }
}
