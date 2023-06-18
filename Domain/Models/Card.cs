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
        public int Id { get; set; }

        [Required]
        [Column("Signature")]
        public string Signature { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("Value")]
        public int Value { get; set; }
    }
}
