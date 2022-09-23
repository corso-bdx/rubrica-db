using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelli.Models;

[Table("Contatti")]
public class Contatto
{
    [Key]
    public long Id { get; set; }

    [MaxLength(200)]
    public string Nome { get; set; } = "";
    
    [MaxLength(200)]
    public string Cognome { get; set; } = "";
    
    [MaxLength(30)]
    public string Numero { get; set; } = "";
}
