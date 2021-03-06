function printDeckOfCards(array) {
    function makeCard(face, suit) {
        let faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        let suits = {
            S: '\u2660',
            H: '\u2665',
            D: '\u2666',
            C: '\u2663'
        };

        if (!faces.includes(face)) {
            throw new Error(`Invalid card: ${face + suit}`);
        }
        else if (!suits.hasOwnProperty(suit)) {
            throw new Error(`Invalid card: ${face + suit}`);
        }

        let card = face + suits[suit];

        toString: return card;
    }

    let cards = [];

    try {
        for (let input of array) {
            if (input.length == 2) {
                let card = makeCard(input[0], input[1]);
                cards.push(card);
            }
            else if (input.length == 3) {
                let card = makeCard(input[0] + input[1], input[2]);
                cards.push(card);
            }
        }
    }
    catch (error) {
        console.log(error.message);
        return;
    }

    console.log(cards.join(' '));
}