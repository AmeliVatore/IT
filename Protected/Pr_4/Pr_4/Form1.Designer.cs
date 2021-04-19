namespace Pr_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.vvodTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.multiplicationRadioButton = new System.Windows.Forms.RadioButton();
            this.sumRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.raschetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод числа";
            // 
            // vvodTextBox
            // 
            this.vvodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vvodTextBox.Location = new System.Drawing.Point(159, 42);
            this.vvodTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.vvodTextBox.Name = "vvodTextBox";
            this.vvodTextBox.Size = new System.Drawing.Size(231, 26);
            this.vvodTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(44, 124);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(528, 278);
            this.resultTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.multiplicationRadioButton);
            this.groupBox1.Controls.Add(this.sumRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(609, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор";
            // 
            // multiplicationRadioButton
            // 
            this.multiplicationRadioButton.AutoSize = true;
            this.multiplicationRadioButton.Enabled = false;
            this.multiplicationRadioButton.Location = new System.Drawing.Point(8, 58);
            this.multiplicationRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.multiplicationRadioButton.Name = "multiplicationRadioButton";
            this.multiplicationRadioButton.Size = new System.Drawing.Size(201, 24);
            this.multiplicationRadioButton.TabIndex = 1;
            this.multiplicationRadioButton.Text = "Произведение ряда";
            this.multiplicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // sumRadioButton
            // 
            this.sumRadioButton.AutoSize = true;
            this.sumRadioButton.Checked = true;
            this.sumRadioButton.Location = new System.Drawing.Point(8, 26);
            this.sumRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.sumRadioButton.Name = "sumRadioButton";
            this.sumRadioButton.Size = new System.Drawing.Size(131, 24);
            this.sumRadioButton.TabIndex = 0;
            this.sumRadioButton.TabStop = true;
            this.sumRadioButton.Text = "Сумма ряда";
            this.sumRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат работы программы";
            // 
            // raschetButton
            // 
            this.raschetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raschetButton.Location = new System.Drawing.Point(643, 297);
            this.raschetButton.Margin = new System.Windows.Forms.Padding(4);
            this.raschetButton.Name = "raschetButton";
            this.raschetButton.Size = new System.Drawing.Size(185, 69);
            this.raschetButton.TabIndex = 5;
            this.raschetButton.Text = "Расчет";
            this.raschetButton.UseVisualStyleBackColor = true;
            this.raschetButton.Click += new System.EventHandler(this.raschetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 444);
            this.Controls.Add(this.raschetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.vvodTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vvodTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton multiplicationRadioButton;
        private System.Windows.Forms.RadioButton sumRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button raschetButton;
    }
}

