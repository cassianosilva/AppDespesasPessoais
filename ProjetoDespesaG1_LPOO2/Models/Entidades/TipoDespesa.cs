using System.ComponentModel.DataAnnotations;

namespace ProjetoDespesaG1_LPOO2.Models
{
    public class TipoDespesa
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