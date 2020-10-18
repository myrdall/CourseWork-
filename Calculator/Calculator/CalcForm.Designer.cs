namespace Calculator
{
    partial class CalcForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.summButton = new System.Windows.Forms.Button();
            this.displayX = new System.Windows.Forms.TextBox();
            this.displayY = new System.Windows.Forms.TextBox();
            this.displayAnswer = new System.Windows.Forms.TextBox();
            this.subButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.factotialButton = new System.Windows.Forms.Button();
            this.expButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.log10Button = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.tgButton = new System.Windows.Forms.Button();
            this.ctgButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summButton
            // 
            this.summButton.Location = new System.Drawing.Point(53, 188);
            this.summButton.Name = "summButton";
            this.summButton.Size = new System.Drawing.Size(80, 51);
            this.summButton.TabIndex = 0;
            this.summButton.Text = "+";
            this.summButton.UseVisualStyleBackColor = true;
            this.summButton.Click += new System.EventHandler(this.SummButton_Click);
            // 
            // displayX
            // 
            this.displayX.Location = new System.Drawing.Point(53, 55);
            this.displayX.Multiline = true;
            this.displayX.Name = "displayX";
            this.displayX.Size = new System.Drawing.Size(223, 35);
            this.displayX.TabIndex = 1;
            this.displayX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisplayX_KeyPress);
            // 
            // displayY
            // 
            this.displayY.Location = new System.Drawing.Point(53, 113);
            this.displayY.Multiline = true;
            this.displayY.Name = "displayY";
            this.displayY.Size = new System.Drawing.Size(223, 35);
            this.displayY.TabIndex = 2;
            this.displayY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisplayY_KeyPress);
            // 
            // displayAnswer
            // 
            this.displayAnswer.Location = new System.Drawing.Point(12, 480);
            this.displayAnswer.Multiline = true;
            this.displayAnswer.Name = "displayAnswer";
            this.displayAnswer.Size = new System.Drawing.Size(223, 35);
            this.displayAnswer.TabIndex = 3;
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(155, 188);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(80, 51);
            this.subButton.TabIndex = 4;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            // 
            // multButton
            // 
            this.multButton.Location = new System.Drawing.Point(261, 188);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(80, 51);
            this.multButton.TabIndex = 5;
            this.multButton.Text = "*";
            this.multButton.UseVisualStyleBackColor = true;
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(362, 188);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(80, 51);
            this.divButton.TabIndex = 6;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            // 
            // sqrtButton
            // 
            this.sqrtButton.Location = new System.Drawing.Point(53, 266);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(80, 51);
            this.sqrtButton.TabIndex = 7;
            this.sqrtButton.Text = "sqrt";
            this.sqrtButton.UseVisualStyleBackColor = true;
            // 
            // factotialButton
            // 
            this.factotialButton.Location = new System.Drawing.Point(155, 266);
            this.factotialButton.Name = "factotialButton";
            this.factotialButton.Size = new System.Drawing.Size(80, 51);
            this.factotialButton.TabIndex = 8;
            this.factotialButton.Text = "n!";
            this.factotialButton.UseVisualStyleBackColor = true;
            // 
            // expButton
            // 
            this.expButton.Location = new System.Drawing.Point(261, 266);
            this.expButton.Name = "expButton";
            this.expButton.Size = new System.Drawing.Size(80, 51);
            this.expButton.TabIndex = 9;
            this.expButton.Text = "^";
            this.expButton.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(362, 266);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(80, 51);
            this.logButton.TabIndex = 10;
            this.logButton.Text = "log";
            this.logButton.UseVisualStyleBackColor = true;
            // 
            // log10Button
            // 
            this.log10Button.Location = new System.Drawing.Point(53, 340);
            this.log10Button.Name = "log10Button";
            this.log10Button.Size = new System.Drawing.Size(80, 51);
            this.log10Button.TabIndex = 11;
            this.log10Button.Text = "log10";
            this.log10Button.UseVisualStyleBackColor = true;
            // 
            // cosButton
            // 
            this.cosButton.Location = new System.Drawing.Point(155, 340);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(80, 51);
            this.cosButton.TabIndex = 12;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
            // 
            // sinButton
            // 
            this.sinButton.Location = new System.Drawing.Point(261, 340);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(80, 51);
            this.sinButton.TabIndex = 13;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
            // 
            // tgButton
            // 
            this.tgButton.Location = new System.Drawing.Point(362, 340);
            this.tgButton.Name = "tgButton";
            this.tgButton.Size = new System.Drawing.Size(80, 51);
            this.tgButton.TabIndex = 14;
            this.tgButton.Text = "tg";
            this.tgButton.UseVisualStyleBackColor = true;
            // 
            // ctgButton
            // 
            this.ctgButton.Location = new System.Drawing.Point(155, 408);
            this.ctgButton.Name = "ctgButton";
            this.ctgButton.Size = new System.Drawing.Size(80, 51);
            this.ctgButton.TabIndex = 15;
            this.ctgButton.Text = "ctg";
            this.ctgButton.UseVisualStyleBackColor = true;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 561);
            this.Controls.Add(this.ctgButton);
            this.Controls.Add(this.tgButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.log10Button);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.expButton);
            this.Controls.Add(this.factotialButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.displayAnswer);
            this.Controls.Add(this.displayY);
            this.Controls.Add(this.displayX);
            this.Controls.Add(this.summButton);
            this.Name = "CalcForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button summButton;
        private System.Windows.Forms.TextBox displayX;
        private System.Windows.Forms.TextBox displayY;
        private System.Windows.Forms.TextBox displayAnswer;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button factotialButton;
        private System.Windows.Forms.Button expButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button log10Button;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button tgButton;
        private System.Windows.Forms.Button ctgButton;
    }
}

