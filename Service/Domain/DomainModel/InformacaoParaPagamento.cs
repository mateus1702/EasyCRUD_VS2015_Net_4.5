using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class InformacaoParaPagamento : BaseModel
    {
        public string NomeTitular { get; set; }

        public string CPF { get; set; }

        public string Banco { get; set; }

        public string Agencia { get; set; }

        public string NumeroDaConta { get; set; }

        public TiposDeConta TipoDeConta { get; set; }

        public enum TiposDeConta
        {
            Corrente = 0,
            Poupanca = 1
        }

        public Candidato Candidato { get; set; }
    }
}
