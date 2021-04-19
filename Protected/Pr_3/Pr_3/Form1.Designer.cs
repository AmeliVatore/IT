namespace Pr_3
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
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expRadioButton = new System.Windows.Forms.RadioButton();
            this.chRadioButton = new System.Windows.Forms.RadioButton();
            this.shRadioButton = new System.Windows.Forms.RadioButton();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.raschetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите x:";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(167, 56);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(487, 27);
            this.xTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expRadioButton);
            this.groupBox1.Controls.Add(this.chRadioButton);
            this.groupBox1.Controls.Add(this.shRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(680, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(335, 141);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "F(x)";
            // 
            // expRadioButton
            // 
            this.expRadioButton.AutoSize = true;
            this.expRadioButton.Location = new System.Drawing.Point(10, 100);
            this.expRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.expRadioButton.Name = "expRadioButton";
            this.expRadioButton.Size = new System.Drawing.Size(56, 24);
            this.expRadioButton.TabIndex = 2;
            this.expRadioButton.Text = "exp";
            this.expRadioButton.UseVisualStyleBackColor = true;
            // 
            // chRadioButton
            // 
            this.chRadioButton.AutoSize = true;
            this.chRadioButton.Location = new System.Drawing.Point(10, 65);
            this.chRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.chRadioButton.Name = "chRadioButton";
            this.chRadioButton.Size = new System.Drawing.Size(48, 24);
            this.chRadioButton.TabIndex = 1;
            this.chRadioButton.Text = "ch";
            this.chRadioButton.UseVisualStyleBackColor = true;
            // 
            // shRadioButton
            // 
            this.shRadioButton.AutoSize = true;
            this.shRadioButton.Checked = true;
            this.shRadioButton.Location = new System.Drawing.Point(10, 29);
            this.shRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.shRadioButton.Name = "shRadioButton";
            this.shRadioButton.Size = new System.Drawing.Size(48, 24);
            this.shRadioButton.TabIndex = 0;
            this.shRadioButton.TabStop = true;
            this.shRadioButton.Text = "sh";
            this.shRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(50, 182);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(604, 260);
            this.resultTextBox.TabIndex = 7;
            // 
            // raschetButton
            // 
            this.raschetButton.Location = new System.Drawing.Point(756, 284);
            this.raschetButton.Margin = new System.Windows.Forms.Padding(5);
            this.raschetButton.Name = "raschetButton";
            this.raschetButton.Size = new System.Drawing.Size(182, 79);
            this.raschetButton.TabIndex = 8;
            this.raschetButton.Text = "Расчет";
            this.raschetButton.UseVisualStyleBackColor = true;
            this.raschetButton.Click += new System.EventHandler(this.raschetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат работы программы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.raschetButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton expRadioButton;
        private System.Windows.Forms.RadioButton chRadioButton;
        private System.Windows.Forms.RadioButton shRadioButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button raschetButton;
        private System.Windows.Forms.Label label4;
    }
}

