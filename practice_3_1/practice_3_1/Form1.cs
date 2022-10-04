using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace practice_3_1 {
    public partial class Form1 : Form {
        // 存放用戶資訊的 list
        List<Account> accountList = new List<Account>();
        public Form1 () {
            InitializeComponent();
        }
        bool isFirstLayout = true;
        private void AddOrDeleteButton_Click (object sender, EventArgs e) {
            // 切換畫面 
            // 隱藏畫面一元件
            if (isFirstLayout) {
                searchTextbox.Enabled = false;
                searchButton.Enabled = false;
                riskyAccountsButton.Enabled = false;
                searchResultLabel.Visible = false;
                searchResultContent.Visible = false;
                // 畫面二元件可視化
                statusContent.Visible = true;
                userLabel.Visible = true;
                userTextBox.Visible = true;
                linkLabel.Visible = true;
                linkTextBox.Visible = true;
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;
                addButton.Visible = true;
                deleteButton.Visible = true;
                // 改變按鈕文字
                AddOrDeleteButton.Text = "回主畫面";

                isFirstLayout = false;
            } else {
                // 反向操作上面的程式碼
                searchTextbox.Enabled = true;
                searchButton.Enabled = true;
                riskyAccountsButton.Enabled = true;
                searchResultLabel.Visible = true;
                searchResultContent.Visible = true;
                // 畫面二元件可視化
                statusContent.Visible = false;
                userLabel.Visible = false;
                userTextBox.Visible = false;
                linkLabel.Visible = false;
                linkTextBox.Visible = false;
                passwordLabel.Visible = false;
                passwordTextBox.Visible = false;
                addButton.Visible = false;
                deleteButton.Visible = false;
                AddOrDeleteButton.Text = "新增或刪除";

                isFirstLayout = true;
            }
        }

        private void Form1_Load (object sender, EventArgs e) {
            searchResultContent.Text = "";
            statusContent.Visible = false;
            userLabel.Visible = false;
            userTextBox.Visible = false;
            linkLabel.Visible = false;
            linkTextBox.Visible = false;
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
            addButton.Visible = false;
            deleteButton.Visible = false;
            //Account defaultAccount = new Account() { };
            //accountList.Add(defaultAccount);
        }

        private void addButton_Click (object sender, EventArgs e) {
            bool check = true;
            string inputLink, inputUser, inputPassword;
            inputLink = linkTextBox.Text;
            inputUser = userTextBox.Text;
            inputPassword = passwordTextBox.Text;
            if (inputLink == "" || inputUser == "" || inputPassword == "") {
                check = false;
                statusContent.Text = "輸入不可為空";
            }
            // 找全部的 連結和帳號依樣就挑出來
            foreach (Account item in accountList) {
                if (item.link == inputLink && item.user == inputUser) {
                    // 重複了
                    check = false;
                    statusContent.Text = "帳號已存在";
                    break;
                }
            }
            if (check) {
                Account account = new Account(inputLink, inputUser, inputPassword);
                accountList.Add(account);
                statusContent.Text = "新增完成";
                linkTextBox.Clear();
                userTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        private void deleteButton_Click (object sender, EventArgs e) {
            bool check = true;
            string inputLink, inputUser, inputPassword;
            inputLink = linkTextBox.Text;
            inputUser = userTextBox.Text;
            inputPassword = passwordTextBox.Text;
            foreach (Account item in accountList) {
                if (item.link == inputLink && item.user == inputUser && item.password == inputPassword) {
                    // 重複了
                    check = false;
                    accountList.Remove(item);
                    statusContent.Text = "刪除完成";
                    linkTextBox.Clear();
                    userTextBox.Clear();
                    passwordTextBox.Clear();
                    break;
                }
            }
            if (check) {
                statusContent.Text = "帳號不存在或密碼錯誤";
            }
        }

        private void searchButton_Click (object sender, EventArgs e) {
            string inputSearch = searchTextbox.Text;
            searchResultContent.Text = "";
                foreach (Account item in accountList) {
                    if (item.link.IndexOf(inputSearch) != -1) {
                        // 存在就把結果加入這個方塊
                        searchResultContent.Text += "" +
                            "連結: " + item.link + "\n" +
                            "使用者: " + item.user + "\n" +
                            "密碼: " + item.password + "\n" +
                            "================================\n";
                    }
                }
            
        }

        private void riskyAccountsButton_Click (object sender, EventArgs e) {
            searchResultContent.Text = "";
            foreach (Account itemCheck in accountList) {
                foreach (Account target in accountList) {
                    // 自己就跳過
                    if (target != itemCheck) {
                        if (target.password == itemCheck.password) {
                            searchResultContent.Text += "" +
                           "連結: " + itemCheck.link + "\n" +
                           "使用者: " + itemCheck.user + "\n" +
                           "密碼: " + itemCheck.password + "\n" +
                           "================================\n";
                        }
                    }
                }
            }
        }
    }
}
