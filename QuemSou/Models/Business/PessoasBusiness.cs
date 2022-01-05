using QuemSou.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Web.Mvc;

namespace QuemSou.Models.Business
{
    public class PessoasBusiness : Conexao.Conexao
    {

        public List<Pessoas> ListarPessoas()
        {
            return acesso.Query<Pessoas>("select *from Pessoas").ToList();
           
        }

        public Pessoas ExibirPerfil(int id)
        {

            var perfilPessoas = acesso.Query<Pessoas>("select *from Pessoas where id=1").SingleOrDefault();

            return perfilPessoas;
        }

        public Pessoas Exibir()
        {
            var perfilPessoas = acesso.Query<Pessoas>("select  *from Pessoas ").SingleOrDefault();

            return perfilPessoas;
        }

        internal bool editar(Pessoas pessoas)
        {
            try
            {
                return acesso.Execute(
                    "update Pessoas set Nome=@Nome, Idade=@Idade, Email=@Email, Celular=@Celular, Linkedin=@Linkedin, Foto=@Foto, Resumo=@Resumo where ID=@ID", pessoas) == 1;
            }
            catch { return false; }
        }

    }
}