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

### Postman Example

![image](https://github.com/CamHowling/CardGame/assets/15999072/376190e7-7160-4978-8004-8220fd46f490)

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

### Postman Example

![image](https://github.com/CamHowling/CardGame/assets/15999072/8ee3204d-3e7a-4c40-8408-4b95869a01c0)

## END GAME

Set a deck to inactive, passing an id as a parameter.

### Request

`POST`

    http://localhost:5000/api/Deck/EndGame?deckid={id}

### Response

        {
            "success": true
        }

### Postman Example

![image](https://github.com/CamHowling/CardGame/assets/15999072/e06a33d8-8931-491d-b54b-31b180854abc)

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

### Postman Example

![image](https://github.com/CamHowling/CardGame/assets/15999072/cf5369da-6582-4be3-ba68-6468a914dd96)
