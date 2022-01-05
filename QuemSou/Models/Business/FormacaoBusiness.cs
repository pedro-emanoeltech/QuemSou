using QuemSou.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;


namespace QuemSou.Models.Business
{
    public class FormacaoBusiness : Conexao.Conexao
    {
        public List<Formacao> ListarFormacao()
        {
            return  acesso.Query<Formacao>("select *from Formacao  order by Curso ").ToList();
            

        }
        public Formacao ExibirFormacao(int id)
        {
            return acesso.Query<Formacao>("select *from Formacao  where id=@wID ", 
                new { wID = id }).SingleOrDefault();

        }
        internal bool Novo(Formacao formacao)
        {
           
                return acesso.Execute("insert into formacao (Curso,Faculdade,SemestreAtual,PrevisaoTermino,NivelFormacao,IDPessoas) values (@Curso,@Faculdade,@SemestreAtual,@PrevisaoTermino,@NivelFormacao,@IDPessoas)", formacao) == 1;
           
        }

        internal bool editar(Formacao formacao)
        {


            try
            {
                return acesso.Execute(
                    "update formacao set Curso=@Curso ,Faculdade=@Faculdade,SemestreAtual=@SemestreAtual,PrevisaoTermino=@PrevisaoTermino,NivelFormacao=@NivelFormacao where ID=@ID", formacao) == 1;
            }
            catch { return false; }
        }

        internal bool Apagar(int id)
        {
            try
            {
                return acesso.Execute("delete from formacao where id = @wID", new { wID = id }) == 1;

            
            }
            catch { return false; }
            
        }


    }
}