using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.MVVM.MODEL
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? NomeCliente { get; set; }
        [Required]
        public int EmpresaId { get; set; }
        [ForeignKey("EmpresaId")]
        public Empresas Empresa {  get; set; }

 
    }
}
