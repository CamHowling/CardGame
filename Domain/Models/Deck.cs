using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Models
{
    [Table("deck")]
    public class Deck
    {
        [Key]
        [Required]
        [Column("Deck_Id")]
        public int Id { get; set; }

        [ForeignKey("Pile_Id")]
        [Required]
        [Column("Draw_Pile")]
        public int DrawPile { get; set; }

        [ForeignKey("Pile_Id")]
        [Required]
        [Column("Discard_Pile")]
        public int DiscardPile { get; set; }

        [Required]
        [Column("Is_Active")]
        public bool IsActive { get; set; }
    }
}
