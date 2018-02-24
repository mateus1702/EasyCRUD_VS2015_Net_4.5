using ASPNET_MVC5.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models.Input
{
    public class PreferenciasDeTrabalhoInputModel
    {
        public PreferenciasDeTrabalhoInputModel() { }

        public PreferenciasDeTrabalhoInputModel(CandidatoDTO candidatoDTO)
        {
            Disponibilidade = (Disponibilidades)candidatoDTO.Disponibilidade;
            HorarioDeTrabalho = (HorariosDeTrabalho)candidatoDTO.HorarioDeTrabalho;
            PretensaoRemuneracaoPorHora = candidatoDTO.PretensaoRemuneracaoPorHora.ToString();
        }

        [Required(ErrorMessage = "Campo disponibilidade obrigatório.")]
        public Disponibilidades Disponibilidade { get; set; }

        [Required(ErrorMessage = "Campo horário de trabalho obrigatório.")]
        [Display(Name = "Horário de trabalho")]
        public HorariosDeTrabalho HorarioDeTrabalho { get; set; }       

        [Required(ErrorMessage = "Campo pretenção de salário por hora obrigatório.")]
        [Display(Name = "Pretenção de salário por hora")]
        [RegularExpression("^(\\d*\\,)?\\d+$", ErrorMessage = "Campo pretenção de salário por hora inválido. Somente números são permitidos (use vírgula).")]
        public string PretensaoRemuneracaoPorHora { get; set; }
    }
}