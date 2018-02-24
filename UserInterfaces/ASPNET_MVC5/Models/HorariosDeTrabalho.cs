using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models
{
    public enum HorariosDeTrabalho
    {
        [Description("Das 8 as 12.")]
        De8as12 = 0,
        [Description("Das 13 as 18.")]
        De13as18 = 1,
        [Description("Das 19 as 22.")]
        De19as22 = 2,
        [Description("Das 22 em diante.")]
        De22emDiante = 3,
        [Description("Horário comercial.")]
        ComercialDe8as18 = 4
    }
}