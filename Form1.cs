using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        int win = 0;
        int lose = 0;
        int safe = 0;
        private void scissors_Click(object sender, EventArgs e)
        {
            playerShow.Text = "玩家出了:剪刀";
            Random kk = new Random();
            int a = kk.Next(1, 4);
            String npc = "";
            if (a == 1)
            {
                npc = "剪刀";
            }
            else if (a == 2)
            {
                npc = "石頭";
            }
            else if (a == 3)
            {
                npc = "布";
            }

            npcShow.Text = "電腦出了:" + npc;

            if (a == 1)
            {
                winLose.Text = "平手";
                safe++;
            }
            else if (a == 2)
            {
                winLose.Text = "敗";
                lose++; 
            }
            else
            {
                winLose.Text = "勝";
                win++;
            }
            sourceCountShow.Text = "勝負統計:你贏了" + win + "次 電腦贏了" + lose + "次 平手" + safe + "次";
        }
        private void rock_Click(object sender, EventArgs e)
        {
            playerShow.Text = "玩家出了:石頭";
            Random kk = new Random();
            int a = kk.Next(1, 4);
            String npc = "";
            if (a == 1)
            {
                npc = "剪刀";
            }
            else if (a == 2)
            {
                npc = "石頭";
            }
            else if (a == 3)
            {
                npc = "布";
            }

            npcShow.Text = "電腦出了:" + npc;

            if (a == 2)
            {
                winLose.Text = "平手";
                safe++;
            }
            else if (a == 3)
            {
                winLose.Text = "敗";
                lose++;
            }
            else
            {
                winLose.Text = "勝";
                win++;
            }
            sourceCountShow.Text = "勝負統計:你贏了" + win + "次 電腦贏了" + lose + "次 平手" + safe + "次";

        }
        private void paper_Click(object sender, EventArgs e)
        {
            playerShow.Text = "玩家出了:布";
            Random kk = new Random();
            int a = kk.Next(1, 4);
            String npc = "";
            if (a == 1)
            {
                npc = "剪刀";
            }
            else if (a == 2)
            {
                npc = "石頭";
            }
            else if (a == 3)
            {
                npc = "布";
            }

            npcShow.Text = "電腦出了:" + npc;

            if (a == 3)
            {
                winLose.Text = "平手";
                safe++;
            }
            else if (a == 1)
            {
                winLose.Text = "敗";
                lose++;
            }
            else
            {
                winLose.Text = "勝";
                win++;
            }
            sourceCountShow.Text = "勝負統計:你贏了" + win + "次 電腦贏了" + lose + "次 平手" + safe + "次";

        }

        private void reset_Click(object sender, EventArgs e)
        {
            win = 0;
            lose = 0;
            safe = 0;
            playerShow.Text = "玩家出了:";
            npcShow.Text = "電腦出了:";
            sourceCountShow.Text = "勝負統計:你贏了0次 電腦了0次 平手0次";
        }

    }
}