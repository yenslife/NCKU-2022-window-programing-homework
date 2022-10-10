namespace practice_4_2 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.scoreBoeadRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fruitImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exitButton);
            this.tabPage1.Controls.Add(this.restartButton);
            this.tabPage1.Controls.Add(this.continueButton);
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Controls.Add(this.userNameTextBox);
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Controls.Add(this.scoreLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "遊玩區";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(587, 286);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 34);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "離開遊戲";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(587, 140);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(97, 34);
            this.restartButton.TabIndex = 5;
            this.restartButton.Text = "重新開始";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(587, 90);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(97, 34);
            this.continueButton.TabIndex = 4;
            this.continueButton.Text = "繼續";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(587, 43);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 34);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "開始遊戲";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(217, 23);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.userNameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("新細明體", 14F);
            this.nameLabel.Location = new System.Drawing.Point(136, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Tag = " ";
            this.nameLabel.Text = "名稱:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("新細明體", 14F);
            this.scoreLabel.Location = new System.Drawing.Point(30, 23);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Tag = " ";
            this.scoreLabel.Text = "分數 : 100";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.scoreBoeadRichTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "歷史紀錄區";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // scoreBoeadRichTextBox
            // 
            this.scoreBoeadRichTextBox.Location = new System.Drawing.Point(38, 18);
            this.scoreBoeadRichTextBox.Name = "scoreBoeadRichTextBox";
            this.scoreBoeadRichTextBox.Size = new System.Drawing.Size(660, 378);
            this.scoreBoeadRichTextBox.TabIndex = 0;
            this.scoreBoeadRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "翻牌小遊戲";
            // 
            // fruitImageList
            // 
            this.fruitImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitImageList.ImageStream")));
            this.fruitImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitImageList.Images.SetKeyName(0, "01.jpg");
            this.fruitImageList.Images.SetKeyName(1, "02.jpg");
            this.fruitImageList.Images.SetKeyName(2, "03.jpg");
            this.fruitImageList.Images.SetKeyName(3, "04.jpg");
            this.fruitImageList.Images.SetKeyName(4, "05.jpg");
            this.fruitImageList.Images.SetKeyName(5, "06.jpg");
            this.fruitImageList.Images.SetKeyName(6, "07.jpg");
            this.fruitImageList.Images.SetKeyName(7, "08.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList fruitImageList;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.RichTextBox scoreBoeadRichTextBox;
    }
}

