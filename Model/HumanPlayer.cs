using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class HumanPlayer: Player
    {
        public HumanPlayer(PlayTable T)
        {
            table = T;
            Poker1 = table.PokerCard.getCard();
            Poker2 = table.PokerCard.getCard();
            Poker3 = table.PokerCard.getCard();
        }
        public override void GetFourteen(Poker p)
        {
            if (IsFourteen(p))
            {
                Pool.Add(p);
                table.PoolPokerList.Remove(p);
                for (int i = 0; i < ChosenCard.Count; i++)
                {
                    p = ChosenCard[i];
                    Pool.Add(p);
                    if (Poker1 == p)
                        Poker1 = table.PokerCard.getCard();
                    else if (Poker2 == p)
                        Poker2 = table.PokerCard.getCard();
                    else
                        Poker3 = table.PokerCard.getCard();

                }
                ChosenCard.Clear();
            }
            else
            {
                ChosenCard.Clear();
            }
        }
    }
}
