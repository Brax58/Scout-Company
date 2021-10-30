using Scout.Service.DTO.BaseDTO;

namespace Scout.Service.DTO.Response
{
    public class ResponseImagemDTO : Errors
    {
        public string Success { get; set; }

        public void AddResponseSuccess() 
        {
            Success = "Imagem cadastrada com sucesso!";
        }
    }
}
