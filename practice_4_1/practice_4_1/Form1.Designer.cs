﻿namespace practice_4_1 {
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("新細明體", 15F);
            this.titleLabel.Location = new System.Drawing.Point(29, 25);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(116, 34);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "翻牌小遊戲\r\n";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(583, 112);
            this.startButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 52);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "開始遊戲";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(583, 205);
            this.continueButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(114, 47);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "繼續";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(583, 303);
            this.exitButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 48);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開遊戲";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.jpg");
            this.imageList1.Images.SetKeyName(1, "02.jpg");
            this.imageList1.Images.SetKeyName(2, "03.jpg");
            this.imageList1.Images.SetKeyName(3, "04.jpg");
            this.imageList1.Images.SetKeyName(4, "05.jpg");
            this.imageList1.Images.SetKeyName(5, "06.jpg");
            this.imageList1.Images.SetKeyName(6, "07.jpg");
            this.imageList1.Images.SetKeyName(7, "08.jpg");
            // 
            // button1
            // 
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(70, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 90);
            this.button1.TabIndex = 4;
            this.button1.Text = "\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(142, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 90);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(230, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 90);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(313, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 90);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(70, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 90);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(142, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 90);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(230, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 90);
            this.button7.TabIndex = 10;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(313, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 90);
            this.button8.TabIndex = 11;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.ImageList = this.imageList1;
            this.button9.Location = new System.Drawing.Point(70, 261);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 90);
            this.button9.TabIndex = 12;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.ImageList = this.imageList1;
            this.button10.Location = new System.Drawing.Point(142, 261);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 90);
            this.button10.TabIndex = 13;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.ImageList = this.imageList1;
            this.button11.Location = new System.Drawing.Point(230, 261);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 90);
            this.button11.TabIndex = 14;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.ImageList = this.imageList1;
            this.button12.Location = new System.Drawing.Point(313, 261);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(63, 90);
            this.button12.TabIndex = 15;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.ImageList = this.imageList1;
            this.button13.Location = new System.Drawing.Point(70, 355);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(63, 90);
            this.button13.TabIndex = 16;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.ImageList = this.imageList1;
            this.button14.Location = new System.Drawing.Point(142, 355);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(63, 90);
            this.button14.TabIndex = 17;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.ImageList = this.imageList1;
            this.button15.Location = new System.Drawing.Point(230, 355);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(63, 90);
            this.button15.TabIndex = 18;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.ImageList = this.imageList1;
            this.button16.Location = new System.Drawing.Point(313, 355);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(63, 90);
            this.button16.TabIndex = 19;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 478);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

