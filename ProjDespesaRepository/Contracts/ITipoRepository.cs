using ProjDespesaCore.Entities;
using System.Collections.Generic;

namespace ProjDespesaRepository.Contracts
{
    public interface ITipoRepository : IRepositoryGeneric<TipoDespesa>
    {
        List<TipoDespesa> getAllExceptOne(int pIdTipo);
    }
}
