using ASPNET_MVC5.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models.Input
{
    public class QuestionarioDeHabilidadesInputModel
    {
        public QuestionarioDeHabilidadesInputModel() { }

        public QuestionarioDeHabilidadesInputModel(CandidatoDTO candidatoDTO)
        {
            Android = (NivelDeConhecimento)candidatoDTO.Conhecimentos.Android;
            AngularJS = (NivelDeConhecimento)candidatoDTO.Conhecimentos.AngularJS;
            AspNetMVC = (NivelDeConhecimento)candidatoDTO.Conhecimentos.AspNetMVC;
            Bootstrap = (NivelDeConhecimento)candidatoDTO.Conhecimentos.Bootstrap;
            C = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.C;
            Cake = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.Cake;
            CPlusPlus = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.CPlusPlus;
            CSS = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.CSS;
            Django = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.Django;
            HTML = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.HTML;
            Illustrator = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.Illustrator;
            Ionic = (NivelDeConhecimento)candidatoDTO.Conhecimentos.Ionic;
            IOS = (NivelDeConhecimento)candidatoDTO.Conhecimentos.IOS;
            Java = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.Java;
            JQuery = (NivelDeConhecimento)candidatoDTO.Conhecimentos.JQuery;
            LinkCRUDRepository = candidatoDTO.Conhecimentos.LinkCRUDRepository;
            Magento = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.Magento;
            MySQL = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.MySQL;
            Outras = candidatoDTO.Conhecimentos.Outras;
            Photoshop = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.Photoshop;
            PHP = (NivelDeConhecimento)candidatoDTO.Conhecimentos.PHP;
            Phyton = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.Phyton;
            Ruby = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.Ruby;
            SalesForce = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.SalesForce;
            SEO = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.SEO;
            SQLServer = (NivelDeConhecimento?)candidatoDTO.Conhecimentos.SQLServer;
            Wordpress = (NivelDeConhecimento)candidatoDTO.Conhecimentos.Wordpress;
            PortifolioURL = candidatoDTO.PortifolioURL;
        }

        [Required(ErrorMessage = "Campo Ionic obrigatório.")]
        public NivelDeConhecimento Ionic { get; set; }

        [Required(ErrorMessage = "Campo Android obrigatório.")]
        public NivelDeConhecimento Android { get; set; }

        [Required(ErrorMessage = "Campo IOS obrigatório.")]
        public NivelDeConhecimento IOS { get; set; }

        public NivelDeConhecimento? HTML { get; set; }

        public NivelDeConhecimento? CSS { get; set; }

        [Required(ErrorMessage = "Campo Bootstrap obrigatório.")]
        public NivelDeConhecimento Bootstrap { get; set; }

        [Required(ErrorMessage = "Campo JQuery obrigatório.")]
        public NivelDeConhecimento JQuery { get; set; }

        [Required(ErrorMessage = "Campo AngularJS obrigatório.")]
        public NivelDeConhecimento AngularJS { get; set; }

        public NivelDeConhecimento? Java { get; set; }

        [Display(Name = "ASP Net MVC")]
        [Required(ErrorMessage = "Campo AspNetMVC obrigatório.")]
        public NivelDeConhecimento AspNetMVC { get; set; }

        public NivelDeConhecimento? C { get; set; }

        [Display(Name = "C++")]
        public NivelDeConhecimento? CPlusPlus { get; set; }

        public NivelDeConhecimento? Cake { get; set; }

        public NivelDeConhecimento? Django { get; set; }

        public NivelDeConhecimento? Magento { get; set; }

        [Required(ErrorMessage = "Campo PHP obrigatório.")]
        public NivelDeConhecimento PHP { get; set; }

        [Required(ErrorMessage = "Campo Wordpress obrigatório.")]
        public NivelDeConhecimento Wordpress { get; set; }

        public NivelDeConhecimento? Phyton { get; set; }

        public NivelDeConhecimento? Ruby { get; set; }

        public NivelDeConhecimento? SQLServer { get; set; }

        public NivelDeConhecimento? MySQL { get; set; }

        public NivelDeConhecimento? SalesForce { get; set; }

        public NivelDeConhecimento? Photoshop { get; set; }

        public NivelDeConhecimento? Illustrator { get; set; }

        public NivelDeConhecimento? SEO { get; set; }

        [Display(Name = "Informe neste campo outras linguagens e tecnologias que não foram listadas e o nível em cada uma delas.")]
        public string Outras { get; set; }

        [Display(Name = "Link para acesso ao CRUD. Leia o documento de boas vindas para mais informações.")]
        public string LinkCRUDRepository { get; set; }

        [Display(Name = "Link para acesso ao portifólio.")]
        public string PortifolioURL { get; set; }
    }
}