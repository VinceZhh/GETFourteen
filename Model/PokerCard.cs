using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Model
{
    public class PokerCard
    {
        private List<Poker> Card = new List<Poker>();
        public PokerCard()
        {
            Poker poker = new Poker("CLUB", 1, Images.Club1);
            Card.Add(poker);

            poker = new Poker("SPADE", 1, Images.Spade1);
            Card.Add(poker);

            poker = new Poker("HEARTS", 1, Images.Hearts1);
            Card.Add(poker);

            poker = new Poker("SQUARE", 1, Images.Square1);
            Card.Add(poker);

            poker = new Poker("CLUB", 2, Images.Club2);
            Card.Add(poker);

            poker = new Poker("SPADE", 2, Images.Spade2);
            Card.Add(poker);

            poker = new Poker("HEARTS", 2, Images.Hearts2);
            Card.Add(poker);

            poker = new Poker("SQUARE", 2, Images.Square2);
            Card.Add(poker);

            poker = new Poker("CLUB", 3, Images.Club3);
            Card.Add(poker);

            poker = new Poker("SPADE", 3, Images.Spade3);
            Card.Add(poker);

            poker = new Poker("HEARTS", 3, Images.Hearts3);
            Card.Add(poker);

            poker = new Poker("SQUARE", 3, Images.Square3);
            Card.Add(poker);

            poker = new Poker("CLUB", 4, Images.Club4);
            Card.Add(poker);

            poker = new Poker("SPADE", 4, Images.Spade4);
            Card.Add(poker);

            poker = new Poker("HEARTS", 4, Images.Hearts4);
            Card.Add(poker);

            poker = new Poker("SQUARE", 4, Images.Square4);
            Card.Add(poker);

            poker = new Poker("CLUB", 5, Images.Club5);
            Card.Add(poker);

            poker = new Poker("SPADE", 5, Images.Spade5);
            Card.Add(poker);

            poker = new Poker("HEARTS", 5, Images.Hearts5);
            Card.Add(poker);

            poker = new Poker("SQUARE", 5, Images.Square5);
            Card.Add(poker);

            poker = new Poker("CLUB", 6, Images.Club6);
            Card.Add(poker);

            poker = new Poker("SPADE", 6, Images.Spade6);
            Card.Add(poker);

            poker = new Poker("HEARTS", 6, Images.Hearts6);
            Card.Add(poker);

            poker = new Poker("SQUARE", 6, Images.Square6);
            Card.Add(poker);

            poker = new Poker("CLUB", 7, Images.Club7);
            Card.Add(poker);

            poker = new Poker("SPADE", 7, Images.Spade7);
            Card.Add(poker);

            poker = new Poker("HEARTS", 7, Images.Hearts7);
            Card.Add(poker);

            poker = new Poker("SQUARE", 7, Images.Square7);
            Card.Add(poker);

            poker = new Poker("CLUB", 8, Images.Club8);
            Card.Add(poker);

            poker = new Poker("SPADE", 8, Images.Spade8);
            Card.Add(poker);

            poker = new Poker("HEARTS", 8, Images.Hearts8);
            Card.Add(poker);

            poker = new Poker("SQUARE", 8, Images.Square8);
            Card.Add(poker);

            poker = new Poker("CLUB", 9, Images.Club9);
            Card.Add(poker);

            poker = new Poker("SPADE", 9, Images.Spade9);
            Card.Add(poker);

            poker = new Poker("HEARTS", 9, Images.Hearts9);
            Card.Add(poker);

            poker = new Poker("SQUARE", 9, Images.Square9);
            Card.Add(poker);

            poker = new Poker("CLUB", 10, Images.Club10);
            Card.Add(poker);

            poker = new Poker("SPADE", 10, Images.Spade10);
            Card.Add(poker);

            poker = new Poker("HEARTS", 10, Images.Hearts10);
            Card.Add(poker);

            poker = new Poker("SQUARE", 10, Images.Square10);
            Card.Add(poker);

            poker = new Poker("CLUB", 11, Images.ClubJ);
            Card.Add(poker);

            poker = new Poker("SPADE", 11, Images.SpadeJ);
            Card.Add(poker);

            poker = new Poker("HEARTS", 11, Images.HeartsJ);
            Card.Add(poker);

            poker = new Poker("SQUARE", 11, Images.SquareJ);
            Card.Add(poker);

            poker = new Poker("CLUB", 12, Images.ClubQ);
            Card.Add(poker);

            poker = new Poker("SPADE", 12, Images.SpadeQ);
            Card.Add(poker);

            poker = new Poker("HEARTS", 12, Images.HeartsQ);
            Card.Add(poker);

            poker = new Poker("SQUARE", 12, Images.SquareQ);
            Card.Add(poker);

            poker = new Poker("CLUB", 13, Images.ClubK);
            Card.Add(poker);

            poker = new Poker("SPADE", 13, Images.SpadeK);
            Card.Add(poker);

            poker = new Poker("HEARTS", 13, Images.HeartsK);
            Card.Add(poker);

            poker = new Poker("SQUARE", 13, Images.SquareK);
            Card.Add(poker);

            WashCard(); WashCard(); WashCard();
        }
        private void WashCard()
        {
            Random ran = new Random();
            int RandKey = ran.Next(0, 52);
            for (int i = 0; i < 52; i++)
            {
                Card.Add(Card[RandKey]);
                Card.RemoveAt(RandKey);
                RandKey = ran.Next(0, 51 - i);
            }
        }
        public Poker getCard()
        {
            if (Card.Count == 0)
                return new Poker("",15,null);
            Poker poker = Card[0];
            Card.RemoveAt(0);
            return poker;
        }
        public int getNum() 
        {
            return Card.Count;
        }

        public Image Bg()
        {
            return Images.Bg;
        }
    }
}
