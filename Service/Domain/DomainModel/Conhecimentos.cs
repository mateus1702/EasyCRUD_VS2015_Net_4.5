using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class Conhecimentos : BaseModel
    {
        public NivelDeConhecimento Ionic { get; set; }

        public NivelDeConhecimento Android { get; set; }

        public NivelDeConhecimento IOS { get; set; }

        public NivelDeConhecimento? HTML { get; set; }

        public NivelDeConhecimento? CSS { get; set; }

        public NivelDeConhecimento Bootstrap { get; set; }

        public NivelDeConhecimento JQuery { get; set; }

        public NivelDeConhecimento AngularJS { get; set; }

        public NivelDeConhecimento? Java { get; set; }

        public NivelDeConhecimento AspNetMVC { get; set; }

        public NivelDeConhecimento? C { get; set; }

        public NivelDeConhecimento? CPlusPlus { get; set; }

        public NivelDeConhecimento? Cake { get; set; }

        public NivelDeConhecimento? Django { get; set; }

        public NivelDeConhecimento? Magento { get; set; }

        public NivelDeConhecimento PHP { get; set; }

        public NivelDeConhecimento Wordpress { get; set; }

        public NivelDeConhecimento? Phyton { get; set; }

        public NivelDeConhecimento? Ruby { get; set; }

        public NivelDeConhecimento? SQLServer { get; set; }

        public NivelDeConhecimento? MySQL { get; set; }

        public NivelDeConhecimento? SalesForce { get; set; }

        public NivelDeConhecimento? Photoshop { get; set; }

        public NivelDeConhecimento? Illustrator { get; set; }

        public NivelDeConhecimento? SEO { get; set; }

        public enum NivelDeConhecimento
        {
            um = 1,
            dois = 2,
            tres = 3,
            quatro = 4,
            cinco = 5
        }

        public string Outras { get; set; }

        public string LinkCRUDRepository { get; set; }



        public Candidato Candidato { get; set; }
    }
}
