using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDespesaRepository.Contracts
{
    public interface IRepositoryGeneric<TEntity> where TEntity : class
    {
        void Create(TEntity pEntity);
        void Update(TEntity pEntity);
        void Delete(int Id);
        List<TEntity> getAll();
        TEntity getOne(int Id);
    }
}
