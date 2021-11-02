using System.Collections.Generic;

namespace Scout.Service.DTO.BaseDTO
{
    public class Errors
    {
        public List<Erro> Erros { get; set; }

        public Errors()
        {
            Erros = new List<Erro>();
        }

        public void AddError(string erro,string erroCode)
        {
            Erros.Add(new Erro(erro,erroCode));
        }
    }

    public class Erro
    {
        public string Error { get; set; }
        public string CodeError { get; set; }

        public Erro(string erro,string codeError)
        {
            Error = erro;
            CodeError = codeError;
        }
    }
}

