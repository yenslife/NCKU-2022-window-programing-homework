using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;





namespace practice_4_2 {
    public class FruitButton {



        public bool isClicked = false;
        public int[] location;
        string imageCode;
        public Button myButton;
        Image image;
        List<FruitButton> buttonList;
        Button continueButton;
        TabPage tabPage;
        Label scoreLabel;
        RichTextBox scoreBoardRichTextBox;
        Button startButton;
        TextBox username;

        public FruitButton (TextBox user, Button startBtn, RichTextBox rtb, Label sL, int[] loc, string code, Image img, string buttonName, List<FruitButton> bL, Button continuebtn, TabPage tp) {
            username = user;
            startButton = startBtn;
            scoreBoardRichTextBox = rtb;
            scoreLabel = sL;
            tabPage = tp;
            buttonList = bL;
            continueButton = continuebtn;
            location = loc;
            myButton = new Button();
            imageCode = code;
            image = img;
            myButton.Name = buttonName;
            myButton.Image = img;
            // put button on the form
            myButton.Location = new Point(loc[0], loc[1]);
            myButton.Size = new Size(50, 70);
            // add event to button
            myButton.Click += new EventHandler(buttonClick);
        }

        //private int clicked1 = -1, clicked2 = -1;
        public void buttonClick (object sender, EventArgs e) {
            if (!GameManager.gameStop) {
                isClicked = true;
                myButton.Image = image;
                buttonCheck(continueButton);
            }
            winCheck();
            scoreLabel.Text = ScoreManager.scoreText;
        }
        public void placeButton () {
            myButton.Location = new Point(location[0], location[1]);

        }
        FruitButton btn1, btn2;

        public void buttonCheck (Button continuebtn) {
            int check = 0;
            foreach (FruitButton fb in buttonList) {
                if (fb.isClicked && check == 0 && fb.myButton.Enabled == true) {
                    check++;
                    btn1 = fb;
                } else if (fb.isClicked && check == 1 && fb.myButton.Enabled == true) {
                    check++;
                    btn2 = fb;
                }
            }
            if (check == 2) {
                // 有兩個被翻開了
                if (btn1.imageCode == btn2.imageCode) {
                    btn1.myButton.Enabled = false;
                    btn2.myButton.Enabled = false;
                    scoreLabel.Text = ScoreManager.getScore();
                } else {
                    // 按繼續才能繼續
                    continueButton.Enabled = true;
                    GameManager.gameStop = true;
                    continuebtn.Enabled = true;
                    scoreLabel.Text = ScoreManager.lostScore();
                }
            }
        }
        public void winCheck () {
            GameManager.win = true;
            foreach (FruitButton fb in buttonList) {
                if (fb.myButton.Enabled == true) GameManager.win = false;
            }
            if (GameManager.win) {
                ScoreManager.scoreBoardUpdate(scoreBoardRichTextBox);
                DialogResult result;
                result = MessageBox.Show("分數: " + ScoreManager.score, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Retry) {
                    // 移除按鈕
                    GameManager.gameRestart(startButton, buttonList, tabPage);
                    scoreLabel.Text = ScoreManager.initScore();
                    username.Text = "";
                }

            }
        }
    }
}
