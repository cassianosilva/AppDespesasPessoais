using ProjDespesaCore.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjDespesaCore.Entities
{
    public class Despesa : IDespesa
    {
        public int IdDespesa { get; set; }

        [Required(ErrorMessage = "Você não informou um local.")]
        public string LocalDespesa { get; set; }

        [Required(ErrorMessage = "Você não informou uma data.")]
        public DateTime DataDespesa { get; set; }

        [Required(ErrorMessage = "Você não informou um valor.")]
        public decimal ValorDespesa { get; set; }

        public TipoDespesa Tipo { get; set; }

        public Despesa()
        {
        }

        public Despesa(int pId, string pLocal, DateTime pData, decimal pValor, TipoDespesa pTipo)
        {
            IdDespesa = pId;
            LocalDespesa = pLocal;
            DataDespesa = pData;
            ValorDespesa = pValor;
            Tipo = pTipo;
        }
    }
}