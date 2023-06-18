using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Models
{
    [Table("Pile")]
    public class Pile
    {
        [Key]
        [Required]
        [Column("Pile_Id")]
        public int Id { get; set; }

        [Required]
        [Column("Cards")]
        public List<string> Cards { get; set; }

        [Required]
        [Column("Is_Draw_Pile")]
        public bool IsDrawPile { get; set; }

        [Required]
        [Column("Is_Discard_Pile")]
        public bool IsDiscardPile { get; set; }
    }
}
