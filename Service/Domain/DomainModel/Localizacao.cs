using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class Localizacao : BaseModel
    {
        public string Cidade { get; set; }

        public string Estado { get; set; }

        public Candidato Candidato { get; set; }
    }
}
