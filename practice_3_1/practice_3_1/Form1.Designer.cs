namespace practice_3_1 {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent () {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchResultContent = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.riskyAccountsButton = new System.Windows.Forms.Button();
            this.AddOrDeleteButton = new System.Windows.Forms.Button();
            this.statusContent = new System.Windows.Forms.RichTextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼管理員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "搜尋列";
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(25, 141);
            this.searchResultLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(53, 12);
            this.searchResultLabel.TabIndex = 2;
            this.searchResultLabel.Text = "搜尋結果";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(78, 50);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(550, 22);
            this.searchTextbox.TabIndex = 3;
            // 
            // searchResultContent
            // 
            this.searchResultContent.BackColor = System.Drawing.SystemColors.Window;
            this.searchResultContent.Location = new System.Drawing.Point(25, 174);
            this.searchResultContent.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.searchResultContent.Name = "searchResultContent";
            this.searchResultContent.Size = new System.Drawing.Size(753, 292);
            this.searchResultContent.TabIndex = 4;
            this.searchResultContent.Text = "label4";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(655, 42);
            this.searchButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 34);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "搜尋";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // riskyAccountsButton
            // 
            this.riskyAccountsButton.Location = new System.Drawing.Point(27, 95);
            this.riskyAccountsButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.riskyAccountsButton.Name = "riskyAccountsButton";
            this.riskyAccountsButton.Size = new System.Drawing.Size(741, 24);
            this.riskyAccountsButton.TabIndex = 6;
            this.riskyAccountsButton.Text = "風險帳號";
            this.riskyAccountsButton.UseVisualStyleBackColor = true;
            this.riskyAccountsButton.Click += new System.EventHandler(this.riskyAccountsButton_Click);
            // 
            // AddOrDeleteButton
            // 
            this.AddOrDeleteButton.Location = new System.Drawing.Point(583, 136);
            this.AddOrDeleteButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AddOrDeleteButton.Name = "AddOrDeleteButton";
            this.AddOrDeleteButton.Size = new System.Drawing.Size(185, 22);
            this.AddOrDeleteButton.TabIndex = 7;
            this.AddOrDeleteButton.Text = "新增或刪除";
            this.AddOrDeleteButton.UseVisualStyleBackColor = true;
            this.AddOrDeleteButton.Click += new System.EventHandler(this.AddOrDeleteButton_Click);
            // 
            // statusContent
            // 
            this.statusContent.Location = new System.Drawing.Point(198, 190);
            this.statusContent.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.statusContent.Name = "statusContent";
            this.statusContent.Size = new System.Drawing.Size(404, 49);
            this.statusContent.TabIndex = 8;
            this.statusContent.Text = "我是狀態列";
            // 
            // linkLabel
            // 
            this.linkLabel.Location = new System.Drawing.Point(196, 263);
            this.linkLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(117, 44);
            this.linkLabel.TabIndex = 9;
            this.linkLabel.Text = "連結";
            // 
            // userLabel
            // 
            this.userLabel.Location = new System.Drawing.Point(196, 301);
            this.userLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(111, 44);
            this.userLabel.TabIndex = 10;
            this.userLabel.Text = "使用者";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(196, 339);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(111, 44);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "密碼";
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(262, 273);
            this.linkTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(342, 22);
            this.linkTextBox.TabIndex = 12;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(262, 315);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(342, 22);
            this.userTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(262, 353);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(342, 22);
            this.passwordTextBox.TabIndex = 14;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(500, 385);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 44);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "刪除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(368, 385);
            this.addButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 44);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 488);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.statusContent);
            this.Controls.Add(this.AddOrDeleteButton);
            this.Controls.Add(this.riskyAccountsButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchResultContent);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label searchResultContent;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button riskyAccountsButton;
        private System.Windows.Forms.Button AddOrDeleteButton;
        private System.Windows.Forms.RichTextBox statusContent;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
    }
}

