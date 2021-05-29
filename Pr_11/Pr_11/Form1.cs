using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_11
{
    public partial class Form1 : Form
    {
        private Point previousPoint, point;
        private Bitmap bmp;
        private Pen blackPen = new Pen(Color.Black, 4);
        private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);

                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;

                bmp = new Bitmap(image, width, height);
                pictureBox1.Image = bmp;

               g = Graphics.FromImage(pictureBox1.Image);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить как...";
                sfd.OverwritePrompt = true;     // показывать ли "Перезаписать файл" если пользователь указывает имя файла, который уже существует
                sfd.CheckPathExists = true;     // отображает ли диалоговое окно предупреждение, если пользователь указывает путь, который не существует
                sfd.Filter = "Bitmap File (*.bmp)|*.bmp|" + "Gif File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" + "TIF File(*.tif)|*.tif|" + "PNG File(*.png)|*.png|" + "Image Files(*.*)|*.*";    // фильтр форматов файлов
                sfd.ShowHelp = true;            // отображается ли кнопка Справка в диалоговом окне
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);       // сохраняем изображение
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int x2 = bmp.Width / 2;
                int x1 = x2 / 2;
                int x3 = x1 + x2;
                g.DrawLine(blackPen, x1, 0, x1, bmp.Height);
                g.DrawLine(blackPen, x2, 0, x2, bmp.Height);
                g.DrawLine(blackPen, x3, 0, x3, bmp.Height);

                for (int j = 0; j < bmp.Height; j++)
                    for (int i = 0; i < x1; i++)
                    {
                        UInt32 pixel = (UInt32)(bmp.GetPixel(i, j).ToArgb());
                        float R = (float)((pixel & 0x00FF0000) >> 16);  // Красный
                        float G = (float)((pixel & 0x0000FF00) >> 8);   // Зелёный
                        float B = (float)((pixel & 0x000000FF));        // Голубой
                        G = B = 0;  // (G + B) / 2.0f;
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8 | ((UInt32)B));
                        bmp.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }

                for (int j = 0; j < bmp.Height; j++)
                    for (int i = x1; i < x2; i++)
                    {
                        UInt32 pixel = (UInt32)(bmp.GetPixel(i, j).ToArgb());
                        float R = (float)((pixel & 0x00FF0000) >> 16);  // Красный
                        float G = (float)((pixel & 0x0000FF00) >> 8);   // Зелёный
                        float B = (float)((pixel & 0x000000FF));        // Голубой
                        R = B = 0;  // (R + B) / 2.0f;
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8 | ((UInt32)B));
                        bmp.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }

                for (int j = 0; j < bmp.Height; j++)
                    for (int i = x2; i < x3; i++)
                    {
                        UInt32 pixel = (UInt32)(bmp.GetPixel(i, j).ToArgb());
                        float R = (float)((pixel & 0x00FF0000) >> 16);  // Красный
                        float G = (float)((pixel & 0x0000FF00) >> 8);   // Зелёный
                        float B = (float)((pixel & 0x000000FF));        // Голубой
                        R = G = 0;  // (R + G) / 2.0f;
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8 | ((UInt32)B));
                        bmp.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }

                for (int j = 0; j < bmp.Height; j++)
                    for (int i = x3; i < bmp.Width; i++)
                    {
                        UInt32 pixel = (UInt32)(bmp.GetPixel(i, j).ToArgb());
                        float R = (float)((pixel & 0x00FF0000) >> 16);
                        float G = (float)((pixel & 0x0000FF00) >> 8);
                        float B = (float)((pixel & 0x000000FF));                        
                        R = G = B = (R + G + B) / 3.0f;
                        UInt32 newPixel = 0XFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        bmp.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            previousPoint.X = e.X;
            previousPoint.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point.X = e.X;
                point.Y = e.Y;

                g.DrawLine(blackPen, previousPoint, point);

                previousPoint.X = point.X;
                previousPoint.Y = point.Y;
                pictureBox1.Invalidate();
            }
        }
    }
}
