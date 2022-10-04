using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace practice_3_2 {
    class Game : System.Windows.Forms.Form {
        // game instance
        private List<int>[] stacks = new List<int>[4];
        // public method
        public bool canPlace (int i) {
            if (stacks[i].Count < 4) return true;
            else return false;
        }
        public bool canTake (int i) {
            if (stacks[i].Any()) return true;
            else return false;
        }
        public void move (int i, int j) {
            stacks[j].Insert(0, stacks[i].First());
            stacks[i].Remove(stacks[i].First());
        }
        public string output (int i) {
            string tmp = "";
            for (int j = 0; j < stacks[i].Count; j++) {
                tmp += "\n" + (stacks[i][j]).ToString();
            }
            return tmp;
        }
        public bool win () {
            Dictionary<int, int> dictionaryOfStacks = new Dictionary<int, int>(); // 第一個為編號 第二個是數量
            bool isWin = true;
            bool[] stackCheck = { false, false, false, false };
            for (int i = 0; i < stacks.Length; i++) {
                for (int j = 0; j < stacks[i].Count; j++) {
                    if (!(dictionaryOfStacks.ContainsKey(stacks[i][j]))) {
                        dictionaryOfStacks.Add(stacks[i][j], 1);
                    } else {
                        dictionaryOfStacks[stacks[i][j]] = (dictionaryOfStacks[stacks[i][j]] + 1);
                    }
                }
            }
            // 再來檢查
            foreach (KeyValuePair<int, int> item in dictionaryOfStacks) {
                for (int i = 0; i < stacks.Length; i++) {
                    int code = item.Key, codeNum = item.Value;
                    if (stacks[i].Count == 0) {
                        stackCheck[i] = true;
                    }
                    for (int j = 0; j < stacks[i].Count; j++) {
                        if (code == stacks[i][j]) {
                            codeNum--;
                        }
                    }
                    if (codeNum == 0) {
                        stackCheck[i] = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < 4; i++) {
                if (stackCheck[i] == false) {
                    isWin = false;
                    break;
                }
            }
            dictionaryOfStacks.Clear();
            return isWin;

        }
        public Game (List<Label> displayList, string[] input) {
            // 將 element 放上四個堆疊
            for (int i = 0; i < 4; i++) {
                stacks[i] = new List<int>(); // 忘記加這行很嚴重...
                for (int j = 0, k = input[i].Length - 1; j < input[i].Length; j += 2, k -= 2) {
                    stacks[i].Add(int.Parse((input[i][k]).ToString()));
                    displayList[i].Text += "\n" + int.Parse((input[i][k]).ToString());
                }
            }
        }
    }
}
