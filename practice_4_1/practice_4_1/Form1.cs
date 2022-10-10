using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_4_1 {
    public partial class Form1 : Form {
        List<Button> buttonList;
        Image backImage;
        int[] imageListCode;
        public Form1 () {
            InitializeComponent();
        }
        
        private void Form1_Load (object sender, EventArgs e) {
            buttonList = new List<Button>();
            backImage = Image.FromFile(@"..\..\images\card.jpg");
            imageListCode = new int[16];

            continueButton.Enabled = false;
            buttonList.Add(button1); buttonList.Add(button2); buttonList.Add(button3); buttonList.Add(button4);
            buttonList.Add(button5); buttonList.Add(button6); buttonList.Add(button7); buttonList.Add(button8);
            buttonList.Add(button9); buttonList.Add(button10); buttonList.Add(button11); buttonList.Add(button12);
            buttonList.Add(button13); buttonList.Add(button14); buttonList.Add(button15); buttonList.Add(button16);
                   
            for (int i = 0; i < 16; i++) {
                buttonList[i].Text = "";
                buttonList[i].Visible = false;
                buttonList[i].Image = backImage;
            }
        }
        
        private void startButton_Click (object sender, EventArgs e) {
            startButton.Enabled = false;
            for (int i = 0; i < 16; i++) {
                buttonList[i].Visible = true;
            }
            Random rand = new Random();
            int[] check = { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 16; i++) {
                int randNum = rand.Next(0, 8);
                while (check[randNum] == 2) {
                    randNum = rand.Next(0, 8);
                }
                imageListCode[i] = randNum;
                check[randNum]++;
            }
        }

        private void exitButton_Click (object sender, EventArgs e) {
            Application.Exit();
        }

        int clickButtonIndex1 = -1, clickButtonIndex2 = -1;
        bool gameTmpStop = false;
        private void gameButtonClick (Button thisButton) {
            
            int tmpIndex = 0;
            for (int i = 0; i < 16; i++) {
                if (buttonList[i] == thisButton) {
                    tmpIndex = i;
                    break;
                }
            }
            // 如果牌被朝上
            if (thisButton.Image == backImage) {
                if (clickButtonIndex1 == -1) clickButtonIndex1 = tmpIndex;
                else clickButtonIndex2 = tmpIndex;

                thisButton.Image = imageList1.Images[imageListCode[tmpIndex]];
                if (clickButtonIndex1 != -1 && clickButtonIndex2 != -1) {
                    // 如果一樣
                    if (imageListCode[clickButtonIndex1] == imageListCode[clickButtonIndex2]) {
                        int tmp = 0;
                        buttonList[clickButtonIndex1].Enabled = false;
                        buttonList[clickButtonIndex2].Enabled = false;
                        imageListCode[clickButtonIndex1] = -1;
                        imageListCode[clickButtonIndex2] = -1;
                        clickButtonIndex1 = -1;
                        clickButtonIndex2 = -1;
                        gameTmpStop = false;
                    } else {
                        // 就要按繼續才能繼續
                        gameTmpStop = true;
                        continueButton.Enabled = true;
                    }

                }
                
            }
            // check win
            bool win = true;
            for (int i = 0; i < 16; i++) {
                if (imageListCode[i] != -1) win = false;
            }
            if (win) {
                startButton.Enabled = false;
                continueButton.Enabled = false;
                MessageBox.Show("你贏了","", MessageBoxButtons.OK);
            }

        }
        private void continueButton_Click (object sender, EventArgs e) {
                buttonList[clickButtonIndex1].Image = backImage;
                buttonList[clickButtonIndex2].Image = backImage;
                clickButtonIndex1 = -1;
                clickButtonIndex2 = -1;
                gameTmpStop = false;
                continueButton.Enabled = false;
            return;
        }
        private void button1_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button1);
        }
        private void button2_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button2);
        }

        private void button3_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button3);
        }

        private void button4_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button4);
        }

        private void button5_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button5);
        }

        private void button6_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button6);
        }

        private void button7_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button7);
        }


        private void button8_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button8);
        }

        private void button9_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button9);

        }

        private void button10_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button10);

        }

        private void button11_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button11);

        }

        private void button12_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button12);

        }

        private void button13_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button13);

        }

        private void button14_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button14);

        }

        private void button15_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button15);

        }

        private void button16_Click (object sender, EventArgs e) {
            if (!gameTmpStop) gameButtonClick(button16);

        }




    }
}
