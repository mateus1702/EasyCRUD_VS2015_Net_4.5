using DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel
{
    public interface IRepository<T> : IBasicRepository<T> where T : BaseModel
    {
        Candidato ReadCandidato(int Id);

        void UpdateCandidato(Candidato candidato);
    }
}
