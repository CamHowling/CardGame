using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardGame.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultCardData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('AH','Ace of Hearts',14)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('2H','Two of Hearts',2)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('3H','Three of Hearts',3)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('4H','Four of Hearts',4)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('5H','Five of Hearts',5)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('6H','Six of Hearts',6)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('7H','Seven of Hearts',7)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('8H','Eight of Hearts',8)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('9H','Nine of Hearts',9)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('0H','Ten of Hearts',10)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('JH','Jack of Hearts',11)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('QH','Queen of Hearts',12)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('KH','King of Hearts',13)");

            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('AS','Ace of Spades',14)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('2S','Two of Spades',2)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('3S','Three of Spades',3)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('4S','Four of Spades',4)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('5S','Five of Spades',5)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('6S','Six of Spades',6)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('7S','Seven of Spades',7)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('8S','Eight of Spades',8)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('9S','Nine of Spades',9)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('0S','Ten of Spades',10)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('JS','Jack of Spades',11)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('QS','Queen of Spades',12)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('KS','King of Spades',13)");

            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('AD','Ace of Diamonds',14)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('2D','Two of Diamonds',2)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('3D','Three of Diamonds',3)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('4D','Four of Diamonds',4)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('5D','Five of Diamonds',5)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('6D','Six of Diamonds',6)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('7D','Seven of Diamonds',7)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('8D','Eight of Diamonds',8)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('9D','Nine of Diamonds',9)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('0D','Ten of Diamonds',10)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('JD','Jack of Diamonds',11)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('QD','Queen of Diamonds',12)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('KD','King of Diamonds',13)");

            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('AC','Ace of Clubs',14)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('2C','Two of Clubs',2)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('3C','Three of Clubs',3)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('4C','Four of Clubs',4)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('5C','Five of Clubs',5)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('6C','Six of Clubs',6)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('7C','Seven of Clubs',7)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('8C','Eight of Clubs',8)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('9C','Nine of Clubs',9)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('0C','Ten of Clubs',10)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('JC','Jack of Clubs',11)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('QC','Queen of Clubs',12)");
            migrationBuilder.Sql("INSERT INTO card(Signature, Name, Value) VALUES('KC','King of Clubs',13)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
