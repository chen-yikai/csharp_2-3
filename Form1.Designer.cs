namespace SAIHS_CS_2_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.scissors = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.winLose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.playerShow = new System.Windows.Forms.Label();
            this.npcShow = new System.Windows.Forms.Label();
            this.sourceCountShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(292, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "猜拳遊戲";
            // 
            // scissors
            // 
            this.scissors.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scissors.Location = new System.Drawing.Point(127, 87);
            this.scissors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(116, 59);
            this.scissors.TabIndex = 1;
            this.scissors.Text = "剪刀";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // rock
            // 
            this.rock.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rock.Location = new System.Drawing.Point(297, 87);
            this.rock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(116, 59);
            this.rock.TabIndex = 2;
            this.rock.Text = "石頭";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.paper.Location = new System.Drawing.Point(473, 87);
            this.paper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(116, 59);
            this.paper.TabIndex = 3;
            this.paper.Text = "布";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // winLose
            // 
            this.winLose.AutoSize = true;
            this.winLose.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.winLose.Location = new System.Drawing.Point(39, 252);
            this.winLose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winLose.Name = "winLose";
            this.winLose.Size = new System.Drawing.Size(0, 27);
            this.winLose.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(121, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "玩家出了";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(121, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "電腦出了";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(121, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "勝負統計";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("PMingLiU", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reset.Location = new System.Drawing.Point(636, 385);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(116, 59);
            this.reset.TabIndex = 8;
            this.reset.Text = "重猜";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // playerShow
            // 
            this.playerShow.AutoSize = true;
            this.playerShow.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playerShow.Location = new System.Drawing.Point(255, 199);
            this.playerShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerShow.Name = "playerShow";
            this.playerShow.Size = new System.Drawing.Size(0, 27);
            this.playerShow.TabIndex = 9;
            // 
            // npcShow
            // 
            this.npcShow.AutoSize = true;
            this.npcShow.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.npcShow.Location = new System.Drawing.Point(255, 252);
            this.npcShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.npcShow.Name = "npcShow";
            this.npcShow.Size = new System.Drawing.Size(0, 27);
            this.npcShow.TabIndex = 10;
            // 
            // sourceCountShow
            // 
            this.sourceCountShow.AutoSize = true;
            this.sourceCountShow.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sourceCountShow.Location = new System.Drawing.Point(255, 320);
            this.sourceCountShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceCountShow.Name = "sourceCountShow";
            this.sourceCountShow.Size = new System.Drawing.Size(0, 27);
            this.sourceCountShow.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 460);
            this.Controls.Add(this.sourceCountShow);
            this.Controls.Add(this.npcShow);
            this.Controls.Add(this.playerShow);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.winLose);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Label winLose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label playerShow;
        private System.Windows.Forms.Label npcShow;
        private System.Windows.Forms.Label sourceCountShow;
    }
}

