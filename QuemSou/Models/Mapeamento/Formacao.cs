using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuemSou.Models.Mapeamento
{
    public class Formacao
    {
        public int ID { get; set; }
        public string Curso { get; set; }
        public string Faculdade { get; set; }
        public string SemestreAtual { get; set; }
        public string PrevisaoTermino { get; set; }
        public string NivelFormacao { get; set; }


        public string IDPessoas { get; set; }
    }
}