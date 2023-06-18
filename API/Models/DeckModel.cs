namespace CardGame.API.Models
{
    public class DeckModel
    {
        public int Id { get; set; }

        public int DrawPile { get; set; }

        public int DiscardPile { get; set; }

        public bool IsActive { get; set; }

        public DateTime Modified { get; set; }
    }
}
