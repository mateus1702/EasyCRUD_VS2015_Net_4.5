using DomainModel;
using ServiceModel.DTO;
using ServiceModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace REST_WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CandidatoController : ApiController
    {
        // GET: api/Candidato
        public IEnumerable<CandidatoDTO> Get()
        {
            CandidatoService service = new CandidatoService();
            return service.ListCandidatos();
        }

        // GET: api/Candidato/5
        public CandidatoDTO Get(int id)
        {
            CandidatoService service = new CandidatoService();
            return service.ReadCandidato(id);
        }

        // POST: api/Candidato
        public int Post([FromBody]CandidatoDTO model)
        {
            CandidatoService service = new CandidatoService();
            var Id = service.CreateCandidato(model);
            return Id;
        }

        // PUT: api/Candidato/5
        public void Put(int id, [FromBody]CandidatoDTO model)
        {
            model.Id = id;
            CandidatoService service = new CandidatoService();
            service.UpdateCandidato(model);
        }

        // DELETE: api/Candidato/5
        public void Delete(int id)
        {
            CandidatoService service = new CandidatoService();
            service.DeleteCandidato(id);
        }
    }
}
