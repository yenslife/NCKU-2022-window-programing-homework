using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace practice_4_2 {
    public static class ScoreManager {
        public static int score = 100;
        public static string scoreText = "分數 : " + ScoreManager.score;
        public static string scoreBoard;

        public static string getScore() {
            ScoreManager.score += 10 ;
            scoreText = "分數 : " + ScoreManager.score;
            return scoreText;
        }
        public static string lostScore() {
            ScoreManager.score -= 5;
            scoreText = "分數 : " + ScoreManager.score;
            return scoreText;
        }
        public static string initScore() {
            score = 100;
            scoreText = "分數 : " + ScoreManager.score;
            return scoreText;
        }
        public static void scoreBoardUpdate(RichTextBox rtb) {
            scoreBoard += GameManager.userName + " 得分為 : " + score + "\n\n";
            rtb.Text = scoreBoard;

        }
    }
}
