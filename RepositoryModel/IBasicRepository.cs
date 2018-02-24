using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryModel
{
    public interface IBasicRepository<T> where T : BaseModel
    {
        void Create(T model);

        void Update(T model);

        void Delete(T model);

        T Read(int Id);

        IEnumerable<T> List();

        void SaveChanges();
    }
}
