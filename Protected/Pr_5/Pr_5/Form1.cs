using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void puskButton_Click(object sender, EventArgs e)
        {
            int index = inputListBox.SelectedIndex;
      try
      {
        string text = (string)inputListBox.Items[index];
        int len = text.Length;
        int count = 0;
        int i = 0;

        int symbols = 0;
        int probels = 0;
        bool proverka;  // true - последний символ может быть концом предложения; 
                        // false - последний символ не является концом предложения

        while (i < len - 1)
        {
          proverka = false;
          if (text[i] == ' ') probels++;
          if (text[i] == '.' || text[i] == '?' || text[i] == '!')
          {
            proverka = true;
          }
          else
          {
            symbols++;
          }
          if ((proverka == true || i == len - 2) && symbols >= 1)
          {
            symbols = 0;
            count++;
          }
          i++;
          if (probels == len - 1) count = 0;
        }
        numberLabel.Text = "Число предложений = " + count.ToString();
      }
      catch (Exception)
      {
        MessageBox.Show("Вы не выбрали предложения", "Вот блин(((", MessageBoxButtons.OK, MessageBoxIcon.Stop);
      }
            
            
        }
    }
}
