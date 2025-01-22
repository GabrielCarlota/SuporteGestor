using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.MVVM.MODEL
{
    public class Empresas
    {
        public Empresas() { 
            Clientes = new Collection<Clientes>();
        }
        [Key]
        public int EmpresaId { get; set; }
        [Required]
        [StringLength(50)]
        public string? NomeEmpresa { get; set; }
        public ICollection<Clientes> Clientes { get; set; }
    }
}
