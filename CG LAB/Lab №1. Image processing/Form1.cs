using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab__1.Image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image;
        Bitmap defaultImage;

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Создаем диалог для открытия файла
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " Image files | *.png; *.jpg; *.bmp | All files(*.*) | *.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                defaultImage = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }


        private void чернобелыйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BlackWhite filter = new BlackWhite();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void постеризацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posterization filter = new Posterization();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }        

        private void безФильтровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = (Bitmap)defaultImage.Clone();
            pictureBox1.Image = image;
            pictureBox1.Refresh();
        }

        private void бинаризацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binarization filter = new Binarization();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void блюрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blur myBlur = new Blur();
            Bitmap resultImage = myBlur.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();

            /*
             * 
             *      BlurFilter MyBlur = new BlurFilter();
                    Color ReversedColor = MyBlur.CalculateNewClolor(MyImg, i, j);
                    MyImg.SetPixel(i, j, ReversedColor);
             * 
             * 
            Color ReversedColor = filter.CalculateNewClolor(image, i, j);
            MyImg.SetPixel(i, j, ReversedColor);
            pictureBox1.Refresh();

             Color ReversedColor = MyImg.GetPixel(i, j);
                    if (ReversedColor.B + ReversedColor.G + ReversedColor.R > 325)
                        ReversedColor = Color.FromArgb(255, 255, 255);
                    else
                        ReversedColor = Color.FromArgb(0, 0, 0);
                    MyImg.SetPixel(i, j, ReversedColor);*/
        }
    }
}
