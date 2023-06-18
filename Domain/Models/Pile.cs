using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Models
{
    [Table("pile")]
    public class Pile
    {
        public Pile()
        {
            Cards = new List<string>();
            IsDrawPile = false;
            IsDiscardPile = false;
        }

        [Key]
        [Required]
        [Column("pile_id")]
        public int Id { get; set; }

        [Required]
        [Column("cards")]
        public List<string> Cards { get; set; }

        [Required]
        [Column("is_draw_pile")]
        public bool IsDrawPile { get; set; }

        [Required]
        [Column("is_discard_pile")]
        public bool IsDiscardPile { get; set; }
    }
}
