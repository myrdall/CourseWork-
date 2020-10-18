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
            this.clearButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summButton
            // 
            this.summButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summButton.Location = new System.Drawing.Point(22, 145);
            this.summButton.Margin = new System.Windows.Forms.Padding(100);
            this.summButton.Name = "summButton";
            this.summButton.Size = new System.Drawing.Size(100, 100);
            this.summButton.TabIndex = 0;
            this.summButton.Text = "+";
            this.summButton.UseVisualStyleBackColor = true;
            this.summButton.Click += new System.EventHandler(this.SummButton_Click);
            // 
            // displayX
            // 
            this.displayX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayX.Location = new System.Drawing.Point(22, 34);
            this.displayX.Multiline = true;
            this.displayX.Name = "displayX";
            this.displayX.Size = new System.Drawing.Size(207, 75);
            this.displayX.TabIndex = 1;
            this.displayX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisplayX_KeyPress);
            // 
            // displayY
            // 
            this.displayY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayY.Location = new System.Drawing.Point(235, 34);
            this.displayY.Multiline = true;
            this.displayY.Name = "displayY";
            this.displayY.Size = new System.Drawing.Size(207, 75);
            this.displayY.TabIndex = 2;
            this.displayY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisplayY_KeyPress);
            // 
            // subButton
            // 
            this.subButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subButton.Location = new System.Drawing.Point(129, 145);
            this.subButton.Margin = new System.Windows.Forms.Padding(100);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(100, 100);
            this.subButton.TabIndex = 4;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multButton.Location = new System.Drawing.Point(235, 145);
            this.multButton.Margin = new System.Windows.Forms.Padding(100);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(100, 100);
            this.multButton.TabIndex = 5;
            this.multButton.Text = "*";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // divButton
            // 
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divButton.Location = new System.Drawing.Point(342, 145);
            this.divButton.Margin = new System.Windows.Forms.Padding(100);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(100, 100);
            this.divButton.TabIndex = 6;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrtButton.Location = new System.Drawing.Point(22, 264);
            this.sqrtButton.Margin = new System.Windows.Forms.Padding(100);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(100, 100);
            this.sqrtButton.TabIndex = 7;
            this.sqrtButton.Text = "sqrt";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // factotialButton
            // 
            this.factotialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factotialButton.Location = new System.Drawing.Point(448, 384);
            this.factotialButton.Margin = new System.Windows.Forms.Padding(100);
            this.factotialButton.Name = "factotialButton";
            this.factotialButton.Size = new System.Drawing.Size(100, 100);
            this.factotialButton.TabIndex = 8;
            this.factotialButton.Text = "n!";
            this.factotialButton.UseVisualStyleBackColor = true;
            this.factotialButton.Click += new System.EventHandler(this.FactotialButton_Click);
            // 
            // expButton
            // 
            this.expButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expButton.Location = new System.Drawing.Point(129, 264);
            this.expButton.Margin = new System.Windows.Forms.Padding(100);
            this.expButton.Name = "expButton";
            this.expButton.Size = new System.Drawing.Size(100, 100);
            this.expButton.TabIndex = 9;
            this.expButton.Text = "^";
            this.expButton.UseVisualStyleBackColor = true;
            this.expButton.Click += new System.EventHandler(this.ExpButton_Click);
            // 
            // logButton
            // 
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logButton.Location = new System.Drawing.Point(235, 264);
            this.logButton.Margin = new System.Windows.Forms.Padding(100);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(100, 100);
            this.logButton.TabIndex = 10;
            this.logButton.Text = "log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // log10Button
            // 
            this.log10Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log10Button.Location = new System.Drawing.Point(342, 264);
            this.log10Button.Margin = new System.Windows.Forms.Padding(100);
            this.log10Button.Name = "log10Button";
            this.log10Button.Size = new System.Drawing.Size(100, 100);
            this.log10Button.TabIndex = 11;
            this.log10Button.Text = "log10";
            this.log10Button.UseVisualStyleBackColor = true;
            this.log10Button.Click += new System.EventHandler(this.Log10Button_Click);
            // 
            // cosButton
            // 
            this.cosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosButton.Location = new System.Drawing.Point(129, 384);
            this.cosButton.Margin = new System.Windows.Forms.Padding(100);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(100, 100);
            this.cosButton.TabIndex = 12;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // sinButton
            // 
            this.sinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sinButton.Location = new System.Drawing.Point(235, 384);
            this.sinButton.Margin = new System.Windows.Forms.Padding(100);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(100, 100);
            this.sinButton.TabIndex = 13;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // tgButton
            // 
            this.tgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tgButton.Location = new System.Drawing.Point(342, 384);
            this.tgButton.Margin = new System.Windows.Forms.Padding(100);
            this.tgButton.Name = "tgButton";
            this.tgButton.Size = new System.Drawing.Size(100, 100);
            this.tgButton.TabIndex = 14;
            this.tgButton.Text = "tg";
            this.tgButton.UseVisualStyleBackColor = true;
            this.tgButton.Click += new System.EventHandler(this.TgButton_Click);
            // 
            // ctgButton
            // 
            this.ctgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctgButton.Location = new System.Drawing.Point(22, 384);
            this.ctgButton.Margin = new System.Windows.Forms.Padding(100);
            this.ctgButton.Name = "ctgButton";
            this.ctgButton.Size = new System.Drawing.Size(100, 100);
            this.ctgButton.TabIndex = 15;
            this.ctgButton.Text = "ctg";
            this.ctgButton.UseVisualStyleBackColor = true;
            this.ctgButton.Click += new System.EventHandler(this.CtgButton_Click);
            // 
            // clearButton1
            // 
            this.clearButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton1.Location = new System.Drawing.Point(448, 145);
            this.clearButton1.Margin = new System.Windows.Forms.Padding(100);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(100, 219);
            this.clearButton1.TabIndex = 16;
            this.clearButton1.Text = "CE";
            this.clearButton1.UseVisualStyleBackColor = true;
            this.clearButton1.Click += new System.EventHandler(this.ClearButton1_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 500);
            this.Controls.Add(this.clearButton1);
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
        private System.Windows.Forms.Button clearButton1;
    }
}

