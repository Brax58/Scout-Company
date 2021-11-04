using Scout.Service.DTO.BaseDTO;

namespace Scout.Service.DTO.Response
{
    public class ResponseImagemDTO : Error
    {
        public string Success { get; set; }

        public void AddResponseSuccess() 
        {
            Success = "Imagem cadastrada com sucesso!";
        }
    }
}
