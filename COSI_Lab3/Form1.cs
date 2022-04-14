using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COSI_Lab3
{
    public partial class Form1 : Form
    {
     
        Bitmap pixelMatrix1;
        Bitmap workingPixelMatrix;

        int[] gistogramR = new int[256];
        int[] gistogramG = new int[256];
        int[] gistogramB = new int[256];

        public Form1()
        {
            InitializeComponent();

            drawElementsDisable();

            progressBar1.Visible = false;
        }

        private void getGistograms(Bitmap matrix)
        {
            for (int i = 0; i < gistogramB.Length; i++)
            {
                gistogramR[i] = 0;
                gistogramG[i] = 0;
                gistogramB[i] = 0;
            }

            for (int i = 0; i < matrix.Width; i++)
            {
                //updateProgressBar(i, pixelMatrix1.Width);
                for (int j = 0; j < matrix.Height; j++)
                {
                    Color clr = matrix.GetPixel(i, j);
                    gistogramR[clr.R]++;
                    gistogramG[clr.G]++;
                    gistogramB[clr.B]++;
                }
            }
        }
        private void showGistograms()
        {
            chartR.Series["Red"].Points.Clear();
            chartG.Series["Green"].Points.Clear();
            chartB.Series["Blue"].Points.Clear();
            for (int j = 0; j < gistogramR.Length; j++)
            {
                chartR.Series["Red"].Points.AddY(gistogramR[j]);
                chartG.Series["Green"].Points.AddY(gistogramG[j]);
                chartB.Series["Blue"].Points.AddY(gistogramB[j]);
            }


        }

        private void buttonToGray_Click(object sender, EventArgs e)
        {
            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }

            Bitmap grayPixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);

            for (int i = 0; i < pixelMatrix.Width; i++)
            {
                updateProgressBar(i, pixelMatrix.Width);
                for (int j = 0; j < pixelMatrix.Height; j++)
                {
                    Color clr = pixelMatrix.GetPixel(i, j);
                    byte R = clr.R;
                    byte G = clr.G;
                    byte B = clr.B;
                    byte gray = (byte)((77 * R + 150 * G + 29 * B) / 256);
                    grayPixelMatrix.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            pictureResult.Image = grayPixelMatrix;
            workingPixelMatrix = new Bitmap(grayPixelMatrix);
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }
            Bitmap negativePixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);

            for (int i = 0; i < pixelMatrix.Width; i++)
            {
                updateProgressBar(i, pixelMatrix.Width);
                for (int j = 0; j < pixelMatrix.Height; j++)
                {
                    Color clr = pixelMatrix.GetPixel(i, j);
                    byte R = clr.R;
                    byte G = clr.G;
                    byte B = clr.B;

                    negativePixelMatrix.SetPixel(i, j, Color.FromArgb(255 - R, 255 - G, 255 - B));
                }
            }

            pictureResult.Image = negativePixelMatrix;
            workingPixelMatrix = new Bitmap(negativePixelMatrix);
        }

        private void openImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pixelMatrix1 = new Bitmap(openFileDialog1.FileName);
            workingPixelMatrix = new Bitmap(pixelMatrix1);
            picture.Image = pixelMatrix1;

           
            getGistograms(pixelMatrix1);
            showGistograms();


            drawElementsEnable();
        }

        private void saveImage_Click(object sender, System.EventArgs e)
        {
            String[] filePath = openFileDialog1.FileName.Split('.');
            pictureResult.Image.Save(filePath[0] + "_result." + filePath[1]);

            textBox1.Text = ("Изображение сохранено как " + filePath[0] + "_result." + filePath[1]);
        }

        private void updateProgressBar(int num, int max)
        {
            if (progressBar1.Value == 0)
            {
                progressBar1.Visible = true;
            }
            progressBar1.Value = (num * 100) / (max);
            if (max - num < 2)
            {
                progressBar1.Visible = false;
            }

        }

        private void trackBarRotate_Move(object sender, EventArgs e)
        {
            labelRotate.Text = trackBarRotate.Value.ToString();
        }

       

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }
            Bitmap rotatePixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);

            int xc = pixelMatrix.Width / 2;
            int yc = pixelMatrix.Height / 2;
            double fi = trackBarRotate.Value;
            double fiRad = fi * Math.PI / 180;

            int x = 0;
            int y = 0;

            for (int i = 0; i < pixelMatrix.Width; i++)
            {
                updateProgressBar(i, pixelMatrix.Width);

                for (int j = 0; j < pixelMatrix.Height; j++)
                {
                    x = (int)((i - xc) * Math.Cos(fiRad) - (j - yc) * Math.Sin(fiRad) + xc);
                    y = (int)((i - xc) * Math.Sin(fiRad) + (j - yc) * Math.Cos(fiRad) + yc);
                    Color clr;
                    if (x < pixelMatrix.Width && y < pixelMatrix.Height && x >0 && y >0)
                    {
                        clr = pixelMatrix.GetPixel(x, y);
                        rotatePixelMatrix.SetPixel(i, j, clr);
                    }
                }
            }


            //int x, y, x0, y0 = 0;
            //double r = 0, a= (trackBarRotate.Value)*3.14/180, s = 0, c = 0;
            //x0 = pixelMatrix.Width / 2;
            //y0 = pixelMatrix.Height / 2;

            //for (int i = 0; i < pixelMatrix.Width; i++)
            //{
            //    updateProgressBar(i, pixelMatrix.Width);

            //    for (int j = 0; j < pixelMatrix.Height; j++)
            //    {
            //        r = Math.Sqrt(Math.Pow(i - x0, 2) + Math.Pow(j - y0, 2));
            //        s = Math.Sin(a + Math.Atan2((j - y0), (i - x0)));
            //        c = Math.Cos(a + Math.Atan2((j - y0), (i - x0)));

            //        Color clr;
            //        if ((int)(x0 + r * c) < pixelMatrix.Width && (int)(y0 + r * s) < pixelMatrix.Height && (int)(x0 + r * c) >0 && (int)(y0 + r * s) >0)
            //        {
            //            clr = pixelMatrix.GetPixel((int)(x0 + r * c), (int)(y0 + r * s));
            //            rotatePixelMatrix.SetPixel(i, j, clr
            //    }
            //}

                pictureResult.Image = rotatePixelMatrix;
            workingPixelMatrix = new Bitmap(rotatePixelMatrix);
        }

        private void blurButton_Click(object sender, EventArgs e)
        {
            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }
            Bitmap blurPixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);
            Random rnd = new Random();
            int V = trackBarBlur.Value; 
            

            for (int i = 0; i < pixelMatrix.Width; i++)
            {
                updateProgressBar(i, pixelMatrix.Width);
                for (int j = 0; j < pixelMatrix.Height; j++)
                {

                    int x = (int)(i + (rnd.NextDouble() - 0.5) * V);
                    int y = (int)(j + (rnd.NextDouble() - 0.5) * V);

                    if (x >= 0 && x < pixelMatrix.Width && y >= 0 && y < pixelMatrix.Height)
                    {
                        Color clr = pixelMatrix.GetPixel(x, y);
                        blurPixelMatrix.SetPixel(i, j, clr);
                    }
  
                }

                pictureResult.Image = blurPixelMatrix;
                workingPixelMatrix = new Bitmap(blurPixelMatrix);
            }
        }


        private void trackBarBlur_ValueChanged(object sender, EventArgs e)
        {
            labelBlur.Text = trackBarBlur.Value.ToString();
        }



        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Работу выполнил студент 4 курса группы АЕ-155 Салагор Д.В.",
        "О программе",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void buttonWave_Click(object sender, EventArgs e)
        {
            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }
            Bitmap wavePixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);
            Random rnd = new Random();
            int V = trackBarBlur.Value;
            double V1 = trackBarV1.Value;
            double V2 = trackBarV2.Value;
            double V3 = trackBarV3.Value;
            double V4 = trackBarV4.Value;

            for (int i = 0; i < pixelMatrix.Width; i++)
            {
                updateProgressBar(i, pixelMatrix.Width);
                for (int j = 0; j < pixelMatrix.Height; j++)
                {

                    
                    int x = (int)(i + V1 * Math.Sin(2 * Math.PI * j / V2));
                    int y = (int)(j + V3 * Math.Sin(2 * Math.PI *i / V4));
               

                    if (x >= 0 && x < pixelMatrix.Width && y >= 0 && y < pixelMatrix.Height)
                    {
                        Color clr = pixelMatrix.GetPixel(x, y);
                        wavePixelMatrix.SetPixel(i, j, clr);
                    }

                }

                pictureResult.Image = wavePixelMatrix;
                workingPixelMatrix = new Bitmap(wavePixelMatrix);
            }
        }

        private void buttonGistogramCorrection_Click(object sender, EventArgs e)
        {
            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }
            Bitmap gistoPixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);
            Random rnd = new Random();
       
            int minR = Convert.ToInt32(textBoxGistoRMin.Text);
            int maxR = Convert.ToInt32(textBoxGistoRMax.Text);
            int deltaR;
            int minG = Convert.ToInt32(textBoxGistoGMin.Text);
            int maxG = Convert.ToInt32(textBoxGistoGMax.Text);
            int deltaG;
            int minB = Convert.ToInt32(textBoxGistoBMin.Text);
            int maxB = Convert.ToInt32(textBoxGistoBMax.Text);
            int deltaB;
            for (int i = 0; i < pixelMatrix.Width; i++)
            {

                
                if (minR == maxR)
                {
                    deltaR = 1;
                }
                else
                {
                    deltaR = maxR - minR;
                }
                if (minG == maxG)
                {
                    deltaG= 1;
                }
                else
                {
                    deltaG = maxG - minG;
                }
                if (minB == maxB)
                {
                    deltaB = 1;
                }
                else
                {
                    deltaB = maxB - minB;
                }


                updateProgressBar(i, pixelMatrix.Width);
                for (int j = 0; j < pixelMatrix.Height; j++)
                {
                    Color clr = pixelMatrix.GetPixel(i, j);
                    byte R = (byte)((clr.R - minR) * 255.0 / deltaR);
                    byte G = (byte)((clr.G - minG) * 255.0 / deltaG);
                    byte B = (byte)((clr.B - minB) * 255.0 / deltaB);
                    gistoPixelMatrix.SetPixel(i, j, Color.FromArgb(R, G, B));

                }
               
            }
            getGistograms(gistoPixelMatrix);
            showGistograms();

            pictureResult.Image = gistoPixelMatrix;
            workingPixelMatrix = new Bitmap(gistoPixelMatrix);
        }

        private void buttonReverseGorizontal_Click(object sender, EventArgs e)
        {
            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }
            Bitmap reverseGPixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);

            for (int i = 0; i < pixelMatrix.Width; i++)
            {
                updateProgressBar(i, pixelMatrix.Width);
                for (int j = 0; j < pixelMatrix.Height; j++)
                { 
                    Color clr = pixelMatrix.GetPixel(i, j);
                    reverseGPixelMatrix.SetPixel(pixelMatrix.Width - i - 1, j, clr);
                
                }
                
            }
            pictureResult.Image = reverseGPixelMatrix;
            workingPixelMatrix = new Bitmap(reverseGPixelMatrix);

        }

        private void buttonReverseVertical_Click(object sender, EventArgs e)
        {
            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }
            Bitmap reverseVPixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);

            for (int i = 0; i < pixelMatrix.Width; i++)
            {
                updateProgressBar(i, pixelMatrix.Width);
                for (int j = 0; j < pixelMatrix.Height; j++)
                {
                    Color clr = pixelMatrix.GetPixel(i, j);
                    reverseVPixelMatrix.SetPixel(i, pixelMatrix.Height - j - 1, clr);


                }
                
            }
            pictureResult.Image = reverseVPixelMatrix;
            workingPixelMatrix = new Bitmap(reverseVPixelMatrix);
        }

        private void checkBoxEffectTo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonMedianFilter_Click(object sender, EventArgs e)
        {

            Bitmap pixelMatrix;
            if (checkBoxEffectTo.Checked == false)
            {
                pixelMatrix = new Bitmap(this.workingPixelMatrix);

            }
            else
            {
                pixelMatrix = new Bitmap(this.pixelMatrix1);

            }
            Bitmap medianFilterPixelMatrix = new Bitmap(pixelMatrix.Width, pixelMatrix.Height);

            int size = Convert.ToInt32(textBoxMedianFilter.Text);
            int sizehalf = size / 2;
            int size2half = size * size / 2;
            int[] arrR = new int[size * size];
            int[] arrG = new int[size * size];
            int[] arrB = new int[size * size];

            for (int i = sizehalf; i < pixelMatrix.Width - sizehalf; i++)
            {
                updateProgressBar(i, pixelMatrix.Width - sizehalf);
                for (int j = sizehalf; j < pixelMatrix.Height - sizehalf; j++)
                {
                    int n = 0;

                    for(int k = -sizehalf; k <= sizehalf; k++)
                    {
                        for (int p = -sizehalf; p <= sizehalf; p++)
                        {
                            Color clr = pixelMatrix.GetPixel(i+k, j+p);
                            arrR[n] = clr.R;
                            arrG[n] = clr.G;
                            arrB[n] = clr.B;
                            n++;
                        }
                    }
                    Array.Sort(arrR);
                    Array.Sort(arrG);
                    Array.Sort(arrB);

                    medianFilterPixelMatrix.SetPixel(i, j, Color.FromArgb(arrR[size2half], arrG[size2half], arrB[size2half]));

                }

            }


            pictureResult.Image = medianFilterPixelMatrix;
            workingPixelMatrix = new Bitmap(medianFilterPixelMatrix);
        }
    }
}

