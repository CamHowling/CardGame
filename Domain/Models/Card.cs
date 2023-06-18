using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Models
{
    [Table("card")]
    public class Card
    {
        [Key]
        [Required]
        [Column("card_Id")]
        public int Id { get; set; }

        [Required]
        [Column("signature")]
        public string Signature { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("value")]
        public int Value { get; set; }
    }
}
