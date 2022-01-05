using QuemSou.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;



namespace QuemSou.Models.Business
{
    public class ExperienciaBusiness : Conexao.Conexao
    {
        public Experiencia ExibirExperiencia(int id)
        {
            var perfil = acesso.Query<Experiencia>("select *from Experiencia where ID= @wID order by Empresa  ", new { wID = id }).SingleOrDefault();

            return perfil;

        }

        public List<Experiencia> ListarExperiencia()
        {
            return acesso.Query<Experiencia>("select *from Experiencia order by Empresa  ").ToList();
        }

        internal bool Novo(Experiencia experiencia)
        {

            return acesso.Execute("insert into Experiencia (Empresa,Admissao,Demissao,Funcao,DescricaoFuncao,IDPessoas) values (@Empresa,@Admissao,@Demissao,@Funcao,@DescricaoFuncao,@IDPessoas)", experiencia) == 1;

        }
        internal bool editar(Experiencia experiencia)
        {


            try
            {
                return acesso.Execute(
                    "update Experiencia set Empresa=@Empresa,Admissao=@Admissao,Demissao=@Demissao,Funcao=@Funcao,DescricaoFuncao=@DescricaoFuncao, where ID=@ID", experiencia) == 1;
            }
            catch { return false; }
        }

        internal bool Apagar(int id)
        {
            try
            {
                return acesso.Execute("delete from experiencia where id = @wID", new { wID = id }) == 1;


            }
            catch { return false; }

        }

    }
}