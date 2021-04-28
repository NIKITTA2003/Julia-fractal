using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class Form1 : Form
    {
        int deg = 1;
        int ass = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //функция зарисовки фрактала
        public void DrawFractal(int w, int h, Graphics g, Pen pen, Bitmap map, double size, int ass)
        {
            // при каждой итерации, вычисляется znew = zold² + С
            
            // вещественная  и мнимая части постоянной C
            double cRe, cIm;
            // вещественная и мнимая части старой и новой
            double newRe, newIm, oldRe, oldIm;
            // Можно увеличивать и изменять положение
            double zoom = size, moveX = -1.15128, moveY = -0.3442098;
            //Определяем после какого числа итераций функция должна прекратить свою работу
            int maxIterations = 2000;

            int r = 64;

            //выбираем несколько значений константы С, это определяет форму фрактала Жюлиа
            cRe = -0.70176;
            cIm = -0.3842;

            //"перебираем" каждый пиксель
            for (int x = 0; x < w/2; x++)
            {
                for (int y = 0; y < h/2; y++)
                {
                    //вычисляется реальная и мнимая части числа z
                    //на основе расположения пикселей,масштабирования и значения позиции
                    newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;

                    //i представляет собой число итераций 
                    int i;

                    //начинается процесс итерации
                    for (i = 0; i < maxIterations; i++)
                    {

                        //Запоминаем значение предыдущей итерации
                        oldRe = newRe;
                        oldIm = newIm;

                        // в текущей итерации вычисляются действительная и мнимая части 
                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;

                        // если точка находится вне круга с радиусом 2 - прерываемся
                        if ((newRe * newRe + newIm * newIm) > r) break;
                    }

                    //определяем цвета
                    pen.Color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                    //рисуем пиксель
                    g.DrawRectangle(pen, x, y, 1, 1);
                    pictureBox1.BackgroundImage = map;

                }
                for (int y = h/2; y < h; y++)
                {
                    //вычисляется реальная и мнимая части числа z
                    //на основе расположения пикселей,масштабирования и значения позиции
                    newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;

                    //i представляет собой число итераций 
                    int i;

                    //начинается процесс итерации
                    for (i = 0; i < maxIterations; i++)
                    {

                        //Запоминаем значение предыдущей итерации
                        oldRe = newRe;
                        oldIm = newIm;

                        // в текущей итерации вычисляются действительная и мнимая части 
                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;

                        // если точка находится вне круга с радиусом 2 - прерываемся
                        if ((newRe * newRe + newIm * newIm) > r) break;
                    }

                    //определяем цвета
                    pen.Color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                    //рисуем пиксель
                    g.DrawRectangle(pen, x, y, 1, 1);

                    pictureBox1.BackgroundImage = map;
                }
                
            }

            for (int x = w/2; x < w; x++)
            {
                for (int y = 0; y < h / 2; y++)
                {
                    //вычисляется реальная и мнимая части числа z
                    //на основе расположения пикселей,масштабирования и значения позиции
                    newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;

                    //i представляет собой число итераций 
                    int i;

                    //начинается процесс итерации
                    for (i = 0; i < maxIterations; i++)
                    {

                        //Запоминаем значение предыдущей итерации
                        oldRe = newRe;
                        oldIm = newIm;

                        // в текущей итерации вычисляются действительная и мнимая части 
                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;

                        // если точка находится вне круга с радиусом 2 - прерываемся
                        if ((newRe * newRe + newIm * newIm) > r) break;
                    }

                    //определяем цвета
                    pen.Color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                    //рисуем пиксель
                    g.DrawRectangle(pen, x, y, 1, 1);
                    pictureBox1.BackgroundImage = map;

                }
                for (int y = h / 2 ; y < h; y++)
                {
                    //вычисляется реальная и мнимая части числа z
                    //на основе расположения пикселей,масштабирования и значения позиции
                    newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;

                    //i представляет собой число итераций 
                    int i;

                    //начинается процесс итерации
                    for (i = 0; i < maxIterations; i++)
                    {

                        //Запоминаем значение предыдущей итерации
                        oldRe = newRe;
                        oldIm = newIm;

                        // в текущей итерации вычисляются действительная и мнимая части 
                        newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                        newIm = 2 * oldRe * oldIm + cIm;

                        // если точка находится вне круга с радиусом 2 - прерываемся
                       if ((newRe * newRe + newIm * newIm) > r) break;
                    }

                    //определяем цвета
                    pen.Color = Color.FromArgb(255, (i * 9) % 255, 0, (i * 9) % 255);
                    //рисуем пиксель
                    g.DrawRectangle(pen, x, y, 1, 1);

                    pictureBox1.BackgroundImage = map;
                }

            }
            map.Save(Convert.ToString(textBox1.Text)+"\\frame_"+Convert.ToString(ass)+".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            Pen myPen = new Pen(Color.Black, 1);
            Bitmap map = new Bitmap(2560, 1440);//Подключаем Битмап
            Graphics g = Graphics.FromImage(map);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            double size = 0.25;
            for (int j = 1; j < 43; j++)
            {
                //size = size * 2;
                label1.Text = Convert.ToString(size);
                label2.Text = Convert.ToString(j);
                //frames = (double)((size-size/2d) / 60d);

                for (int sz = 1; sz <= 60; sz++)
                {
                    size = size * 1.01162;
                    ass++;
                    DrawFractal(2560, 1440, g, myPen, map, size, ass);
                }
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

            timer1.Enabled = true;

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

            if (deg <= ass)
            {
                pictureBox1.Image = Image.FromFile(Convert.ToString(textBox1.Text) + "\\frame_" + Convert.ToString(deg) + ".jpg");
                deg++;
            }

        }
    }
}