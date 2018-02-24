using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC5.Models.View
{
    public class CandidatoListViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Skype { get; set; }

        public string Telefone { get; set; }
    }
}