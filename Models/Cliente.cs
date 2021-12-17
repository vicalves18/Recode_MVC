
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recode_MVC.Models
{
  public class Cliente
  {
    [Key]
    public int id { get; set; }

    [Required(ErrorMessage = "Campo nome é obrigatório")]
    public string nome { get; set; }

    [Required(ErrorMessage = "Campo email é obrigatório")]
    public string email { get; set; }

    [Required(ErrorMessage = "Campo telefone é obrigatório")]
    [MaxLength(15)]
    public string telefone { get; set; }

    [Required(ErrorMessage = "Campo cpf é obrigatório")]
    public double cpf { get; set; }
    
    [Required(ErrorMessage = "Campo destino é obrigatório")]
    public string destino { get; set; }
  }
}