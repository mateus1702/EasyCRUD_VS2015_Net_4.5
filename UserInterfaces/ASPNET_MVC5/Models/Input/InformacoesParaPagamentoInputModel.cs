using ASPNET_MVC5.Infrastructure;
using ASPNET_MVC5.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models.Input
{
    public class InformacoesParaPagamentoInputModel
    {
        public InformacoesParaPagamentoInputModel() { }

        public InformacoesParaPagamentoInputModel(CandidatoDTO candidatoDTO)
        {
            Agencia = candidatoDTO.InformacaoParaPagamento.Agencia;
            Banco = candidatoDTO.InformacaoParaPagamento.Banco;
            CPF = candidatoDTO.InformacaoParaPagamento.CPF;
            NomeTitular = candidatoDTO.InformacaoParaPagamento.NomeTitular;
            NumeroDaConta = candidatoDTO.InformacaoParaPagamento.NumeroDaConta;
            TipoDeConta = (TiposDeConta)candidatoDTO.InformacaoParaPagamento.TipoDeConta;
        }

        [Required(ErrorMessage = "Campo nome do titular obrigatório.")]
        [Display(Name = "Nome do titular")]
        public string NomeTitular { get; set; }

        [Required(ErrorMessage = "Campo CPF obrigatório.")]
        [CPF(ErrorMessage = "Campo CPF inválido.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo banco obrigatório.")]
        public string Banco { get; set; }

        [Required(ErrorMessage = "Campo agência obrigatório.")]
        [Display(Name = "Agência")]
        public string Agencia { get; set; }

        [Required(ErrorMessage = "Campo número da conta obrigatório.")]
        [Display(Name = "Número da conta")]
        public string NumeroDaConta { get; set; }

        [Required(ErrorMessage = "Campo tipo de conta obrigatório.")]
        [Display(Name = "Tipo de conta")]
        public TiposDeConta TipoDeConta { get; set; }        
    }
}