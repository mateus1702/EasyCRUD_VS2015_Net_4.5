using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class Candidato : BaseModel
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Telefone { get; set; }

        public bool TelefoneEWhatsApp { get; set; }

        public string Linkedin { get; set; }

        public string PortifolioURL { get; set; }

        public Disponibilidades Disponibilidade { get; set; }

        public enum Disponibilidades
        {
            Ate4HorasPorDia = 0,
            De4a6HorasPorDia = 1,
            De6a8HorasPorDia = 2,
            AcimaDe8HorasPorDia = 3,
            ApenasNosFinaisDeSemana = 4
        }

        public HorariosDeTrabalho HorarioDeTrabalho { get; set; }

        public enum HorariosDeTrabalho
        {
            De8as12 = 0,
            De13as18 = 1,
            De19as22 = 2,
            De22emDiante = 3,
            ComercialDe8as18 = 4
        }

        public decimal PretensaoRemuneracaoPorHora { get; set; }


        public Localizacao Localizacao { get; set; }

        public InformacaoParaPagamento InformacaoParaPagamento { get; set; }

        public Conhecimentos Conhecimentos { get; set; }
    }
}
