using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIHS_CS_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String[] guessType = new String[] { "剪刀", "石頭", "布" };
        public int gameState = 0;
        public int[] gameSource = new int[] { 0, 0, 0 };
        private void scissors_Click(object sender, EventArgs e)
        {
            updateGame(0);
        }

        private void rock_Click(object sender, EventArgs e)
        {
            updateGame(1);
        }

        private void paper_Click(object sender, EventArgs e)
        {
            updateGame(2);
        }
        private void updateGame(int player)
        {
            // 0 == i win
            // 1 == i lose 
            Random random = new Random();
            int npc = random.Next(0, 3);
            playerShow.Text = guessType[player];
            npcShow.Text = guessType[npc];
            if (npc == player)
            {
                gameState = 2;
            }
            else if (npc == 0)
            {
                switch (player)
                {
                    case 1: gameState = 0; break;
                    case 2: gameState = 1; break;
                }
            }
            else if (npc == 1)
            {
                switch (player)
                {
                    case 0: gameState = 1; break;
                    case 2: gameState = 0; break;
                }
            }
            else if(npc == 2)
            {
                switch (player)
                {
                    case 0: gameState = 0; break;
                    case 1: gameState = 1; break;
                }
            }
            winLose.Text = gameState == 2 ? "平手" : gameState == 0 ? "勝" : "輸";
            gameSource[gameState]++;
            sourceCountShow.Text = $"你贏了{gameSource[0]}次 電腦贏了{gameSource[1]}次 平手{gameSource[2]}";

        }

        private void reset_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<gameSource.Length;i++)
            {
                gameSource[i] = 0;
            }
            var labelAll = new Label[] { winLose, playerShow, npcShow, sourceCountShow };
            foreach(Label i in labelAll)
            {
                i.Text = "";
            }

        }
    }
}
