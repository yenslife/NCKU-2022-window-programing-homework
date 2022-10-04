using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_1_1 {
    class Program {
        static void Main (string[] args) {
            string inputNum = "0", moneySpent = "0";
            int cash = 0;
            double[] array = new double[6] { 0, 0, 0, 0, 0, 0 };

            while (inputNum != "5") {

                string options = "0";
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)計算比例 (4)剩餘金額 (5)退出程式");
                Console.WriteLine("輸入數字選擇功能");
                inputNum = Console.ReadLine();
                if (inputNum == "1") {
                    Console.WriteLine("輸入金額: ");
                    cash += (int)Int64.Parse(Console.ReadLine());
                } else if (inputNum == "2") {
                    Console.WriteLine("(1)食 (2)衣 (3)住 (4)行 (5)育樂");
                    Console.WriteLine("輸入數字選擇支出項目");
                    options = Console.ReadLine();
                    Console.WriteLine("輸入支出金額: ");
                    moneySpent = Console.ReadLine();
                    array[Int64.Parse(options)] = (int)Int64.Parse(moneySpent);
                    cash -= (int)Int64.Parse(moneySpent);

                } else if (inputNum == "3") {
                    double spendsum = array[1] + array[2] + array[3] + array[4] + array[5];
                    if (spendsum == 0) {
                        Console.WriteLine("食: " + 0 + "%");
                        Console.WriteLine("衣: " + 0 + "%");
                        Console.WriteLine("住: " + 0 + "%");
                        Console.WriteLine("行: " + 0 + "%");
                        Console.WriteLine("育樂: " + 0 + "%");
                    } else {
                        Console.WriteLine("食: " + (double)array[1] / (double)spendsum * 100 + "%");
                        Console.WriteLine("衣: " + (double)array[2] / (double)spendsum * 100 + "%");
                        Console.WriteLine("住: " + (double)array[3] / (double)spendsum * 100 + "%");
                        Console.WriteLine("行: " + (double)array[4] / (double)spendsum * 100 + "%");
                        Console.WriteLine("育樂: " + (double)array[5] / (double)spendsum * 100 + "%");
                    }
                } else if (inputNum == "4") {
                    Console.WriteLine("剩餘金額為: " + cash);
                }
            }
        }
    }
}