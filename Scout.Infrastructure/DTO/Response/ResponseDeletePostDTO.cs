using Scout.Infrastructure.DTO.BaseDTO;

namespace Scout.Infrastructure.DTO.Response
{
    public class ResponseDeletePostDTO : Error
    {
        public string Success { get; set; }

        public void AddResponseSuccess()
        {
            Success = "Pessoa deletada com sucesso!";
        }
    }
}
