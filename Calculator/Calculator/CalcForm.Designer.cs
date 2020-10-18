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
            this.SuspendLayout();
            // 
            // summButton
            // 
            this.summButton.Location = new System.Drawing.Point(125, 188);
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
            this.displayAnswer.Location = new System.Drawing.Point(53, 264);
            this.displayAnswer.Multiline = true;
            this.displayAnswer.Name = "displayAnswer";
            this.displayAnswer.Size = new System.Drawing.Size(223, 35);
            this.displayAnswer.TabIndex = 3;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 376);
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
    }
}

