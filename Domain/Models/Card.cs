using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Models
{
    [Table("Card")]
    public class Card
    {
        [Key]
        [Required]
        [Column("Card_Id")]
        int Id { get; set; }

        [Required]
        [Column("Signature")]
        string Signature { get; set; }

        [Required]
        [Column("Name")]
        string Name { get; set; }

        [Required]
        [Column("Value")]
        string Value { get; set; }
    }
}
