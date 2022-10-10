using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_4_2 {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }
        List<int[]> cardPosition = new List<int[]>();
        Random rand = new Random();
        List<FruitButton> buttonList = new List<FruitButton>();
        Image backImage = Image.FromFile(@"..\..\images\card.jpg");
        public void initCardPos() {
            scoreLabel.Text = ScoreManager.initScore();
            if (GameManager.getUserName(userNameTextBox)) {
                startButton.Enabled = false;
                int buttonName = 0, posX = 40, posY = 70;
                // random the card position 先把位置打好 在隨便指定位置給 按鈕
                // {x, y}
                buttonList.Clear();
                // 建表
                for (int i = 0; i < 4; i++) {
                    for (int j = 0; j < 4; j++) {
                        cardPosition.Add(new int[] { posX + 80 * i, posY + j * 90 });
                        buttonList.Add(new FruitButton(userNameTextBox, startButton, scoreBoeadRichTextBox, scoreLabel, cardPosition[buttonName], "" + buttonName / 2, fruitImageList.Images[buttonName / 2], "" + buttonName, buttonList, continueButton, tabPage1));
                        tabPage1.Controls.Add(buttonList[buttonName].myButton);
                        buttonName++;
                    }
                }
                // random place 
                foreach (FruitButton fb in buttonList) {
                    int pos = rand.Next(cardPosition.Count);
                    fb.location = cardPosition[pos];
                    cardPosition.RemoveAt(pos);
                    fb.placeButton();
                    fb.myButton.Image = backImage;
                }
            }
        }
        private void Form1_Load (object sender, EventArgs e) {
            continueButton.Enabled = false;
        }
       
       

        private void startButton_Click (object sender, EventArgs e) {
            initCardPos();
        }

        private void restartButton_Click (object sender, EventArgs e) {
            // 移除按鈕
            GameManager.gameRestart(startButton, buttonList, tabPage1);
            scoreLabel.Text = ScoreManager.scoreText;
            startButton.Enabled = true;
            scoreLabel.Text = ScoreManager.initScore();
            userNameTextBox.Text = "";
        }

        private void exitButton_Click (object sender, EventArgs e) {
            DialogResult result;
            result = MessageBox.Show("確定要離開遊戲嗎?", "離開遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK) {
                Application.Exit();
            }
            
        }

        private void continueButton_Click (object sender, EventArgs e) {
            continueButton.Enabled = false;
            scoreLabel.Text = ScoreManager.scoreText;
            GameManager.gameStop = false;
            foreach(FruitButton fb in buttonList) {
                if (fb.isClicked && fb.myButton.Enabled == true) {
                    fb.isClicked = false;
                    fb.myButton.Image = backImage;
                }

            }
        }
    }
}
