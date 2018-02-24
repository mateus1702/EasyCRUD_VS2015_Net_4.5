using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models
{
    public enum Disponibilidades
    {
        [Description("Até 4 horas por dia.")]
        Ate4HorasPorDia = 0,
        [Description("De 4 a 6 horas por dia.")]
        De4a6HorasPorDia = 1,
        [Description("De 6 a 8 horas por dia.")]
        De6a8HorasPorDia = 2,
        [Description("Acima de 8 horas por dia.")]
        AcimaDe8HorasPorDia = 3,
        [Description("Apenas nos finais de semana.")]
        ApenasNosFinaisDeSemana = 4
    }
}