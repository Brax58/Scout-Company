using System;
using System.Text.Json.Serialization;

namespace Scout.Service.DTO.Request
{
    public class InsertDescricaoDTO
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Descricao { get; set; }
    }
}
