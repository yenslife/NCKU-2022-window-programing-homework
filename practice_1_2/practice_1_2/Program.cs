using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1_2 {
    class Program {
        static void Main (string[] args) {
            string inputNum = "0", moneySpent = "0";
            int cash = 0, totalSpent = 0;
            double[] spentCash = new double[6] { 0, 0, 0, 0, 0, 0 };
            string[] spentName = { "", "", "", "", "", "" };

            while (inputNum != "8") {
                string options = "0", tmp = "";
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
                Console.Write("輸入數字選擇功能: ");
                inputNum = Console.ReadLine();
                // 輸入收入
                if (inputNum == "1") {
                    Console.Write("輸入金額: ");
                    tmp = Console.ReadLine();
                    try {
                        if (int.Parse(tmp) >= 0) cash += int.Parse(tmp);
                        else Console.WriteLine("收入不可為負數");
                    } catch (Exception e) {
                        Console.WriteLine("請輸入數字");
                    }
                    // 輸入支出
                } else if (inputNum == "2") {
                    bool isEmpty = false;
                    bool isExist = false;
                    if (spentName[1] == "" && spentName[2] == "" && spentName[3] == "" && spentName[4] == "" && spentName[5] == "") isEmpty = true;
                    if (isEmpty) Console.WriteLine("請新增支出項目");
                    else {
                        for (int i = 1; i < 6; i++) {
                            if (spentName[i] != "") {
                                Console.Write("({0}){1} ", i, spentName[i]);
                            } else {
                                break;
                            }
                        }
                        Console.Write("\n");
                        Console.Write("輸入數字選擇支出項目: ");
                        options = Console.ReadLine();
                        try {
                            for (int i = 1; i < 6; i++) {
                                if (spentName[i] != "" && int.Parse(options) == i) isExist = true;
                            }
                        } catch {
                            ;
                        }
                        if (isExist) {
                            Console.Write("輸入支出金額: ");
                            moneySpent = Console.ReadLine();
                            try {
                                if (int.Parse(moneySpent) > cash) Console.WriteLine("存款不足");
                                else {
                                    spentCash[int.Parse(options)] += int.Parse(moneySpent);
                                }
                            } catch {
                                Console.WriteLine("請輸入數字");
                            }
                        } else {
                            Console.WriteLine("此數字不在範圍中");
                        }
                    }
                    // 新增項目
                } else if (inputNum == "3") {
                    bool isFull = false, isExist = false;
                    int addIndex = 1;
                    if (spentName[1] != "" && spentName[2] != "" && spentName[3] != "" && spentName[4] != "" && spentName[5] != "") isFull = true;
                    if (isFull) {
                        Console.WriteLine("已無法再新增支出項目");
                    } else {
                        Console.Write("輸入項目名稱: ");
                        tmp = Console.ReadLine();
                        for (int i = 1; i < 6; i++) {
                            if (spentName[i] == tmp) isExist = true;
                        }
                        if (isExist) {
                            Console.WriteLine("支出項目已存在");
                        } else {
                            for (addIndex = 1; addIndex < 6; addIndex++) {
                                if (spentName[addIndex] == "") {
                                    spentName[addIndex] = tmp;
                                    break;
                                }
                            }
                        }
                    }
                    // 刪除項目
                } else if (inputNum == "4") {
                    bool isEmpty = false, isExist = false;
                    if (spentName[1] == "" && spentName[2] == "" && spentName[3] == "" && spentName[4] == "" && spentName[5] == "") isEmpty = true;
                    if (isEmpty) {
                        Console.WriteLine("已無法再刪除支出項目");
                    } else {
                        Console.Write("輸入項目名稱: ");
                        tmp = Console.ReadLine();
                        // check isExist and delete item
                        for (int i = 1; i < 6; i++) {
                            if (spentName[i] == tmp) {
                                isExist = true;
                                spentName[i] = "";
                                spentCash[i] = 0;
                            }
                            if (i + 1 < 6 && spentName[i] == "" && spentName[i+1] != "" ) {
                                spentName[i] = spentName[i + 1];
                                spentName[i + 1] = "";
                                spentCash[i] = spentCash[i + 1];
                                spentCash[i + 1] = 0;
                            }
                        }
                        if (!(isExist)) {
                            Console.WriteLine("此項目不存在");
                        }
                    }
                    // 計算比例
                } else if (inputNum == "5") {
                    totalSpent = 0;
                    for (int i = 1; i < 6; i++) {
                        totalSpent += (int)spentCash[i];
                    }
                    if (totalSpent == 0) {
                        // dont forget the 0 case
                        for (int i = 1; i < 6; i++) {
                            if (spentName[i] != "") {
                                Console.WriteLine("({0}){1}: 0%", i, spentName[i]);
                            } else break;
                        }
                    } else {
                        for (int i = 1; i < 6 && spentName[i] != ""; i++) {
                            Console.WriteLine("({0}){1}: {2}%", i, spentName[i], spentCash[i] / totalSpent * 100);
                        }
                    }
                    // 查詢支出
                } else if (inputNum == "6") {
                    bool isExist = false;
                    bool isEmpty = false;
                    totalSpent = 0;
                    for (int i = 1; i < 6; i++) {
                        totalSpent += (int)spentCash[i];
                        if (spentName[i] == "") {
                            isEmpty = true;
                        }
                    }
                    Console.WriteLine("目前總支出: {0}", totalSpent);
                    if (isEmpty) {
                        Console.Write("輸入要查詢的項目: ");
                        tmp = Console.ReadLine();
                        for (int i = 1; i < 6; i++) {
                            if (spentName[i] == tmp) {
                                isExist = true;
                                Console.WriteLine("{0}: {1}", spentName[i], spentCash[i]);
                                break;
                            }
                        }
                        if (!isExist) {
                            Console.WriteLine("此項目不存在");
                        }

                    } else {
                        Console.WriteLine("此項目不存在");
                    }
                    // 剩餘金額
                } else if (inputNum == "7") {
                    totalSpent = 0;
                    for (int i = 1; i < 6; i++) {
                        totalSpent += (int)spentCash[i];
                    }
                    Console.WriteLine("剩餘金額為: {0}", cash - totalSpent);
                } else if (inputNum == "8") {
                    break;
                }
                Console.Write("\n");
            }
        }
    }
}
