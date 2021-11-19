using Scout.Service.DTO.BaseDTO;

namespace Scout.Service.DTO.Response
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
