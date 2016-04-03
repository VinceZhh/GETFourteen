using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AI : Player
    {
        public AI(PlayTable T)
        {
            table = T;
            Poker1 = table.PokerCard.getCard();
            Poker2 = table.PokerCard.getCard();
            Poker3 = table.PokerCard.getCard();
        }
        private List<Poker> showCard = new List<Poker>();
        private int poolNum;
        public int PoolNum
        {
            get { return poolNum; }
        }
        public List<Poker> ShowCard
        {
            get { return showCard; }
        }
        public override void GetFourteen(Poker p)
        {
            showCard.Clear();
            Pool.Add(p);
            table.PoolPokerList.Remove(p);
            for (int i = 0; i < ChosenCard.Count; i++)
            {
                p = ChosenCard[i];
                ShowCard.Add(p);
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
        public bool hasFourteen()
        {
            ChosenCard.Clear();
            int i;
            ChosenCard.Add(Poker1);
            for (i = 0; i < table.PoolPokerList.Count; i++)
                if (IsFourteen(table.PoolPokerList[i]))
                    break;
            if (i < table.PoolPokerList.Count)
            {
                GetFourteen(table.PoolPokerList[i]);
                poolNum = i;
                return true;
            }

            ChosenCard.Clear();
            ChosenCard.Add(Poker2);
            for (i = 0; i < table.PoolPokerList.Count; i++)
                if (IsFourteen(table.PoolPokerList[i]))
                    break;
            if (i < table.PoolPokerList.Count)
            {
                GetFourteen(table.PoolPokerList[i]);
                poolNum = i;
                return true;
            }

            ChosenCard.Clear();
            ChosenCard.Add(Poker3);
            for (i = 0; i < table.PoolPokerList.Count; i++)
                if (IsFourteen(table.PoolPokerList[i]))
                    break;
            if (i < table.PoolPokerList.Count)
            {
                GetFourteen(table.PoolPokerList[i]);
                poolNum = i;
                return true;
            }

            ChosenCard.Clear();
            ChosenCard.Add(Poker1);
            ChosenCard.Add(Poker2);
            for (i = 0; i < table.PoolPokerList.Count; i++)
                if (IsFourteen(table.PoolPokerList[i]))
                    break;
            if (i < table.PoolPokerList.Count)
            {
                GetFourteen(table.PoolPokerList[i]);
                poolNum = i;
                return true;
            }

            ChosenCard.Clear();
            ChosenCard.Add(Poker1);
            ChosenCard.Add(Poker3);
            for (i = 0; i < table.PoolPokerList.Count; i++)
                if (IsFourteen(table.PoolPokerList[i]))
                    break;
            if (i < table.PoolPokerList.Count)
            {
                GetFourteen(table.PoolPokerList[i]);
                poolNum = i;
                return true;
            }

            ChosenCard.Clear();
            ChosenCard.Add(Poker2);
            ChosenCard.Add(Poker3);
            for (i = 0; i < table.PoolPokerList.Count; i++)
                if (IsFourteen(table.PoolPokerList[i]))
                    break;
            if (i < table.PoolPokerList.Count)
            {
                GetFourteen(table.PoolPokerList[i]);
                poolNum = i;
                return true;
            }

            ChosenCard.Clear();
            ChosenCard.Add(Poker1);
            ChosenCard.Add(Poker2);
            ChosenCard.Add(Poker3);
            for (i = 0; i < table.PoolPokerList.Count; i++)
                if (IsFourteen(table.PoolPokerList[i]))
                    break;
            if (i < table.PoolPokerList.Count)
            {
                GetFourteen(table.PoolPokerList[i]);
                poolNum = i;
                return true;
            }

            return false;
        }
        public Poker DorpCard()
        {
            Poker p = null;
            if (Poker1.Num < 14)
            {
                p = Poker1;
                Poker1 = table.PokerCard.getCard();
            }
            if (Poker2.Num < 14 && Poker2.Num > p.Num)
            {
                p = Poker2;
                Poker2 = table.PokerCard.getCard();
            }
            if (Poker3.Num < 14 && Poker3.Num > p.Num)
            {
                p = Poker3;
                Poker3 = table.PokerCard.getCard();
            }
            return p;
        }
    }
}
