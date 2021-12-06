using Scout.Infrastructure.DTO.BaseDTO;

namespace Scout.Infrastructure.DTO.Response
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
