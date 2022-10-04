using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_3_2 {
    public partial class Form1 : Form {
        Game game;
        List<Button> buttonList;
        List<Label> displayList;
        public Form1 () {
            InitializeComponent();
            statusRichTextBox.Text = "請輸入測資";
            displayList = new List<Label> { stack1display, stack2display, stack3display, stack4display };
            buttonList = new List<Button>() { stackButton1, stackButton2, stackButton3, stackButton4 };
            for (int i = 0; i < 4; i++) {
                buttonList[i].Visible = false;
                displayList[i].Visible = false;
            }
            
        }
        bool isMainLayout = true;
        bool inputError (string[] inputStringArray) {
            int one = 0, two = 0, three = 0, four = 0;
            for (int i = 0; i < 4; i++) {
                if (inputStringArray[i].Length > 7) return true; // 超過四個數字 (包含空格為 7)
                // 用迴圈計算出現數字的數量 順便檢查所有字元是否不符合某些條件
                for (int j = 0; j < inputStringArray[i].Length; j++) {
                    // 有數字與空白以外的字元出現
                    if ((('0' > inputStringArray[i][j] || inputStringArray[i][j] > '9') && inputStringArray[i][j] != ' ') && inputStringArray[i] != "") {
                        return true;
                    }
                    if (inputStringArray[i][j] == '1') one++;
                    if (inputStringArray[i][j] == '2') two++;
                    if (inputStringArray[i][j] == '3') three++;
                    if (inputStringArray[i][j] == '4') four++;
                }
                // input 前後有空格 (需要排除掉空的情況)
                if (inputStringArray[i] != "" && (inputStringArray[i][0] == ' ' || inputStringArray[i][inputStringArray[i].Length - 1] == ' ')) return true;
            }
            // 數字數量超過4
            if (one > 4 || two > 4 || three > 4 || four > 4) return true;
            return false;
        }
        private void gameStartBbtton_Click (object sender, EventArgs e) {
            string[] inputStringArray = new string[] { stack1Input.Text, stack2Input.Text, stack3Input.Text, stack4Input.Text };
            if (isMainLayout) {
                if (!inputError(inputStringArray)) {
                    //layout init
                    stack1Label.Location = new Point(40, 40);
                    stack2Label.Location = new Point(120, 40);
                    stack3Label.Location = new Point(200, 40);
                    stack4Label.Location = new Point(280, 40);
                    stack1Input.Visible = false;
                    stack2Input.Visible = false;
                    stack3Input.Visible = false;
                    stack4Input.Visible = false;
                    mainButton.Size = new Size(122, 33);
                    mainButton.Location = new Point(200, 383);
                    statusRichTextBox.Location = new Point(40, 383);
                    statusRichTextBox.Size = new Size(122, 33);
                    stack1display.Visible = true;
                    stack2display.Visible = true;
                    stack3display.Visible = true;
                    stack4display.Visible = true;
                    stack1display.Text = "";
                    stack2display.Text = "";
                    stack3display.Text = "";
                    stack4display.Text = "";
                    stackButton1.Visible = true;
                    stackButton2.Visible = true;
                    stackButton3.Visible = true;
                    stackButton4.Visible = true;
                    for (int i = 0; i < 4; i++) {
                        buttonList[i].Text = "選取";
                    }
                    isMainLayout = false;
                    mainButton.Text = "回主畫面";
                    statusRichTextBox.Text = "...";
                    // game condition init
                    game = new Game(displayList, inputStringArray);
                    // make button enabled if it's empty
                    for (int i = 0; i < 4; i++) {
                        //if (!game.canTake(i)) buttonList[i].Enabled = false;
                        if (game.canTake(i)) {
                            buttonList[i].Enabled = true;
                        } else {
                            buttonList[i].Enabled = false;
                        }
                    }
                    if (game.win()) {
                        for (int i = 0; i < 4; i++) {
                            buttonList[i].Text = "贏";
                            buttonList[i].Enabled = false;
                        }
                        statusRichTextBox.Text = "你贏了";
                    }
                } else {
                    statusRichTextBox.Text = "測資錯誤";
                }
                

            } else {
                // layout init
                stack1Label.Location = new Point(40, 85);
                stack2Label.Location = new Point(40, 125);
                stack3Label.Location = new Point(40, 170);
                stack4Label.Location = new Point(40, 212);
                stack1Input.Visible = true;
                stack2Input.Visible = true;
                stack3Input.Visible = true;
                stack4Input.Visible = true;
                mainButton.Size = new Size(114, 22);
                mainButton.Location = new Point(119, 259);
                statusRichTextBox.Location = new Point(43, 29);
                statusRichTextBox.Size = new Size(279, 33);
                stack1display.Visible = false;
                stack2display.Visible = false;
                stack3display.Visible = false;
                stack4display.Visible = false;
                stackButton1.Visible = false;
                stackButton2.Visible = false;
                stackButton3.Visible = false;
                stackButton4.Visible = false;
                statusRichTextBox.Text = "請輸入測資";
                mainButton.Text = "開始遊戲";
                isMainLayout = true;

            }

        }
        bool selecting = false;
        int selectedStackNumber = -1;
        private void changeButtonStatus () {
            if (game.win()) {
                for (int i = 0; i < 4; i++) {
                    buttonList[i].Text = "贏";
                    buttonList[i].Enabled = false;
                }
                statusRichTextBox.Text = "你贏了";
            }
            if (selecting) {
                for (int i = 0; i < 4; i++) {
                    buttonList[i].Text = "放置";
                    if (game.canPlace(i)) {
                        buttonList[i].Enabled = true;
                    } else {
                        buttonList[i].Enabled = false;
                    }
                }
            }
        }
        private void changeButtonStatus (int placeNum) {
            
            game.move(selectedStackNumber - 1, placeNum - 1);
            for (int i = 0; i < 4; i++) {
                buttonList[i].Text = "選取";
                if (game.canTake(i)) {
                    buttonList[i].Enabled = true;
                } else {
                    buttonList[i].Enabled = false;
                }
            }
            if (game.win()) {
                for (int i = 0; i < 4; i++) {
                    buttonList[i].Text = "贏";
                    buttonList[i].Enabled = false;
                }
                statusRichTextBox.Text = "你贏了";
            }
        }
        private void stackButton1_Click (object sender, EventArgs e) {
            int numberOfThisStack = 1;
            if (!selecting) { // 還沒按選取
                if (game.canTake(numberOfThisStack - 1)) {
                    selecting = true;
                    statusRichTextBox.Text = "你選擇了堆疊" + numberOfThisStack;
                    selectedStackNumber = numberOfThisStack;
                    changeButtonStatus();
                }
            } else {
                selecting = false;
                statusRichTextBox.Text = "...";
                changeButtonStatus(numberOfThisStack); // selectedstackNum 要放在 1
                displayList[numberOfThisStack - 1].Text = game.output(numberOfThisStack - 1);
                displayList[selectedStackNumber - 1].Text = game.output(selectedStackNumber - 1);
            }
        }

        private void stackButton2_Click (object sender, EventArgs e) {
            int numberOfThisStack = 2;
            if (!selecting) { // 還沒按選取
                if (game.canTake(numberOfThisStack - 1)) {
                    selecting = true;
                    statusRichTextBox.Text = "你選擇了堆疊" + numberOfThisStack;
                    selectedStackNumber = numberOfThisStack;
                    changeButtonStatus();
                }
            } else {
                selecting = false;
                statusRichTextBox.Text = "...";
                changeButtonStatus(numberOfThisStack); // selectedstackNum 要放在 1
                displayList[numberOfThisStack - 1].Text = game.output(numberOfThisStack - 1);
                displayList[selectedStackNumber - 1].Text = game.output(selectedStackNumber - 1);
            }
        }

        private void stackButton3_Click (object sender, EventArgs e) {
            int numberOfThisStack = 3;
            if (!selecting) { // 還沒按選取
                if (game.canTake(numberOfThisStack - 1)) {
                    selecting = true;
                    statusRichTextBox.Text = "你選擇了堆疊" + numberOfThisStack;
                    selectedStackNumber = numberOfThisStack;
                    changeButtonStatus();
                }
            } else {
                selecting = false;
                statusRichTextBox.Text = "...";
                changeButtonStatus(numberOfThisStack); // selectedstackNum 要放在 1
                displayList[numberOfThisStack - 1].Text = game.output(numberOfThisStack - 1);
                displayList[selectedStackNumber - 1].Text = game.output(selectedStackNumber - 1);
            }
        }

        private void stackButton4_Click (object sender, EventArgs e) {
            int numberOfThisStack = 4;
            if (!selecting) { // 還沒按選取
                if (game.canTake(numberOfThisStack - 1)) {
                    selecting = true;
                    statusRichTextBox.Text = "你選擇了堆疊" + numberOfThisStack;
                    selectedStackNumber = numberOfThisStack;
                    changeButtonStatus();
                }
            } else {
                selecting = false;
                statusRichTextBox.Text = "...";
                changeButtonStatus(numberOfThisStack); // selectedstackNum 要放在 1
                displayList[numberOfThisStack - 1].Text = game.output(numberOfThisStack - 1);
                displayList[selectedStackNumber - 1].Text = game.output(selectedStackNumber - 1);
            }
        }
    }
}
