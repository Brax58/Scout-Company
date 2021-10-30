namespace Scout.Infrastructure.Queries
{
    public static class QueryStringPessoa
    {
        public static string CadastrarLoginSQL = @"insert into pessoa (id,login,senha,email,imagemPessoa,descricaoPessoa) 
                                        values(@id,@login,@senha,@email,null,null);";

        public static string InsertImagemSQL = @"update pessoa p set p.imagem = @imagem where p.id = @id;";

        public static string InsertDescricaoSQL = @"update pessoa p set p.descricaoPessoa = @descricao where p.id = @id;";

        public static string LogarLoginSQL = @"select p.id from pessoa p where p.login = @login;";

        public static string GetFotoSQL = @"select p.imagemPessoa from pessoa p where p.id = @id;";


    }
}