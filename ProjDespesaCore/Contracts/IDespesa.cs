using ProjDespesaCore.Entities;
using System;

namespace ProjDespesaCore.Contracts
{
    public interface IDespesa
    {
        int IdDespesa { get; set; }
        string LocalDespesa { get; set; }
        DateTime DataDespesa { get; set; }
        decimal ValorDespesa { get; set; }
        TipoDespesa Tipo { get; set; }
    }
}
