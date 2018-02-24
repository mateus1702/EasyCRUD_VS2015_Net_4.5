using ASPNET_MVC5.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models.Input
{
    public class InformacoesDeContatoInputModel
    {
        public InformacoesDeContatoInputModel() { }

        public InformacoesDeContatoInputModel(CandidatoDTO candidatoDTO)
        {
            Nome = candidatoDTO.Nome;
            Email = candidatoDTO.Email;
            Skype = candidatoDTO.Skype;
            Telefone = candidatoDTO.Telefone;
            TelefoneEWhatsApp = candidatoDTO.TelefoneEWhatsApp;
            Linkedin = candidatoDTO.Linkedin;
            Cidade = candidatoDTO.Localizacao.Cidade;
            Estado = candidatoDTO.Localizacao.Estado;
        }

        [Required(ErrorMessage ="Campo nome obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo email obrigatório.")]
        [EmailAddress(ErrorMessage = "Campo email inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Skype obrigatório.")]
        public string Skype { get; set; }

        [Required(ErrorMessage = "Campo telefone obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Campo telefone inválido. Somente números são permitidos.")]
        public string Telefone { get; set; }

        [Display(Name = "Telefone é WhatsApp?")]
        public bool TelefoneEWhatsApp { get; set; }

        [Display(Name = "LinkedIn")]
        public string Linkedin { get; set; }

        [Required(ErrorMessage = "Campo cidade obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo estado obrigatório.")]
        public string Estado { get; set; }
    }
}