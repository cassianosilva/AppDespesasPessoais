using ProjDespesaCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDespesaRepository.Contracts
{
    public interface IDespesaRepository : IRepositoryGeneric<Despesa>
    {
        List<Despesa> getLasts();
        List<Despesa> getByDate(string pData);
    }
}
