using RepositoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DomainModel;


namespace EF6
{
    public class NSEF6_Repository<T> : IRepository<T> where T : BaseModel
    {
        public NSEF6_Repository()
        {
            _context = new EF6_DbContext();
        }

        private EF6_DbContext _context;

        void IBasicRepository<T>.Create(T model)
        {
            _context.Set<T>().Add(model);
        }

        void IBasicRepository<T>.Update(T model)
        {
            _context.Set<T>().Attach(model);
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

        void IBasicRepository<T>.Delete(T model)
        {
            _context.Set<T>().Attach(model);
            _context.Entry(model).State = System.Data.Entity.EntityState.Deleted;
        }

        T IBasicRepository<T>.Read(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        IEnumerable<T> IBasicRepository<T>.List()
        {
            return _context.Set<T>();
        }

        void IBasicRepository<T>.SaveChanges()
        {
            _context.SaveChanges();
        }

        Candidato IRepository<T>.ReadCandidato(int Id)
        {
            return _context
                .Set<Candidato>()
               .Include(x => x.InformacaoParaPagamento)
               .Include(x => x.Conhecimentos)
               .Include(x => x.Localizacao)
               .FirstOrDefault(x => x.Id == Id);
        }

        void IRepository<T>.UpdateCandidato(Candidato candidato)
        {
            _context.Set<Candidato>().Attach(candidato);
            _context.Entry(candidato).State = EntityState.Modified;

            _context.Set<Localizacao>().Attach(candidato.Localizacao);
            _context.Entry(candidato.Localizacao).State = EntityState.Modified;

            _context.Set<Conhecimentos>().Attach(candidato.Conhecimentos);
            _context.Entry(candidato.Conhecimentos).State = EntityState.Modified;

            _context.Set<InformacaoParaPagamento>().Attach(candidato.InformacaoParaPagamento);
            _context.Entry(candidato.InformacaoParaPagamento).State = EntityState.Modified;
        }        
    }
}
