using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2_1 {
    class Program {
        static void Main (string[] args) {
            int option = 0;
            string[,] classTable = new string[8, 7];
            // 初始化字串陣列
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 7; j++) {
                    classTable[i,j] = "     ";
                }
            }
            while (option != 5) {
                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式");
                Console.Write("請輸入數字選擇功能: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1) {
                    bool isExistClass = false, isExistOtherClass = false;
                    string input = "xx-xx x x x";
                    Console.WriteLine("請輸入要加入的課程，格式為<課程代號 星期 開始節 結束節>");
                    input = Console.ReadLine();
                    string classCode, day, start, end;

                    // 處理輸入
                    classCode = input.Remove(5, 6);
                    day = input.Remove(0, 6).Remove(1, 4); // + input.Remove(7, 4);
                    start = input.Remove(0, 8).Remove(1, 2); // + input.Remove(9, 2);
                    end = input.Remove(0, 10);
                    //Console.WriteLine("start:{0}#", end);
                    // 檢查有沒有衝堂和重複
                    for (int i = 0; i < 8; i++) {
                        for (int j = 0; j < 7; j++) {
                            if (classTable[i, j] != "     " && int.Parse(day) - 1 == j && (int.Parse(start) - 1 <= i && i <= int.Parse(end) - 1)) {
                                isExistOtherClass = true;
                            } else if (classTable[i, j] == classCode) {
                                isExistClass = true;
                            }
                        }
                    }
                    if (isExistClass) {
                        Console.WriteLine("課程重複!");
                    } else if (isExistOtherClass) {
                        Console.WriteLine("課程衝堂!");
                    } else {
                        for (int i = int.Parse(start) - 1; i <= int.Parse(end) - 1; i++) {
                            classTable[i, int.Parse(day) - 1] = classCode;
                        }
                        Console.WriteLine("成功加入課程!");
                    }
                } else if (option == 2) {
                    string input;
                    bool isExist = false;
                    Console.Write("請輸入要刪除的課程代號: ");
                    input = Console.ReadLine();
                    // 找課程，找到就刪除
                    for (int i = 0; i < 8; i++) {
                        for (int j = 0; j < 7; j++) {
                            if (classTable[i, j] == input) {
                                classTable[i, j] = "     ";
                                isExist = true;
                            }
                        }
                    }
                    if (isExist) {
                        Console.WriteLine("成功刪除課程: {0}", input);
                    } else {
                        Console.WriteLine("課程 {0} 不在課表中", input);
                    }
                } else if (option == 3) {
                    // 印出課表
                    // 印出星期
                    Console.WriteLine("      Sun   Mon   Tue   Wed   Thu   Fri   Sat");
                    // 印刻表和節次 注意式星期日在最前面，所以要從 index 6 開始 再回到 index 0
                    for (int i = 0; i < 8; i++) {
                        Console.Write("{0}     ", i + 1);
                        // index 6 開始
                        Console.Write("{0} ", classTable[i, 6]);
                        for (int j = 0; j < 6; j++) {
                            Console.Write("{0} ", classTable[i, j]);
                        }
                        Console.WriteLine();
                    }
                } else if (option == 4) {
                    // 印出學分
                    int sum = 0;
                    for (int i = 0; i < 8; i++) {
                        for (int j = 0; j < 7; j++) {
                            if (classTable[i, j] != "     ") {
                                sum++;
                            }
                        }
                    }
                    Console.WriteLine(sum);
                } else if (option == 5) break;
                Console.WriteLine();
            }
            
        }
    }
}
