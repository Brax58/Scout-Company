﻿namespace Scout.Infrastructure.Queries
{
    public static class QueryStringPost
    {
        public static string BuscarPostsSQL = @"select 
	                                            pe.imagemPessoa,
                                                pe.login,
                                                po.imagemPost,
                                                po.descricaoPost
                                        from pessoa pe 
                                        inner join post po
                                        on pe.id = po.idPessoa
                                        where pe.id != @idPessoa;";

        public static string InsertPostSQL = @"insert into post (id,imagemPost,descricaoPost,idPessoa) 
                                    values(@id,@imagem,@descricao,@idpessoa);";
    }
}
