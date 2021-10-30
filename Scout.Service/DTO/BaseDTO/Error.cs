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

        public void AddError(string erro)
        {
            Erros.Add(new Erro(erro));
        }
    }

    public class Erro
    {
        public string Error { get; set; }

        public Erro(string erro)
        {
            Error = erro;
        }
    }
}

