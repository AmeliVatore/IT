namespace Pr_5
{
    partial class Form1
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
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.puskButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputListBox
            // 
            this.inputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.ItemHeight = 20;
            this.inputListBox.Items.AddRange(new object[] {
            "Привет! Как дела??",
            "Привет!! Хорошо! Я люблю восклицательные знаки!!!!",
            "Больше восклицательных знаков!!!!!!!!",
            "     ",
            "Некоторые предпочитают видеть уродство в этом мире. Беспорядок.",
            "Я хочу видеть красоту."});
            this.inputListBox.Location = new System.Drawing.Point(37, 59);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(608, 224);
            this.inputListBox.TabIndex = 0;
            // 
            // puskButton
            // 
            this.puskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puskButton.Location = new System.Drawing.Point(37, 319);
            this.puskButton.Name = "puskButton";
            this.puskButton.Size = new System.Drawing.Size(93, 49);
            this.puskButton.TabIndex = 1;
            this.puskButton.Text = "Пуск";
            this.puskButton.UseVisualStyleBackColor = true;
            this.puskButton.Click += new System.EventHandler(this.puskButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(282, 333);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(182, 20);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Число предложений = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 411);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.puskButton);
            this.Controls.Add(this.inputListBox);
            this.Name = "Form1";
            this.Text = "Работа со строками";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.Button puskButton;
        private System.Windows.Forms.Label numberLabel;
    }
}

