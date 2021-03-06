namespace Scout.Infrastructure.Queries
{
    public static class QueryStringPost
    {
        public static string BuscarPostsSQL = @"select
	                                            pe.imagemPessoa as ImagemPessoa,
                                                pe.login as NomePessoa,
                                                po.imagemPost as ImagemPost,
                                                po.descricaoPost as DescricaoPost
                                        from pessoa pe 
                                        inner join post po
                                        on pe.id = po.idPessoa;";

        public static string InsertPostSQL = @"insert into post (id,imagemPost,descricaoPost,idPessoa) 
                                    values(@id,@imagem,@descricao,@idpessoa);";
    }
}
