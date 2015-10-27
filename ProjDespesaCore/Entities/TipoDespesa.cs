using ProjDespesaCore.Contracts;
using System.ComponentModel.DataAnnotations;

namespace ProjDespesaCore.Entities
{
    public class TipoDespesa : ITipoDespesa
    {
        public int idTipo { get; set; }

        [Required(ErrorMessage = "Você não informou um nome.")]
        public string nomeTipo { get; set; }

        public TipoDespesa()
        {
        }

        public TipoDespesa(int pId, string pTipo)
        {
            idTipo = pId;
            nomeTipo = pTipo;
        }
    }
}