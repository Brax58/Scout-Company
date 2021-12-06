namespace Scout.Infrastructure.DTO.BaseDTO
{
    public class Error
    {
        public string Erro { get; set; }
        public string CodeError { get; set; }

        public void AddError(string erro,string erroCode)
        {
            Erro = erro;
            CodeError = erroCode;
        }
    }
}

