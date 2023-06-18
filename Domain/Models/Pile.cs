using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Models
{
    public class Pile
    {
        [Key]
        [Required]
        [Column("Pile_Id")]
        int Id { get; set; }

        [Required]
        [Column("Cards")]
        List<string> Cards { get; set; }
    }
}
