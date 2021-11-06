using MediatR;
using Scout.Service.DTO.Response;

namespace Scout.Service.DTO.Request
{
    public class LogarSiteDTO : IRequest<ResponseLoginDTO>
    {
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}
