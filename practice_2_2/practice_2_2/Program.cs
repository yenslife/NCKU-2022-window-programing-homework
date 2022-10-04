using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2_2 {
    class Program {
        static void Main (string[] args) {
            // 初始化陣列
            bool player_order = true, endGame = false;
            string winner;
            int O_sum = 0, X_sum = 0;
            string[,] board = new string[8, 8];
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    board[i, j] = "-";
                }
            }
            while (true) {
                /*if (endGame) {
                    Console.WriteLine("  A B C D E F G H");
                    for (int i = 0; i < 8; i++) {
                        Console.Write("{0} ", i + 1);
                        for (int j = 0; j < 8; j++) {
                            Console.Write("{0} ", board[i, j]);
                        }
                        Console.WriteLine();
                    }
                    if (O_sum > X_sum) {
                        Console.WriteLine("遊戲結束 玩家O獲勝!");
                    } else if (X_sum > O_sum) {
                        Console.WriteLine("遊戲結束 玩家X獲勝!");
                    }
                    Console.ReadLine();
                    break;
                }*/
                bool errorStep = false;
                Console.WriteLine("  A B C D E F G H");
                for (int i = 0; i < 8; i++) {
                    Console.Write("{0} ", i + 1);
                    for (int j = 0; j < 8; j++) {
                        Console.Write("{0} ", board[i, j]);
                    }
                    Console.WriteLine();
                }
                if (endGame) {
                    if (O_sum > X_sum) {
                        Console.WriteLine("遊戲結束 玩家O獲勝!");
                    } else if (X_sum > O_sum) {
                        Console.WriteLine("遊戲結束 玩家X獲勝!");
                    }
                    Console.ReadLine();
                    break;
                }
                string rowCode, columnCode, input;
                string row = "12345678", column = "ABCDEFGH";
                if (player_order) Console.WriteLine("輪到玩家 O 請輸入要下的位置:");
                else Console.WriteLine("輪到玩家 X 請輸入要下的位置:");
                input = Console.ReadLine();
                rowCode = input.Remove(0, 1);
                columnCode = input.Remove(1, 1);
                if (player_order && board[row.IndexOf(rowCode), column.IndexOf(columnCode)] == "-") {
                    board[row.IndexOf(rowCode), column.IndexOf(columnCode)] = "O";
                    // player_order = false;
                } else if (!player_order && board[row.IndexOf(rowCode), column.IndexOf(columnCode)] == "-") {
                    board[row.IndexOf(rowCode), column.IndexOf(columnCode)] = "X";
                    // player_order = true;
                } else {
                    errorStep = true;
                }
                if (errorStep) {
                    player_order = !player_order;
                    Console.WriteLine("此位置已有棋子! 按任鍵繼續遊戲");
                    Console.ReadLine();
                }

                // 套用規則 沒有走錯的話
                string teamSign = "O", enemySign = "X";
                if (!player_order) {
                    teamSign = "X";
                    enemySign = "O";
                }
                if (!errorStep) {
                    // 上下左右檢查有沒有我方棋子，如果有就將中間的敵方棋子變成我方棋子
                    bool allyExist = false;
                    // 上
                    int tmpEdge = 0;
                    for (int i = row.IndexOf(rowCode); i >= 0; i--) {
                        if (board[i, column.IndexOf(columnCode)] == teamSign) {
                            allyExist = true;
                            //i = row.IndexOf(rowCode);
                            tmpEdge = i;
                        }
                    }
                    for (int i = row.IndexOf(rowCode); i >= tmpEdge; i--) {
                        if (allyExist && board[i, column.IndexOf(columnCode)] == enemySign) {
                            board[i, column.IndexOf(columnCode)] = teamSign;
                        }
                    }

                    // 下
                    allyExist = false;
                    for (int i = row.IndexOf(rowCode); i <= 7; i++) {
                        if (board[i, column.IndexOf(columnCode)] == teamSign) {
                            allyExist = true;
                            //i = row.IndexOf(rowCode);
                            tmpEdge = i;
                        }
                    }
                    for (int i = row.IndexOf(rowCode); i <= tmpEdge; i++) {
                        if (allyExist && board[i, column.IndexOf(columnCode)] == enemySign) {
                            board[i, column.IndexOf(columnCode)] = teamSign;
                        }
                    }

                    // 左
                    allyExist = false;
                    for (int j = column.IndexOf(columnCode); j >= 0; j--) {
                        if (board[row.IndexOf(rowCode), j] == teamSign) {
                            allyExist = true;
                            tmpEdge = j;
                        }
                    }
                    for (int j = column.IndexOf(columnCode); j >= tmpEdge; j--) {
                        if (allyExist && board[row.IndexOf(rowCode), j] == enemySign) {
                            board[row.IndexOf(rowCode), j] = teamSign;
                        }
                    }

                    // 右
                    allyExist = false;
                    for (int j = column.IndexOf(columnCode); j <= 7; j++) {
                        if (board[row.IndexOf(rowCode), j] == teamSign) {
                            allyExist = true;
                            tmpEdge = j;
                        }
                    }
                    for (int j = column.IndexOf(columnCode); j <= tmpEdge; j++) {
                        if (allyExist && board[row.IndexOf(rowCode), j] == enemySign) {
                            board[row.IndexOf(rowCode), j] = teamSign;
                        }
                    }
                }
                // check 遊戲是否結束 並找出 winner
                endGame = true;
                O_sum = 0;
                X_sum = 0;
                for (int i = 0; i < 8; i++) {
                    for (int j = 0; j < 8; j++) {
                        if (board[i,j] == "-") {
                            endGame = false;
                        } else if (board[i, j] == "X") {
                            X_sum++;
                        } else if (board[i, j] == "O") {
                            O_sum++;
                        }
                    }
                }

                player_order = !player_order;
                Console.Clear();
            }
            
        }
    }
}
