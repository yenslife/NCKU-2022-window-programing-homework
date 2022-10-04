namespace practice_3_2 {
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
            this.statusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.stack1Label = new System.Windows.Forms.Label();
            this.stack2Label = new System.Windows.Forms.Label();
            this.stack3Label = new System.Windows.Forms.Label();
            this.stack4Label = new System.Windows.Forms.Label();
            this.stack1Input = new System.Windows.Forms.TextBox();
            this.stack2Input = new System.Windows.Forms.TextBox();
            this.stack3Input = new System.Windows.Forms.TextBox();
            this.stack4Input = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.stack1display = new System.Windows.Forms.Label();
            this.stack2display = new System.Windows.Forms.Label();
            this.stack3display = new System.Windows.Forms.Label();
            this.stack4display = new System.Windows.Forms.Label();
            this.stackButton1 = new System.Windows.Forms.Button();
            this.stackButton2 = new System.Windows.Forms.Button();
            this.stackButton3 = new System.Windows.Forms.Button();
            this.stackButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusRichTextBox
            // 
            this.statusRichTextBox.Location = new System.Drawing.Point(43, 29);
            this.statusRichTextBox.Name = "statusRichTextBox";
            this.statusRichTextBox.ReadOnly = true;
            this.statusRichTextBox.Size = new System.Drawing.Size(279, 33);
            this.statusRichTextBox.TabIndex = 0;
            this.statusRichTextBox.Text = "";
            // 
            // stack1Label
            // 
            this.stack1Label.AutoSize = true;
            this.stack1Label.Location = new System.Drawing.Point(40, 85);
            this.stack1Label.Name = "stack1Label";
            this.stack1Label.Size = new System.Drawing.Size(35, 12);
            this.stack1Label.TabIndex = 1;
            this.stack1Label.Text = "堆疊1";
            // 
            // stack2Label
            // 
            this.stack2Label.AutoSize = true;
            this.stack2Label.Location = new System.Drawing.Point(40, 125);
            this.stack2Label.Name = "stack2Label";
            this.stack2Label.Size = new System.Drawing.Size(35, 12);
            this.stack2Label.TabIndex = 2;
            this.stack2Label.Text = "堆疊2";
            // 
            // stack3Label
            // 
            this.stack3Label.AutoSize = true;
            this.stack3Label.Location = new System.Drawing.Point(40, 170);
            this.stack3Label.Name = "stack3Label";
            this.stack3Label.Size = new System.Drawing.Size(35, 12);
            this.stack3Label.TabIndex = 3;
            this.stack3Label.Text = "堆疊3";
            // 
            // stack4Label
            // 
            this.stack4Label.AutoSize = true;
            this.stack4Label.Location = new System.Drawing.Point(40, 212);
            this.stack4Label.Name = "stack4Label";
            this.stack4Label.Size = new System.Drawing.Size(35, 12);
            this.stack4Label.TabIndex = 4;
            this.stack4Label.Text = "堆疊4";
            // 
            // stack1Input
            // 
            this.stack1Input.Location = new System.Drawing.Point(103, 82);
            this.stack1Input.Name = "stack1Input";
            this.stack1Input.Size = new System.Drawing.Size(219, 22);
            this.stack1Input.TabIndex = 5;
            this.stack1Input.Text = "1 1 2";
            // 
            // stack2Input
            // 
            this.stack2Input.Location = new System.Drawing.Point(103, 122);
            this.stack2Input.Name = "stack2Input";
            this.stack2Input.Size = new System.Drawing.Size(219, 22);
            this.stack2Input.TabIndex = 6;
            this.stack2Input.Text = "2 2";
            // 
            // stack3Input
            // 
            this.stack3Input.Location = new System.Drawing.Point(103, 167);
            this.stack3Input.Name = "stack3Input";
            this.stack3Input.Size = new System.Drawing.Size(219, 22);
            this.stack3Input.TabIndex = 7;
            // 
            // stack4Input
            // 
            this.stack4Input.Location = new System.Drawing.Point(103, 209);
            this.stack4Input.Name = "stack4Input";
            this.stack4Input.Size = new System.Drawing.Size(219, 22);
            this.stack4Input.TabIndex = 8;
            this.stack4Input.Text = "3 3 3 1";
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(119, 259);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(114, 22);
            this.mainButton.TabIndex = 9;
            this.mainButton.Text = "開始遊戲";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.gameStartBbtton_Click);
            // 
            // stack1display
            // 
            this.stack1display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stack1display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stack1display.Location = new System.Drawing.Point(40, 80);
            this.stack1display.Name = "stack1display";
            this.stack1display.Size = new System.Drawing.Size(35, 243);
            this.stack1display.TabIndex = 10;
            this.stack1display.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // stack2display
            // 
            this.stack2display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stack2display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stack2display.Location = new System.Drawing.Point(120, 80);
            this.stack2display.Name = "stack2display";
            this.stack2display.Size = new System.Drawing.Size(35, 243);
            this.stack2display.TabIndex = 11;
            this.stack2display.Text = "label1";
            this.stack2display.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // stack3display
            // 
            this.stack3display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stack3display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stack3display.Location = new System.Drawing.Point(200, 80);
            this.stack3display.Name = "stack3display";
            this.stack3display.Size = new System.Drawing.Size(35, 243);
            this.stack3display.TabIndex = 12;
            this.stack3display.Text = "label1";
            this.stack3display.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // stack4display
            // 
            this.stack4display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stack4display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stack4display.Location = new System.Drawing.Point(280, 80);
            this.stack4display.Name = "stack4display";
            this.stack4display.Size = new System.Drawing.Size(35, 243);
            this.stack4display.TabIndex = 13;
            this.stack4display.Text = "stack4";
            this.stack4display.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // stackButton1
            // 
            this.stackButton1.Location = new System.Drawing.Point(40, 340);
            this.stackButton1.Name = "stackButton1";
            this.stackButton1.Size = new System.Drawing.Size(42, 23);
            this.stackButton1.TabIndex = 14;
            this.stackButton1.Text = "選取";
            this.stackButton1.UseVisualStyleBackColor = true;
            this.stackButton1.Click += new System.EventHandler(this.stackButton1_Click);
            // 
            // stackButton2
            // 
            this.stackButton2.Location = new System.Drawing.Point(120, 340);
            this.stackButton2.Name = "stackButton2";
            this.stackButton2.Size = new System.Drawing.Size(42, 23);
            this.stackButton2.TabIndex = 15;
            this.stackButton2.Text = "選取";
            this.stackButton2.UseVisualStyleBackColor = true;
            this.stackButton2.Click += new System.EventHandler(this.stackButton2_Click);
            // 
            // stackButton3
            // 
            this.stackButton3.Location = new System.Drawing.Point(200, 340);
            this.stackButton3.Name = "stackButton3";
            this.stackButton3.Size = new System.Drawing.Size(42, 23);
            this.stackButton3.TabIndex = 16;
            this.stackButton3.Text = "選取";
            this.stackButton3.UseVisualStyleBackColor = true;
            this.stackButton3.Click += new System.EventHandler(this.stackButton3_Click);
            // 
            // stackButton4
            // 
            this.stackButton4.Location = new System.Drawing.Point(280, 340);
            this.stackButton4.Name = "stackButton4";
            this.stackButton4.Size = new System.Drawing.Size(42, 23);
            this.stackButton4.TabIndex = 17;
            this.stackButton4.Text = "選取";
            this.stackButton4.UseVisualStyleBackColor = true;
            this.stackButton4.Click += new System.EventHandler(this.stackButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 457);
            this.Controls.Add(this.stackButton4);
            this.Controls.Add(this.stackButton3);
            this.Controls.Add(this.stackButton2);
            this.Controls.Add(this.stackButton1);
            this.Controls.Add(this.stack4display);
            this.Controls.Add(this.stack3display);
            this.Controls.Add(this.stack2display);
            this.Controls.Add(this.stack1display);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.stack4Input);
            this.Controls.Add(this.stack3Input);
            this.Controls.Add(this.stack2Input);
            this.Controls.Add(this.stack1Input);
            this.Controls.Add(this.stack4Label);
            this.Controls.Add(this.stack3Label);
            this.Controls.Add(this.stack2Label);
            this.Controls.Add(this.stack1Label);
            this.Controls.Add(this.statusRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox statusRichTextBox;
        private System.Windows.Forms.Label stack1Label;
        private System.Windows.Forms.Label stack2Label;
        private System.Windows.Forms.Label stack3Label;
        private System.Windows.Forms.Label stack4Label;
        private System.Windows.Forms.TextBox stack1Input;
        private System.Windows.Forms.TextBox stack2Input;
        private System.Windows.Forms.TextBox stack3Input;
        private System.Windows.Forms.TextBox stack4Input;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Label stack1display;
        private System.Windows.Forms.Label stack2display;
        private System.Windows.Forms.Label stack3display;
        private System.Windows.Forms.Label stack4display;
        private System.Windows.Forms.Button stackButton1;
        private System.Windows.Forms.Button stackButton2;
        private System.Windows.Forms.Button stackButton3;
        private System.Windows.Forms.Button stackButton4;
    }
}

