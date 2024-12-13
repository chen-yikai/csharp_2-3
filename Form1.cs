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
        public String[] guessType = new String[] { "剪刀", "石頭", "布" }; // 建立猜拳出拳的類型
        public int gameState = 0; // 0:玩家贏 1:電腦贏 2:平手
        public int[] gameSource = new int[] { 0, 0, 0 }; // 0:玩家贏次數 1:電腦贏次數 2:平手次數
        private void scissors_Click(object sender, EventArgs e) // 剪刀
        {
            updateGame(0);
        }
        private void rock_Click(object sender, EventArgs e) // 石頭
        {
            updateGame(1);
        }
        private void paper_Click(object sender, EventArgs e) // 布
        {
            updateGame(2);
        }
        private void updateGame(int player)
        {
            Random random = new Random(); // 建立亂數物件
            int npc = random.Next(0, 3); // 產生0~2的亂數
            playerShow.Text = guessType[player]; // 顯示玩家出拳
            npcShow.Text = guessType[npc]; // 顯示電腦出拳
            if (npc == player) // 判斷是否平手
            {
                gameState = 2;
            }
            else if (npc == 0) // 電腦出剪刀
            {
                gameState = player == 1 ? 0 : 1; // 判斷如果玩家出石頭則玩家贏，否則電腦贏
            }
            else if (npc == 1) // 電腦出石頭
            {
                gameState = player == 0 ? 1 : 0; // 判斷如果玩家出剪刀則玩家贏，否則電腦贏
            }
            else if (npc == 2) // 電腦出布
            {
                gameState = player == 0 ? 0 : 1; // 判斷如果玩家出剪刀則玩家贏，否則電腦贏
            }
            winLose.Text = gameState == 2 ? "平手" : gameState == 0 ? "勝" : "輸"; // 顯示結果
            gameSource[gameState]++; // 更新遊戲計分
            sourceCountShow.Text = $"你贏了{gameSource[0]}次 電腦贏了{gameSource[1]}次 平手{gameSource[2]}次"; // 顯示遊戲計分
        }
        private void reset_Click(object sender, EventArgs e)
        {
            // 重置遊戲計分
            for (int i = 0; i < gameSource.Length; i++)
            {
                gameSource[i] = 0;
            }
            // 重置所有Label
            var labelAll = new Label[] { winLose, playerShow, npcShow, sourceCountShow };
            foreach (Label i in labelAll)
            {
                i.Text = "";
            }
        }
    }
}