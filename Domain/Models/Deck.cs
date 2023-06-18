using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Models
{
    [Table("deck")]
    public class Deck
    {
        public Deck()
        {
            IsActive = true;
        }

        [Key]
        [Required]
        [Column("deck_id")]
        public int Id { get; set; }

        [ForeignKey("pile_id")]
        [Required]
        [Column("draw_pile")]
        public int DrawPile { get; set; }

        [ForeignKey("pile_id")]
        [Required]
        [Column("discard_pile")]
        public int DiscardPile { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }
    }
}
