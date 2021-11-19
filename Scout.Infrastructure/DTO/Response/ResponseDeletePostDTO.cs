using Scout.Service.DTO.BaseDTO;

namespace Scout.Service.DTO.Response
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
