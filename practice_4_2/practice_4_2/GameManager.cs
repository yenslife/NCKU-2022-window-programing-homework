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
    public static class GameManager {
        public static bool gameStop = false;
        public static bool win = false;
        public static string userName;
        
        public static void gameRestart(Button startbtn, List<FruitButton> buttonList, TabPage tp) {
            foreach (FruitButton fb in buttonList) {
                tp.Controls.Remove(fb.myButton);
            }
            startbtn.Enabled = true;
        }

        public static bool getUserName (TextBox tb) {
            if (tb.Text == "") {
                MessageBox.Show("名稱不得為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            } else if (tb.Text.Length < 3 || tb.Text.Length > 10) {
                MessageBox.Show("名稱不合格式 ( >= 3 && <= 10 )", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            userName = tb.Text;
            return true;
        }

    }
    
}
