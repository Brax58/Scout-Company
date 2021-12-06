using Scout.Infrastructure.DTO.BaseDTO;

namespace Scout.Infrastructure.DTO.Response
{
    public class ResponseDescricaoDTO : Error
    {
        public string Success { get; set; }

        public void AddResponseSuccess()
        {
            Success = "Descrição cadastrada com sucesso!";
        }
    }
}
