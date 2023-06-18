namespace CardGame.API.Models
{
    public class PileModel
    {
        public int Id { get; set; }

        public List<string> Cards { get; set; }

        public bool IsDrawPile { get; set; }

        public bool IsDiscardPile { get; set; }
    }
}
