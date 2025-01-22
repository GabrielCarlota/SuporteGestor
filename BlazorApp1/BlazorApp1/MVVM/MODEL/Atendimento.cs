using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.MVVM.MODEL
{
    public class Atendimentos
    {
        [Key, Required]
        public int AtendimentoId { get; set; }
        [Required , ForeignKey("AtendenteId")]
        public Atendentes Atendentes { get; set; }  
        public Clientes? Clientesid { get; set; }
        public string? Problema { get; set; }
        [Required]
        public DateTime Data_Atendimento { get; set; }
        [Required]
        public DateTime Data_Inclusao { get; set; }
        

    }
}
