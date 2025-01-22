using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.MVVM.MODEL
{
    public class Atendentes
    {

        public Atendentes() {
            Atendimentos = new Collection<Atendimentos>();
        }
        [Key]
        public int AtendenteId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? NomeAtendente { get; set; }
        [Required]
        public int? Cargo { get; set; }

        public ICollection<Atendimentos> Atendimentos { get; set; }

    }
}
