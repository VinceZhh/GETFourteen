using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public abstract class Player
    {
        private List<Poker> pool = new List<Poker>();    
        public List<Poker> Pool
        {
            get { return pool; }
            set { pool = value; }
        }

        private List<Poker> chosenCard = new List<Poker>();
        public List<Poker> ChosenCard
        {
            get { return chosenCard; }
            set { chosenCard = value; }
        }

        protected PlayTable table;
       
        private Poker poker1;
        public Poker Poker1
        {
            get { return poker1; }
            set { poker1 = value; }
        }

        private Poker poker2;
        public Poker Poker2
        {
            get { return poker2; }
            set { poker2 = value; }
        }

        private Poker poker3;
        public Poker Poker3
        {
            get { return poker3; }
            set { poker3 = value; }
        }

        private double point = 0;
        public double Point
        {
            get {
                point = 0;
                for (int i = 0; i < pool.Count; i++)
                {
                    point += pool[i].GetPoint();
                }
                return point;
            }
        }

        public bool IsFourteen(Poker p)
        {
            int sum = 0;
            for (int i = 0; i < ChosenCard.Count; i++)
            {
                sum += ChosenCard[i].Num;
            }
            sum += p.Num;
            if (sum == 14)
                return true;
            else
                return false;
        }

        public abstract void GetFourteen(Poker p);
       
    }
}
