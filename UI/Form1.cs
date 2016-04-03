using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 定义区
        PlayTable Table;
        HumanPlayer P;
        AI AI1, AI2;
        List<PictureBox> PoolImageList = new List<PictureBox>();
        List<PictureBox> AI1ImageList = new List<PictureBox>();
        List<PictureBox> AI2ImageList = new List<PictureBox>();
        bool AI1_over = false, AI2_over = false,Player_over=false;
        #endregion       

        private void GetMyImage()
        {
            MyFish1.Image = P.Poker1.CardImage;
            MyFish1.Location = new Point(MyFish1.Location.X, 30);
            MyFish2.Image = P.Poker2.CardImage;
            MyFish2.Location = new Point(MyFish2.Location.X, 30);
            MyFish3.Image = P.Poker3.CardImage;
            MyFish3.Location = new Point(MyFish3.Location.X, 30);
            if (P.Poker1.Num == 15)
                MyFish1.Visible = false;
            if (P.Poker2.Num == 15)
                MyFish2.Visible = false;
            if (P.Poker3.Num == 15)
                MyFish3.Visible = false;
            if (P.Poker1.Num + P.Poker2.Num + P.Poker3.Num == 45)
                Player_over = true;
            Pal_My.Refresh();
        }
        private void GetPoolImage()
        {
            int i;
            for (i = 0; i < Table.PoolPokerList.Count ; i++)
            {
                PoolImageList[i].Visible = true;
                PoolImageList[i].Image = Table.PoolPokerList[i].CardImage;
            }
            for (; i < 32; i++)
                PoolImageList[i].Visible = false;
            pool.Refresh();
        }
        private void GetPokerNum()
        {
            lab_Num.Text = Table.PokerCard.getNum().ToString();
            double point = P.Point;

            lab_Point.Text = point.ToString("f2");
        }
        private void GetAI1Image()
        {
            for (int i = 0; i < 3; i++)
                AI1ImageList[i].Image = Table.PokerCard.Bg();
            Pal_AI1.Refresh();
            System.Threading.Thread.Sleep(600);

        }
        private void GetAI2Image()
        {
            for (int i = 0; i < 3; i++)
                AI2ImageList[i].Image = Table.PokerCard.Bg();
            Pal_AI2.Refresh();
            System.Threading.Thread.Sleep(600);
        }
        private void LoadPoolImageList()
        {
            PoolImageList.Add(Fish1);
            PoolImageList.Add(Fish2);
            PoolImageList.Add(Fish3);
            PoolImageList.Add(Fish4);
            PoolImageList.Add(Fish5);
            PoolImageList.Add(Fish6);
            PoolImageList.Add(Fish7);
            PoolImageList.Add(Fish8);
            PoolImageList.Add(Fish9);
            PoolImageList.Add(Fish10);
            PoolImageList.Add(Fish11);
            PoolImageList.Add(Fish12);
            PoolImageList.Add(Fish13);
            PoolImageList.Add(Fish14);
            PoolImageList.Add(Fish15);
            PoolImageList.Add(Fish16);
            PoolImageList.Add(Fish17);
            PoolImageList.Add(Fish18);
            PoolImageList.Add(Fish19);
            PoolImageList.Add(Fish20);
            PoolImageList.Add(Fish21);
            PoolImageList.Add(Fish22);
            PoolImageList.Add(Fish23);
            PoolImageList.Add(Fish24);
            PoolImageList.Add(Fish25);
            PoolImageList.Add(Fish26);
            PoolImageList.Add(Fish27);
            PoolImageList.Add(Fish28);
            PoolImageList.Add(Fish29);
            PoolImageList.Add(Fish30);
            PoolImageList.Add(Fish31);
            PoolImageList.Add(Fish32);
            AI1ImageList.Add(Pbox_AI1_card1);
            AI1ImageList.Add(Pbox_AI1_card2);
            AI1ImageList.Add(Pbox_AI1_card3);
            AI2ImageList.Add(Pbox_AI2_card1);
            AI2ImageList.Add(Pbox_AI2_card2);
            AI2ImageList.Add(Pbox_AI2_card3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Table = new PlayTable();
            P = new HumanPlayer(Table);
            AI1 = new AI(Table);
            AI2 = new AI(Table);
            LoadPoolImageList();
            GetMyImage();
            GetPoolImage();
            GetPokerNum();
            GetAI1Image();
            GetAI2Image();
            Btn_Over.Visible = false;
            Pbox_AI1_pool.Visible = false;
            Pbox_AI2_Pool.Visible = false;
            lab_AI1_turn.Visible = false;
            lab_AI2_turn.Visible = false;
        }

        #region 个人卡片区域单击事件
        private void MyFish1_Click(object sender, EventArgs e)
        {
            if (P.ChosenCard.IndexOf(P.Poker1) < 0)
            {
                P.ChosenCard.Add(P.Poker1);
                MyFish1.Location = new Point(MyFish1.Location.X, MyFish1.Location.Y - 10);
            }
            else
            {
                P.ChosenCard.Remove(P.Poker1);
                MyFish1.Location = new Point(MyFish1.Location.X, MyFish1.Location.Y + 10);
            }
        }
        private void MyFish2_Click(object sender, EventArgs e)
        {
            if (P.ChosenCard.IndexOf(P.Poker2) < 0)
            {
                P.ChosenCard.Add(P.Poker2);
                MyFish2.Location = new Point(MyFish2.Location.X, MyFish2.Location.Y - 10);
            }
            else
            {
                P.ChosenCard.Remove(P.Poker2);
                MyFish2.Location = new Point(MyFish2.Location.X, MyFish2.Location.Y + 10);
            }
        }
        private void MyFish3_Click(object sender, EventArgs e)
        {
            if (P.ChosenCard.IndexOf(P.Poker3) < 0)
            {
                P.ChosenCard.Add(P.Poker3);
                MyFish3.Location = new Point(MyFish3.Location.X, MyFish3.Location.Y - 10);
            }
            else
            {
                P.ChosenCard.Remove(P.Poker3);
                MyFish3.Location = new Point(MyFish3.Location.X, MyFish3.Location.Y + 10);
            }
        }
        /// <summary>
        /// 弃牌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Drop_Click(object sender, EventArgs e)
        {
            if (P.ChosenCard.Count == 0)
                return;
            Poker p = P.ChosenCard[0];
            P.ChosenCard.Clear();
            Table.PoolPokerList.Add(p);
            if (P.Poker1 == p)
                P.Poker1 = Table.PokerCard.getCard();
            else if (P.Poker2 == p)
                P.Poker2 = Table.PokerCard.getCard();
            else
                P.Poker3 = Table.PokerCard.getCard();
            GetPoolImage();
            GetMyImage();
            
            Btn_Over_Click(sender, e);
        }
        #endregion
        #region 鱼塘卡片单击事件
        private void Fish1_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[0];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish2_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[1];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish3_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[2];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish4_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[3];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish5_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[4];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish6_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[5];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish7_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[6];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish8_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[7];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish9_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[8];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish10_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[9];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish11_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[10];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish12_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[11];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish13_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[12];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish14_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[13];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish15_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[14];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish16_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[15];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish17_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[16];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish18_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[17];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish19_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[18];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish20_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[19];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish21_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[20];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish22_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[21];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish23_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[22];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish24_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[23];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish25_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[24];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish26_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[25];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish27_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[26];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish28_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[27];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish29_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[28];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish30_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[29];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish31_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[30];
            GetFourteen(p);
            GetPokerNum();
        }
        private void Fish32_Click(object sender, EventArgs e)
        {
            Poker p = Table.PoolPokerList[31];
            GetFourteen(p);
            GetPokerNum();
        }

        private void GetFourteen(Poker p)
        {
            if (P.IsFourteen(p))
            {
                Btn_Drop.Visible = false;
                Btn_Over.Visible = true;
            }
            P.GetFourteen(p);
            GetPoolImage();
            GetMyImage();
            Pbox_MyPool.Image = P.Pool.Last().CardImage;
        }




        #endregion

        private void Pbox_AI1_pool_Click(object sender, EventArgs e)
        {
            Poker p = AI1.Pool.Last();
            AI1.Pool.Remove(p);
            if (AI1.Pool.Count != 0)
                Pbox_AI1_pool.Image = AI1.Pool.Last().CardImage;
            else
                Pbox_AI1_pool.Visible = false;
            GetFourteen(p);
            GetPokerNum();
        }

        private void Pbox_AI2_Pool_Click(object sender, EventArgs e)
        {
            Poker p = AI2.Pool.Last();
            AI2.Pool.Remove(p);
            if (AI2.Pool.Count != 0)
                Pbox_AI2_Pool.Image = AI2.Pool.Last().CardImage;
            else
                Pbox_AI2_Pool.Visible = false;
            GetFourteen(p);
            GetPokerNum();
        }

        private void Btn_Over_Click(object sender, EventArgs e)
        {
            if (Player_over && AI1_over && AI2_over)
            {
                textBox1.Text = "游戏结束啦~！";
                return;
            }
            P.ChosenCard.Clear();
            GetMyImage();
            AI1Turn();
            AI2Turn();
            if (Player_over)
                Btn_Over_Click(sender, e);
            Btn_Over.Visible = false;
            Btn_Drop.Visible = true;
            GetPokerNum();
        }

        private void AI1Turn()
        {
            if (AI1_over)
                return;
            lab_AI1_turn.Visible = true;
            lab_AI1_turn.Refresh();
            System.Threading.Thread.Sleep(600);
            bool temp = true;
            while (AI1.hasFourteen())
            {
                temp = false;
                GetAI1Image();
                for (int i = 0; i < AI1.ShowCard.Count; i++)
                {
                    AI1ImageList[i].Image = AI1.ShowCard[i].CardImage;
                    AI1ImageList[i].Refresh();
                }
                PoolImageList[AI1.PoolNum].Location = new Point(PoolImageList[AI1.PoolNum].Location.X, PoolImageList[AI1.PoolNum].Location.Y - 10);
                PoolImageList[AI1.PoolNum].Refresh();
                System.Threading.Thread.Sleep(1000);
                PoolImageList[AI1.PoolNum].Location = new Point(PoolImageList[AI1.PoolNum].Location.X, PoolImageList[AI1.PoolNum].Location.Y + 10);
                PoolImageList[AI1.PoolNum].Refresh();                
                GetAI1Image();
                GetPoolImage();
                lab_AI1_piont.Text = AI1.Point.ToString("f2");
                Pbox_AI1_pool.Visible = true;
                Pbox_AI1_pool.Image = AI1.Pool.Last().CardImage;
                Pbox_AI1_pool.Refresh();
                GetPokerNum();
            }
            if (temp)
            {
                System.Threading.Thread.Sleep(400);
                Poker p = AI1.DorpCard();
                if (p != null)
                    Table.PoolPokerList.Add(p);
                else
                {
                    AI1_over = true;
                    textBox1.Text += "AI1空城了！";
                }
                GetPoolImage();
                textBox1.Text += "AI1弃牌";
                textBox1.Refresh();
                GetPokerNum();
            }
            lab_AI1_turn.Visible = false;
        }

        private void AI2Turn()
        {
            if (AI2_over)
                return ;
            lab_AI2_turn.Visible = true;
            lab_AI2_turn.Refresh();
            System.Threading.Thread.Sleep(600);
            bool temp = true;
            while (AI2.hasFourteen())
            {
                temp = false;
                GetAI2Image();
                for (int i = 0; i < AI2.ShowCard.Count; i++)
                {
                    AI2ImageList[i].Image = AI2.ShowCard[i].CardImage;
                    AI2ImageList[i].Refresh();
                }
                PoolImageList[AI2.PoolNum].Location = new Point(PoolImageList[AI2.PoolNum].Location.X, PoolImageList[AI2.PoolNum].Location.Y - 10);
                PoolImageList[AI2.PoolNum].Refresh();
                System.Threading.Thread.Sleep(1000);
                PoolImageList[AI2.PoolNum].Location = new Point(PoolImageList[AI2.PoolNum].Location.X, PoolImageList[AI2.PoolNum].Location.Y + 10);
                PoolImageList[AI2.PoolNum].Refresh();
                GetAI2Image();
                GetPoolImage();
                lab_AI2_Piont.Text = AI2.Point.ToString("f2");
                Pbox_AI2_Pool.Visible = true;
                Pbox_AI2_Pool.Image = AI2.Pool.Last().CardImage;
                Pbox_AI2_Pool.Refresh();
                GetPokerNum();
            }
            if (temp)
            {
                System.Threading.Thread.Sleep(400);
                Poker p = AI2.DorpCard();
                if (p != null)
                    Table.PoolPokerList.Add(p);
                else
                {
                    AI2_over = true;
                    textBox1.Text += "AI2空城了！";
                }
                GetPoolImage();
                textBox1.Text += "AI2弃牌";
                textBox1.Refresh();
                GetPokerNum();
            }
            lab_AI2_turn.Visible = false;
        }
  

       
    }
}
