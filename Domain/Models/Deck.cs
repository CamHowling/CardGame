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
        int Id { get; set; }

        [ForeignKey("Pile_Id")]
        [Required]
        [Column("Draw_Pile")]
        int DrawPile { get; set; }

        [ForeignKey("Pile_Id")]
        [Required]
        [Column("Discard_Pile")]
        int DiscardPile { get; set; }

        [Required]
        [Column("Is_Active")]
        bool IsActive { get; set; }

        [Required]
        [Column("Last_Modified")]
        DateTime Modified { get; set; }
    }
}
