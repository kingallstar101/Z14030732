using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace gray_process
{
    public partial class Form1 : Form
    {
        int iw, ih;

        public Form1()
        {
            InitializeComponent();
        }

        private void 选择图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPic = new OpenFileDialog();
            ofdPic.Filter = "图像文件(*.bmp;*.jpg;*gif;*png;*.tif;*.wmf)|"
                        + "*.bmp;*jpg;*gif;*png;*.tif;*.wmf";
            ofdPic.FilterIndex = 1;
            ofdPic.RestoreDirectory = true;
            ofdPic.FileName = "";
            if (ofdPic.ShowDialog() == DialogResult.OK)
            {
                string sPicPaht = ofdPic.FileName.ToString();
                FileInfo fiPicInfo = new FileInfo(sPicPaht);
                long lPicLong = fiPicInfo.Length / 1024;
                string sPicName = fiPicInfo.Name;
                string sPicDirectory = fiPicInfo.Directory.ToString();
                string sPicDirectoryPath = fiPicInfo.DirectoryName;
                Bitmap bmPic = new Bitmap(sPicPaht);

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = bmPic;
                iw = bmPic.Width;
                ih = bmPic.Height;
            }
        }

        private void 灰度处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请选择图片！");
                return;
            }
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            Color pixel;
            //获取图片的宽度和长度
            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    //获取每个点的像素并得到该像素的R、G、B值
                    pixel = bitmap.GetPixel(x, y);
                    int r, g, b, Result = 0;
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    
                    Result = ((int)(0.299 * r) + (int)(0.587 * g) + (int)(0.114 * b));//加权平均值
                    //Result = pixel.R;
                    //Result = ((r + g + b)/3);
                    bitmap.SetPixel(x, y, Color.FromArgb(Result, Result, Result));
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.Image = bitmap;
            this.pictureBox2.Refresh();
        }

        private void 对比度处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            string constr="";
            if (frm2.DialogResult == DialogResult.OK)
            {
                constr = frm2.tran;
                frm2.Close();
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请选择图片！");
                return ;
            }
            
            Color c;
            Bitmap temp = new Bitmap(pictureBox1.Image);
            Bitmap bmap = (Bitmap)temp.Clone();

            double contrast = Convert.ToInt32(constr);
            if (contrast < -100)
            {
                contrast = -100;
            }
            if (contrast > 100)
            {
                contrast = 100;
            }
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;

            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double pR = c.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    if (pR < 0)
                    {
                        pR = 0;
                    }
                    if (pR > 255)
                    {
                        pR = 255;
                    }
                    double pG = c.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    if (pG < 0)
                    {
                        pG = 0;
                    }
                    if (pG > 255)
                    {
                        pG = 255;
                    }
                    double pB = c.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    if (pB < 0)
                    {
                        pB = 0;
                    }
                    if (pB > 255)
                    {
                        pB = 255;
                    }
                    bmap.SetPixel(i, j, Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }

            }
            //_currentBitmap = (Bitmap)bmap.Clone();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.Image = bmap;
            this.pictureBox2.Refresh();
        }

        private void 图片分割ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请选择图片！");
                return;
            }
            Bitmap bm = new Bitmap(pictureBox1.Image);
            int wh = iw * ih;

            int[,] inIm = new int[iw, ih];   //input image

            int i, j, t;
            int L = 256;
            double a1, a2, max, pt;
            long[] p = new long[L];
            long[] num = new long[L];

            //转为灰度图像in_image[,]            
            for (j = 0; j < ih; j++)
                for (i = 0; i < iw; i++)
                    inIm[i, j] = bm.GetPixel(i, j).R;
            //初始化
            for (i = 0; i < L; i++)
                p[i] = 0;

            //统计各灰度级出现的次数
            for (j = 0; j < ih; j++)
                for (i = 0; i < iw; i++)
                    p[inIm[i, j]]++;

            //计算各灰度级出现的概率
            for (j = 0; j < L; j++)
                p[j] = p[j] / wh;

            for (i = 0; i < L; i++)
            {
                a1 = a2 = 0.0;
                pt = 0.0;
                for (j = 0; j <= i; j++)
                    pt += p[j];
                //计算图像熵
                for (j = 0; j <= i; j++)
                    a1 += (double)p[j] / pt * Math.Log(p[j] / pt);

                for (j = i + 1; j < L; j++)
                    a2 += (double)p[j] / (1 - pt) * Math.Log(p[j] / (1 - pt));
                //计算图像后验熵
                num[i] = (long)(a1 + a2);
            }
            //求出阈值t
            max = 0.0; t = 0;
            for (i = 0; i < L; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                    t = i;
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Refresh();
            pictureBox2.Image = threshSeg(inIm, iw, ih, t); ;

        }

        Bitmap threshSeg(int[,] in_image, int w, int h, int t)
        {
            Bitmap bm = new Bitmap(w, h);
            Color c;
            for (int j = 0; j < h; j++)
            {
                for (int i = 0; i < w; i++)
                {
                    //T为阈值，若大于阈值则表示是图像元素，小于则表示背景图像元素
                    if (in_image[i, j] > t)
                        c = Color.FromArgb(255, 255, 255);//设置RGB值
                    else
                        c = Color.FromArgb(0, 0, 0);
                    bm.SetPixel(i, j, c);
                }
            }
            return bm;
        }

    }
}
