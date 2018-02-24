using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using ServiceModel.DTO;

namespace ServiceModel.Services
{
    public class CandidatoService
    {
        public int CreateCandidato(CandidatoDTO dto)
        {
            var model = dto.ToModel();
            var repository = RepositoryFactory.Create<Candidato>();
            repository.Create(model);
            repository.SaveChanges();
            return model.Id;
        }

        public IEnumerable<CandidatoDTO> ListCandidatos()
        {
            var repository = RepositoryFactory.Create<Candidato>();
            return repository
                .List()
                .Select(model => new CandidatoDTO(model));
        }

        public CandidatoDTO ReadCandidato(int Id)
        {
            var repository = RepositoryFactory.Create<Candidato>();
            var model = repository.ReadCandidato(Id);

            if (model != null)
                return new CandidatoDTO(model);
            else
                return null;
        }

        public void DeleteCandidato(int Id)
        {
            var repository = RepositoryFactory.Create<Candidato>();
            var model = new Candidato()
            {
                Id = Id
            };
            repository.Delete(model);
            repository.SaveChanges();
        }

        public void UpdateCandidato(CandidatoDTO dto)
        {
            var model = dto.ToModel();

            var repository = RepositoryFactory.Create<Candidato>();
            repository.UpdateCandidato(model);

            repository.SaveChanges();            
        }
    }
}
