# CardGame 

This is a simple API to support a specific card game design.

The application uses entity framework with postgres for the database. And the backend uses dotnet core.

There is an associated github project with this repo, with backlog tickets that indicate the possible future updates to the project.

## Building the container locally

To build the application from source, clone and build the repo using:

	$ git clone https://github.com/CamHowling/CardGame.git

Once you have cloned the repo locally, you can build project using:

	docker-compose run --build

# REST API

The REST API to the example app is described below.

## NEW GAME

Create a new deck. The deck has previously been shuffled, and the first card drawn.

### Request

`GET`

    http://localhost:5000/api/Deck/NewGame

### Response

        {
            "deck": {
                "id": DECKID,
                "drawPile": DRAWPILEID,
                "discardPile": DISCARDPILEID,
                "isActive": ISACTIVE
            }
            "firstCard": {
                "id": CARDID,
                "signature": CARDSIGNATURE,
                "name": CARDNAME,
                "value": CARDVALUE
            }
        }

## GET DECK

Retrieve a deck passing an id as a parameter.

### Request

`GET`

    http://localhost:5000/api/Deck/GetDeck?id={id}

### Response

        {
            "deck": {
                "id": DECKID,
                "drawPile": DRAWPILEID,
                "discardPile": DISCARDPILEID,
                "isActive": ISACTIVE
            }
        }

## End Game

Set a deck to inactive, passing an id as a parameter.

### Request

`POST`

    http://localhost:5000/api/Deck/EndGame?deckid={id}

### Response

        {
            "success": true
        }

## SUBMIT GUESS

Submit a guess on if the next card is a higher or lower value than the previously drawn card, passing in the parameters: isHigher, isLower, and deckId.
The response includes a server validated evaluation of the guess.

### Request

`GET`

    http://localhost:5000/api/Deck/SubmitGuess?isHigher={guessIsHigher}&isLower={guessIsLower}&deckId={id}

### Response

        {
            "correct": true,
            "model": {
                "id": CARDID,
                "signature": CARDSIGNATURE,
                "name": CARDNAME,
                "value": CARDVALUE
            },
        }
