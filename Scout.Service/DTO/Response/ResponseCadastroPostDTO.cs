using Scout.Service.DTO.BaseDTO;

namespace Scout.Service.DTO.Response
{
    public class ResponseCadastroPostDTO : Errors
    {
        public string Success { get; set; }

        public void AddResponseSuccess()
        {
            Success = "Post cadastrado com sucesso!";
        }
    }
}
