using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuemSou.Models.Mapeamento
{
    public class Experiencia
    {
        public int ID { get; set; }
        public string Empresa { get; set; }
        public string Admissao { get; set; }
        public string Demissao { get; set; }
        public string Funcao { get; set; }
        public string DescricaoFuncao { get; set; }
        
        public string IDPessoas { get; set; }
    }
}