using Scout.Infrastructure.DTO.BaseDTO;

namespace Scout.Infrastructure.DTO.Response
{
    public class ResponseCadastroPostDTO : Error
    {
        public string Success { get; set; }

        public void AddResponseSuccess()
        {
            Success = "Post cadastrado com sucesso!";
        }
    }
}
